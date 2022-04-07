using Microsoft.EntityFrameworkCore;
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

        public async Task<Employee> Add(Employee newEmp)
        {
            var result = await _empContext.Employees
                .AddAsync(newEmp);
            await _empContext
                .SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> Delete(int id)
        {
            var result = await _empContext.Employees
                .FirstOrDefaultAsync(p => p.EmployeeId == id);
            if (result != null)
            {
                _empContext.Employees
                    .Remove(result);
                await _empContext
                    .SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _empContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetSingle(int id)
        {
            return await _empContext.Employees
                .FirstOrDefaultAsync(p => p.EmployeeId == id);
        }

        public async Task<Employee> Update(Employee employee)
        {
            var result = await _empContext.Employees
                .FirstOrDefaultAsync(p => p.EmployeeId == employee.EmployeeId);
            if (result != null)
            {
                result.EmpName = employee.EmpName;
                result.Email = employee.Email;
                return result;
            }
            return null;
        }
    }
}
