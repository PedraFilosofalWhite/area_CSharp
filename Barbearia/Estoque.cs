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
using static System.Net.Mime.MediaTypeNames;

namespace Barbearia
{
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
            DesabilitarCampos();
            Txt_Codigo.Enabled = false;
        }
        public void DesabilitarCampos()
        {
            Gpb_Estoque.Enabled = false;
            Btn_Limpar.Enabled = false;
            Btn_Cadastrar.Enabled = false;
        }
        public void HabilitarCampos()
        {
            Gpb_Estoque.Enabled = true;
            Btn_Limpar.Enabled = true;
            Btn_Cadastrar.Enabled = true;
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
            Btn_Novo.Visible = false;
            Btn_Cadastrar.Location = new Point(11, 593);
            Btn_Limpar.Location = new Point(194, 593);
            Btn_Pesquisar.Location = new Point(377, 593);
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {

            FrmListaEstoque lista = new FrmListaEstoque();
            lista.Show();
            this.Hide();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        public void LimparCampos()
        {
            Txt_Codigo.Clear();
            txtProduto.Clear();

            TxtDescricao.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {

            Btn_Voltar.Visible = false;
            Btn_voltar2.Visible = true;


            if (Txt_Codigo.Text.Equals("") ||
                txtProduto.Text.Equals("") ||
                TxtDescricao.Text.Equals("") ||
                txtPreco.Text.Equals("") ||
                txtQuantidade.Equals("") ||
                cbxCategoria.Equals(""))
            {
                MessageBox.Show("Favor preencher os campos!!!");
            }
            try
            {
                string produto = txtProduto.Text;
                string descricao = TxtDescricao.Text;
                decimal preco = decimal.Parse(txtPreco.Text);
                int quantidade = int.Parse(txtQuantidade.Text);
                string categoria = cbxCategoria.Text;
                using (MySqlConnection conexao = Conexao.obterConexao())
                {
                    string sql = "INSERT INTO Produtos (nome, descricao, preco, quantidade, categoria) " +
                                 "VALUES (@nome, @descricao, @preco, @quantidade, @categoria)";
                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", produto);
                        comando.Parameters.AddWithValue("@descricao", descricao);
                        comando.Parameters.AddWithValue("@preco", preco);
                        comando.Parameters.AddWithValue("@quantidade", quantidade);
                        comando.Parameters.AddWithValue("@categoria", categoria);
                        comando.ExecuteNonQuery();
                    }
                    MessageBox.Show("Produto cadastrado com sucesso!");
                }
                LimparCampos(); // se quiser limpar os campos após o cadastro
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }

        }
       

        private void Btn_voltar2_Click(object sender, EventArgs e)
        {
            Btn_Novo.Visible = true;
            Btn_Voltar.Visible = true;
            Btn_voltar2.Visible = false;

            Btn_Cadastrar.Location = new Point(194, 593);
            Btn_Limpar.Location = new Point(377, 593);
            Btn_Pesquisar.Location = new Point(560, 593);

            DesabilitarCampos();

        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
                TextBox txt = sender as TextBox;
                // Evita múltiplas vírgulas
                if (e.KeyChar == ',' && txt.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        public static class Conexao
        {
            public static MySqlConnection obterConexao()
            {
                string connStr = "server=localhost;user=root;database=barbearia;password=;";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                return conn;
            }
        }

    }
}




