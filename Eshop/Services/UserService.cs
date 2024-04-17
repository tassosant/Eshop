using Eshop.DTOs;
using Eshop.Mappers;
using Eshop.Models.Account;
using Eshop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Services
{
    
    internal class UserService
    {
        UserRepository UserRepository;
        public UserService()
        {
            UserRepository = new UserRepository();
        }

        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> usersDTO = new List<UserDTO>();
            List<UserAbstract> users = UserRepository.GetAllUsers();
            UserMap userMap = new UserMap();
            foreach (UserAbstract user in users)
            {
                usersDTO.Add(userMap.UserToUserDTO(user));
            }
            return usersDTO;
        }

        public UserAbstract GetUser(int id)
        {
            return UserRepository.GetUserById(id);
        }
    }
}
