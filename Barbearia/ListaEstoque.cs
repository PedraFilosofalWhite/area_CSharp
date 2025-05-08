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

        private void FrmListaEstoque_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);



            TxtNome.Enabled = false;
            cbxCategoria.Enabled = false;
            CarregarNomesCategorias();
        }

        public void pesquisarPorNome(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Por favor, informe um nome para pesquisa");
                return;
            }

            ltbNomeProdutos.Items.Clear();
            ltbQtdProd.Items.Clear();

            MySqlConnection conn = Conexao.obterConexao();
            MySqlCommand comm = new MySqlCommand();

            comm.Connection = conn;
            comm.CommandText = "SELECT nomeProd, qtdProd FROM produtos WHERE nomeProd LIKE @NomeProd;";
            comm.Parameters.Add("@NomeProd", MySqlDbType.VarChar).Value = $"%{descricao}%";

            MySqlDataReader DR = comm.ExecuteReader();


            while (DR.Read())
            {
                ltbNomeProdutos.Items.Add(DR.GetString(0));
                ltbQtdProd.Items.Add(DR.GetInt32(1));
            }



            Conexao.Fecharconexao();
        }

        public void pesquisarPorCategoria(int categoria)
        {


            ltbNomeProdutos.Items.Clear();
            ltbQtdProd.Items.Clear();

            MySqlConnection conn = Conexao.obterConexao();
            MySqlCommand comm = new MySqlCommand();
            {
                comm.Connection = conn;
                comm.CommandText = "select nomeProd, qtdProd from Produtos where idCategoria = @idCategoria;";
                comm.Parameters.Add("@idCategoria", MySqlDbType.Int32).Value = categoria;

                MySqlDataReader DR = comm.ExecuteReader();

                while (DR.Read())
                {
                    ltbNomeProdutos.Items.Add(DR.GetString(0));
                    ltbQtdProd.Items.Add(DR.GetInt32(1));
                }
                Conexao.Fecharconexao();

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


        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            TxtNome.Clear();
            TxtNome.Enabled = true;
            cbxCategoria.Enabled = false;
        }

        private void rdbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            cbxCategoria.SelectedIndex = -1;
            TxtNome.Enabled = false;
            cbxCategoria.Enabled = true;

        }

        private void btnCarregaProdutos_Click(object sender, EventArgs e)
        {
            int categoria = obterIdCategoria();
            if (rdbNome.Checked)
            {
                pesquisarPorNome(TxtNome.Text);
            }
            else if (rdbCategoria.Checked)
            {
                pesquisarPorCategoria(categoria);
            }
        }

        private void ltbNomeProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string descricao = ltbNomeProdutos.SelectedItem.ToString();
            FrmEstoque abrir = new FrmEstoque(descricao);
            abrir.Show();
            this.Hide();
        }
    }
}

