using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Models.Enums;
using Dziennik_v0._1.Core.Repositories;
using Dziennik_v0._1.Core.ViewModels;
using Dziennik_v0._1.Persistence;
using Dziennik_v0._1.Presistence.Repositories;
using System;
using System.Linq;

namespace Dziennik_v0._1.Presistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Workouts = new WorkoutRepository(context);
            Exercises = new ExerciseRepository(context);
            Cardios = new CardioRepository(context);
            Achievements = new AchievementsRepository(context);
            Users = new ApplicationUserRepository(context);
        }

        public IWorkoutRepository Workouts { get; private set; }

        public IExerciseRepository Exercises { get; private set; }

        public ICardioRepository Cardios { get; private set; }

        public IAchievementsRepository Achievements { get; private set; }
        public IApplicationUserRepository Users { get; private set; }

        public void CardioAchievementsCheck(CardioCreateViewModel cardioCreateViewModel)
        {
            var user = Users.GetUser(cardioCreateViewModel.Cardio.UserId);
            var AchievementsList = Achievements.GetAllAchievement(cardioCreateViewModel.Cardio.UserId);
            var CardioList = Cardios.GetAllCardios(cardioCreateViewModel.Cardio.UserId);

            var Achievement = AchievementsList.FirstOrDefault(a => a.Name == "Pierwszy trenig cardio");
            if (CardioList.Any() && !Achievement.Acquired)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }

            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "Przebiegnij 5 km.");
            var test = CardioList.FirstOrDefault(c => c.Distance >= 5);
            if (test!=null && !Achievement.Acquired && cardioCreateViewModel.Cardio.CardioType==CardioType.Bieganie)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }

            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "Przebiegnij 10 km.");
            test = CardioList.FirstOrDefault(c => c.Distance >= 10);
            if (test != null && !Achievement.Acquired && cardioCreateViewModel.Cardio.CardioType == CardioType.Bieganie)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }

            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "Przebiegnij Półmaraton");
            test = CardioList.FirstOrDefault(c => Convert.ToInt32(c.Distance * 10000) >= Convert.ToInt32(21.0975 * 10000));
            if (test != null && !Achievement.Acquired && cardioCreateViewModel.Cardio.CardioType == CardioType.Bieganie)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }

            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "Przebiegnij Maraton");
            test = CardioList.FirstOrDefault(c => Convert.ToInt32(c.Distance * 10000) >= Convert.ToInt32(42.195 * 10000));
            if (test != null && !Achievement.Acquired && cardioCreateViewModel.Cardio.CardioType == CardioType.Bieganie)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }

            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "10 trenigów cardio");
            if (CardioList.Count() >= 10 && !Achievement.Acquired)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }
            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "20 trenigów cardio");
            if (CardioList.Count() >= 20 && !Achievement.Acquired)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }
            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "50 trenigów cardio");
            if (CardioList.Count() >= 50 && !Achievement.Acquired)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }
            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "100 trenigów cardio");
            if (CardioList.Count() >= 100 && !Achievement.Acquired)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }
            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "Przejedz rowerem 10 km.");
            test = CardioList.FirstOrDefault(c => c.Distance >= 10);
            if (test != null && !Achievement.Acquired && cardioCreateViewModel.Cardio.CardioType == CardioType.Rower)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }
            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "Przejedz rowerem 20 km.");
            test = CardioList.FirstOrDefault(c => c.Distance >= 20);
            if (test != null && !Achievement.Acquired && cardioCreateViewModel.Cardio.CardioType == CardioType.Rower)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }
            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "Przejedz rowerem 50 km.");
            test = CardioList.FirstOrDefault(c => c.Distance >= 50);
            if (test != null && !Achievement.Acquired && cardioCreateViewModel.Cardio.CardioType == CardioType.Rower)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }
            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "Przejedz rowerem 100 km.");
            test = CardioList.FirstOrDefault(c => c.Distance >= 100);
            if (test != null && !Achievement.Acquired && cardioCreateViewModel.Cardio.CardioType == CardioType.Rower)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }
            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "Przepłyń 1 km.");
            test = CardioList.FirstOrDefault(c => c.Distance >= 1);
            if (test != null && !Achievement.Acquired && cardioCreateViewModel.Cardio.CardioType == CardioType.Pływanie)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }
            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "Przepłyń 3 km.");
            test = CardioList.FirstOrDefault(c => c.Distance >= 3);
            if (test != null && !Achievement.Acquired && cardioCreateViewModel.Cardio.CardioType == CardioType.Pływanie)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }
            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "Przepłyń 5 km.");
            test = CardioList.FirstOrDefault(c => c.Distance >= 5);
            if (test != null && !Achievement.Acquired && cardioCreateViewModel.Cardio.CardioType == CardioType.Pływanie)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }
            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "Przepłyń 20 km.");
            test = CardioList.FirstOrDefault(c => c.Distance >= 20);
            if (test != null && !Achievement.Acquired && cardioCreateViewModel.Cardio.CardioType == CardioType.Pływanie)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = cardioCreateViewModel.Cardio.Date;
                user.AchievementsPoints += Achievement.Value;
            }




        }

        public void WorkoutAchievementsCheck(Workout Workout)
        {
            var user = Users.GetUser(Workout.UserId);
            var AchievementsList = Achievements.GetAllAchievement(Workout.UserId);
            var WorkoutList = Workouts.GetAllWorkouts(Workout.UserId);

            var Achievement = AchievementsList.First(a => a.Name == "Pierwszy trenig siłowy");
            if (WorkoutList.Any() && !Achievement.Acquired)
            {
                    Achievement.Acquired = true;
                    Achievement.AcquiredDate = Workout.Date;
                    user.AchievementsPoints += Achievement.Value;
            }

        }

        public void Complete()
        {
            _context.SaveChanges();
        }

    }
}