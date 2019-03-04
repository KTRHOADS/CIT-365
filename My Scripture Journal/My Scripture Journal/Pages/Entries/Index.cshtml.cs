using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using My_Scripture_Journal.Models;
using PagedList;





namespace My_Scripture_Journal.Pages.Entries
{

    public class MultiSelectList : PageModel
    {
      
        private readonly My_Scripture_JournalContext _context;

        public MultiSelectList(My_Scripture_JournalContext context)
        {
            _context = context;
        }

        public IList<Entry> Entry { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public string BookSearchString { get; set; }
        public SelectList SortList { get; private set; }

        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string EntryBook { get; set; }
        private string sortOrder = "default";
        public SelectListItem bookListItem = new SelectListItem();
        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public string SortOrder { get => sortOrder; set => sortOrder = value; }



        public async Task OnGetAsync(string sortOrder, int? page)
        {


            BookSort = String.IsNullOrEmpty(sortOrder) ? "book" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Entry> entries = from e in _context.Entry
                                        select e;

            switch (sortOrder)
            {
                case "book":
                    entries = entries.OrderBy(e => e.Book);
                    break;
                case "Date":
                    entries = entries.OrderBy(e => Convert.ToDateTime(e.DatePosted));
                    break;

                default:
                    entries = entries.OrderBy(e => e.ID);
                    break;
            }

            Entry = await entries.ToListAsync();

            // Use LINQ to get list of genres.
            IQueryable<string> bookQuery = from e in _context.Entry
                                           orderby e.Book
                                           select e.Book;







            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(s => s.Note.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(EntryBook))
            {
                entries = entries.Where(x => x.Book == EntryBook);

            }

            if (!string.IsNullOrEmpty(BookSearchString))
            {
                entries = entries.Where(s => s.Book.Contains(BookSearchString));
            }


            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            Entry = await entries.ToListAsync();
        }

       
        }
    }


    
