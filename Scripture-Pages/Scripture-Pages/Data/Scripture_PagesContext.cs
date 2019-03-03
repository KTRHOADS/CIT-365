using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Scripture_Pages.Models
{
    public class Scripture_PagesContext : DbContext
    {
        public Scripture_PagesContext (DbContextOptions<Scripture_PagesContext> options)
            : base(options)
        {
        }

        public DbSet<Scripture_Pages.Models.Scripture> Scripture { get; set; }
    }
}
