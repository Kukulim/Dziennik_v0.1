using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Resources;
using System.Web;

namespace Dziennik_v0._1.Core.Models
{
    public class Workout
    {
        public Workout()
        {
            Exercises = new List<Exercise>();
        }
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Data:")]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = "Czas treningu:")]
        public string LengthOfTraining { get; set; }
        public List<Exercise> Exercises { get; set; }
        [ScaffoldColumn(false)]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}