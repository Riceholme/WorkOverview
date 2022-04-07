using Models;
using RestAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Services
{
    public class EmployeeRepository : IEmpRepository<Employee>
    {
        private Context _empContext;
        public EmployeeRepository(Context empContext)
        {
            _empContext = empContext;
        }

        public Task<Employee> Add(Employee newEntity)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetPersonIncludeTimeReports(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> Update(Employee Entity)
        {
            throw new NotImplementedException();
        }
    }
}
