using AutoMapper;
using Employee.DAL.DTOs;
using Employee.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.DAL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IGenericRepo<Employee.DAL.Models.Employee> _repo;
        private readonly IMapper _mapper;

        public EmployeeService(IGenericRepo<Employee.DAL.Models.Employee> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<object?> GetEmployee(int? id)
        {
            if(id == null)
            {
                var employees = await _repo.GetAll();
                return employees.Where(x => x.IsDeleted == false);
            }

            var employee = await _repo.GetById(id.Value);
            if (employee != null && employee.IsDeleted == false)
            {
                return employee;
            }
            return null;
        }

        public async Task CreateEmployee(EmployeeDTO entity)
        {
            var employee = _mapper.Map<Employee.DAL.Models.Employee>(entity);
            await _repo.Create(employee);
            LoggingService.GetInstance().Log("Employee Created");
        }

        public async Task UpdateEmployee(EmployeeUpdateDTO entity)
        {
            var employee = _mapper.Map<Employee.DAL.Models.Employee>(entity);
            await _repo.Update(employee);
            LoggingService.GetInstance().Log("Employee Updated");
        }

        public async Task DeleteEmployee(int id)
        {
            var employee = await _repo.GetById(id);
            employee.Status = false;
            await _repo.Delete(id);
            LoggingService.GetInstance().Log("Employee Deleted");
        }
    }
}
