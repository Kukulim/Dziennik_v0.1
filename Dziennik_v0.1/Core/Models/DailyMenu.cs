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

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DailyMenuDate { get; set; }

        public List<FoodModel> FoodModels { get; set; }

        [ScaffoldColumn(false)]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}