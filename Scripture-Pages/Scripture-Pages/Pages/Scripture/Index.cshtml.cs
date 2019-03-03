using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Scripture_Pages.Models;

namespace Scripture_Pages.Models
{
    public class IndexModel : PageModel
    {
        private readonly Scripture_Pages.Models.Scripture_PagesContext _context;

        public IndexModel(Scripture_Pages.Models.Scripture_PagesContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }

        public async Task OnGetAsync()
        {
            Scripture = await _context.Scripture.ToListAsync();
        }
    }
}
