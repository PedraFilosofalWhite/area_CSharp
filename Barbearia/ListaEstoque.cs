using MySql.Data.MySqlClient;
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
namespace Barbearia
{
    public partial class FrmListaEstoque : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public FrmListaEstoque()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FrmEstoque tela = new FrmEstoque();
            tela.Show();
            this.Hide();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        public void LimparCampos()
        {
            TxtNome.Clear();
            cbxCategoria.Items.Clear();
            TxtNome.Focus();
        }

        public void selecaoDePesquisa()
        {


            if (rdbCategoria.Checked)
            {
                TxtNome.Enabled = false;
                cbxCategoria.Enabled = true;
                cbxCategoria.SelectedIndex = -1;
            }
            else if (rdbNome.Checked)
            {
                TxtNome.Enabled = true;
                cbxCategoria.Enabled = false;
                cbxCategoria.SelectedIndex = -1;
            }
        }

        private void FrmListaEstoque_Load(object sender, EventArgs e)
        {
            TxtNome.Enabled = false;
            cbxCategoria.Enabled = false;
            selecaoDePesquisa();
        }

        public void pesquisarPorNome(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Por favor, informe um nome para pesquisa");
                return;
            }

            ltbPesquisar.Items.Clear();

            MySqlConnection conn = Conexao.obterConexao();
            MySqlCommand comm = new MySqlCommand();

            comm.Connection = conn;
            comm.CommandText = "select nomeProd from produtos WHERE nomeProd LIKE '%@nomeProd%';";
            comm.Parameters.Add("@nomeProd", MySqlDbType.VarChar, 100).Value = descricao;

            MySqlDataReader DR = comm.ExecuteReader();

            while (DR.Read())
            {
                ltbPesquisar.Items.Add(DR.GetString(0));
            }
        }

        private void CarregarNomesCategorias()
        {
            cbxCategoria.Items.Clear();

            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "select idCategoria, nomeCategoria from categorias order by nomeCategoria asc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbxCategoria.Items.Add(DR["nomeCategoria"].ToString());
            }
            Conexao.Fecharconexao();
        }
        private int obterIdCategoria()
        {
            int idCategoria = -1;

            MySqlCommand comm = new MySqlCommand();

            if (cbxCategoria.SelectedItem == null)
            {
                return -1;
            }
            else
            {
                comm.Connection = Conexao.obterConexao();
                comm.CommandText = "SELECT idCategoria FROM categorias WHERE nomeCategoria = @nomeCategoria";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@nomeCategoria", MySqlDbType.VarChar, 20).Value = cbxCategoria.Text;

                object result = comm.ExecuteScalar();

                if (result != null)
                {
                    idCategoria = Convert.ToInt32(result);
                }
            }
            Conexao.Fecharconexao();
            return idCategoria;
        }

        private void btnCarregaGridView_Click(object sender, EventArgs e)
        {
            if (rdbNome.Checked)
            {
                pesquisarPorNome(TxtNome.Text);
            } else if (rdbCategoria.Text) { }
        }
    }
}

