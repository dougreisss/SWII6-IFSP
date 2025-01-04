using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilsApp.Services;
using UtilsApp.DTOs;

namespace DesktopApp
{
    public partial class frmAddUser : Form
    {
        const string API_URL = "https://localhost:44318/api/User";
        private readonly UserServices userService;
        private readonly frmUser frmUser;

        public frmAddUser(frmUser frmUser)
        {
            InitializeComponent();
            this.frmUser = frmUser;
            this.userService = new UserServices(API_URL, new HttpClient());
        }

        private async void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (!formIsValid())
            {
                return;
            }

            var user = getEntity(txtUserName.Text, txtPassword.Text);

            if (!await userService.Create(user))
            {
                MessageBox.Show("Ocorreu um erro inesperado ao tentar criar o usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
            MessageBox.Show("Usuário criado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmUser.Focus();
        }

        private bool formIsValid()
        {
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Por favor, Digite o nome do usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Por favor, Digite a senha do usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Por favor, Digite a confirmação de senha do usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("A senha e a confirmação da senha devem ser iguais", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; 
        }

        private UserDTO getEntity(string username, string password)
        {
            UserDTO userDTO = new UserDTO
            {
                Id = 0,
                Name = username,
                Password = password,
                Status = true
            };

            return userDTO;
        }
    }
}
