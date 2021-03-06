﻿using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik_v0._1.Core.Repositories
{
    public interface IWorkoutRepository
    {
        Workout GetWorkout(int WorkoutId);
        IEnumerable<Workout> GetAllWorkouts(string id);
        void AddWorkout(Workout workout);
        void DeleteWorkout(int WorkoutId);
        void EditWorkout(Workout workout);
    }
}
