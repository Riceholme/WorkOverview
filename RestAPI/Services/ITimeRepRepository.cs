using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Services
{
    public interface ITimeRepRepository<T>
    {
        Task<T> GetSingle(int id);
        Task<IEnumerable<T>> GetAll();

        //Uppgift 1
        Task<IEnumerable<T>> GetTimeReportsByEmpId(int id);

        //Uppgift 2
        Task<IEnumerable<T>> GetEmpsOfProjectId(int id);

        //Uppgift 3
        Task<IEnumerable<T>> WorkedHoursByWeekAndEmpId(int id, int week);
        Task<int> WorkedHoursByWeekAndEmpIdtest(int id, int week);
        Task<T> Add(T newEntity);
        Task<T> Update(T Entity);
        Task<T> Delete(int id);
    }
}
