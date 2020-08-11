using Dziennik_v0._1.Core.Dtos;
using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.ViewModels
{
    public class DietIndexViewModel
    {
        public DailyMenu DailyMenu { get; set; }
        public MealSumaryDto Breakfast { get; set; } = new MealSumaryDto();
        public MealSumaryDto Dinner { get; set; } = new MealSumaryDto();
        public MealSumaryDto Lunch { get; set; } = new MealSumaryDto();
        public MealSumaryDto Snack { get; set; } = new MealSumaryDto();
        public MealSumaryDto AllDayMenuSumary { get; set; } = new MealSumaryDto();
        public MealSumaryDto CalorieLimit { get; set; } = new MealSumaryDto();

    }
}