using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FPTBook.Models.ViewModels
{
    public class ManageUserRoles
    {
        public long? RoleID { get; set; }
        public string? RoleName { get; set; }
        public bool Selected { get; set; }
    }
}