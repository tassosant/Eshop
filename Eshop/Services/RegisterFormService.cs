using Eshop.Models.Account;
using Eshop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Services
{
    internal class RegisterFormService
    {
        public Boolean IsDuplicateUsername(string username)
        {
            UserRepository userRepository = new UserRepository();
            UserAbstract userAbstract = userRepository.GetUserByUserName(username);
            if (userAbstract != null)
            {
                return true;
            }
            return false;
        }

        public Boolean CreateUser(UserAbstract user)
        {
            UserRepository userRepository = new UserRepository();
            user.RoleId = 0;
            userRepository.Save(user);
            if (userRepository.GetUserByUserName(user.Username) != null)
            {
                return true;
            }
            return false;
        }
    }
}
