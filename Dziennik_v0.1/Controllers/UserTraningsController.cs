using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.ViewModels;
using Microsoft.AspNet.Identity;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Dziennik_v0._1.Controllers
{
    [Authorize]
    public class UserTraningsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserTraningsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult TrainingBoard(int? page)
        {
            var userId = User.Identity.GetUserId();
            //var viewModel = new TrainingBoardViewModel();
            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).ToList();
            var WorkoutList = _unitOfWork.Workouts.GetAllWorkouts(userId).ToList();

            var viewModel = new List<TrainigBaseModel>();

            foreach (var item in CardioList)
            {
                viewModel.Add(item);
            }
            foreach (var item in WorkoutList)
            {
                viewModel.Add(item);
            }
            viewModel = viewModel.OrderByDescending(t => t.Date).ToList();

            return View(viewModel.ToPagedList(page ?? 1, 10));
        }

        public ActionResult CreateWorkout()
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
        public ActionResult CreateWorkout(WorkoutCreateViewModel viewModel)
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
            return RedirectToAction("TrainingBoard");
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
            viewModel.Cardio.Distance = Convert.ToDecimal(viewModel.DistanceString.Replace(".", ","));
            _unitOfWork.Cardios.AddCardio(viewModel.Cardio);
            _unitOfWork.Complete();

            return RedirectToAction("TrainingBoard");
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
            return RedirectToAction("TrainingBoard");
        }
        [HttpPost, ActionName("DeleteWorkout")]
        public ActionResult DeleteWorkoutConfirmed(int id)
        {
            _unitOfWork.Workouts.DeleteWorkout(id);
            _unitOfWork.Complete();
            return RedirectToAction("TrainingBoard");
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
                var ViewModel = new CardioCreateViewModel();
                ViewModel.Cardio = model;
                ViewModel.DistanceString = model.Distance.ToString().Replace(",", ".");
                return View("EditCardio", ViewModel);
            }
            else
            {
                var model = _unitOfWork.Workouts.GetWorkout(id);
                return View("EditWorkout",model);
            }
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCardio(CardioCreateViewModel viewModel)
        {
            viewModel.Cardio.Distance = Convert.ToDecimal(viewModel.DistanceString.Replace(".", ","));
            _unitOfWork.Cardios.EditCardio(viewModel.Cardio);
            _unitOfWork.Complete();
            return RedirectToAction("TrainingBoard");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditWorkout(Workout workout)
        {
            _unitOfWork.Workouts.EditWorkout(workout);
            _unitOfWork.Complete();
            return RedirectToAction("TrainingBoard");
        }


    }
}