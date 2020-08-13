using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Models.Enums;
using Dziennik_v0._1.Core.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Dziennik_v0._1.Controllers
{
    [Authorize]
    public class DietController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DietController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index(DateTime? dateTime = null)
        {
            var userId = User.Identity.GetUserId();
            var ToDayDate = dateTime ?? DateTime.Now.Date;
            var viewModel = _unitOfWork.DailyMenus.GetDailyMenu(userId, ToDayDate);
            if (viewModel == null)
            {
                viewModel = new DailyMenu { DailyMenuDate = ToDayDate, FoodModels = new List<FoodModel>(), UserId = userId };
                _unitOfWork.DailyMenus.AddDailyMenu(viewModel);
                _unitOfWork.Complete();
            }
            var viewModelToReturn = new DietIndexViewModel();
            viewModelToReturn.DailyMenu = viewModel;
            foreach (var item in viewModelToReturn.DailyMenu.FoodModels)
            {
                if (item.MealType == MealType.breakfast)
                {
                    viewModelToReturn.Breakfast.Calories += item.Calories;
                    viewModelToReturn.Breakfast.Fat += item.Fat;
                    viewModelToReturn.Breakfast.Carbohydrates += item.Carbohydrates;
                    viewModelToReturn.Breakfast.Protein += item.Protein;
                }
                if (item.MealType == MealType.dinner)
                {
                    viewModelToReturn.Dinner.Calories += item.Calories;
                    viewModelToReturn.Dinner.Fat += item.Fat;
                    viewModelToReturn.Dinner.Carbohydrates += item.Carbohydrates;
                    viewModelToReturn.Dinner.Protein += item.Protein;
                }
                if (item.MealType == MealType.lunch)
                {
                    viewModelToReturn.Lunch.Calories += item.Calories;
                    viewModelToReturn.Lunch.Fat += item.Fat;
                    viewModelToReturn.Lunch.Carbohydrates += item.Carbohydrates;
                    viewModelToReturn.Lunch.Protein += item.Protein;
                }
                if (item.MealType == MealType.snacks)
                {
                    viewModelToReturn.Snack.Calories += item.Calories;
                    viewModelToReturn.Snack.Fat += item.Fat;
                    viewModelToReturn.Snack.Carbohydrates += item.Carbohydrates;
                    viewModelToReturn.Snack.Protein += item.Protein;
                }

                viewModelToReturn.AllDayMenuSumary.Calories = viewModelToReturn.Snack.Calories + viewModelToReturn.Breakfast.Calories
                    + viewModelToReturn.Dinner.Calories + viewModelToReturn.Lunch.Calories;

                viewModelToReturn.AllDayMenuSumary.Fat = viewModelToReturn.Snack.Fat + viewModelToReturn.Breakfast.Fat
                    + viewModelToReturn.Dinner.Fat + viewModelToReturn.Lunch.Fat;

                viewModelToReturn.AllDayMenuSumary.Protein = viewModelToReturn.Snack.Protein + viewModelToReturn.Breakfast.Protein
                    + viewModelToReturn.Dinner.Protein + viewModelToReturn.Lunch.Protein;

                viewModelToReturn.AllDayMenuSumary.Carbohydrates = viewModelToReturn.Snack.Carbohydrates + viewModelToReturn.Breakfast.Carbohydrates
                    + viewModelToReturn.Dinner.Carbohydrates + viewModelToReturn.Lunch.Carbohydrates;
            }
            var measurementModel = _unitOfWork.Measurements.GetAllMeasurements(userId).OrderByDescending(m => m.Date).FirstOrDefault();
            var limit = 0;
            if (measurementModel != null)
            {
                limit = (int)measurementModel.CaloricRequirement;
                viewModelToReturn.CalorieLimit.Protein = Decimal.Round((decimal)measurementModel.Weight * 2,2);
                viewModelToReturn.CalorieLimit.Fat = Decimal.Round((decimal)(limit *0.25)/9,2);
                viewModelToReturn.CalorieLimit.Carbohydrates = Decimal.Round(((decimal)measurementModel.CaloricRequirement - (viewModelToReturn.CalorieLimit.Fat*9+viewModelToReturn.CalorieLimit.Protein*4))/4,2);
            }
            viewModelToReturn.CalorieLimit.Calories = limit;
            return View(viewModelToReturn);
        }

        public ActionResult UserProfile()
        {
            var userId = User.Identity.GetUserId();
            var user = _unitOfWork.Users.GetUser(userId);
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserProfile(ApplicationUser viewModel)
        {
            _unitOfWork.Users.EditUser(viewModel);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }

        public ActionResult AddFoodToMeal(MealType mealType, DateTime dateTime)
        {
            var result = new AddFoodToMealViewModel();
            var userId = User.Identity.GetUserId();
            var viewModel = _unitOfWork.DailyMenus.GetDailyMenu(userId, dateTime);
            result.FoodModels = viewModel.FoodModels.Where(f => f.MealType == mealType).ToList();
            result.Date = viewModel.DailyMenuDate;
            result.Id = viewModel.Id;
            result.MealType = mealType;
            return View(result);
        }

        public void DeleteFood(int id)
        {
            _unitOfWork.Foods.DeleteFoodModel(id);
            _unitOfWork.Complete();
        }

        [HttpGet]
        public ActionResult AddFoodToCSV()
        {
            var viewModel = new AddFoodToCSVViewModel();
            viewModel.FoodModel = new FoodModel();
            viewModel.Url = Request.UrlReferrer.ToString();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult AddFoodToCSV(AddFoodToCSVViewModel viewModel)
        {
            string newFileName = "D:/Dziennik_v0.1/Dziennik_v0.1/App_Data/TabeleKaloryczne.csv";
            string FoodToInsert = Environment.NewLine + viewModel.FoodModel.Name + "." + viewModel.FoodModel.Calories + "." + viewModel.FoodModel.Protein + "." + viewModel.FoodModel.Fat + "." + viewModel.FoodModel.Carbohydrates;
            System.IO.File.AppendAllText(newFileName, FoodToInsert);
            return Redirect(viewModel.Url);
        }

        [HttpGet]
        public ActionResult AddMeasurement()
        {
            var viewModel = new Measurement { Date = DateTime.Now };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddMeasurement(Measurement viewModel)
        {
            var userId = User.Identity.GetUserId();
            var user = _unitOfWork.Users.GetUser(userId);

            var meas = (9.99 * viewModel.Weight) + (6.25 * user.Height) - (4.92 * user.Age);
            if (user.Sex == SexType.Female)
            {
                viewModel.CaloricRequirement = (float)(meas - 161);
            }
            if (user.Sex == SexType.Male)
            {
                viewModel.CaloricRequirement = (float)(meas + 5);
            }
            viewModel.UserId = userId;

            if (user.Target == viewModel.Weight)
            {
                viewModel.DietType = DietType.keep;
            }
            if (user.Target > viewModel.Weight)
            {
                viewModel.DietType = DietType.bulk;
                viewModel.CaloricRequirement += 200;
            }
            if (user.Target < viewModel.Weight)
            {
                viewModel.DietType = DietType.cut;
                viewModel.CaloricRequirement -= 200;
            }

            _unitOfWork.Measurements.AddMeasurement(viewModel);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DietSummary()
        {
            var userId = User.Identity.GetUserId();
            var YearsWithTraning = new List<int>();
            var Measurments =_unitOfWork.Measurements.GetAllMeasurements(userId);

            foreach (var item in Measurments)
            {
                YearsWithTraning.Add(Convert.ToInt32(item.Date.Year.ToString()));
            }
            YearsWithTraning = YearsWithTraning.Distinct().OrderBy(c => c).ToList();

            return View(YearsWithTraning);
        }
    }
}