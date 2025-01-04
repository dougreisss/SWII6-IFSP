using UtilsApp.DTOs;
using UtilsApp.Services;
using Newtonsoft.Json;

namespace DesktopApp
{
    public partial class frmUser : Form
    {
        const string API_URL = "https://localhost:44318/api/User";
        private readonly UserServices userService;

        public frmUser()
        {
            InitializeComponent();
            userService = new UserServices(API_URL, new HttpClient());
        }

        private async void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string username = txtBuscarUsuario.Text;

            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Por favor, Digite o nome do usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var users = await userService.GetByName(username);

            if (users != null)
            {
                dgvUser.DataSource = users;
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var teste = dgvUser.Rows[e.RowIndex].DataBoundItem;
        }

        private void tstmiAdicionarUsuario_Click(object sender, EventArgs e)
        {
            var frmAddUser = new frmAddUser();

            frmAddUser.Show();
        }
    }
}
