using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Models.Enums;
using Dziennik_v0._1.Core.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dziennik_v0._1.Controllers
{
    public class DietController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DietController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult Index(DateTime? dateTime=null)
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
                if (item.MealType==MealType.breakfast)
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
            }
            return View(viewModelToReturn);
        }
        public ActionResult UserProfile()
        {
            var userId = User.Identity.GetUserId();
            var user = _unitOfWork.Users.GetUser(userId);
            return View(user);
        }
        [HttpPost]
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
    }
}