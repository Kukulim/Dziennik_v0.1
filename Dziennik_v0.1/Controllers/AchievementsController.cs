using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dziennik_v0._1.Controllers
{
    public class AchievementsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AchievementsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            var viewModel = new Achievement { Id=1, Name="Pierwszy trenig cardio", AcquiredDate=new DateTime(2020,06,30), Acquired=true };
            return View(viewModel);
        }
    }
}