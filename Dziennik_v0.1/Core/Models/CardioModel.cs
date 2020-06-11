using Dziennik_v0._1.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Models
{
    public class Cardio
    {
        public Cardio()
        {
            this.Date = DateTime.Today;
            this.LengthOfTraining = "60";
        }
        [Required]
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data:")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Czas treningu:")]
        public string LengthOfTraining { get; set; }

        [Required]
        [Display(Name = "Dystans:")]
        public double Distance { get; set; }

        [Required]
        [Display(Name = "Rodzaj treningu:")]
        public CardioType CardioType { get; set; }

        [ScaffoldColumn(false)]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}