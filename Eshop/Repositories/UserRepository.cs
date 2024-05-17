using Eshop.Models.CashRegister;
using Eshop.MockDB;
using Eshop.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace Eshop.Repositories
{
    internal class UserRepository
    {
        public int guestId = 100;
        List<UserAbstract> Users { get; set; }
        JSONParser Parser { get; set; }

        public UserRepository()
        {
            Parser = new JSONParser();
            Users = GetAllUsers();
        }

        public List<UserAbstract> GetAllUsers()
        {
            Parser.ParseUsersFileToUsers();
            Users = Parser.Users;
            return Parser.Users;
        }

        public UserAbstract GetUserById(int id)
        {
            try
            {
                return Users.First(user => user.UserId == id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public UserAbstract GetUserByUserName(string userName)
        {
            try
            {
                return Users.First(user=>user.Username == userName);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void DeleteUserById(int id)
        {
            int index = Users.FindIndex(user => user.UserId == id);
            if(index == -1)
            {
                return;
            }
            Users.RemoveAt(index);
            Parser.OverwriteUsersJSON(Users);
        }

        public void UpdateUser(UserAbstract user)
        {
            int id = user.UserId;
            int index = Users.FindIndex(user => user.UserId == id);
            Users[index] = user;
            Parser.OverwriteUsersJSON(Users);
        }

        public void AddUser(UserAbstract user)
        {
            if (user.UserId != guestId)
            {
                user.UserId = GetLastUserId();
            }
            Users.Add(user);
            Parser.OverwriteUsersJSON(Users);
        }

        private int GetLastUserId()
        {
            List<UserAbstract> users = GetAllUsers().OrderBy(user => user.UserId).ToList();
            int id = users.Last().UserId + 1;
            if (id == guestId)
            {
                return guestId+1;
            }
            if(id == guestId+1)
            {
                return users[users.Count - 2].UserId;
            }
            return id;
        }


        public void Save(UserAbstract user)
        {
            if(GetUserById(user.UserId) != null)
            {
                UpdateUser(user);
            }
            else
            {
                AddUser(user);
            }
        }

        public void SaveAll(List<UserAbstract> users)
        {
            Users = users;
            Parser.OverwriteUsersJSON(users);
        }
        
    }
}
