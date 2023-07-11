using EmployeeManagement.Foundation.Models;

namespace EmployeeManagement.Foundation.Interfaces
{
    public interface IEmployeeRepository
    {
        EmployeeDetails Get(int id);
        IEnumerable<EmployeeDetails> GetAll();
    }
}
