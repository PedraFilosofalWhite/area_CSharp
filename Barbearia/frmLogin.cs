namespace Barbearia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       private void avan�ar_tela_inicial()
        {
            frmTela_Inicial tela_Inicial = new frmTela_Inicial();
            tela_Inicial.Show();
            this.Hide();
        }
        private void Login_Load(object sender, EventArgs e)
        {

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
            string usuario, senha;
            usuario = Tb_Usuario.Text;
            senha = Tb_Senha.Text;

            //Valida��o dos campos de usuario e sena 
            if (string.IsNullOrWhiteSpace((usuario)))
            {
                MessageBox.Show("Digite o Usu�rio no campo vazio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace((senha)))
            {
                MessageBox.Show("Digite a Senha no campo vazio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }

            // credenciais  validar o acesso
            if (usuario == "paulogoiaba" && senha == "123456")
            {
                avan�ar_tela_inicial();
            }
            else
            {
                MessageBox.Show("Senha ou Usu�rio inv�lido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
