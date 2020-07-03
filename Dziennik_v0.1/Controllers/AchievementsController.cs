using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Dziennik_v0._1.Controllers
{
    public class AchievementsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AchievementsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var user = _unitOfWork.Users.GetUser(userId);
            var viewModel = new AchievementsIndexViewModel { Achievements = _unitOfWork.Achievements.GetAllAchievement(userId).OrderByDescending(a=>a.AcquiredDate).ToList() };
            viewModel.AchievementsPoints = user.AchievementsPoints;
            return View(viewModel);
        }
    }
}