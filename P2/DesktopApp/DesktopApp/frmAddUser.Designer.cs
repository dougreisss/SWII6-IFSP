namespace DesktopApp
{
    partial class frmAddUser
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
            label1 = new Label();
            txtUserName = new TextBox();
            btnCreateUser = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtConfirmPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite o nome do usuário: ";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(186, 15);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(263, 23);
            txtUserName.TabIndex = 1;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(23, 139);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(426, 23);
            btnCreateUser.TabIndex = 2;
            btnCreateUser.Text = "Criar Usuário";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 55);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 3;
            label2.Text = "Digite a senha do usuário: ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(186, 52);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(263, 23);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 92);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 5;
            label3.Text = "Confirmar senha do usuário:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(186, 89);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(263, 23);
            txtConfirmPassword.TabIndex = 6;
            // 
            // frmAddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 174);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(btnCreateUser);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private Button btnCreateUser;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtConfirmPassword;
    }
}