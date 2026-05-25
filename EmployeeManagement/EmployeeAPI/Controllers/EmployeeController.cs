using AutoMapper;
using Employee.DAL.Models;
using Employee.DAL.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service, IMapper mapper)
        {
            _service = service;
        }

        [HttpGet("GetEmployee")]
        public async Task<IActionResult> GetEmployee([FromQuery] int? id)
        {
            var result = await _service.GetEmployee(id);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("CreateEmployee")]
        public async Task<IActionResult> CreateEmployee(Employee.DAL.DTOs.EmployeeDTO emp)
        {
            await _service.CreateEmployee(emp);
            return Ok("Employee Created");
        }

        [HttpPut("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee(Employee.DAL.DTOs.EmployeeUpdateDTO emp)
        {
            await _service.UpdateEmployee(emp);
            return Ok("Employee Updated");
        }

        [HttpDelete("DeleteEmployee/{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            await _service.DeleteEmployee(id);
            return Ok("Employee Deleted");
        }
    }
}
