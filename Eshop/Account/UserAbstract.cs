using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Account
{
    internal abstract class UserAbstract
    {
        private int _userId;
        private int _profileId;
        private string _username;
        private string _password;
        public int UserId { get { return _userId; } set { _userId = value; } }
        public int ProfileId { get { return _profileId; } set { _profileId = value; } }
        public string UserName { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } } 
        
        public void OpenCart()
        {

        }

        public void Logout()
        {

        }


        


    }
}
