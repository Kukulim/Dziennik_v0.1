using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Presistence;
using Dziennik_v0._1.Presistence.UserDbInitializer;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Dziennik_v0._1.Persistence
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new UserDbInitializer());
        }

        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Cardio> Cardios { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<DailyMenu> DailyMenus { get; set; }
        public DbSet<FoodModel> Foods { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}