using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;

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
            var viewModel = new IndexUserPanelViewModel();
            viewModel.CardioList = _unitOfWork.Cardios.GetAllCardios(userId).ToList();
            viewModel.WorkoutList = _unitOfWork.Workouts.GetAllWorkouts(userId).ToList();

            //viewModel.AllWorkouts = new List<object>();
            //foreach (var item in viewModel.CardioList)
            //{
            //    viewModel.AllWorkouts.Add(item);
            //}
            //foreach (var item in viewModel.WorkoutList)
            //{
            //    viewModel.AllWorkouts.Add(item);
            //}

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
            var viewModel = new CardioCreateViewModel();
            viewModel.DistanceString = "0";
            viewModel.Cardio = new Cardio();
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCardio(CardioCreateViewModel viewModel)
        {
            viewModel.Cardio.UserId = User.Identity.GetUserId();
            viewModel.Cardio.Distance = Convert.ToDecimal(viewModel.DistanceString);
            _unitOfWork.Cardios.AddCardio(viewModel.Cardio);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id, string type)
        {
            if (type == "cardio")
            {
                var model = _unitOfWork.Cardios.GetCardio(id);
                return View("DeleteCardio", model);
            }
            else
            {
                var model = _unitOfWork.Workouts.GetWorkout(id);
                return View("DeleteWorkout", model);
            }
        }
        [HttpPost, ActionName("DeleteCardio")]
        public ActionResult DeleteCardioConfirmed(int id)
        {
            _unitOfWork.Cardios.DeleteCardio(id);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }
        [HttpPost, ActionName("DeleteWorkout")]
        public ActionResult DeleteWorkoutConfirmed(int id)
        {
            _unitOfWork.Workouts.DeleteWorkout(id);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id, string type)
        {
            if (type == "cardio")
            {
                var model = _unitOfWork.Cardios.GetCardio(id);
                return View("DetailsCardio", model);
            }
            else
            {
                var model = _unitOfWork.Workouts.GetWorkout(id);
                return View("DetailsWorkout", model);
            }
        }
        public ActionResult Edit(int id, string type)
        {
            if (type== "cardio")
            {
                var model = _unitOfWork.Cardios.GetCardio(id);
                return View("EditCardio",model);
            }
            else
            {
                var model = _unitOfWork.Workouts.GetWorkout(id);
                return View("EditWorkout",model);
            }
            
        }
        [HttpPost]
        public ActionResult EditCardio(Cardio cardio)
        {
            _unitOfWork.Cardios.EditCardio(cardio);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult EditWorkout(Workout workout)
        {
            _unitOfWork.Workouts.EditWorkout(workout);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }


    }
}