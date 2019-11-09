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

        public SelectList Name { get; set; }

        public string FirstName { get; set; }



        public async Task OnGetAsync()
        {
            var names = from m in _context.DeskQuote
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                names = names.Where(s => s.FirstName.Contains(SearchString));
            }

            DeskQuote = await names.ToListAsync();
        }
    }
}
