using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.DAL.Models
{
    public class Employee : BaseEntity
    {
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public string EmailId { get; set; }
        public DateTime JoiningDate { get; set; } = DateTime.Now;
        public bool Status { get; set; } = true;
    }
}
