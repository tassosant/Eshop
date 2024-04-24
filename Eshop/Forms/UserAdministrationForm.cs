using Eshop.DTOs;
using Eshop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshop.Forms
{
    public partial class UserAdministrationForm : Form
    {
        UserService UserService;
        BindingList<UserDTO> UserDTOs;
        public UserAdministrationForm()
        {
            InitializeComponent();
            InitProperties();
            FillDatagrid();
        }

        private void InitProperties()
        {
            UserService = new UserService();
            List<UserDTO> UserDTOsTemp = UserService.GetAllUsers();
            UserDTOs = new BindingList<UserDTO>(UserDTOsTemp);
        }

        private void FillDatagrid()
        {           
            this.UserDataGridView.DataSource = UserDTOs;
            this.UserDataGridView.Columns["RoleId"].Visible = false;
            this.UserDataGridView.AllowUserToDeleteRows = true;
            
            this.UserDataGridView.AllowUserToAddRows = true;
            

        }
        //private void ParseUserDTOToRow(DataGridViewRow row, UserDTO userDTO)
        //{
        //    row.Cells["UserId"].Value = userDTO.UserId;
        //    row.Cells["RoleName"].Value = userDTO.RoleName;
        //    row.Cells["Username"].Value = userDTO.Username;
        //    row.Cells["Email"].Value = userDTO.Email;
        //}

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveUsers();
        }

        private void DeleteButton_Click(Object sender, EventArgs e)
        {
            List<int> indexes = new List<int>();
            foreach (DataGridViewRow row in UserDataGridView.SelectedRows)
            {
                this.UserDataGridView.Rows.Remove(row);
            };
            SaveUsers();
            
        }

        private void SaveUsers()
        {
            BindingList<UserDTO> userDTOs = this.UserDataGridView.DataSource as BindingList<UserDTO>;
            this.UserService.SaveAllUsers(new List<UserDTO>(userDTOs));
        }
    }
}
