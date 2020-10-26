using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Employee.Data
{
   public interface IEmployeeData
    {
        IEnumerable<Employee> GetEmployees();
    }

    public class InMemoryEmployeeData : IEmployeeData
    {
       readonly List<Employee> employees; 
        public InMemoryEmployeeData()
        {
            employees = new List<Employee>()
            {
                new Employee {Id = 1, Name = "Tommy John"},
                new Employee { Id = 2, Name = "Beth Jamm" },
                new Employee {Id = 3, Name = "Jason Mamoa"},
                new Employee {Id = 4, Name = "Ron Swanson"}

            };
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return from e in employees
                   orderby e.Name
                   select e;
        }
    }
}
