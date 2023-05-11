using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FPTBook.Models.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
            = Enumerable.Empty<Book>();
        public PagingInfo PagingInfo { get; set; } = new();
    }
}