using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Services
{
    public interface IEmpRepository<T>
    {
        Task<T> GetSingle(int id);
        //Uppgift 1
        Task<IEnumerable<T>> GetPersonIncludeTimeReports(int id);
        //Uppgift 1a
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T newEntity);
        Task<T> Update(T Entity);
        Task<T> Delete(int id);
    }
}
