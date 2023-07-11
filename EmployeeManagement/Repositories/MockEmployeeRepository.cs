using EmployeeManagement.Foundation.Interfaces;
using EmployeeManagement.Foundation.Models;

namespace EmployeeManagement.Repositories
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        static List<EmployeeDetails> employees = new List<EmployeeDetails>();   
        public MockEmployeeRepository()
        {
            employees.Add(new EmployeeDetails
            {
                id = 1,
                name = "Test",
                DeparmentId = "cs"

            });
        }
        public EmployeeDetails Get(int id)
        {
            return employees.FirstOrDefault(x => x.id == id);  
        }

        public IEnumerable<EmployeeDetails> GetAll()
        {
            return employees;
        }
    }
}
