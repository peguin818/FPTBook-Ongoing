using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class Order
    {
        public long? OrderID { get; set; }
        public DateTime OrderTime { get; set; }
        public float Total { get; set; }
        public string? UserId { get; set; }
        public User? User { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}