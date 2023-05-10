using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace FPTBook.Models
{
    public class Book
    {
        [Required]
        public long? BookID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public DateTime? PublicationDate { get; set; }
        [Required]
        public long? AuthorID { get; set; }
        [Required]
        public Author? Author { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string? Image { get; set; }
        [Required]
        public long? CategoryID { get; set; }
        [Required]
        public Category? Category { get; set; }
        // public ICollection<OrderDetail>? OrderDetials { get; set; }
    }
}