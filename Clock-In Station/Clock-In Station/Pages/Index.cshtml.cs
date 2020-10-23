using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using Microsoft.Extensions.Logging;

namespace Clock_In_Station.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
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
    }
}
