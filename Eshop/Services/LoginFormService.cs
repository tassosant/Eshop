using Eshop.Models.Account;
using Eshop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Services
{
    internal class LoginFormService
    {
        UserRepository userRepository { get; set; }
        public LoginFormService() { 
            userRepository = new UserRepository();
        }

        public UserAbstract GetUser(string username)
        {
            UserAbstract user = null;
            user = this.userRepository.GetUserByUserName(username);
                
            if(user!= null)
            {
                return user;
            }
            return null;
        }

        

    }
}
