using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Repositories;
using Dziennik_v0._1.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Presistence.Repositories
{
    public class AchievementsRepository : IAchievementsRepository
    {
        private readonly ApplicationDbContext _context;

        public AchievementsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Achievement GetAchievement(string name)
        {
            return _context.Achievements.Where(x => x.Name == name).FirstOrDefault();
        }

        public IEnumerable<Achievement> GetAllAchievement(string id)
        {
            return _context.Achievements.Where(x => x.UserId == id).ToList();
        }
    }
}