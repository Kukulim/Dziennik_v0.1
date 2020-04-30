using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Models;
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
            var viewModel = new Workout();
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Workout viewModel)
        {
            viewModel.UserId = User.Identity.GetUserId();
            _unitOfWork.Workouts.AddWorkout(viewModel);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }
    }
}