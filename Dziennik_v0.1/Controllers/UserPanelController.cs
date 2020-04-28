﻿using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.ViewModels;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Dziennik_v0._1.Controllers
{
    [Authorize]
    public class UserPanelController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserPanelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var viewModel = _unitOfWork.Workouts.GetAllWorkouts(userId);
            return View(viewModel);
        }
        public ActionResult Create()
        {
            var buffor = new Exercise 
            {
                Name = "imie"
            };
            var newlist = new List<Exercise>();
            newlist.Add(buffor);

            var viewModel = new Workout();
            viewModel.Exercises = newlist;

            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Create(Workout workout)
        {
            if (ModelState.IsValid)
            {
                workout.UserId = User.Identity.GetUserId();
                _unitOfWork.Workouts.AddWorkout(workout);
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }
            return View(workout);
        }
    }
}