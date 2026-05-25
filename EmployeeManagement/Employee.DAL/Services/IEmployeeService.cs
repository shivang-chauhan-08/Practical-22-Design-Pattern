using Employee.DAL.DTOs;
using Employee.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.DAL.Services
{
    public interface IEmployeeService
    {
        Task<object> GetEmployee(int? id);
        Task CreateEmployee(EmployeeDTO entity);
        Task UpdateEmployee(EmployeeUpdateDTO entity);
        Task DeleteEmployee(int id);
    }
}
