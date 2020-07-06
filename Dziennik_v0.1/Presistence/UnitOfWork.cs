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
            var Achievement = AchievementsList.FirstOrDefault(a=>a.Name == "Pierwszy trenig cardio");
            var CardioList = Cardios.GetAllCardios(userId);
            if (CardioList.Any())
            {
                    Achievement.Acquired = true;
                    Achievement.AcquiredDate = System.DateTime.Now;
                    user.AchievementsPoints += Achievement.Value;
            }

        }

        public void WorkoutAchievementsCheck(string userId)
        {
            var user = Users.GetUser(userId);
            var AchievementsList = Achievements.GetAllAchievement(userId).Where(a=> !a.Acquired);
            var WorkoutList = Workouts.GetAllWorkouts(userId);
            if (WorkoutList.Count() > 0)
            {
                var buffor = AchievementsList.First(a => a.Name == "Pierwszy trenig siłowy");
                if (!buffor.Acquired)
                {
                    buffor.Acquired = true;
                    buffor.AcquiredDate = System.DateTime.Now;
                    user.AchievementsPoints += buffor.Value;
                }
            }

        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}