using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LDS_Movies.Models
{
    public static class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LDS_MoviesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LDS_MoviesContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                   

                    new Movie
                    {
                        Title = "The RM ",
                        ReleaseDate = DateTime.Parse("2007-3-13"),
                        Rating = "PG",
                        Genre = "Comedy",
                        Price = 1.99M
                    },

                    new Movie
                    {
                        Title = "Saints And Soldiers",
                        ReleaseDate = DateTime.Parse("2006-2-23"),
                        Rating = "PG-13",
                        Genre = "Drama",
                        Price = 2.99M
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2005-4-15"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 2.99M
                    },
                     new Movie
                     {
                         Title = "The Singles Ward",
                         ReleaseDate = DateTime.Parse("2002-2-12"),
                         Rating = "PG",
                         Genre = "Romantic Comedy",
                         Price = 1.99M
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
