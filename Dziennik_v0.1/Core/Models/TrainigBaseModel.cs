using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Models
{
    public class TrainigBaseModel
    {
        [Required]
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data:")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Czas treningu:")]
        public string LengthOfTraining { get; set; }
    }
}