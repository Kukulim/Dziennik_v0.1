﻿using Dziennik_v0._1.Core;
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
    [Authorize]
    public class StatisticsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StatisticsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult AnnualStatistics()
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
            viewModel.YearsWithTraning = viewModel.YearsWithTraning.Distinct().OrderBy(c => c).ToList();
            return View(viewModel);
        }
        public ActionResult WorkoutStatistics()
        {
            var userId = User.Identity.GetUserId();

            var WorkoutList = _unitOfWork.Workouts.GetAllWorkouts(userId).ToList();
            var viewModel = new WorkoutStatisticsViewModel();

            foreach (var item in WorkoutList)
            {
                viewModel.YearsWithTraning.Add(Convert.ToInt32(item.Date.Year.ToString()));
            }
            viewModel.YearsWithTraning = viewModel.YearsWithTraning.Distinct().OrderBy(c => c).ToList();
            return View(viewModel);
        }
        public ActionResult CardioStatistics()
        {
            var userId = User.Identity.GetUserId();

            var WorkoutList = _unitOfWork.Cardios.GetAllCardios(userId).ToList();
            var viewModel = new WorkoutStatisticsViewModel();

            foreach (var item in WorkoutList)
            {
                viewModel.YearsWithTraning.Add(Convert.ToInt32(item.Date.Year.ToString()));
            }
            viewModel.YearsWithTraning = viewModel.YearsWithTraning.Distinct().OrderBy(c => c).ToList();
            return View(viewModel);
        }
    }
}