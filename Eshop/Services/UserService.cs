using Eshop.DTOs;
using Eshop.Mappers;
using Eshop.Models.Account;
using Eshop.Models.CashRegister;
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
        RoleRepository RoleRepository;
        CartRepository CartRepository;
        public UserService()
        {
            UserRepository = new UserRepository();
            RoleRepository = new RoleRepository();
            CartRepository = new CartRepository();
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

        public void SaveUserDTOs(List<UserDTO> usersDTO)
        {
            UserMap userMap = new UserMap();
            
            foreach (UserDTO userDTO in usersDTO)
            {
                UserAbstract user = userMap.UserDTOToUser(userDTO);
                UserRepository.Save(user);
            }
        }

        public void SaveAllUsers(List<UserDTO> usersDTO)
        {
            UserMap userMap = new UserMap();
            List<UserAbstract> users = new List<UserAbstract>();
            foreach (UserDTO userDTO in usersDTO)
            {
                UserAbstract user = userMap.UserDTOToUser(userDTO);
                users.Add(user);
            }
            UserRepository.SaveAll(users);
        }

        public Boolean IsAdmin(int userID)
        {
            UserAbstract user = UserRepository.GetUserById(userID);
            int roleId = user.RoleId;
            Role role = RoleRepository.GetRoleById(roleId);
            if(role != null)
            {
                if(role.RoleDescription.Equals("admin") || role.RoleDescription.Equals("Admin"))
                {
                    return true;
                }
            }
            return false;
        }

        public void CreateGuest()
        {
            UserAbstract guest = new UserAbstract();
            guest.RoleId = 3;
            guest.UserId = UserRepository.guestId;
            Cart cart = new Cart();
            cart.UserId = guest.UserId;
            cart.CartId = guest.UserId;
            CartRepository.Save(cart);
            UserRepository.Save(guest);

        }

        public void CreateUser()
        {
            UserAbstract user = new UserAbstract();
            user.RoleId = 1;
            UserRepository.Save(user);


        }

        public int GetGuestId()
        {
            return UserRepository.GetUserById(100).UserId;
        }


        
    }
}
