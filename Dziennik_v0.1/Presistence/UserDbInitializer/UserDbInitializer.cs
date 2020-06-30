using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Models.Enums;
using Dziennik_v0._1.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Presistence.UserDbInitializer
{
    public class UserDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            context.Users.Add(new ApplicationUser { Id = "6d99442e-f680-4bef-bd30-6441f6238afa",SecurityStamp= "f7c82b55-fa9e-43bd-a05d-0cc521f5f6d6", Email = "test@test.test", UserName = "test@test.test", PasswordHash= "AAs+h0C5tUc4l1deZozs3nyDzJjFMrzIL+wsv3Mrfyca4ZIkscTroBo2PfPPz8qT0w==" });

            // seed Cardio Trenings

            context.Cardios.Add(new Cardio { Date = new DateTime(2020, 01, 01), CardioType = CardioType.Bieganie, Distance = 5, Id = 1, UserId = "6d99442e-f680-4bef-bd30-6441f6238afa", LengthOfTraining = "57" });

            // seed Workout Trenings

            context.Workouts.Add(new Workout { Id = 1, Date = new DateTime(2020, 01, 02), LengthOfTraining="58", UserId= "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume=1500, Exercises = new List<Exercise>
                { new Exercise {Name="Pompki", Id=1, Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=1 } }});

            base.Seed(context);
        }
    }
}