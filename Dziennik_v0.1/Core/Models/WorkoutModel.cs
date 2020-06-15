
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dziennik_v0._1.Core.Models
{
    public class Workout
    {
        public Workout()
        {
            this.Exercises = new List<Exercise>();
            this.Date = DateTime.Today;
            this.LengthOfTraining = "60";
        }

        [Required]
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data:")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Czas treningu:")]
        public string LengthOfTraining { get; set; }

        [Display(Name = "Objętość treningu:")]
        public int WorkoutVolume { get; set; }

        public virtual List<Exercise> Exercises { get; set; }

        [ScaffoldColumn(false)]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}