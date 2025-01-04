namespace DesktopApp
{
    partial class frmDetailsUser
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
            txtPassword = new TextBox();
            label2 = new Label();
            btnEditUser = new Button();
            txtUserName = new TextBox();
            label1 = new Label();
            cbxStauts = new CheckBox();
            btnDeleteUser = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(123, 43);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(263, 23);
            txtPassword.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 10;
            label2.Text = "Senha do usuário: ";
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(12, 113);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(374, 23);
            btnEditUser.TabIndex = 9;
            btnEditUser.Text = "Editar Usuário";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(123, 6);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(263, 23);
            txtUserName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome do usuário: ";
            // 
            // cbxStauts
            // 
            cbxStauts.AutoSize = true;
            cbxStauts.Location = new Point(12, 76);
            cbxStauts.Name = "cbxStauts";
            cbxStauts.RightToLeft = RightToLeft.Yes;
            cbxStauts.Size = new Size(120, 19);
            cbxStauts.TabIndex = 13;
            cbxStauts.Text = ":Status do usuário";
            cbxStauts.TextAlign = ContentAlignment.MiddleCenter;
            cbxStauts.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(12, 162);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(374, 23);
            btnDeleteUser.TabIndex = 14;
            btnDeleteUser.Text = "Deletar Usuário";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // frmDetailsUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 197);
            Controls.Add(btnDeleteUser);
            Controls.Add(cbxStauts);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(btnEditUser);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDetailsUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes do usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label label2;
        private Button btnEditUser;
        private TextBox txtUserName;
        private Label label1;
        private CheckBox cbxStauts;
        private Button btnDeleteUser;
    }
}