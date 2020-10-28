using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Employee.Data;

namespace Clock_In_Station.Pages
{
    public class listModel : PageModel
    {
        private readonly IEmployeeData employeeData;
        public IEnumerable<InMemoryEmployeeData> Employees { get; set; }
        public listModel(IEmployeeData employeeData)
        {
            this.employeeData = employeeData;
        }

        public string CurrentDateTime()
        {
            string current;
            return current = DateTime.Now.ToString("hh:mm:ss");
        }
        public void OnGet()
        {
        }
    }
}
