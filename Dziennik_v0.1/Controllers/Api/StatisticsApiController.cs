﻿using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Dtos;
using Dziennik_v0._1.Core.ViewModels.StatisticsViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace Dziennik_v0._1.Controllers.Api
{
    public class StatisticsApiController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        public StatisticsApiController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IHttpActionResult TraningsLengthList(int? year)
        {
            var userId = User.Identity.GetUserId();

            var viewModel = new TraningsLengthListViewModel();

            var WorkoutList = _unitOfWork.Workouts.GetAllWorkouts(userId).ToList();

            for (int i = 0; i < 12; i++)
            {
                var buffor = WorkoutList.Where(c => (c.Date.Month == (i + 1)) && (c.Date.Year == year)).ToList();
                var buffor2 = 0;
                foreach (var item in buffor)
                {
                    buffor2 += (Convert.ToInt32(item.LengthOfTraining));
                }
                viewModel.Workouts.Add(buffor2);
            }

            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).ToList();

            for (int i = 0; i < 12; i++)
            {
                var buffor = CardioList.Where(c => (c.Date.Month == (i + 1)) && (c.Date.Year == year)).ToList();
                var buffor2 = 0;
                foreach (var item in buffor)
                {
                    buffor2 += (Convert.ToInt32(item.LengthOfTraining));
                }
                viewModel.Cardios.Add(buffor2);
            }

            return Ok(viewModel);
        }
        [HttpGet]
        public IHttpActionResult WorkoutVolumeSumaryList()
        {
            var userId = User.Identity.GetUserId();

            var WorkoutList = _unitOfWork.Workouts.GetAllWorkouts(userId).ToList();
            var viewModel = new WorkoutStatisticsViewModel();

            foreach (var item in WorkoutList)
            {
                viewModel.YearsWithTraning.Add(Convert.ToInt32(item.Date.Year.ToString()));
            }
            viewModel.YearsWithTraning = viewModel.YearsWithTraning.Distinct().OrderBy(c => c).ToList();

            for (int i = 0; i < viewModel.YearsWithTraning.Count(); i++)
            {
                var buffor = WorkoutList.Where(c => c.Date.Year == viewModel.YearsWithTraning[i]).ToList();
                var buffor2 = 0;
                foreach (var item in buffor)
                {
                    buffor2 += item.WorkoutVolume;
                }
                viewModel.WorkoutVolume.Add(buffor2);
            }

            return Ok(viewModel);
        }
        [Route("Api/StatisticsApi/WorkoutVolumePerMonthList/{year}/{month}")]
        [HttpGet]
        public IHttpActionResult WorkoutVolumePerMonthList(int year, int month)
        {
            var userId = User.Identity.GetUserId();

            var WorkoutList = _unitOfWork.Workouts.GetAllWorkouts(userId).Where(c => (c.Date.Month == month) && (c.Date.Year == year)).ToList();

            var viewModel = new WorkoutVolumePerMonthListViewModel();

            foreach (var item in WorkoutList)
            {
                var buffor = new WotkoutVolumeDto();
                buffor.Year = item.Date.Year;
                buffor.Month = item.Date.Month;
                buffor.Day = item.Date.Day;
                buffor.WorkoutVolume = item.WorkoutVolume;
                viewModel.Volume.Add(buffor);
            }
            return Ok(viewModel.Volume);
        }
        [HttpGet]
        public IHttpActionResult WorkoutVolumePerYearList(int year)
        {
            var userId = User.Identity.GetUserId();

            var WorkoutList = _unitOfWork.Workouts.GetAllWorkouts(userId).Where(c => c.Date.Year == year).ToList();

            var viewModel = new WorkoutStatisticsViewModel();

            for (int i = 0; i < 12; i++)
            {
                var buffor = WorkoutList.Where(c => (c.Date.Month == (i + 1)) && (c.Date.Year == year)).ToList();
                var buffor2 = 0;
                foreach (var item in buffor)
                {
                    buffor2 += item.WorkoutVolume;
                }
                viewModel.WorkoutVolume.Add(buffor2);
            }
            return Ok(viewModel);
        }
        [HttpGet]
        public IHttpActionResult CardioDistanceSumaryList()
        {
            var userId = User.Identity.GetUserId();

            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).ToList();
            var viewModel = new WorkoutStatisticsViewModel();

            foreach (var item in CardioList)
            {
                viewModel.YearsWithTraning.Add(Convert.ToInt32(item.Date.Year.ToString()));
            }
            viewModel.YearsWithTraning = viewModel.YearsWithTraning.Distinct().OrderBy(c => c).ToList();

            for (int i = 0; i < viewModel.YearsWithTraning.Count(); i++)
            {
                var buffor = CardioList.Where(c => c.Date.Year == viewModel.YearsWithTraning[i]).ToList();
                var buffor2 = 0;
                foreach (var item in buffor)
                {
                    buffor2 += Convert.ToInt32(item.Distance);
                }
                viewModel.WorkoutVolume.Add(buffor2);
            }
            return Ok(viewModel);
        }
        [HttpGet]
        public IHttpActionResult CardioDistancePerYearList(int year)
        {
            var userId = User.Identity.GetUserId();

            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).Where(c => c.Date.Year == year).ToList();

            var viewModel = new WorkoutStatisticsViewModel();

            for (int i = 0; i < 12; i++)
            {
                var buffor = CardioList.Where(c => (c.Date.Month == (i + 1)) && (c.Date.Year == year)).ToList();
                var buffor2 = 0;
                foreach (var item in buffor)
                {
                    buffor2 += Convert.ToInt32(item.Distance);
                }
                viewModel.WorkoutVolume.Add(buffor2);
            }
            return Ok(viewModel);
        }
        [Route("Api/StatisticsApi/CardioDistancePerMonthList/{year}/{month}")]
        [HttpGet]
        public IHttpActionResult CardioDistancePerMonthList(int year, int month)
        {
            var userId = User.Identity.GetUserId();

            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).Where(c => (c.Date.Month == month) && (c.Date.Year == year)).ToList();

            var viewModel = new CarioDistancePerMonthListViewModel();

            foreach (var item in CardioList)
            {
                var buffor = new CardioDistanceDto();
                buffor.Year = item.Date.Year;
                buffor.Month = item.Date.Month;
                buffor.Day = item.Date.Day;
                buffor.Distance = item.Distance;
                viewModel.Distance.Add(buffor);
            }
            
            return Ok(viewModel.Distance.OrderBy(d => d.Day).ToList());
        }
        [HttpGet]
        public IHttpActionResult CardioCountSumaryList()
        {
            var userId = User.Identity.GetUserId();

            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).ToList();
            var viewModel = new WorkoutStatisticsViewModel();

            foreach (var item in CardioList)
            {
                viewModel.YearsWithTraning.Add(Convert.ToInt32(item.Date.Year.ToString()));
            }
            viewModel.YearsWithTraning = viewModel.YearsWithTraning.Distinct().OrderBy(c => c).ToList();

            for (int i = 0; i < viewModel.YearsWithTraning.Count(); i++)
            {
                var buffor = CardioList.Where(c => c.Date.Year == viewModel.YearsWithTraning[i]).ToList();
                var buffor2 = 0;
                foreach (var item in buffor)
                {
                    buffor2 ++;
                }
                viewModel.WorkoutVolume.Add(buffor2);
            }
            return Ok(viewModel);
        }
        [HttpGet]
        public IHttpActionResult CardioCountPerYearList(int year)
        {
            var userId = User.Identity.GetUserId();

            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).Where(c => c.Date.Year == year).ToList();

            var viewModel = new WorkoutStatisticsViewModel();

            for (int i = 0; i < 12; i++)
            {
                var buffor = CardioList.Where(c => (c.Date.Month == (i + 1)) && (c.Date.Year == year)).ToList();
                var buffor2 = 0;
                foreach (var item in buffor)
                {
                    buffor2 ++;
                }
                viewModel.WorkoutVolume.Add(buffor2);
            }
            return Ok(viewModel);
        }
        [Route("Api/StatisticsApi/CardioCountPerMonthList/{year}/{month}")]
        [HttpGet]
        public IHttpActionResult CardioCountPerMonthList(int year, int month)
        {
            var userId = User.Identity.GetUserId();

            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).Where(c => (c.Date.Month == month) && (c.Date.Year == year)).ToList();

            var viewModel = new CarioDistancePerMonthListViewModel();

            foreach (var item in CardioList)
            {
                var buffor = new CardioDistanceDto();
                buffor.Year = item.Date.Year;
                buffor.Month = item.Date.Month;
                buffor.Day = item.Date.Day;
                buffor.Distance = 1;
                viewModel.Distance.Add(buffor);
            }

            return Ok(viewModel.Distance);
        }
        //--------------------------------------------------- czas treningow
        public IHttpActionResult CardioLengthSumaryList()
        {
            var userId = User.Identity.GetUserId();

            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).ToList();
            var viewModel = new WorkoutStatisticsViewModel();

            foreach (var item in CardioList)
            {
                viewModel.YearsWithTraning.Add(Convert.ToInt32(item.Date.Year.ToString()));
            }
            viewModel.YearsWithTraning = viewModel.YearsWithTraning.Distinct().OrderBy(c => c).ToList();

            for (int i = 0; i < viewModel.YearsWithTraning.Count(); i++)
            {
                var buffor = CardioList.Where(c => c.Date.Year == viewModel.YearsWithTraning[i]).ToList();
                var buffor2 = 0;
                foreach (var item in buffor)
                {
                    buffor2 += Convert.ToInt32(item.LengthOfTraining);
                }
                viewModel.WorkoutVolume.Add(buffor2);
            }
            return Ok(viewModel);
        }
        [HttpGet]
        public IHttpActionResult CardioLengthPerYearList(int year)
        {
            var userId = User.Identity.GetUserId();

            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).Where(c => c.Date.Year == year).ToList();

            var viewModel = new WorkoutStatisticsViewModel();

            for (int i = 0; i < 12; i++)
            {
                var buffor = CardioList.Where(c => (c.Date.Month == (i + 1)) && (c.Date.Year == year)).ToList();
                var buffor2 = 0;
                foreach (var item in buffor)
                {
                    buffor2 += Convert.ToInt32(item.LengthOfTraining);
                }
                viewModel.WorkoutVolume.Add(buffor2);
            }
            return Ok(viewModel);
        }
        [Route("Api/StatisticsApi/CardioLengthPerMonthList/{year}/{month}")]
        [HttpGet]
        public IHttpActionResult CardioLengthPerMonthList(int year, int month)
        {
            var userId = User.Identity.GetUserId();

            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).Where(c => (c.Date.Month == month) && (c.Date.Year == year)).ToList();

            var viewModel = new CarioDistancePerMonthListViewModel();

            foreach (var item in CardioList)
            {
                var buffor = new CardioDistanceDto();
                buffor.Year = item.Date.Year;
                buffor.Month = item.Date.Month;
                buffor.Day = item.Date.Day;
                buffor.Distance =Convert.ToDecimal(item.LengthOfTraining);
                viewModel.Distance.Add(buffor);
            }

            return Ok(viewModel.Distance);
        }
    }
}
