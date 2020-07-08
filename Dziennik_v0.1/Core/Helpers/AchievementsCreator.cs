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
                    Description="Przebiegnij 5 km. w jednym treningu.",
                    ImageUrl = "./Content/images/man-runnew.png"
                },
                new Achievement {
                    Name="Przebiegnij 10 km.",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=10,
                    Description="Przebiegnij 10 km. w jednym treningu.",
                    ImageUrl = "./Content/images/man-runnew.png"
                },
                new Achievement {
                    Name="Przebiegnij Półmaraton",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=25,
                    Description="Przebiegnij 21,0975 km. w jednym treningu.",
                    ImageUrl = "./Content/images/man-runnew.png"
                },
                new Achievement {
                    Name="Przebiegnij Maraton",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=50,
                    Description="Przebiegnij 42,195 km. w jednym treningu.",
                    ImageUrl = "./Content/images/man-runnew.png"
                },
                new Achievement {
                    Name="10 trenigów cardio",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=10,
                    Description="Wykonaj 10 treningów Cardio.",
                    ImageUrl = "./Content/images/man-runnew.png"
                },
                new Achievement {
                    Name="20 trenigów cardio",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=10,
                    Description="Wykonaj 20 treningów Cardio.",
                    ImageUrl = "./Content/images/man-runnew.png"
                },
                new Achievement {
                    Name="50 trenigów cardio",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=20,
                    Description="Wykonaj 50 treningów Cardio.",
                    ImageUrl = "./Content/images/man-runnew.png"
                },
                new Achievement {
                    Name="100 trenigów cardio",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=30,
                    Description="Wykonaj 100 treningów Cardio.",
                    ImageUrl = "./Content/images/man-runnew.png"
                },
               new Achievement {
                    Name="Przejedz rowerem 10 km.",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=5,
                    Description="Przejedz rowerem 10 km. w jednym treningu.",
                    ImageUrl = "./Content/images/bike.jpg"
                },
               new Achievement {
                    Name="Przejedz rowerem 20 km.",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=10,
                    Description="Przejedz rowerem 20 km. w jednym treningu.",
                    ImageUrl = "./Content/images/bike.jpg"
                },
                new Achievement {
                    Name="Przejedz rowerem 50 km.",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=20,
                    Description="Przejedz rowerem 50 km. w jednym treningu.",
                    ImageUrl = "./Content/images/bike.jpg"
                },
                new Achievement {
                    Name="Przejedz rowerem 100 km.",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=30,
                    Description="Przejedz rowerem 100 km. w jednym treningu.",
                    ImageUrl = "./Content/images/bike.jpg"
                },
                new Achievement {
                    Name="Przepłyń 1 km.",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=5,
                    Description="Przepłyń 1 km. w jednym treningu.",
                    ImageUrl = "./Content/images/swimming.jpg"
                },
                new Achievement {
                    Name="Przepłyń 3 km.",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=5,
                    Description="Przepłyń 3 km. w jednym treningu.",
                    ImageUrl = "./Content/images/swimming.jpg"
                },
                new Achievement {
                    Name="Przepłyń 5 km.",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=10,
                    Description="Przepłyń 5 km. w jednym treningu.",
                    ImageUrl = "./Content/images/swimming.jpg"
                },
                new Achievement {
                    Name="Przepłyń 20 km.",
                    AcquiredDate=new DateTime(2000,01,01),
                    TraningType=TraningType.Cardio,
                    Value=20,
                    Description="Przepłyń 20 km. w jednym treningu.",
                    ImageUrl = "./Content/images/swimming.jpg"
                },
            };
        }
    }
}