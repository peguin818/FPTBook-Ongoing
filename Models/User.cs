using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using FPTBook.Models;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class User : IdentityUser
    {
        [PersonalData]
        [Required]
        public string? Name { get; set; }
        [PersonalData]
        [Required]
        public string? Address { get; set; }
        [PersonalData]
        [Required]
        public DateTime DOB { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}