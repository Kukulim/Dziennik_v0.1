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

            context.Cardios.Add(new Cardio { Date = new DateTime(2020, 01, 01), CardioType = CardioType.Bieganie, Distance = 5, UserId = "6d99442e-f680-4bef-bd30-6441f6238afa", LengthOfTraining = "57" });

            // seed Workout Trenings

            context.Workouts.Add(new Workout
            {
                Id = 1,
                Date = new DateTime(2020, 01, 02),
                LengthOfTraining = "58",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=1, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=1, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=1, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=1, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=1, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=1, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 2,
                Date = new DateTime(2020, 01, 05),
                LengthOfTraining = "64",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=2, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=2, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=2, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=2, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=2, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=2, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 3,
                Date = new DateTime(2020, 01, 07),
                LengthOfTraining = "64",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=3, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=3, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=3, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=3, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=3, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=3, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 4,
                Date = new DateTime(2020, 01, 09),
                LengthOfTraining = "64",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=4, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=4, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=4, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=4, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=4, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=4, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 5,
                Date = new DateTime(2020, 01, 11),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=5, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=5, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=5, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=5, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=5, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=5, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 6,
                Date = new DateTime(2020, 01, 14),
                LengthOfTraining = "70",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=6, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=6, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=6, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=6, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=6, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=6, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 7,
                Date = new DateTime(2020, 01, 17),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=7, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=7, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=7, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=7, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=7, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=7, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 8,
                Date = new DateTime(2020, 01, 19),
                LengthOfTraining = "50",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=8, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=8, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=8, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=8, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=8, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=8, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 9,
                Date = new DateTime(2020, 01, 22),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=9, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=9, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=9, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=9, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=9, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=9, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 10,
                Date = new DateTime(2020, 01, 25),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=10, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=10, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=10, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=10, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=10, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=10, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 11,
                Date = new DateTime(2020, 01, 27),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=11, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=11, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=11, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=11, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=11, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=11, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 12,
                Date = new DateTime(2020, 01, 30),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=12, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=12, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=12, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=12, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=12, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=12, Name="Uginanie biceps",  } },
                }
            });

            context.Workouts.Add(new Workout
            {
                Id = 13,
                Date = new DateTime(2020, 02, 02),
                LengthOfTraining = "58",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=13, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=13, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=13, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=13, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=13, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=13, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 14,
                Date = new DateTime(2020, 02, 05),
                LengthOfTraining = "64",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=14, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=14, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=14, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=14, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=14, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=14, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 15,
                Date = new DateTime(2020, 02, 07),
                LengthOfTraining = "64",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=15, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=15, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=15, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=15, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=15, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=15, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 16,
                Date = new DateTime(2020, 02, 09),
                LengthOfTraining = "64",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=16, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=16, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=16, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=16, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=16, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=16, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 17,
                Date = new DateTime(2020, 02, 11),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=17, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=17, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=17, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=17, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=17, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=17, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 18,
                Date = new DateTime(2020, 02, 14),
                LengthOfTraining = "70",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=18, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=18, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=18, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=18, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=18, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=18, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 19,
                Date = new DateTime(2020, 02, 16),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=19, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=19, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=19, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=19, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=19, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=19, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 20,
                Date = new DateTime(2020, 02, 18),
                LengthOfTraining = "50",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=20, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=20, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=20, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=20, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=20, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=20, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 21,
                Date = new DateTime(2020, 02, 20),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=21, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=21, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=21, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=21, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=21, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=21, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 22,
                Date = new DateTime(2020, 02, 23),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=22, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=22, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=22, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=22, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=22, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=22, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 23,
                Date = new DateTime(2020, 02, 25),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=23, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=23, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=23, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=23, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=23, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=23, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 24,
                Date = new DateTime(2020, 02, 27),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=24, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=24, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=24, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=24, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=24, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=24, Name="Uginanie biceps",  } },
                }
            });

            context.Workouts.Add(new Workout
            {
                Id = 25,
                Date = new DateTime(2020, 03, 02),
                LengthOfTraining = "58",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=25, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=25, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=25, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=25, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=25, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=25, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 26,
                Date = new DateTime(2020, 03, 05),
                LengthOfTraining = "64",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=26, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=26, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=26, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=26, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=26, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=26, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 27,
                Date = new DateTime(2020, 03, 07),
                LengthOfTraining = "64",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=27, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=27, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=27, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=27, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=27, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=27, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 28,
                Date = new DateTime(2020, 03, 09),
                LengthOfTraining = "64",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=28, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=28, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=28, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=28, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=28, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=28, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 29,
                Date = new DateTime(2020, 03, 11),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=29, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=29, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=29, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=29, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=29, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=29, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 30,
                Date = new DateTime(2020, 03, 14),
                LengthOfTraining = "70",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=30, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=30, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=30, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=30, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=30, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=30, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 31,
                Date = new DateTime(2020, 03, 16),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=31, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=31, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=31, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=31, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=31, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=31, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 32,
                Date = new DateTime(2020, 03, 18),
                LengthOfTraining = "50",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=32, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=32, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=32, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=32, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=32, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=32, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 33,
                Date = new DateTime(2020, 03, 20),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=33, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=33, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=33, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=33, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=33, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=33, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 34,
                Date = new DateTime(2020, 03, 23),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=34, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=34, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=34, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=34, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=34, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=34, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 35,
                Date = new DateTime(2020, 03, 25),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=35, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=35, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=35, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=35, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=35, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=35, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 36,
                Date = new DateTime(2020, 03, 27),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=36, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=36, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=36, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=36, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=36, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=36, Name="Uginanie biceps",  } },
                }
            });
            base.Seed(context);
            context.Workouts.Add(new Workout
            {
                Id = 37,
                Date = new DateTime(2020, 03, 29),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=37, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=37, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=37, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=37, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=37, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=37, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 38,
                Date = new DateTime(2020, 04, 02),
                LengthOfTraining = "58",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=38, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=38, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=38, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=38, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=38, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=38, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 39,
                Date = new DateTime(2020, 04, 05),
                LengthOfTraining = "64",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=39, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=39, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=39, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=39, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=39, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=39, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 40,
                Date = new DateTime(2020, 04, 07),
                LengthOfTraining = "64",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=40, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=40, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=40, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=40, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=40, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=40, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 41,
                Date = new DateTime(2020, 04, 09),
                LengthOfTraining = "64",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=41, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=41, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=41, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=41, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=41, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=41, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 42,
                Date = new DateTime(2020, 04, 11),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=42, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=42, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=42, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=42, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=42, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=42, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 43,
                Date = new DateTime(2020, 04, 14),
                LengthOfTraining = "70",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=43, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=43, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=43, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=43, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=43, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=43, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 44,
                Date = new DateTime(2020, 04, 16),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=44, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=44, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=44, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=44, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=44, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=44, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 45,
                Date = new DateTime(2020, 04, 18),
                LengthOfTraining = "50",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=45, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=45, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=45, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=45, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=45, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=45, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 46,
                Date = new DateTime(2020, 04, 20),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=46, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=46, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=46, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=46, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=46, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=46, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {
                Id = 47,
                Date = new DateTime(2020, 04, 23),
                LengthOfTraining = "60",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=47, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=47, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=47, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=47, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=47, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500,WorkoutId=47, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 04, 25),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 04, 27),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 04, 29),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 05, 01),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 05, 03),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 05, 05),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 05, 07),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 05, 10),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 05, 12),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 05, 14),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 05, 16),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 05, 19),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 05, 21),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 05, 23),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 05, 25),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 05, 28),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 05, 30),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 06, 01),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 06, 03),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 06, 05),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 06, 07),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 06, 10),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 06, 12),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 06, 14),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 06, 16),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 06, 19),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 06, 21),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 06, 23),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 06, 25),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 06, 28),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });
            context.Workouts.Add(new Workout
            {

                Date = new DateTime(2020, 06, 30),
                LengthOfTraining = "55",
                UserId = "6d99442e-f680-4bef-bd30-6441f6238afa",
                WorkoutVolume = 9000,
                Exercises = new List<Exercise>
                {
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wiasłowanie sztangą" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Przysiad" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Wyciskanie ławka skos" } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="OHP",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Francuzy",  } },
                 { new Exercise { Repetitions=5, Series=5, Weight=60, Volume=1500, Name="Uginanie biceps",  } },
                }
            });

            base.Seed(context);
        }
    }
}