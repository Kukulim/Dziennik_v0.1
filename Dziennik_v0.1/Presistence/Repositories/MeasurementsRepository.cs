using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Repositories;
using Dziennik_v0._1.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Presistence.Repositories
{
    public class MeasurementsRepository : IMeasurementsRepository
    {
        private readonly ApplicationDbContext context;

        public MeasurementsRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void AddMeasurement(Measurement Measurement)
        {
            context.Measurements.Add(Measurement);
        }

        public void DeleteMeasurement(int id)
        {
            throw new NotImplementedException();
        }

        public void EditMeasurement(Measurement Measurement)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Measurement> GetAllMeasurements(string id)
        {
            throw new NotImplementedException();
        }

        public Measurement GetMeasurement(int MeasurementId)
        {
            throw new NotImplementedException();
        }
    }
}