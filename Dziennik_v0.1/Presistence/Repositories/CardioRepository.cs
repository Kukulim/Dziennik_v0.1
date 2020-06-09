using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Repositories;
using Dziennik_v0._1.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Presistence.Repositories
{
    public class CardioRepository : ICardioRepository
    {
        private readonly ApplicationDbContext _context;

        public CardioRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddCardio(Cardio cardio)
        {
            _context.Cardios.Add(cardio);
        }

        public void DeleteCardio(int id)
        {
            var CardioToDelete = _context.Cardios.Find(id);
            _context.Cardios.Remove(CardioToDelete);
        }

        public void EditCardio(int CardioId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cardio> GetAllCardios(string id)
        {
            return _context.Cardios.Where(x => x.UserId == id).ToList();
        }

        public Cardio GetCardio(int CardioId)
        {
            return _context.Cardios.Where(c => c.Id == CardioId).FirstOrDefault();
        }
    }
}