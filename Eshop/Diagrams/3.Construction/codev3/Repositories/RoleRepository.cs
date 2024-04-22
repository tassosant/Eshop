using Eshop.MockDB;
using Eshop.Models.Account;
using Eshop.Models.CashRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Repositories
{
    internal class RoleRepository
    {
        List<Role> Roles { get; set; }
        JSONParser Parser { get; set; }

        public RoleRepository()
        {
            Parser = new JSONParser();
            Roles = GetAllRoles();
        }

        public List<Role> GetAllRoles()
        {
            Parser.ParseRolesFileToRoles();
            return Parser.Roles;
        }

        public Role GetRoleById(int id)
        {
            try
            {
                return Roles.First(role => role.RoleId == id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void DeleteRoleById(int id)
        {
            int index = Roles.FindIndex(role => role.RoleId == id);
            Roles.RemoveAt(index);
            Parser.OverwriteRolesJSON(Roles);
        }

        public void UpdateRole(Role role)
        {
            int id = role.RoleId;
            int index = Roles.FindIndex(role => role.RoleId == id);
            Roles[index] = role;
            Parser.OverwriteRolesJSON(Roles);
        }

        public void AddRole(Role role)
        {
            List<Role> roles = GetAllRoles().OrderBy(role => role.RoleId).ToList();
            role.RoleId = roles.Last().RoleId+1;
            Roles.Add(role);
            Parser.OverwriteRolesJSON(Roles);
        }

        public void Save(Role role)
        {
            if(GetRoleById(role.RoleId) != null)
            {
                UpdateRole(role);
            }
            else
            {
                AddRole(role);
            }
        }
       
    }
}
