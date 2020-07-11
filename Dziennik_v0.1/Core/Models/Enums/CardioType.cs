using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Models.Enums
{
    public enum CardioType
    {
        Bieganie,
        Pływanie,
        [Display(Name = "Jazda na rowerze")] Rower,
        Fitness
    }
}