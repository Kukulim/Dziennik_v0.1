using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Repositories
{
    public interface ICardioRepository
    {
        Cardio GetCardio(int CardioId);
        IEnumerable<Cardio> GetAllCardios(string id);

        void AddCardio(Cardio cardio);
        void DeleteCardio();
        void EditCardio(int CardioId);
    }
}