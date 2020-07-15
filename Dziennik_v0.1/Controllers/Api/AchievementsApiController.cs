using Dziennik_v0._1.Core;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dziennik_v0._1.Controllers.Api
{
    public class AchievementsApiController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public AchievementsApiController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IHttpActionResult AchievementsIsNewCount()
        {
            var userId = User.Identity.GetUserId();
            var Achievements = _unitOfWork.Achievements.GetAllAchievement(userId);
            var IsNewCount=0;
            foreach (var item in Achievements)
            {
                if (item.IsNew)
                {
                    IsNewCount++;
                }
            }
            return Ok(IsNewCount);
        }
    }
}
