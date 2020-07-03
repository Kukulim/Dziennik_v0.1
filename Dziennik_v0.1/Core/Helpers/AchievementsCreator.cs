using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Helpers
{
    public static class AchievementsCreator
    {
        public static List<Achievement> CreateAchievements()
        {
            return new List<Achievement>
            {
                new Achievement {
                    Name="Pierwszy trenig cardio",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=5,
                    Description="Wykonaj pierwszy trening Cardio.",
                    ImageUrl = "./Content/images/man-runnew.png"
                },
                new Achievement {
                    Name="Pierwszy trenig siłowy",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Workout,
                    Value=5,
                    Description="Wykonaj pierwszy trening Siłowy.",
                    ImageUrl = "./Content/images/weightlifternew.jpg"
                },
                new Achievement {
                    Name="Przebiegnij 5 km.",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=10,
                    Description="Przebiegnij 5 km. w jednym treningu",
                    ImageUrl = "./Content/images/man-runnew.png"
                },
            };
        }
    }
}