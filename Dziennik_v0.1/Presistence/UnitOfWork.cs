using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Repositories;
using Dziennik_v0._1.Persistence;
using Dziennik_v0._1.Presistence.Repositories;
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

        public void CardioAchievementsCheck(string userId)
        {
            var user = Users.GetUser(userId);
            var AchievementsList = Achievements.GetAllAchievement(userId);
            var CardioList = Cardios.GetAllCardios(userId);

            var Achievement = AchievementsList.FirstOrDefault(a => a.Name == "Pierwszy trenig cardio");
            if (CardioList.Any() && !Achievement.Acquired)
            {
                    Achievement.Acquired = true;
                    Achievement.AcquiredDate = CardioList.FirstOrDefault(_ => true).Date;
                    user.AchievementsPoints += Achievement.Value;
            }

            Achievement = AchievementsList.FirstOrDefault(a => a.Name == "Przebiegnij 5 km.");
            var test = CardioList.FirstOrDefault(c => c.Distance >= 5);
            if (test!=null && !Achievement.Acquired)
            {
                Achievement.Acquired = true;
                Achievement.AcquiredDate = CardioList.FirstOrDefault(c => c.Distance >= 5)?.Date ?? default;
                user.AchievementsPoints += Achievement.Value;
            }

        }

        public void WorkoutAchievementsCheck(string userId)
        {
            var user = Users.GetUser(userId);
            var AchievementsList = Achievements.GetAllAchievement(userId);
            var WorkoutList = Workouts.GetAllWorkouts(userId);

            var Achievement = AchievementsList.First(a => a.Name == "Pierwszy trenig siłowy");
            if (WorkoutList.Any() && !Achievement.Acquired)
            {
                    Achievement.Acquired = true;
                    Achievement.AcquiredDate = WorkoutList.FirstOrDefault(_ => true).Date;
                    user.AchievementsPoints += Achievement.Value;
            }

        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}