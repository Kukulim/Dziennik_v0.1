using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dziennik_v0._1.Controllers
{
    public class DietController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DietController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserProfile()
        {
            var userId = User.Identity.GetUserId();
            var user = _unitOfWork.Users.GetUser(userId);
            return View(user);
        }
        [HttpPost]
        public ActionResult UserProfile(ApplicationUser viewModel)
        {
            return View();
        }
    }
}