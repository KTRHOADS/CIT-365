using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace My_Scripture_Journal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new My_Scripture_JournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<My_Scripture_JournalContext>>()))
            {
                // Look for any movies.
               //  if (context.Entry.Any())
                //{
              //  return;   // DB has been seeded
               // }

                context.Entry.AddRange(
                   /* new Entry
                    {
                        Book = "Nephi",
                        Chapter = 3,
                        Note = "The Lord always provides",
                        Verses = "7",
                        StandardWork = "Book of Mormon"

                    },

                    new Entry {
                        Book = "Nephi",
                        Chapter = 3,
                        Note = "The Lord always provides",
                        Verses = "7",
                        StandardWork = "Book of Mormon",
                        DatePosted = "12/03/2003"
                       
                    } */

             
                  
                );
                context.SaveChanges();
            }
        }
    }
}
