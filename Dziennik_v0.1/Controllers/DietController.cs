﻿using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Models.Enums;
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
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var ToDayDate = DateTime.Now.Date;
            var viewModel = _unitOfWork.DailyMenus.GetDailyMenu(userId, ToDayDate);
            if (viewModel == null)
            {
                viewModel = new DailyMenu { DailyMenuDate = ToDayDate, FoodModels = new List<FoodModel>(), UserId = userId };
                _unitOfWork.DailyMenus.AddDailyMenu(viewModel);
                _unitOfWork.Complete();
            }
            return View(viewModel);
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
        public ActionResult AddFoodToMeal()
        {
            return View();
        }
    }
}