using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.ViewModels.StatisticsViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;

namespace Dziennik_v0._1.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StatisticsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).ToList();
            var WorkoutList = _unitOfWork.Workouts.GetAllWorkouts(userId).ToList();

            var viewModel = new TraningsLengthListViewModel();

            foreach (var item in CardioList)
            {
                viewModel.YearsWithTraning.Add(item.Date.Year);
            }
            foreach (var item in WorkoutList)
            {
                viewModel.YearsWithTraning.Add(item.Date.Year);
            }
            viewModel.YearsWithTraning = viewModel.YearsWithTraning.Distinct().OrderBy(c =>c).ToList();
            return View(viewModel);
        }
        public JsonResult TraningsLengthList()
        {
            var userId = User.Identity.GetUserId();

            var viewModel = new TraningsLengthListViewModel();

            var WorkoutList = _unitOfWork.Workouts.GetAllWorkouts(userId).ToList();

            for (int i = 0; i < 12; i++)
            {
                var buffor = WorkoutList.Where(c => c.Date.Month == (i + 1)).ToList();
                var buffor2 = 0;
                foreach (var item in buffor)
                {
                    buffor2 += (Convert.ToInt32(item.LengthOfTraining));
                }
                viewModel.Workouts.Add(buffor2);
            }

            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).ToList();

            for (int i = 0; i < 12; i++)
            {
                var buffor = CardioList.Where(c => c.Date.Month == (i + 1)).ToList();
                var buffor2 = 0;
                foreach (var item in buffor)
                {
                    buffor2+=(Convert.ToInt32(item.LengthOfTraining));
                }
                viewModel.Cardios.Add(buffor2);
            }
            foreach (var item in CardioList)
            {
                viewModel.YearsWithTraning.Add(Convert.ToInt32(item.Date.Year.ToString()));
            }
            viewModel.YearsWithTraning = viewModel.YearsWithTraning.Distinct().ToList();

            return Json(viewModel, JsonRequestBehavior.AllowGet);
        }
    }
}