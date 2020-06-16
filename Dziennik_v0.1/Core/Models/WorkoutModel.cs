
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dziennik_v0._1.Core.Models
{
    public class Workout :TrainigBaseModel
    {
        public Workout()
        {
            this.Exercises = new List<Exercise>();
            this.Date = DateTime.Today;
            this.LengthOfTraining = "60";
        }

        [Display(Name = "Objętość treningu:")]
        public int WorkoutVolume { get; set; }

        public virtual List<Exercise> Exercises { get; set; }

        [ScaffoldColumn(false)]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}