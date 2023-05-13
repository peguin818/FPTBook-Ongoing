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
        public long BookID { get; set; }
        [Required(ErrorMessage = "Please enter a book name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter aN author name")]
        public string? Author { get; set; }
        [Required(ErrorMessage = "Please enter a publication date")]
        public DateTime PublicationDate { get; set; }
        [Required(ErrorMessage = "Please enter a description")]
        public string? Description { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please enter a category")]
        public string? Category { get; set; }
        [Required]
        [DataType(DataType.ImageUrl, ErrorMessage = "Please enter a valid URL")]
        public string? Image { get; set; }
    }
}