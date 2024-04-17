using Eshop.Models.CashRegister;
using Eshop.MockDB;
using Eshop.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Repositories
{
    internal class UserRepository
    {
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
            List<UserAbstract> users = GetAllUsers().OrderBy(user => user.UserId).ToList();
            user.UserId = users.Last().UserId+1;
            Users.Add(user);
            Parser.OverwriteUsersJSON(Users);
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
        
    }
}
