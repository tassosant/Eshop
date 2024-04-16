using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Models.Account
{
    internal abstract class UserAbstract
    {
        public int UserId { get; set; }
        public int ProfileId { get; set; }
        public int RoleId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }

        





    }
}
