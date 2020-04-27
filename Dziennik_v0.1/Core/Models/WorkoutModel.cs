using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string LengthOfTraining { get; set; }
        public List<Exercise> Exercises { get; set; }
        public int ExerciseId { get; set; }
    }
}