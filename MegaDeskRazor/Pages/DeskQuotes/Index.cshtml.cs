using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazor.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaDeskRazor.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskRazor.Models.MegaDeskRazorContext _context;

        public IndexModel(MegaDeskRazor.Models.MegaDeskRazorContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Names { get; set; }
        public string Name { get; set; }
        public string NameSort { get; set; }
        public string DateSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            var searchValue = Request.Query["searchByValue"];
            var nameList = from x in _context.DeskQuote
                        select x;
            if (!string.IsNullOrEmpty(SearchString))
            {
                nameList = nameList.Where(s => s.FirstName.Contains(SearchString) || s.LastName.Contains(SearchString) || $"{s.FirstName} {s.LastName}" == SearchString);
            }

            DeskQuote = await nameList.ToListAsync();

            NameSort = sortOrder == "name_asc" ? "name_desc" : "name_asc";
            DateSort = sortOrder == "date_asc" ? "date_desc" : "date_asc";

            var quotes = from q in _context.DeskQuote
                             select q;

            switch (sortOrder)
            {
                case "name_desc":
                    quotes = quotes.OrderByDescending(s => s.LastName);
                    break;
                case "date_asc":
                    quotes = quotes.OrderBy(s => s.QuoteDate);
                    break;
                case "date_desc":
                    quotes = quotes.OrderByDescending(s => s.QuoteDate);
                    break;
                default:
                    quotes = quotes.OrderBy(s => s.LastName);
                    break;
            }

            DeskQuote = await quotes.AsNoTracking().ToListAsync();
        }
    }
}
