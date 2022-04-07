using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class TimeReport
    {
        [Key]
        public int TimeReportId { get; set; }
        public int WeekNumber { get; set; }
        public int HoursWorked { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
