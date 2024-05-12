namespace Eshop.Forms
{
    partial class UserAdministrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            UserDataGridView = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            RoleColumn = new DataGridViewTextBoxColumn();
            UsernameColumn = new DataGridViewTextBoxColumn();
            EmailColumn = new DataGridViewTextBoxColumn();
            SaveButton = new Button();
            DeleteButton = new Button();
            navbar1 = new CustomComponents.Navbar(components);
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).BeginInit();
            SuspendLayout();
            // 
            // UserDataGridView
            // 
            UserDataGridView.AllowDrop = true;
            UserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, RoleColumn, UsernameColumn, EmailColumn });
            UserDataGridView.Location = new Point(38, 127);
            UserDataGridView.Margin = new Padding(5, 5, 5, 5);
            UserDataGridView.Name = "UserDataGridView";
            UserDataGridView.RowHeadersWidth = 51;
            UserDataGridView.RowTemplate.Height = 29;
            UserDataGridView.Size = new Size(902, 301);
            UserDataGridView.TabIndex = 0;
            // 
            // IdColumn
            // 
            IdColumn.DataPropertyName = "UserId";
            IdColumn.HeaderText = "Id";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "IdColumn";
            IdColumn.Width = 125;
            // 
            // RoleColumn
            // 
            RoleColumn.DataPropertyName = "RoleName";
            RoleColumn.HeaderText = "Role";
            RoleColumn.MinimumWidth = 6;
            RoleColumn.Name = "RoleColumn";
            RoleColumn.Width = 125;
            // 
            // UsernameColumn
            // 
            UsernameColumn.DataPropertyName = "Username";
            UsernameColumn.HeaderText = "Username";
            UsernameColumn.MinimumWidth = 6;
            UsernameColumn.Name = "UsernameColumn";
            UsernameColumn.Width = 125;
            // 
            // EmailColumn
            // 
            EmailColumn.DataPropertyName = "Email";
            EmailColumn.HeaderText = "Email";
            EmailColumn.MinimumWidth = 6;
            EmailColumn.Name = "EmailColumn";
            EmailColumn.Width = 125;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(786, 494);
            SaveButton.Margin = new Padding(5, 5, 5, 5);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(153, 46);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(515, 494);
            DeleteButton.Margin = new Padding(5, 5, 5, 5);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(242, 46);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete Selected";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // navbar1
            // 
            navbar1.ImageScalingSize = new Size(32, 32);
            navbar1.Location = new Point(0, 0);
            navbar1.Name = "navbar1";
            navbar1.Size = new Size(1300, 42);
            navbar1.TabIndex = 3;
            navbar1.Text = "navbar1";
            // 
            // UserAdministrationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(DeleteButton);
            Controls.Add(SaveButton);
            Controls.Add(UserDataGridView);
            Controls.Add(navbar1);
            MainMenuStrip = navbar1;
            Margin = new Padding(5, 5, 5, 5);
            Name = "UserAdministrationForm";
            Text = "UserAdministrationForm1";
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UserDataGridView;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn RoleColumn;
        private DataGridViewTextBoxColumn UsernameColumn;
        private DataGridViewTextBoxColumn EmailColumn;
        private Button SaveButton;
        private Button DeleteButton;
        private CustomComponents.Navbar navbar1;
    }
}