using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using Microsoft.Extensions.Logging;
using Employee.Data;
using Clock_In_Station.Pages.Redirects;

namespace Clock_In_Station.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IEmployeeData empData;

        public IndexModel(ILogger<IndexModel> logger, IEmployeeData empData)
        {
            _logger = logger;
            this.empData = empData;
        }

        public string CurrentDateTime()
        {
            string current;
            return current = DateTime.Now.ToString("dddd, MMM dd yyyy, hh:mm:ss");
        }
        public void OnGet()
        {
            CurrentDateTime();
        }

       public IActionResult OnPost(int employeeid)
        {
            if (empData.Clockin(employeeid))
            {
                return RedirectToPage(@"./Redirects/Clockin");
            }
            return StatusCode(404);
        }
    }
}
