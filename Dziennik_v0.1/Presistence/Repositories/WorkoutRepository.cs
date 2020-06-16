using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Repositories;
using Dziennik_v0._1.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void DeleteWorkout(int WorkoutId)
        {
            var WorkoutToRemove = _context.Workouts.Find(WorkoutId);
            _context.Workouts.Remove(WorkoutToRemove);
        }

        public void EditWorkout(Workout workout)
        {
            var Workoutedit = _context.Entry(workout);
            foreach (var item in workout.Exercises)
            {
                _context.Entry(item).State = EntityState.Modified;
            }
            Workoutedit.State = EntityState.Modified;
        }

        public IEnumerable<Workout> GetAllWorkouts(string id)
        {
            return _context.Workouts.Where(x => x.UserId == id).ToList();
        }

        public Workout GetWorkout(int WorkoutId)
        {
            return _context.Workouts.Where(c => c.Id == WorkoutId).FirstOrDefault();
        }
    }
}