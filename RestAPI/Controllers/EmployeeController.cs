using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using RestAPI.Services;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmpRepository<Employee> _empRepo;

        public EmployeeController(IEmpRepository<Employee> empRepo)
        {
            _empRepo = empRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            return Ok(await _empRepo.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Employee>> GetOneEmployee(int id)
        {
            try
            {
                var result = await _empRepo.GetSingle(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to get data...");
            }

        }

        [HttpPost]
        public async Task<ActionResult<Employee>> AddNewEmployee(Employee newEmployee)
        {
            try
            {
                if (newEmployee == null)
                {
                    return BadRequest("Employee was not added");
                }
                var createdEmployee = await _empRepo.Add(newEmployee);
                return CreatedAtAction(nameof(GetOneEmployee), new { id = createdEmployee.EmployeeId }, createdEmployee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error To Add Employee");
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee employee)
        {
            try
            {
                if (id != employee.EmployeeId)
                {
                    return BadRequest("Interest with given ID was not found");
                }
                var employeeToUpdate = await _empRepo.GetSingle(id);
                if (employeeToUpdate == null)
                {
                    return NotFound($"Interest withe ID: {id} was not found");
                }
                return await _empRepo.Update(employee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to update Employee");
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {
            try
            {
                var EmpToDelete = await _empRepo.GetSingle(id);
                if (EmpToDelete == null)
                {
                    return NotFound($"Employee with ID; {id} was not found...");
                }
                return await _empRepo.Delete(id);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error occured trying to delete Employee");
            }
        }
    }
}
