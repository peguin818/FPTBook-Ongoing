using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FPTBook.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Name = "The Great Gatsby",
                        Author = "F. Scott Fitzgerald",
                        Description = "The story primarily concerns the young and mysterious millionaire Jay Gatsby and his quixotic passion and obsession with the beautiful former debutante Daisy Buchanan.",
                        Category = "Novel",
                        Price = 180000,
                        PublicationDate = new DateTime(1925, 4, 10),
                        Image = "https://upload.wikimedia.org/wikipedia/commons/7/7a/The_Great_Gatsby_Cover_1925_Retouched.jpg"
                    },
                    new Book
                    {
                        Name = "The Da Vinci Code",
                        Author = "Dan Brown",
                        Description = "The Da Vinci Code is a 2003 mystery thriller novel by Dan Brown. It is Brown's second novel to include the character Robert Langdon: the first was his 2000 novel Angels & Demons.",
                        Category = "Novel",
                        Price = 200000,
                        PublicationDate = new DateTime(2003, 3, 18),
                        Image = "https://upload.wikimedia.org/wikipedia/en/6/6b/DaVinciCode.jpg"
                    },
                    new Book
                    {
                        Name = "The Da Vinci Code2",
                        Author = "Dan Brown",
                        Description = "The Da Vinci Code is a 2003 mystery thriller novel by Dan Brown. It is Brown's second novel to include the character Robert Langdon: the first was his 2000 novel Angels & Demons.",
                        Category = "Novel",
                        Price = 200000,
                        PublicationDate = new DateTime(2003, 3, 18),
                        Image = "https://upload.wikimedia.org/wikipedia/en/6/6b/DaVinciCode.jpg"
                    },
                    new Book
                    {
                        Name = "The Da Vinci Code3",
                        Author = "Dan Brown",
                        Description = "The Da Vinci Code is a 2003 mystery thriller novel by Dan Brown. It is Brown's second novel to include the character Robert Langdon: the first was his 2000 novel Angels & Demons.",
                        Category = "Novel",
                        Price = 200000,
                        PublicationDate = new DateTime(2003, 3, 18),
                        Image = "https://upload.wikimedia.org/wikipedia/en/6/6b/DaVinciCode.jpg"
                    },
                    new Book
                    {
                        Name = "The Da Vinci Code4",
                        Author = "Dan Brown",
                        Description = "The Da Vinci Code is a 2003 mystery thriller novel by Dan Brown. It is Brown's second novel to include the character Robert Langdon: the first was his 2000 novel Angels & Demons.",
                        Category = "Novel",
                        Price = 200000,
                        PublicationDate = new DateTime(2003, 3, 18),
                        Image = "https://upload.wikimedia.org/wikipedia/en/6/6b/DaVinciCode.jpg"
                    },
                    new Book
                    {
                        Name = "The Da Vinci Code5",
                        Author = "Dan Brown",
                        Description = "The Da Vinci Code is a 2003 mystery thriller novel by Dan Brown. It is Brown's second novel to include the character Robert Langdon: the first was his 2000 novel Angels & Demons.",
                        Category = "Novel",
                        Price = 200000,
                        PublicationDate = new DateTime(2003, 3, 18),
                        Image = "https://upload.wikimedia.org/wikipedia/en/6/6b/DaVinciCode.jpg"
                    },
                    new Book
                    {
                        Name = "The Alchemist",
                        Author = "Paulo Coelho",
                        Description = "The Alchemist is a novel by Brazilian author Paulo Coelho that was first published in 1988. Originally written in Portuguese, it became a widely translated international bestseller.",
                        Category = "Novel",
                        Price = 150000,
                        PublicationDate = new DateTime(1988, 1, 1),
                        Image = "https://upload.wikimedia.org/wikipedia/en/c/c4/TheAlchemist.jpg"
                    },
                    new Book
                    {
                        Name = "The Wolf of Wall Street",
                        Author = "Jordan Belfort",
                        Description = "The Wolf of Wall Street is a memoir by former stockbroker and trader Jordan Belfort, first published in September 2007 by Bantam Books, then adapted into a 2013 film of the same name.",
                        Category = "Memoir",
                        Price = 250000,
                        PublicationDate = new DateTime(2007, 9, 25),
                        Image = "https://upload.wikimedia.org/wikipedia/en/8/85/The_wolf_of_wall_street_-_bookcover.jpg"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}