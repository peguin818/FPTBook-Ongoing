using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FPTBook.Models
{
    public class Order
    {
        [BindNever]
        public long OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();
        [Required(ErrorMessage = "Please enter a name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter a phone number")]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter an address")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Please enter a city name")]
        public string? City { get; set; }
        [Required(ErrorMessage = "Please enter a country name")]
        public string? Country { get; set; }
        public bool Wrap { get; set; }
        [BindNever]
        public bool Shipped { get; set; }
    }
}