using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Models.Enums
{
    public enum SexType
    {
        [Display(Name = "Mężczyzna")] Male,
        [Display(Name = "Kobieta")] Female
    }
}