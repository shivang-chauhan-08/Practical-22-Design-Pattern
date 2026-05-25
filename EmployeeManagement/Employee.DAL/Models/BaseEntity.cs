using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.DAL.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
