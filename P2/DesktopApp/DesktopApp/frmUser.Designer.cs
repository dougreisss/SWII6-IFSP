namespace DesktopApp
{
    partial class frmUser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBuscarUsuario = new Button();
            label1 = new Label();
            txtBuscarUsuario = new TextBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.Location = new Point(526, 6);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(229, 23);
            btnBuscarUsuario.TabIndex = 1;
            btnBuscarUsuario.Text = "Buscar Usuário";
            btnBuscarUsuario.UseVisualStyleBackColor = true;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 2;
            label1.Text = "Digite o nome do usuário: ";
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Location = new Point(165, 6);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(355, 23);
            txtBuscarUsuario.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Password, Status });
            dataGridView1.Location = new Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(743, 150);
            dataGridView1.TabIndex = 4;
            // 
            // Id
            // 
            Id.FillWeight = 50F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // Name
            // 
            Name.FillWeight = 300F;
            Name.HeaderText = "Nome";
            Name.Name = "Name";
            Name.Width = 300;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.Width = 300;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Width = 50;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 211);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscarUsuario);
            Controls.Add(label1);
            Controls.Add(btnBuscarUsuario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciador de Usuários";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBuscarUsuario;
        private Label label1;
        private TextBox txtBuscarUsuario;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Status;
    }
}
