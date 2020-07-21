using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Dtos
{
    public class MealSumaryDto
    {
        public int Calories { get; set; }
        public decimal Fat { get; set; }
        public decimal Protein { get; set; }
        public decimal Carbohydrates { get; set; }
    }
}