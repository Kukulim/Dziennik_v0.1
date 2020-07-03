using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Repositories;
using Dziennik_v0._1.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Presistence.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly ApplicationDbContext _context;

        public ApplicationUserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void EditUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser GetUser(string userId)
        {
            return _context.Users.Where(w => w.Id == userId).FirstOrDefault();
        }
    }
}