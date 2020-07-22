using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Models
{
    public class DailyMenu
    {
        public int Id { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime DailyMenuDate { get; set; }

        public virtual List<FoodModel> FoodModels { get; set; }

        [ScaffoldColumn(false)]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}