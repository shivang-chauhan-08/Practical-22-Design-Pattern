using Employee.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.DAL.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Employee.DAL.Models.Employee> Employees { get; set; }
        public DbSet<Employee.DAL.Models.Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "IT"},
                new Department { Id = 2, Name = "Admin" },
                new Department { Id = 3, Name = "HR" },
                new Department { Id = 4, Name = "Sales" },
                new Department { Id = 5, Name = "On-Site" }
             );
        }
    }
}
