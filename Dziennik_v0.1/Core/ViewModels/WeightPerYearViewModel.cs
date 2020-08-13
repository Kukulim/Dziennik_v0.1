using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.ViewModels
{
    public class WeightPerYearViewModel
    {
        public List<float> Weight { get; set; } = new List<float>();
        public List<string> Date { get; set; } = new List<string>();
    }
}