using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.ViewModels
{
    public class CardioCreateViewModel
    {
        public Cardio Cardio { get; set; }

        string _DistanceString;

        [Required]
        [Display(Name = "Dystans:")]
        [RegularExpression("^(-?)(0|([1-9][0-9]*))(\\.[0-9]+)?$", ErrorMessage = "Dystans musi być liczbą")]
        public string DistanceString
        {
            get { return _DistanceString; }
            set {
                _DistanceString = value.Replace(".", ",");
            }
        }
    }
}