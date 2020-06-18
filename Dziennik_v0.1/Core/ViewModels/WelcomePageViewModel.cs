using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.ViewModels
{
    public class WelcomePageViewModel
    {
        public List<Workout> Workouts = new List<Workout>();
        public List<Cardio> Cardios = new List<Cardio>();
    }
}