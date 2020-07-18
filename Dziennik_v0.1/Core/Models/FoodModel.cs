using Dziennik_v0._1.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Models
{
    public class FoodModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public decimal Protein { get; set; }
        public decimal Carbohydrates { get; set; }
        public decimal Fat { get; set; }
        public int Weight { get; set; }
        public MealType MealType { get; set; }
        public int DailyMenuId { get; set; }
        public DailyMenu DailyMenu { get; set; }
    }
}