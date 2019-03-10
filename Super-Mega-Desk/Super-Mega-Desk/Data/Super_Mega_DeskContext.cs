using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Super_Mega_Desk.Models
{
    public class Super_Mega_DeskContext : DbContext
    {
        public Super_Mega_DeskContext (DbContextOptions<Super_Mega_DeskContext> options)
            : base(options)
        {
        }

        public DbSet<Super_Mega_Desk.Models.Desk> Desk { get; set; }
    }
}
