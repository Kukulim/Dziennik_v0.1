﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Dziennik_v0._1.Core.Models
{
    public class Measurement
    {
        public int Id { get; set; }

        [Display(Name = "Waga:")]
        public float Weight { get; set; }

        [Display(Name = "Data:")]
        public DateTime Date { get; set; }

        [Display(Name = "Zapotrzebowanie kaloryczne:")]
        public float CaloricRequirement { get; set; }

        public string UserId { get; set; }
    }
}