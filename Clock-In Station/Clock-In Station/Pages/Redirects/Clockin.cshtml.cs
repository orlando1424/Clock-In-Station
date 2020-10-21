using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clock_In_Station.Pages.Redirects
{
    public class ClockinModel : PageModel
    {

        public string Message { get; set; }
        public void OnGet()
        {
            Message = "You are clocked in!";
        }
    }
}
