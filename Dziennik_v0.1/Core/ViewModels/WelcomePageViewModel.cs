using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Models.Enums;
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

        public int LengthOfWorkoutSum { get; set; }
        public double VolumeSum { get; set; }

        public int LengthOfCardioSum { get; set; }
        public CardioType MostCardioType { get; set; }

        public decimal DistanceSum { get; set; }

        public Cardio RuningBestDistance { get; set; }
    }
}