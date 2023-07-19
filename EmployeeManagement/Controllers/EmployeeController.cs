using EmployeeManagement.Foundation.Interfaces;
using EmployeeManagement.Foundation.Models;
using EmployeeManagement.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository
        }
        [HttpGet("values")]
        public IEnumerable<EmployeeDetails> Values()
        {
            return employeeRepository.GetAll(); 
        }
        [HttpGet("GetEmployeeById")]
        public EmployeeDetails GetEmployeeById(int id)
        {
            return employeeRepository.Get(id);
        }
        [HttpPost]
        public IActionResult Post([FromBody] EmployeeDetails employee)
        {
            employeeRepository.AddEmployee(employee);
            return Ok();
        }
    }
}
