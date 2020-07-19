using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Repositories;
using Dziennik_v0._1.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Presistence.Repositories
{
    public class DailyMenuRepository : IDailyMenuRepository
    {
        private readonly ApplicationDbContext _context;

        public DailyMenuRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddDailyMenu(DailyMenu DailyMenu)
        {
            _context.DailyMenus.Add(DailyMenu);
        }

        public void DeleteDailyMenu(int Id)
        {
            throw new NotImplementedException();
        }

        public void EditDailyMenu(DailyMenu DailyMenu)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DailyMenu> GetAllDailyMenu(string Id)
        {
            return _context.DailyMenus.Where(d => d.UserId == Id).ToList();
        }

        public DailyMenu GetDailyMenu(string Id, DateTime date)
        {
            return _context.DailyMenus.Where(d => d.UserId == Id && d.DailyMenuDate == date).FirstOrDefault();
        }
    }
}