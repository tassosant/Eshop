using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.DTOs
{
    internal class UserDTO
    {
         public int UserId { get; set; }
         public int RoleId {get;set;}
         public string RoleName { get; set;}
         public string Username {get;set;}
         public string Password {get;set;}
         public string Email {get;set;}
    }
}
