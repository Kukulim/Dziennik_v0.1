using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Models
{
    public class TreningModel
    {
        public int Id { get; set; }
        public DateTime WorkoutDate { get; set; }
        public string LengthOfTraining { get; set; }
        public List<ExerciseModel> Exercises { get; set; }
        public int ExerciseId { get; set; }
    }
}