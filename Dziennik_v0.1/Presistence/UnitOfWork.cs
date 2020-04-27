using Dziennik_v0._1.Core;
using Dziennik_v0._1.Persistence;

namespace Dziennik_v0._1.Presistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}