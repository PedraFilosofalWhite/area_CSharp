using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Globalization;



namespace Barbearia
{
    public partial class Cliente : Form
    {


        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public Cliente()
        {
            InitializeComponent();
            DesabilitarCampos();
           
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
        public void limpar()
        {
            Txt_nome.Clear();
            Msk_Telefone.Clear();
        }
        private void Cliente_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            rdbVipNao.Checked = false;
            rdbVipSim.Checked = false;
            rdbVipNao.Checked = false;

            Txt_Descricao.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            rdbVip.Checked = false;

            ltb_Pesquisar.Items.Clear();

            Txt_nome.Focus();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            frmTela_Inicial tela = new frmTela_Inicial();
            tela.Show();
            this.Hide();

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

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Gpb_Pesquisar.Visible = true;


        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        public void btn_voltar2_Click(object sender, EventArgs e)
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
        public int cadastrarCliente()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into Clientes (nomeCli, TelCelCli, vipCli) values (@nomeCli, @TelCelCli, @vipCli);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeCli", MySqlDbType.VarChar, 100).Value = Txt_nome.Text;
            comm.Parameters.Add("@telCelCli", MySqlDbType.VarChar, 10).Value = Msk_Telefone.Text;
            if (rdbVipSim.Checked)
            {
                comm.Parameters.Add("@vipCli", MySqlDbType.Int16).Value = 1;

            }
            if (rdbVipNao.Checked)
            {
                comm.Parameters.Add("@vipCli", MySqlDbType.Int16).Value = 0;
            }

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.Fecharconexao();

            return resp;


        }
        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {

            if (Txt_nome.Text.Equals("") ||
                Msk_Telefone.Text.Equals("     -") ||
                (!rdbVipSim.Checked && !rdbVipNao.Checked))
            {
                MessageBox.Show("Favor preencher todos os campos!!!");
            }
            else
            {
                if (cadastrarCliente() == 1)
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
        public void pesquisarPorNome(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nomeCli from Clientes" +
                "where nomeCli Like '%@Nome%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = descricao;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                ltb_Pesquisar.Items.Add((DR.GetString(0)));
            }

            Conexao.Fecharconexao();
        }
        public void pesquisarProCodigo(int descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select idCli from Clientes" +
                "where codCli = @idCliente;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@idCLiente", MySqlDbType.Int16).Value = descricao;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            try
            {
                ltb_Pesquisar.Items.Add(DR.GetString(0));
            }
            catch (Exception)
            {
                MessageBox.Show("Registro não encontrado");
                Txt_Descricao.Focus();
                Txt_Descricao.Clear();
            }

            Conexao.Fecharconexao();
        }
        public void pesquisarVip(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nomeCli from Clientes" +
                "where nomeCli Like '%@Nome%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = descricao;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                ltb_Pesquisar.Items.Add((DR.GetString(0)));
            }

            Conexao.Fecharconexao();
        }

    }
}

