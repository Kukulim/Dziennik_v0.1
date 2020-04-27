using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik_v0._1.Core.Repositories
{
    interface IExerciseRepository
    {
        Exercise GetExercise(int ExerciseId);
        IEnumerable<Exercise> GetAllExercises();
        void AddExercise();
        void DeleteExercise();
        void EditExercise(int ExerciseId);
    }
}
