using Microsoft.EntityFrameworkCore;
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
        public Task<IEnumerable<TimeReport>> HoursWorkByEmpIdAndWeek(int id, int week)
        {
            throw new NotImplementedException();
        }
        public async Task<TimeReport> Add(TimeReport newTimeRep)
        {
            var result = await _timRepContext.TimeReports
                .AddAsync(newTimeRep);
            await _timRepContext
                .SaveChangesAsync();
            return result.Entity;
        }

        public async Task<TimeReport> Delete(int id)
        {
            var result = await _timRepContext.TimeReports
                .FirstOrDefaultAsync(p => p.TimeReportId == id);
            if (result != null)
            {
                _timRepContext.TimeReports
                    .Remove(result);
                await _timRepContext
                    .SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<TimeReport>> GetAll()
        {
            return await _timRepContext.TimeReports
                .ToListAsync();
        }

        public async Task<TimeReport> GetSingle(int id)
        {
            return await _timRepContext.TimeReports
                .FirstOrDefaultAsync(p => p.TimeReportId == id);
        }

        public async Task<TimeReport> Update(TimeReport timeReport)
        {
            var result = await _timRepContext.TimeReports
                .FirstOrDefaultAsync(p => p.TimeReportId == timeReport.TimeReportId);
            if (result != null)
            {
                result.WeekNumber = timeReport.WeekNumber;
                result.HoursWorked = timeReport.HoursWorked;
                result.EmployeeId = timeReport.EmployeeId;
                result.ProjectId = timeReport.ProjectId;
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<TimeReport>> GetTimeReportsByEmpId(int id)
        {
            return await _timRepContext.TimeReports
                .Include(p => p.Employee)
                .Where(p => p.EmployeeId == id)
                .ToListAsync();
        }
        public async Task<IEnumerable<TimeReport>> GetEmpsOfProjectId(int id)
        {
            return await _timRepContext.TimeReports
                .Include(p => p.Employee)
                .Where(p => p.ProjectId == id)
                .ToListAsync();
        }
    }
}
