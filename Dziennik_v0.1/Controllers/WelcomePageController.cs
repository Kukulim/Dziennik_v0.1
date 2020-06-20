using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Dtos;
using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Models.Enums;
using Dziennik_v0._1.Core.ViewModels;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Script.Serialization;

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

            var WorkoutList = _unitOfWork.Workouts.GetAllWorkouts(userId).Where(c => c.Date.Month == CurrentMonth).ToList();
            ViewModel.Workouts = WorkoutList.Where(c => c.Date.Month == CurrentMonth).ToList();

            foreach (var item in ViewModel.Workouts)
            {
                ViewModel.LengthOfWorkoutSum += Convert.ToInt32(item.LengthOfTraining);
                ViewModel.VolumeSum += item.WorkoutVolume;
            }

            ViewModel.VolumeSum /= 1000;

            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).ToList();
            ViewModel.Cardios = CardioList.Where(c => c.Date.Month == CurrentMonth).ToList();

            foreach (var item in ViewModel.Cardios)
            {
                ViewModel.LengthOfCardioSum += Convert.ToInt32(item.LengthOfTraining);
                ViewModel.DistanceSum += item.Distance;
            }

            int Licznik, EnumCount = 0, MaxEnum = 0;

            for (int i = 0; i < ViewModel.Cardios.Count(); i++)
            {
                Licznik = 0;
                for (int j = 0; j < ViewModel.Cardios.Count(); j++)
                {
                    if (Convert.ToInt32(ViewModel.Cardios[j].CardioType) == Convert.ToInt32(ViewModel.Cardios[i].CardioType)) Licznik++;
                }
                if (Licznik > EnumCount)
                {
                    EnumCount = Licznik;
                    MaxEnum = Convert.ToInt32(ViewModel.Cardios[i].CardioType);
                }
            }
            ViewModel.MostCardioType = (CardioType)MaxEnum;

            ViewModel.RuningBestDistance = CardioList.Where(f => f.CardioType == CardioType.Bieganie).OrderByDescending(c => c.Distance).FirstOrDefault();
            ViewModel.RuningLongestTime = CardioList.Where(f => f.CardioType == CardioType.Bieganie).OrderByDescending(c => c.LengthOfTraining).FirstOrDefault();

            ViewModel.WorkoutBestVolume = WorkoutList.OrderByDescending(w => w.WorkoutVolume).FirstOrDefault();
            ViewModel.WorkoutLongestTrening = WorkoutList.OrderByDescending(w => w.LengthOfTraining).FirstOrDefault();

            return View(ViewModel);
        }
        public JsonResult WorkoutTraningList()
        {
            var userId = User.Identity.GetUserId();

            var TraningList = _unitOfWork.Workouts.GetAllWorkouts(userId).ToList();
            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).ToList();

            var DateTraningList = new List<CalendarTraningDto>();

            foreach (var item in TraningList)
            {
                DateTraningList.Add(new CalendarTraningDto { Name=" Tr. siłowy", Date = item.Date.AddDays(1).ToString("MM-dd-yyyy")});
            }
            foreach (var item in CardioList)
            {
                DateTraningList.Add(new CalendarTraningDto { Name = " Tr. cardio", Date = item.Date.AddDays(1).ToString("MM-dd-yyyy")});
            }


            return Json(DateTraningList, JsonRequestBehavior.AllowGet);
        }
    }
}
