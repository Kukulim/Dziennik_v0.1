using Dziennik_v0._1.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Models
{
    public class Cardio : TrainigBaseModel
    {
        public Cardio()
        {
            this.Date = DateTime.Today;
            this.LengthOfTraining = "60";
        }

        [Required]
        [Display(Name = "Dystans:")]
        public decimal Distance { get; set; }

        [Required]
        [Display(Name = "Rodzaj treningu:")]
        public CardioType CardioType { get; set; }

        [ScaffoldColumn(false)]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}