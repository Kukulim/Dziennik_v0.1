using Dziennik_v0._1.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Models
{
    public class FoodModel
    {
        public int Id { get; set; }
        [Display(Name = "Nazwa:")]
        public string Name { get; set; }
        [Display(Name = "Kalorie:")]
        public int Calories { get; set; }
        [Display(Name = "Białko:")]
        public decimal Protein { get; set; }
        [Display(Name = "Węglowodany:")]
        public decimal Carbohydrates { get; set; }
        [Display(Name = "Tłuszcz:")]
        public decimal Fat { get; set; }
        public int Weight { get; set; }
        public MealType MealType { get; set; }
        public int DailyMenuId { get; set; }
        public DailyMenu DailyMenu { get; set; }
    }
}