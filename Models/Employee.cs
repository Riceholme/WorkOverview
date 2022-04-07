using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
    }
}
