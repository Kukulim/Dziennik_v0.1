using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Repositories;
using Dziennik_v0._1.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Presistence.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly ApplicationDbContext _context;

        public ExerciseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddExercise()
        {
            throw new NotImplementedException();
        }

        public void DeleteExercise()
        {
            throw new NotImplementedException();
        }

        public void EditExercise(int ExerciseId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Exercise> GetAllExercises()
        {
            throw new NotImplementedException();
        }

        public Exercise GetExercise(int ExerciseId)
        {
            throw new NotImplementedException();
        }
    }
}