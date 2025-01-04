using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilsApp.DTOs;
using UtilsApp.Services;

namespace DesktopApp
{
    public partial class frmDetailsUser : Form
    {
        const string API_URL = "https://localhost:44318/api/User";
        private readonly UserServices userService;
        private readonly UserDTO userDTO;
        private readonly frmUser frmUser;

        public frmDetailsUser(frmUser frmUser, UserDTO user)
        {
            InitializeComponent();
            this.userDTO = user;
            this.frmUser = frmUser;
            this.userService = new UserServices(API_URL, new HttpClient());
            txtUserName.Text = this.userDTO.Name;
            txtPassword.Text = this.userDTO.Password;
            cbxStauts.Checked = this.userDTO.Status;
        }

        private async void btnEditUser_Click(object sender, EventArgs e)
        {
            if (!formValid()) 
            {
                return;
            }

            this.userDTO.Name = txtUserName.Text;
            this.userDTO.Password = txtPassword.Text;
            this.userDTO.Status = cbxStauts.Checked;

            if (!await userService.Update(this.userDTO))
            {
                MessageBox.Show("Ocorreu um erro inesperado ao atualizar o usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
            MessageBox.Show("Usuário atualizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmUser.Focus();
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (!await userService.Delete(this.userDTO.Id))
            {
                MessageBox.Show("Ocorreu um erro inesperado ao deletar o usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
            MessageBox.Show("Usuário deletado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmUser.Focus();
        }

        private bool formValid()
        {
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Por favor, digite o nome do usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Por favor, digite a senha do usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }

            return true;
        }
    }
}
