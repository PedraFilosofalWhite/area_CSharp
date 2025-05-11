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
using System.Runtime.InteropServices;
using System.Globalization;
using Barbeariaz;

namespace Barbearia
{
    public partial class FrmEstoque : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public FrmEstoque()
        {
            InitializeComponent();
            DesabilitarCampos();
            Txt_Codigo.Enabled = false;
            carregarCategorias();
            Btn_voltar2.Visible = false;
        }
        public void DesabilitarCampos()
        {
            Gpb_Estoque.Enabled = false;
            Btn_Limpar.Enabled = false;
            Btn_Cadastrar.Enabled = false;
            Btn_Alterar.Enabled = false;
            Btn_Excluir.Enabled = false;
        }
        public void HabilitarCampos()
        {
            Gpb_Estoque.Enabled = true;
            Btn_Limpar.Enabled = true;
            Btn_Cadastrar.Enabled = true;
            Btn_Alterar.Enabled = true;
            Btn_Excluir.Enabled = true;
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
            Btn_Excluir.Visible = false;
            Btn_Alterar.Visible = false;
            Btn_voltar2.Visible = true;
            Btn_Cadastrar.Location = new Point(11, 593);
            Btn_Limpar.Location = new Point(194, 593);
            Btn_Pesquisar.Location = new Point(377, 593);
        }
        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Gpb_Pesquisar.Visible = true;
            Btn_Alterar.Enabled = true;
            Btn_Excluir.Enabled = true;
            ltb_Pesquisar.Items.Clear();

            if (rdbCategoria.Checked)
            {
                pesquisarPorCategoria();
            }
            else if (rdbNome.Checked)
            {
                pesquisarPorNome(Txt_Descricao.Text);
            }
        }
        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        public void LimparCampos()
        {
            Txt_Codigo.Clear();
            txtProduto.Clear();
            cbxCategoria.SelectedIndex = -1;
            TxtDescricao.Clear();
            txt_preco.Clear();
            txtQuantidade.Clear();
        }
        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {

            Btn_Voltar.Visible = false;
            Btn_voltar2.Visible = true;


            if (
                txtProduto.Text.Equals("") ||
                TxtDescricao.Text.Equals("") ||
                txt_preco.Text.Equals("") ||
                txtQuantidade.Equals("") ||
                cbxCategoria.Equals(""))
            {
                MessageBox.Show("Favor preencher todos os campos!!!");
            }
            else
            {
                if (cadastrarprod() == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso!!!");
                    LimparCampos();
                    DesabilitarCampos();

                    DesabilitarCampos();
                    Btn_Novo.Visible = true;
                    Btn_Alterar.Visible = true;
                    Btn_Excluir.Visible = true;
                    Btn_voltar2.Visible = false;
                    Btn_Voltar.Visible = true;
                    Btn_Novo.Location = new Point(2, 593);
                    Btn_Cadastrar.Location = new Point(183, 593);
                    Btn_Limpar.Location = new Point(364, 593);
                    Btn_Alterar.Location = new Point(540, 593);
                    Btn_Excluir.Location = new Point(721, 593);
                    Btn_Pesquisar.Location = new Point(902, 593);
                    Btn_Novo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!!!");

                }

            }
            Btn_Voltar.Visible = true;
            Btn_Voltar.Enabled = true;
            Btn_voltar2.Visible = false;
            Btn_voltar2.Enabled = false;

        }
        public int cadastrarprod()
        {
            int categoria = obterIdCategoria();

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "iNSERT INTO Produtos (nomeProd, descProd, precoUnitario, qtdProd, idCategoria) VALUES (@nomeProd, @descProd, @precoUnitario, @qtdprod, @idCategoria);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeProd", MySqlDbType.VarChar, 100).Value = txtProduto.Text;
            comm.Parameters.Add("@descProd", MySqlDbType.VarChar, 255).Value = TxtDescricao.Text;
            comm.Parameters.Add("@precoUnitario", MySqlDbType.Decimal).Value = decimal.Parse(txt_preco.Text);
            comm.Parameters.Add("@qtdProd", MySqlDbType.Int32).Value = txtQuantidade.Text;
            comm.Parameters.Add("@idCategoria", MySqlDbType.Int32).Value = categoria;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.Fecharconexao();

            return resp;
        }
        private void carregarCategorias()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nomeCategoria from categorias;";

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbxCategoria.Items.Add(DR["nomeCategoria"].ToString());
                cbxCategoriasDesc.Items.Add(DR["nomeCategoria"].ToString());
            }
            Conexao.Fecharconexao();

        }
        public int obterIdCategoria()
        {
            int categoria = 0;
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select idCategoria from categorias where nomeCategoria = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = cbxCategoria.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR = comm.ExecuteReader();
            if (DR.Read())
            {
                categoria = DR.GetInt32(0);
            }
            Conexao.Fecharconexao();
            return categoria;
        }
        private void Btn_voltar2_Click(object sender, EventArgs e)
        {
            Btn_Novo.Visible = true;
            Btn_Voltar.Visible = true;
            Btn_Excluir.Visible = true;
            Btn_Alterar.Visible = true;
            Btn_voltar2.Visible = false;
            Btn_Pesquisar.Visible = true;
            Btn_Novo.Enabled = true;
            LimparCampos();
            ltb_Pesquisar.Items.Clear();
            rdbCategoria.Checked = false;
            rdbNome.Checked = false;

            Btn_Cadastrar.Location = new Point(194, 593);
            Btn_Limpar.Location = new Point(377, 593);
            Btn_Pesquisar.Location = new Point(926, 593);

            DesabilitarCampos();

        }
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
        private void txt_preco_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string textoAtual = textBox.Text.Replace(",", "");

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }

            string novoTxt;
            if (e.KeyChar == '\b' && textoAtual.Length > 0)
            {
                novoTxt = textoAtual.Substring(0, textoAtual.Length - 1);
            }
            else if (e.KeyChar == '\b')
            {
                novoTxt = "";
            }
            else
            {
                if (textoAtual.Length >= 5)
                {
                    e.Handled = true;
                    return;
                }
                novoTxt = textoAtual + e.KeyChar;
            }

            if (novoTxt.Length > 0)
            {
                decimal valor = decimal.Parse(novoTxt) / 100;
                textBox.Text = valor.ToString("#0.00").Replace(".", ",");
                textBox.SelectionStart = textBox.Text.Length;
            }
            else
            {
                textBox.Text = "";
            }

            e.Handled = true;
        }
        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            if (
                txtProduto.Text.Equals("") ||
                TxtDescricao.Text.Equals("") ||
                txt_preco.Text.Equals("") ||
                txtQuantidade.Equals("") ||
                cbxCategoria.Equals(""))
            {
                MessageBox.Show("Favor preencher todos os campos!!!");
            }
            else
            {
                if (AlterarProdutos() == 1)
                {
                    MessageBox.Show("Produto atualizado com sucesso!");
                    LimparCampos();
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
            Btn_Voltar.Visible = true;
            Btn_Voltar.Enabled = true;
            Btn_voltar2.Visible = false;
            Btn_voltar2.Enabled = false;
        }
        public int AlterarProdutos()
        {
            int categoria = obterIdCategoria();
            int idProduto = int.Parse(Txt_Codigo.Text);
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = @"UPDATE Produtos 
                    SET nomeProd = @nomeProd, 
                        descProd = @descProd, 
                        precoUnitario = @precoUnitario, 
                        qtdProd = @qtdProd, 
                        idCategoria = @idCategoria 
                    WHERE idProd = @idProd;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeProd", MySqlDbType.VarChar, 100).Value = txtProduto.Text;
            comm.Parameters.Add("@descProd", MySqlDbType.VarChar, 255).Value = TxtDescricao.Text;
            comm.Parameters.Add("@precoUnitario", MySqlDbType.Decimal).Value = decimal.Parse(txt_preco.Text);
            comm.Parameters.Add("@qtdProd", MySqlDbType.Int32).Value = int.Parse(txtQuantidade.Text);
            comm.Parameters.Add("@idCategoria", MySqlDbType.Int32).Value = categoria;
            comm.Parameters.Add("@idProd", MySqlDbType.Int32).Value = idProduto;

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
                excluirProdutos(int.Parse(Txt_Codigo.Text));
                MessageBox.Show("Produto excluido com sucesso!");
                LimparCampos();
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
            Btn_Voltar.Visible = true;
            Btn_Voltar.Enabled = true;
            Btn_voltar2.Visible = false;
            Btn_voltar2.Enabled = false;
        }
        public int excluirProdutos(int idProd)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update produtos " +
                "set ativoProd = FALSE " +
                "where idProd = @idProd;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@idProd", MySqlDbType.Int32).Value = idProd;

            int resp = comm.ExecuteNonQuery();

            Conexao.Fecharconexao();

            return resp;
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
                comm.CommandText = "SELECT nomeProd FROM produtos WHERE nomeProd LIKE CONCAT('%', @nome, '%') and ativoProd = true";
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
        public void pesquisarPorCategoria()
        {
            int idcategoria = obterIdCategoriaDesc();
            if (string.IsNullOrWhiteSpace(cbxCategoriasDesc.Text))
            {
                MessageBox.Show("Por favor, informe uma caetgoria para pesquisa");
                return;
            }

            ltb_Pesquisar.Items.Clear();

            MySqlConnection conn = Conexao.obterConexao();
            MySqlCommand comm = new MySqlCommand();
            {
                comm.Connection = conn;
                comm.CommandText = "SELECT nomeProd FROM produtos WHERE idCategoria = @id and ativoProd = true";
                comm.Parameters.Add("@id", MySqlDbType.VarChar, 100).Value = idcategoria;

                using (MySqlDataReader DR = comm.ExecuteReader())
                {
                    while (DR.Read())
                    {
                        ltb_Pesquisar.Items.Add(DR.GetString(0));
                    }
                }
            }
        }
        public int obterIdCategoriaDesc()
        {
            int categoria = 0;
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select idCategoria from categorias where nomeCategoria = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = cbxCategoriasDesc.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR = comm.ExecuteReader();
            if (DR.Read())
            {
                categoria = DR.GetInt32(0);
            }
            Conexao.Fecharconexao();
            return categoria;
        }
        private void rdbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            Txt_Descricao.Visible = false;
            cbxCategoriasDesc.Visible = true;
        }
        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            Txt_Descricao.Visible = true;
            cbxCategoriasDesc.Visible = false;
        }
        private void ltb_Pesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltb_Pesquisar.SelectedItem != null)
            {
                string prod = ltb_Pesquisar.SelectedItem.ToString();
                CarregarDadosProd(prod);
                HabilitarCampos();
                Btn_Novo.Enabled = false;
                Btn_voltar2.Enabled = true;
                Btn_voltar2.Visible = true;
                Btn_Voltar.Visible = false;
                Btn_Alterar.Enabled = true;
                Btn_Cadastrar.Enabled = false;
                Btn_Pesquisar.Enabled = false;
                Gpb_Pesquisar.Visible = false;
                Btn_Pesquisar.Visible = true;
                Btn_Pesquisar.Enabled = false;
                ltb_Pesquisar.Items.Clear();
                rdbCategoria.Checked = false;
                rdbNome.Checked = false;
                Txt_Descricao.Clear();
                cbxCategoriasDesc.SelectedIndex = -1;
            }
        }
        public void CarregarDadosProd(string nomeProd)
        {
            int idCategoria = 0;
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = @"SELECT idProd, nomeProd, descProd, precoUnitario, qtdProd, idCategoria 
                    FROM Produtos 
                    WHERE nomeProd = @nomeProd;";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeProd", MySqlDbType.VarChar, 100).Value = nomeProd;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR = comm.ExecuteReader();

            if (DR.Read())
            {
                Txt_Codigo.Text = DR["idProd"].ToString();  
                txtProduto.Text = DR["nomeProd"].ToString();   
                TxtDescricao.Text = DR["descProd"].ToString();  
                txt_preco.Text = DR["precoUnitario"].ToString();
                txtQuantidade.Text = DR["qtdProd"].ToString();
                idCategoria = Convert.ToInt32(DR["idCategoria"]);
            }

            cbxCategoria.SelectedIndex = idCategoria - 1;


            Conexao.Fecharconexao();
        }
    }
}




