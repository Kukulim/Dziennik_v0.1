
using Dziennik_v0._1.Core.Repositories;

namespace Dziennik_v0._1.Core
{
    public interface IUnitOfWork
    {
        IWorkoutRepository Workouts { get; }
        IExerciseRepository Exercises { get; }
        ICardioRepository Cardios { get; }
        void Complete();
    }
}