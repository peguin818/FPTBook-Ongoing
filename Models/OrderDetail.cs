using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class OrderDetail
    {
        public long? OrderDetailID { get; set; }
        public long? OrderID { get; set; }
        [Required]
        public Order? Order { get; set; }
        public long? BookID { get; set; }
        [Required]
        public Book? Book { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}