using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Repositories
{
    public interface IDailyMenuRepository
    {
        DailyMenu GetDailyMenu(int Id);
        IEnumerable<DailyMenu> GetAllDailyMenu(string Id);

        void AddDailyMenu(DailyMenu DailyMenu);
        void DeleteDailyMenu(int Id);
        void EditDailyMenu(DailyMenu DailyMenu);
    }
}