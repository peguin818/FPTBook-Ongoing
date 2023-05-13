using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FPTBook.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;
        public EFStoreRepository(StoreDbContext ctx) => context = ctx;
        public IQueryable<Book> Books => context.Books;
        public void Create(Book b)
        {
            context.Add(b);
            context.SaveChanges();
        }
        public void Delete(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
        public void Save(Book b)
        {
            context.SaveChanges();
        }
    }
}