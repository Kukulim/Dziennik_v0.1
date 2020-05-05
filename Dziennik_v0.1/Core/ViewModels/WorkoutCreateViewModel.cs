using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.ViewModels
{
    public class WorkoutCreateViewModel
    {
        public Workout Workout { get; set; }
        public List<Exercise> Exercises { get; set; }

    }
}