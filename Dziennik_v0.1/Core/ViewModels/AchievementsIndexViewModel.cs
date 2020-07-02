using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.ViewModels
{
    public class AchievementsIndexViewModel
    {
        public int AchievementsPoints { get; set; }

        public List<Achievement> Achievements = new List<Achievement>();
    }
}