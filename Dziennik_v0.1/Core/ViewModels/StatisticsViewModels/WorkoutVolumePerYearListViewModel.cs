using Dziennik_v0._1.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.ViewModels.StatisticsViewModels
{
    public class WorkoutVolumePerYearListViewModel
    {
        public List<WotkoutVolumeDto> Volume { get; set; } = new List<WotkoutVolumeDto>();
        public List<int> YearsWithTraning { get; set; } = new List<int>();
    }
}