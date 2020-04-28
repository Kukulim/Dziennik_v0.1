using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Repositories;
using Dziennik_v0._1.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dziennik_v0._1.Presistence.Repositories
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private readonly ApplicationDbContext _context;

        public WorkoutRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddWorkout(Workout workout)
        {
            _context.Workouts.Add(workout);
        }

        public void DeleteWorkout()
        {
            throw new NotImplementedException();
        }

        public void EditWorkout(int WorkoutId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Workout> GetAllWorkouts(string id)
        {
            return _context.Workouts.Where(x => x.UserId == id).ToList();
        }

        public Workout GetWorkout(int WorkoutId)
        {
            throw new NotImplementedException();
        }
    }
}