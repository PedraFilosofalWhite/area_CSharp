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
            Btn_Cadastrar.Enabled = false;
            Btn_Limpar.Enabled = false;
            Btn_Alterar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Gpb_Cadastrar.Enabled = false;
            Gpb_Pesquisar.Visible = false;
            btn_voltar2.Visible = false;







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
            Msk_Telefone.Clear();
            txtLogin.Clear();
            Msk_Telefone.Clear();
            mskAluguel.Clear();
            txtSenha.Clear();
            mskCPF.Clear();
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

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Btn_Cadastrar.Visible = true;
            Btn_Cadastrar.Enabled = false;
            Gpb_Pesquisar.Visible = true;

            if (Rb_Codigo.Checked)
            {
                pesquisarPorCodigo((Txt_Descricao.Text));
            }
            else if (Rb_Nome.Checked)
            {
                pesquisarPorNome(Txt_Descricao.Text);
            }


        }

        public void pesquisarPorCodigo(string descricao)
        {
            if (!int.TryParse(descricao, out int idFunc))
            {
                MessageBox.Show("Código inválido. Informe um número válido.");
                Txt_Descricao.Clear();
                Txt_Descricao.Focus();
                return;
            }

            ltb_Pesquisar.Items.Clear();

            MySqlConnection conn = Conexao.obterConexao();
            MySqlCommand comm = new MySqlCommand();
            {
                comm.Connection = conn;
                comm.CommandText = "SELECT nomeFunc FROM Funcionarios WHERE idFunc = @idFunc and ativoFunc = true;";
                comm.Parameters.Add("@idFunc", MySqlDbType.Int32).Value = idFunc;

                using (MySqlDataReader DR = comm.ExecuteReader())
                {
                    if (DR.Read())
                    {
                        ltb_Pesquisar.Items.Add(DR.GetString(0));
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado");
                        Txt_Descricao.Clear();
                        Txt_Descricao.Focus();
                    }
                }
            }
        }

        public void pesquisarPorNome(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Por favor, informe um nome para pesquisa");
                return;
            }

            ltb_Pesquisar.Items.Clear();

            MySqlConnection conn = Conexao.obterConexao();
            MySqlCommand comm = new MySqlCommand();
            {
                comm.Connection = conn;
                comm.CommandText = "SELECT nomeFunc FROM Funcionarios WHERE nomeFunc LIKE CONCAT('%', @nome, '%') and ativoFunc = true";
                comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = descricao;

                using (MySqlDataReader DR = comm.ExecuteReader())
                {
                    while (DR.Read())
                    {
                        ltb_Pesquisar.Items.Add(DR.GetString(0));
                    }
                }
            }
        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            if (Txt_nome.Text.Equals("") ||
                !Msk_Telefone.MaskFull ||
                !mskAluguel.MaskFull||
                !mskCPF.MaskFull ||
                txtLogin.Text.Equals("") ||
                txtSenha.Text.Equals("") )
            {
                MessageBox.Show("Favor preencher todos os campos!!!");
            }
            else
            {
                if (AlterarFuncionarios() == 1)
                {
                    MessageBox.Show("Cliente atualizado com sucesso!");
                    limpar();
                    DesabilitarCampos();
                    Btn_Novo.Enabled = true;
                    Btn_Pesquisar.Enabled = true;
                    Gpb_Pesquisar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar.");
                }

            }
        }

        public int AlterarFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update Funcionarios " +
                "set nomeFunc = @nomeFunc," +
                "loginFunc = @loginFunc," +
                "senhaFunc = @senhaFunc," +
                "cpfFunc = @cpfFunc," +
                "aluguel_cadeira = @aluguel_cadeira," +
                "telCelFunc = @telCelFunc " +
                "where idFunc = @idFunc;";

            comm.Parameters.Clear();
            comm.Parameters.Add("idFunc", MySqlDbType.Int32).Value = Convert.ToInt32(Txt_Codigo.Text);
            comm.Parameters.Add("@nomeFunc", MySqlDbType.VarChar, 100).Value = Txt_nome.Text;
            comm.Parameters.Add("@telCelFunc", MySqlDbType.VarChar, 10).Value = Msk_Telefone.Text;
            comm.Parameters.Add("LoginFunc", MySqlDbType.VarChar, 50).Value = txtLogin.Text;
            comm.Parameters.Add("senhaFunc", MySqlDbType.VarChar, 10).Value = txtSenha.Text;
            comm.Parameters.Add("cpfFunc", MySqlDbType.VarChar, 14).Value = mskCPF.Text;
            comm.Parameters.Add("aluguel_cadeira", MySqlDbType.Decimal).Value = decimal.Parse(mskAluguel.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"));
            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();
            Conexao.Fecharconexao();
            return resp;
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir?",
                "Mensagem do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                excluirFuncionarios(Convert.ToInt32(Txt_Codigo.Text));
                MessageBox.Show("Funcionário excluido com sucesso!");
                limpar();
                DesabilitarCampos();
                Btn_Novo.Enabled = true;
                Btn_Pesquisar.Enabled = true;
                Gpb_Pesquisar.Visible = true;
            }
            else
            {
                MessageBox.Show("Operação Abortada",
                "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }
        }
        public int excluirFuncionarios(int idFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update Funcionarios " +
                "set ativoFunc = FALSE " +
                "where idFunc = @idFunc;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@idFunc", MySqlDbType.Int32).Value = idFunc;

            int resp = comm.ExecuteNonQuery();

            Conexao.Fecharconexao();

            return resp;
        }

        private void ltb_Pesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ltb_Pesquisar.SelectedItem != null)
            {
                string nomeFunc= ltb_Pesquisar.SelectedItem.ToString();
                CarregarDadosFuncionario(nomeFunc);
                HabilitarCampos();
                Btn_Alterar.Enabled = true;
                Btn_Cadastrar.Enabled = false;
                Btn_Pesquisar.Enabled = false;
            }
        }

        public void CarregarDadosFuncionario(string nomeFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT idFunc, nomeFunc, loginFunc, telCelFunc, aluguel_cadeira, cpfFunc, senhaFunc FROM funcionarios WHERE nomeFunc = @nome;";
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nomeFunc;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR = comm.ExecuteReader();

            if (DR.Read())
            {
                Txt_Codigo.Text = DR["idFunc"].ToString();
                Txt_nome.Text = DR["nomeFunc"].ToString();
                Msk_Telefone.Text = DR["TelCelFunc"].ToString();
                mskAluguel.Text = DR["aluguel_cadeira"].ToString();
                mskCPF.Text = DR["cpfFunc"].ToString();
                txtSenha.Text = DR["senhaFunc"].ToString();
                txtLogin.Text = DR["loginFunc"].ToString();
                
            }

            Conexao.Fecharconexao();
        }
    }
}

