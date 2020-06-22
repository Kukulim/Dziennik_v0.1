using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.ViewModels.StatisticsViewModels
{
    public class TraningsLengthListViewModel
    {
        public List<int> Cardios { get; set; } = new List<int>();
        public List<int> Workouts { get; set; } = new List<int>();
    }
}