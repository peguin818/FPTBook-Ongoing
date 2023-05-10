using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class Category
    {
        [Required]
        public long? CategoryID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Status { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}