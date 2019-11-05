using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class EmployeeService
    {
        public List<Employee> GetAll()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Name = "Kevin", Salary = 30000},
                new Employee { Id = 2, Name = "Joe", Salary = 40000},
                new Employee { Id = 3, Name = "Bob", Salary = 50000}
            };
        }
    }
}