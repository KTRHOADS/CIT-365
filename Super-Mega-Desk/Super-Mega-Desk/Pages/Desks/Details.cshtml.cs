﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Super_Mega_Desk.Models;

namespace Super_Mega_Desk.Pages.Desks
{
    public class DetailsModel : PageModel
    {
        private readonly Super_Mega_Desk.Models.Super_Mega_DeskContext _context;

        public DetailsModel(Super_Mega_Desk.Models.Super_Mega_DeskContext context)
        {
            _context = context;
        }

        public Desk Desk { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Desk = await _context.Desk.FirstOrDefaultAsync(m => m.ID == id);

            if (Desk == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
