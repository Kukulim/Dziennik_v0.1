using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik_v0._1.Presistence
{
    interface IApplicationDbContext
    {
        DbSet<Workout> Workouts { get; set; }
        DbSet<Exercise> Exercises { get; set; }
        DbSet<Cardio> Cardios { get; set; }
        DbSet<Achievement> Achievements { get; set; }
    }
}
