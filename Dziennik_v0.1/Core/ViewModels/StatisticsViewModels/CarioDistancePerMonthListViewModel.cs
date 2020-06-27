using Dziennik_v0._1.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.ViewModels.StatisticsViewModels
{
    public class CarioDistancePerMonthListViewModel
    {
        public List<CardioDistanceDto> Distance { get; set; } = new List<CardioDistanceDto>();
        public List<int> YearsWithTraning { get; set; } = new List<int>();
    }
}