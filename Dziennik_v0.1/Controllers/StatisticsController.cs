using Dziennik_v0._1.Core;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dziennik_v0._1.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StatisticsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var CardioList = _unitOfWork.Cardios.GetAllCardios(userId).ToList();
            return View(CardioList);
        }
    }
}