using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LDS_Movies.Models
{
    public class LDS_MoviesContext : DbContext
    {
        public LDS_MoviesContext (DbContextOptions<LDS_MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<LDS_Movies.Models.Movie> Movie { get; set; }
    }
}
