using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Employee.Data
{
   public interface IEmployeeData
    {
        IEnumerable<Employee> GetEmployees();
        bool Clockin(int employeeid);
    }

    public class InMemoryEmployeeData : IEmployeeData
    {
        List<Employee> employees;
        List<Clock> clocks = new List<Clock> { };
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
        public bool Clockin(int employeeid)
        {
            Employee emp = employees.SingleOrDefault(e => e.Id == employeeid);

            if (emp == null)
            {
                return false;

            }
            Clock newClock = new Clock()
            {
                Employee = emp,
                Clockin = DateTime.Now
                
            };

            clocks.Add(newClock);
                return true;
           
        }

        
    }
}
