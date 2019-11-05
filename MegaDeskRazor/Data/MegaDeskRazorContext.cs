using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MegaDeskRazor.Models
{
    public class MegaDeskRazorContext : DbContext
    {
        public MegaDeskRazorContext (DbContextOptions<MegaDeskRazorContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDeskRazor.Models.DeskQuote> DeskQuote { get; set; }
    }
}
