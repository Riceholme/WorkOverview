using Models;
using RestAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Services
{
    public class TimeReportRepository : ITimeRepRepository<TimeReport>
    {
        private Context _timRepContext;
        public TimeReportRepository(Context timRepContext)
        {
            _timRepContext = timRepContext;
        }

        public Task<TimeReport> Add(TimeReport newEntity)
        {
            throw new NotImplementedException();
        }

        public Task<TimeReport> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TimeReport>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TimeReport> GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TimeReport> Update(TimeReport Entity)
        {
            throw new NotImplementedException();
        }
    }
}
