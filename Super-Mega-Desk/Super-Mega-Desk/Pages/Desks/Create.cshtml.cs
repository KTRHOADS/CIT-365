using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Super_Mega_Desk.Models;

namespace Super_Mega_Desk.Pages.Desks
{
    public class CreateModel : PageModel
    {
        private readonly Super_Mega_Desk.Models.Super_Mega_DeskContext _context;

        public CreateModel(Super_Mega_Desk.Models.Super_Mega_DeskContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();

        }

        [BindProperty]
        public Desk Desk { get; set; }
        

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Desk.Date = DateTime.Now.ToString("MM/dd/yyyy");
            Desk.DrawerCost = Desk.DrawerNumber * 50;
            getArea();
            getMaterialCost();
            getExtraSurfaceAreaCost();
            getFinalCost();

            _context.Desk.Add(Desk);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

       
    

    private void getFinalCost()
    {
        Desk.FinalCost = Desk.MaterialCost + Desk.BasePrice + Desk.DrawerCost + Desk.ExtraSurfaceAreaCost + Desk.ShippingCost;
    }

    public void getDrawerCost()
    {
        Desk.DrawerCost = Desk.DrawerNumber * 50;
    }
    public void getArea()
    {
            Desk.Area = Desk.Width * Desk.Depth;


    }

    public void getMaterialCost()
    {
        switch (Desk.ShippingDays)
        {
            case 3:
                if (Desk.Area < 1000)
                {
                    Desk.ShippingCost = 60;
                }

                if (Desk.Area < 2000 && Desk.Area > 1000)
                {
                    Desk.ShippingCost = 70;
                }

                if (Desk.Area > 2000)
                {
                    Desk.ShippingCost = 80;
                }
                break;

            case 5:
                if (Desk.Area < 1000)
                {
                    Desk.ShippingCost = 40;
                }

                if (Desk.Area < 2000 && Desk.Area > 1000)
                {
                    Desk.ShippingCost = 50;
                }

                if (Desk.Area > 2000)
                {
                    Desk.ShippingCost = 60;
                }
                break;

            case 7:
                if (Desk.Area < 1000)
                {
                    Desk.ShippingCost = 30;
                }

                if (Desk.Area < 2000 && Desk.Area > 1000)
                {
                    Desk.ShippingCost = 35;
                }

                if (Desk.Area > 2000)
                {
                    Desk.ShippingCost = 40;
                }
                break;
        }
    }
    public void getExtraSurfaceAreaCost()
    {
        if (Desk.Area > 1000)
        {
                Desk.ExtraSurfaceAreaCost = Desk.Area - 1000;
        }
    }
}
    }
