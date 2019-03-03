using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Scripture_Pages.Models;

namespace Scripture_Pages.Pages.Models
{
    public class DetailsModel : PageModel
    {
        private readonly Scripture_Pages.Models.Scripture_PagesContext _context;

        public DetailsModel(Scripture_Pages.Models.Scripture_PagesContext context)
        {
            _context = context;
        }

        public Scripture Scripture { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Scripture = await _context.Scripture.FirstOrDefaultAsync(m => m.id == id);

            if (Scripture == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
