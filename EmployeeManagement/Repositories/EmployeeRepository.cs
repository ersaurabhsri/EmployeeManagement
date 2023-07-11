using EmployeeManagement.Data;
using EmployeeManagement.Foundation.Interfaces;
using EmployeeManagement.Foundation.Models;

namespace EmployeeManagement.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public EmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public EmployeeDetails Get(int id)
        {
            return context.Employees.FirstOrDefault(x => x.id == id);
        }

        public IEnumerable<EmployeeDetails> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
