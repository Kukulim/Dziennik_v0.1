using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.ViewModels
{
    public class AddFoodToMealViewModel
    {
        public List<FoodModel> FoodModels { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public MealType MealType { get; set; }
    }
}