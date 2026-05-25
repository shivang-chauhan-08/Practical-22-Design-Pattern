using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.DAL.DTOs
{
    public class EmployeeDTO
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public string EmailId { get; set; }
    }
}
