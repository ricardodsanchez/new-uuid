using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NewUUID.Pages
{
    public class IndexModel : PageModel
    {
        public string NewUuid { get; private set; }
        public void OnGet()
        {
            NewUuid = null;
        }

        public void OnPost()
        {
            NewUuid = System.Guid.NewGuid().ToString();
        }
    }
}
