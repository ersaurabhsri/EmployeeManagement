using EmployeeManagement.Foundation.Interfaces;
using EmployeeManagement.Foundation.Models;
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
            this.employeeRepository = employeeRepository;
        }
        [HttpGet("values")]
        public IEnumerable<string> Values()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet("GetEmployeeById")]
        public EmployeeDetails GetEmployeeById(int id)
        {
            return employeeRepository.Get(id);
        }
        [HttpPost]
        public void Post([FromBody] string value)
        {
            List<string> list = new List<string>(); 
        }
    }
}
