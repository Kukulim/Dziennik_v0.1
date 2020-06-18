using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dziennik_v0._1.Controllers
{
    public class WelcomePageController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public WelcomePageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            var CurrentMonth = DateTime.Now.Month;

            var userId = User.Identity.GetUserId();
            var ViewModel = new WelcomePageViewModel();

            ViewModel.Cardios = _unitOfWork.Cardios.GetAllCardios(userId).Where(c => c.Date.Month == CurrentMonth).ToList();
            ViewModel.Workouts = _unitOfWork.Workouts.GetAllWorkouts(userId).Where(c => c.Date.Month == CurrentMonth).ToList();

            return View(ViewModel);
        }
    }
}