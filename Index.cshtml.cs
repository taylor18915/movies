using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace movies.Pages
{
    public class IndexModel : PageModel
    {
        public string[] movienames { get; set; }
        public void OnGet()
        {
            movienames = new string[] { " madea1", "madea2", " madea3 " };
        }
       
    }
}