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
            UserDataGridView = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            RoleColumn = new DataGridViewTextBoxColumn();
            UsernameColumn = new DataGridViewTextBoxColumn();
            EmailColumn = new DataGridViewTextBoxColumn();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).BeginInit();
            SuspendLayout();
            // 
            // UserDataGridView
            // 
            UserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, RoleColumn, UsernameColumn, EmailColumn });
            UserDataGridView.Location = new Point(23, 12);
            UserDataGridView.Name = "UserDataGridView";
            UserDataGridView.RowHeadersWidth = 51;
            UserDataGridView.RowTemplate.Height = 29;
            UserDataGridView.Size = new Size(555, 188);
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
            SaveButton.Location = new Point(483, 241);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += this.SaveButton_Click;
            // 
            // UserAdministrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveButton);
            Controls.Add(UserDataGridView);
            Name = "UserAdministrationForm";
            Text = "UserAdministrationForm1";
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView UserDataGridView;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn RoleColumn;
        private DataGridViewTextBoxColumn UsernameColumn;
        private DataGridViewTextBoxColumn EmailColumn;
        private Button SaveButton;
    }
}