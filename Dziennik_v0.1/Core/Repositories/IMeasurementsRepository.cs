using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Repositories
{
    public interface IMeasurementsRepository
    {
        Measurement GetMeasurement(int MeasurementId);
        IEnumerable<Measurement> GetAllMeasurements(string id);

        void AddMeasurement(Measurement Measurement);
        void DeleteMeasurement(int id);
        void EditMeasurement(Measurement Measurement);
    }
}