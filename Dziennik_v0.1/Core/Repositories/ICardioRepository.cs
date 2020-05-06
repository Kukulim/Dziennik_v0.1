using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Repositories
{
    public interface ICardioRepository
    {
        CardioModel GetCardio(int CardioId);
        IEnumerable<CardioModel> GetAllCardios();

        void AddCardio();
        void DeleteCardio();
        void EditCardio(int CardioId);
    }
}