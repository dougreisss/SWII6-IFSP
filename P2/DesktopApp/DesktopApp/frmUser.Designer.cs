using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            components = new System.ComponentModel.Container();
            btnBuscarUsuario = new Button();
            label1 = new Label();
            txtBuscarUsuario = new TextBox();
            dgvUser = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            adicionarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            tsmiGerenciarUsuario = new ToolStripMenuItem();
            tstmiAdicionarUsuario = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.Location = new Point(526, 40);
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
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 2;
            label1.Text = "Digite o nome do usuário: ";
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Location = new Point(165, 40);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(355, 23);
            txtBuscarUsuario.TabIndex = 3;
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(12, 80);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.Size = new Size(743, 150);
            dgvUser.TabIndex = 4;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { adicionarUsuárioToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(169, 26);
            // 
            // adicionarUsuárioToolStripMenuItem
            // 
            adicionarUsuárioToolStripMenuItem.MergeIndex = 1;
            adicionarUsuárioToolStripMenuItem.Name = "adicionarUsuárioToolStripMenuItem";
            adicionarUsuárioToolStripMenuItem.Size = new Size(168, 22);
            adicionarUsuárioToolStripMenuItem.Text = "Adicionar Usuário";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiGerenciarUsuario });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(766, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiGerenciarUsuario
            // 
            tsmiGerenciarUsuario.DropDownItems.AddRange(new ToolStripItem[] { tstmiAdicionarUsuario });
            tsmiGerenciarUsuario.Name = "tsmiGerenciarUsuario";
            tsmiGerenciarUsuario.Size = new Size(111, 20);
            tsmiGerenciarUsuario.Text = "Gerenciar usuário";
            // 
            // tstmiAdicionarUsuario
            // 
            tstmiAdicionarUsuario.Name = "tstmiAdicionarUsuario";
            tstmiAdicionarUsuario.Size = new Size(180, 22);
            tstmiAdicionarUsuario.Text = "Adicionar usuário";
            tstmiAdicionarUsuario.Click += tstmiAdicionarUsuario_Click;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 247);
            Controls.Add(menuStrip1);
            Controls.Add(dgvUser);
            Controls.Add(txtBuscarUsuario);
            Controls.Add(label1);
            Controls.Add(btnBuscarUsuario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciador de Usuários";
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBuscarUsuario;
        private Label label1;
        private TextBox txtBuscarUsuario;
        private DataGridView dgvUser;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem adicionarUsuárioToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiGerenciarUsuario;
        private ToolStripMenuItem tstmiAdicionarUsuario;
    }
}
