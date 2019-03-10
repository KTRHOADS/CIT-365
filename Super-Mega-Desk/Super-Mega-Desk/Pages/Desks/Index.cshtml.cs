using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Super_Mega_Desk.Models;
using PagedList;


namespace Super_Mega_Desk.Pages.Desks
{
    public class IndexModel : PageModel
    {
        private readonly Super_Mega_Desk.Models.Super_Mega_DeskContext _context;

        public IndexModel(Super_Mega_Desk.Models.Super_Mega_DeskContext context)
        {
            _context = context;
        }

        public IPagedList<Desk> deskToPageList;
        public List<Desk> Desk { get;set; }
        public string CustomerSort;
        public string DateSort;
        [BindProperty(SupportsGet = true)]
        public String CustomerName { get; set; }
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList Customers { get; set; }
        public int pageNo;
        public int NoOfPages;
        public async Task OnGetAsync(string sortOrder)
        {
            pageNo = 1;
            CustomerSort = String.IsNullOrEmpty(sortOrder) ? "customer" : "";
            DateSort = sortOrder == "date" ? "date_desc" : "date";

            IQueryable<Desk> desks = from d in _context.Desk
                                        select d;

            switch (sortOrder)
            {
                case "customer":
                    desks = desks.OrderBy(d => d.CustomerName);
                    break;
                case "date":
                    desks = desks.OrderBy(d => Convert.ToDateTime(d.Date));
                    break;

                default:
                    desks = desks.OrderBy(d => d.ID);
                    break;
            }

            Desk = await desks.ToListAsync();

            // Use LINQ to get list of genres.
            IQueryable<string> customerQuery = from d in _context.Desk
                                               orderby d.CustomerName
                                           select d.CustomerName;




            if (!string.IsNullOrEmpty(CustomerName))
            {
                desks = desks.Where(x => x.CustomerName == CustomerName);

            }




            Customers = new SelectList(await customerQuery.Distinct().ToListAsync());
            Desk = await desks.ToListAsync();
            deskToPageList  = Desk.ToPagedList(pageNo, 5);
            NoOfPages = deskToPageList.PageCount;
        }
    }
}
