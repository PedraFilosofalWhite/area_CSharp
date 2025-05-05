using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Barbearia
{
    public partial class FrmFuncionario : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public FrmFuncionario()
        {
            InitializeComponent();
            Txt_Codigo.Enabled = false;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            frmTela_Inicial telaInicial = new frmTela_Inicial();
            telaInicial.Show();
            this.Hide();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

            Txt_Descricao.Clear();
            ltb_Pesquisar.Items.Clear();
            Txt_nome.Focus();
        }


        public void Btn_Limpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        public void limparCampos()
        {
            Txt_nome.Clear();
            Txt_Codigo.Clear();
            Txt_Descricao.Clear();
            Txt_nome.Text = "";
            Msk_Telefone.Clear();

            Txt_Descricao.Clear();
            Rb_Codigo.Checked = false;
            Rb_Nome.Checked = false;

            ltb_Pesquisar.Items.Clear();

            Txt_nome.Focus();
        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            Btn_Cadastrar.Location = new Point(2, 600);
            Btn_Limpar.Location = new Point(183, 600);
            Btn_Pesquisar.Location = new Point(364, 600);
            Btn_Novo.Visible = false;
            Btn_Alterar.Visible = false;
            Btn_Excluir.Visible = false;
            btn_voltar2.Visible = true;
            Btn_Voltar.Visible = false;
            btn_voltar2.Location = new Point(1083, 600);
        }
        public void HabilitarCampos()
        {
            Gpb_Cadastrar.Enabled = true;
            Btn_Alterar.Enabled = true;
            Btn_Excluir.Enabled = true;
            Btn_Cadastrar.Enabled = true;
            Btn_Limpar.Enabled = true;
            Gpb_Pesquisar.Visible = false;
            Btn_Novo.Enabled = false;

        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (Txt_nome.Text.Equals("") ||
                !Msk_Telefone.MaskCompleted ||
                !mskAluguel.MaskCompleted ||
                !mskCPF.MaskCompleted)
            {
                MessageBox.Show("Favor preencher todos os campos!!!");
            }
            else
            {
                if (cadastrarFunc() == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso!!!");
                    limpar();
                    DesabilitarCampos();

                    DesabilitarCampos();
                    Btn_Novo.Visible = true;
                    Btn_Alterar.Visible = true;
                    Btn_Excluir.Visible = true;
                    btn_voltar2.Visible = false;
                    Btn_Voltar.Visible = true;
                    Btn_Novo.Location = new Point(2, 600);
                    Btn_Cadastrar.Location = new Point(183, 600);
                    Btn_Limpar.Location = new Point(364, 600);
                    Btn_Alterar.Location = new Point(540, 600);
                    Btn_Excluir.Location = new Point(721, 600);
                    Btn_Pesquisar.Location = new Point(902, 600);
                    Btn_Novo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!!!");

                }

            }

        }

        public void DesabilitarCampos()
        {
            Gpb_Cadastrar.Enabled = false;
            Txt_Codigo.Enabled = false;
            Btn_Alterar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Cadastrar.Enabled = false;
            Btn_Limpar.Enabled = false;
        }
        public void limpar()
        {
            Txt_Codigo.Clear();
            Txt_nome.Clear();
            mskCPF.Clear();
            Msk_Telefone.Clear();
            mskAluguel.Clear();
            Rb_Codigo.Checked = false;
            Rb_Nome.Checked = false;
            ltb_Pesquisar.Items.Clear();
            Txt_Descricao.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
        }

        public int cadastrarFunc()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "INSERT INTO Funcionarios (nomeFunc, telCelFunc,loginFunc, senhaFunc, cpfFunc, aluguel_Cadeira)" +
                "VALUES (@nomeFunc, @telCelFunc, @LoginFunc,@senhaFunc, @cpfFunc, @aluguel);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeFunc", MySqlDbType.VarChar, 100).Value = Txt_nome.Text;
            comm.Parameters.Add("@telCelFunc", MySqlDbType.VarChar, 10).Value = Msk_Telefone.Text;
            comm.Parameters.Add("LoginFunc", MySqlDbType.VarChar, 50).Value = txtLogin.Text;
            comm.Parameters.Add("senhaFunc", MySqlDbType.VarChar, 10).Value = txtSenha.Text;
            comm.Parameters.Add("cpfFunc", MySqlDbType.VarChar, 14).Value = mskCPF.Text;
            comm.Parameters.Add("aluguel", MySqlDbType.Decimal).Value = decimal.Parse(mskAluguel.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"));

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.Fecharconexao();

            return resp;


        }

        private void btn_voltar2_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            Btn_Novo.Visible = true;
            Btn_Alterar.Visible = true;
            Btn_Excluir.Visible = true;
            btn_voltar2.Visible = false;
            Btn_Voltar.Visible = true;
            Btn_Novo.Location = new Point(2, 600);
            Btn_Cadastrar.Location = new Point(183, 600);
            Btn_Limpar.Location = new Point(364, 600);
            Btn_Alterar.Location = new Point(540, 600);
            Btn_Excluir.Location = new Point(721, 600);
            Btn_Pesquisar.Location = new Point(902, 600);
            Btn_Novo.Enabled = true;
        }
    }
}

