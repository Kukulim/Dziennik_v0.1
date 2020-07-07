
using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Repositories;
using Dziennik_v0._1.Core.ViewModels;
using System;

namespace Dziennik_v0._1.Core
{
    public interface IUnitOfWork
    {
        IWorkoutRepository Workouts { get; }
        IExerciseRepository Exercises { get; }
        ICardioRepository Cardios { get; }
        IAchievementsRepository Achievements { get; }
        IApplicationUserRepository Users { get; }
        void Complete();
        void CardioAchievementsCheck(CardioCreateViewModel cardioCreateViewModel);
        void WorkoutAchievementsCheck(Workout Workout);
    }
}