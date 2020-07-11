using Dziennik_v0._1.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Models
{
    public class Achievement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Acquired { get; set; }
        public bool IsNew { get; set; }
        public string ImageUrl { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime AcquiredDate { get; set; }
        public TraningType TraningType { get; set; }
        public int Value { get; set; }

        [ScaffoldColumn(false)]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}