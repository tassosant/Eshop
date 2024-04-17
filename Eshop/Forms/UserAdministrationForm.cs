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
        List<UserDTO> UserDTOs;
        public UserAdministrationForm()
        {
            InitializeComponent();
            InitProperties();
            FillDatagrid();
        }

        private void InitProperties()
        {
            UserService = new UserService();
            UserDTOs = UserService.GetAllUsers();
        }

        private void FillDatagrid()
        {
            foreach(UserDTO userDTO in UserDTOs)
            {
                DataGridViewRow row = (DataGridViewRow)this.UserDataGridView.Rows[0].Clone();
                ParseUserDTOToRow(row, userDTO);
                this.UserDataGridView.Rows.Add(row);
            }
        }
        private void ParseUserDTOToRow(DataGridViewRow row, UserDTO userDTO)
        {
            row.Cells["Id"].Value = userDTO.UserId;
            row.Cells["Role"].Value = userDTO.RoleName;
            row.Cells["Username"].Value = userDTO.Username;
            row.Cells["Email"].Value = userDTO.Email;
        }
    }
}
