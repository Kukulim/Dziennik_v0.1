﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
        public int Series { get; set; }
        public int Repetitions { get; set; }
        public int Weight { get; set; }
        public int Volume { get; set; }

    }
}