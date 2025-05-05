using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Barbearia
{
    public partial class Login : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public Login()
        {
            InitializeComponent();
            
        }
       private void avançar_tela_inicial()
        {
            frmTela_Inicial tela_Inicial = new frmTela_Inicial();
            tela_Inicial.Show();
            this.Hide();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void Bt_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bt_Entrar_Click(object sender, EventArgs e)
        {
            string usuario;
            string senha;
            usuario = Tb_Usuario.Text;
            senha = Tb_Senha.Text;

            //Validação dos campos de usuario e sena 
            if (string.IsNullOrWhiteSpace((usuario)))
            {
                MessageBox.Show("Digite o Usuário no campo vazio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace((senha)))
            {
                MessageBox.Show("Digite a Senha no campo vazio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }

            // credenciais  validar o acesso
            if (BuscarFunc(usuario, senha))
            {
                avançar_tela_inicial();
            }
            else
            {
                MessageBox.Show("Senha ou Usuário inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public Boolean BuscarFunc (string usuario, string senha)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from Funcionarios where loginFunc = @nomeFunc and senhaFunc = @senhaFunc;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeFunc", MySqlDbType.VarChar, 50).Value = usuario;
            comm.Parameters.Add("@senhaFunc", MySqlDbType.VarChar, 12).Value = senha;

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            bool resp = DR.HasRows;

            Conexao.Fecharconexao();

            return resp;
        }
    }
}
