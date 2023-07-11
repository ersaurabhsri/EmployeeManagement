using EmployeeManagement.Foundation.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EmployeeManagement.Data
{
    public class AppDbContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string connString = configuration.GetConnectionString("DbConnection")!;
        //    optionsBuilder.UseSqlServer(connString);
        //    base.OnConfiguring(optionsBuilder);
        //}
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //if(!Employees.Any())
            //{
            //    Employees.Add(new EmployeeDetails
            //    {

            //    });

            //}
            modelBuilder.Entity<Department>().HasData(
            new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });
           
            
            modelBuilder.Entity<EmployeeDetails>().HasData(new EmployeeDetails
            {
                id = 1,
                name = "John",
                DeparmentId = 1,
                age = 25,
                city="Abc",
                country="AA",                
            });

            modelBuilder.Entity<EmployeeDetails>().HasData(new EmployeeDetails
            {
                id = 2,
                name = "saurabh",
                DeparmentId = 2,
                age = 23,
                city = "Delhi",
                country = "India",
            });

            modelBuilder.Entity<EmployeeDetails>().HasData(new EmployeeDetails
            {
                id = 3,
                name = "Mark",
                DeparmentId = 1,
                age = 25,
                city = "Abc",
                country = "AA",
            });

            modelBuilder.Entity<EmployeeDetails>().HasData(new EmployeeDetails
            {
                id = 4,
                name = "Sam",
                DeparmentId = 2,
                age = 25,
                city = "Abc",
                country = "AA",
            });
        }
        public DbSet<EmployeeDetails> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
