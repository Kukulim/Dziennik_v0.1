using Dziennik_v0._1.Core;
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
        public IHttpActionResult test()
        {
            return Ok();
        }
    }

}
