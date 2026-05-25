using AutoMapper;
using Employee.DAL.DTOs;
using Employee.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.DAL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee.DAL.Models.Employee, EmployeeDTO>().ReverseMap();
            CreateMap<Employee.DAL.Models.Employee, EmployeeUpdateDTO>().ReverseMap();
        }
    }
}
