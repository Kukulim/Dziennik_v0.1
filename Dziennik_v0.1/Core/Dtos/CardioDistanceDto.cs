using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Dtos
{
    public class CardioDistanceDto
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public decimal Distance { get; set; }
    }
}