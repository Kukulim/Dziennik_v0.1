using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Repositories;
using Dziennik_v0._1.Persistence;
using Dziennik_v0._1.Presistence.Repositories;

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
        }

        public IWorkoutRepository Workouts { get; private set; }

        public IExerciseRepository Exercises { get; private set; }

        public ICardioRepository Cardios { get; private set; }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}