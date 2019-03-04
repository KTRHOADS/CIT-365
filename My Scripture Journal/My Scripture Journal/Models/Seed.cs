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
                 if (context.Entry.Any())
                {
               return;   // DB has been seeded
                }

                context.Entry.AddRange(
                   new Entry
                   {
                       Book = "Matthew",
                       Chapter = 28,
                       Note = "Missionary work will continue forever.",
                       Verses = "19-20",
                       StandardWork = "New Testament",
                       DatePosted = "07/28/1995",
                       Passage = "Go ye therefore, and teach all nations, baptizing them in the name of the Father, and of the Son, and of the Holy Ghost:Teaching them to observe all things whatsoever I have commanded you: and,lo, I am with you alway, even unto the end of the world.Amen. "

                   },
                    new Entry {
                        Book = "D&C 18",
                        Chapter = 3,
                        Note = "Missionary Work is worth it",
                        Verses = "",
                        StandardWork = "D&C",
                        DatePosted = "12/25/1987",
                        Passage = "And if it so be that you should labor all your days in crying repentance unto this people, and bring, save it be one soul unto me, how great shall be your joy with him in the kingdom of my Father! And now, if your joy will be great with one soul that you have brought unto me into the kingdom of my Father, how great will be your joy if you should bring many souls unto me!"
                    },

                    new Entry {
                        Book = "1 Nephi",
                        Chapter = 3,
                        Note = "The Lord always provides",
                        Verses = "7",
                        StandardWork = "Book of Mormon",
                        DatePosted = "12/03/2003",
                        Passage = " And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."

                    }

                     



                );
                context.SaveChanges();
            }
        }
    }
}
