using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FPTBook.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreIdentityDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreIdentityDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Authors.Any())
            {
                context.Authors.AddRange(
                    new Author
                    {
                        Name = "Author1"
                    }
                );
            }
            // if (!context.Books.Any())
            // {
            //     context.Books.AddRange(
            //         new Book
            //         {
            //             Name = "Book1",
            //             Description = "Description1",
            //             AuthorID = 01,
            //             Price = 100,
            //             PublicationDate = DateTime.Parse("2023-01-01"),
            //             CategoryID = 01,
            //             Image = "https://images.squarespace-cdn.com/content/v1/58d26ed2e6f2e10bb3d09660/1572848630688-3W7YP4CF7ZFQUKVDJAC5/30+swatchbook.jpg?format=1000w"
            //         }
            //     );
            // }

            context.SaveChanges();
        }
    }
}