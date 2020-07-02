using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Helpers
{
    public static class AchievementsHelper
    {
        public static List<Achievement> CreateAchievements()
        {
            return new List<Achievement>
            {
                new Achievement { Id=1, Name="Pierwszy trenig cardio", AcquiredDate=new DateTime(2000,01,01) }
            };
        }
    }
}