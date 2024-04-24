﻿using Eshop.DTOs;
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
    }
}