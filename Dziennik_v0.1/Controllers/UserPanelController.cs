using Dziennik_v0._1.Core;
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
            var viewModel = new WorkoutCreateViewModel
            {
                Workout = new Workout(),
                Exercises = new List<Exercise>()
            };
            return View(viewModel);
        }

        public ActionResult UpdateExerciseTable(int ExersisesCount)
        {
            var viewModel = new WorkoutCreateViewModel
            {
                Exercises = new List<Exercise>()
            };
            for (int i = 0; i < ExersisesCount; i++)
            {
                viewModel.Exercises.Add(new Exercise());
            }

            return PartialView("_ExerciseTable", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorkoutCreateViewModel viewModel)
        {
            viewModel.Workout.UserId = User.Identity.GetUserId();
            try
            {
                foreach (var item in viewModel.Exercises)
                {
                    viewModel.Workout.Exercises.Add(item);
                }
                _unitOfWork.Workouts.AddWorkout(viewModel.Workout);
                _unitOfWork.Complete();
            }
            catch
            {
                return View(viewModel);
            }
            return RedirectToAction("Index");
        }
        public ActionResult CreateCardio()
        {
            var viewModel = new Cardio();
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCardio(Cardio viewModel)
        {
            viewModel.UserId = User.Identity.GetUserId();
            _unitOfWork.Cardios.AddCardio(viewModel);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }
    }
}