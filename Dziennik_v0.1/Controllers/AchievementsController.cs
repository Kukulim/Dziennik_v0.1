using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Helpers;
using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.ViewModels;
using Dziennik_v0._1.Presistence;
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
        private IUnitOfWork _unitOfWork;

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
        [HttpGet]
        public void AchievementsUnSelect()
        {
            var userId = User.Identity.GetUserId();
            foreach (var item in _unitOfWork.Achievements.GetAllAchievement(userId).ToList())
            {
                item.IsNew = false;
            }
            _unitOfWork.Complete();
        }
    }
}