using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Repositories;
using Dziennik_v0._1.Persistence;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Presistence.Repositories
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private readonly ApplicationDbContext _context;

        public WorkoutRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddWorkout()
        {
            throw new NotImplementedException();
        }

        public void DeleteWorkout()
        {
            throw new NotImplementedException();
        }

        public void EditWorkout(int WorkoutId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Workout> GetAllWorkouts()
        {
            throw new NotImplementedException();
        }

        public Workout GetWorkout(int WorkoutId)
        {
            throw new NotImplementedException();
        }
    }
}