using Eshop.DTOs;
using Eshop.Models.Account;
using Eshop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Mappers
{
    internal class UserMap
    {
    //     "UserId": 2,
    //"RoleId": 1,
    //"Username": "a3",
    //"Password": "1",
    //"Email": "t"

        public UserMap() { }

        public UserDTO UserToUserDTO(UserAbstract user)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.UserId = user.UserId; 
            userDTO.Username = user.Username;
            userDTO.Password = user.Password;
            userDTO.Email = user.Email;
            Role role = GetRole(user.RoleId);
            userDTO.RoleName = role.RoleDescription;
            userDTO.RoleId = role.RoleId;
            return userDTO;
        }

        public UserAbstract UserDTOToUser(UserDTO userDTO)
        {
            UserAbstract user = new UserAbstract();
            user.Username = userDTO.Username;
            user.Password = userDTO.Password;
            user.Email = userDTO.Email;
            user.RoleId = userDTO.RoleId;
            return user;
        }

        private Role GetRole(int id)
        {
            RoleRepository roleRepository = new RoleRepository();
            return roleRepository.GetRoleById(id);
            
        }
    }
}
