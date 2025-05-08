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
using Mysqlx.Crud;
using System.Globalization;

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
            Btn_Alterar.Visible = false;
            Btn_Excluir.Visible = false;

        }
        public FrmEstoque(string descricao)
        {
            InitializeComponent();
            Txt_Codigo.Enabled = false;
            txtProduto.Text = descricao;
            HabilitarCampos();
            CarregarNomesCategorias();
            pesquisarPorNome(txtProduto.Text);
            Btn_Alterar.Visible = true;
            Btn_Alterar.Visible = true;
            Btn_Novo.Enabled = false;
            Btn_Cadastrar.Enabled = false;
            Btn_Pesquisar.Enabled = false;
        }
        public void pesquisarPorNome(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Por favor, informe um nome para pesquisa");
                return;
            }



            MySqlConnection conn = Conexao.obterConexao();
            MySqlCommand comm = new MySqlCommand();

            comm.Connection = conn;
            comm.CommandText = "SELECT * FROM produtos WHERE nomeProd LIKE @NomeProd;";
            comm.Parameters.Add("@NomeProd", MySqlDbType.VarChar).Value = descricao;

            MySqlDataReader DR = comm.ExecuteReader();
            DR.Read();

            Txt_Codigo.Text = DR.GetInt32(0).ToString();
            txtProduto.Text = DR.GetString(1);
            TxtDescricao.Text = DR.GetString(2);
            //mskPreco.Text = DR.GetDecimal(3).ToString("N2", CultureInfo.GetCultureInfo("pt-BR"));
            //mskPreco.Text = DR.GetDecimal(3).ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
            decimal valorBanco = DR.GetDecimal(3); // Pega o valor do banco (ex: 7.00)
            if (valorBanco < 99)
            {
                mskPreco.Text = "00" + valorBanco.ToString(); 
            } else
            {
                mskPreco.Text = valorBanco.ToString();
            }
           
            mskQuantidade.Text = DR.GetInt32(4).ToString();
            int categoria = DR.GetInt32(5);
            cbxCategoria.SelectedIndex = categoria - 1;

            Conexao.Fecharconexao();
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
            txtProduto.Clear();
            cbxCategoria.SelectedIndex = -1;
            TxtDescricao.Clear();
            mskPreco.Clear();
            mskQuantidade.Clear();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {

            Btn_Voltar.Visible = false;
            Btn_voltar2.Visible = true;

            if (txtProduto.Text.Equals("") || TxtDescricao.Text.Equals("") || string.IsNullOrWhiteSpace(cbxCategoria.Text))
            {
                MessageBox.Show("Favor preencher todos os campos");
                return;
            }

            if (Convert.ToDecimal(mskPreco.Text) <= 0)
            {
                MessageBox.Show("Favor preencher informe um valor maior que R$00,00!!!");
            }
            else if (Convert.ToInt32(mskQuantidade.Text) <= 0)
            {
                MessageBox.Show("Favor preencher informe um valor maior que 0!!!");
            }
            else
            {
                int idCategoria = obterIdCategoria();
                if (idCategoria == -1)
                {
                    MessageBox.Show("Selecione uma categoria válida!");
                    return;
                }
                else if (cadastrarProduto(idCategoria) == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso!!!");
                    LimparCampos();
                    DesabilitarCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!!!");
                }



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


        //private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    {
        //        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
        //        {
        //            e.Handled = true;
        //        }
        //        TextBox txt = sender as TextBox;
        //        // Evita múltiplas vírgulas
        //        if (e.KeyChar == ',' && txt.Text.Contains(","))
        //        {
        //            e.Handled = true;
        //        }
        //    }
        //}

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

            CarregarNomesCategorias();
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

        public int cadastrarProduto(int idCategoria)
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "insert into produtos (nomeProd, descProd, precoUnitario, qtdProd, idCategoria) values (@nomeProd, @descProd, @precoUnitario, @qtdProd,      @idCategoria);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("nomeProd", MySqlDbType.VarChar, 100).Value = txtProduto.Text;
            comm.Parameters.Add("descProd", MySqlDbType.VarChar, 255).Value = TxtDescricao.Text;
            comm.Parameters.Add("precoUnitario", MySqlDbType.Double).Value = double.Parse(mskPreco.Text);
            comm.Parameters.Add("qtdProd", MySqlDbType.Int32).Value = int.Parse(mskQuantidade.Text);
            comm.Parameters.Add("idCategoria", MySqlDbType.Int32).Value = idCategoria;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.Fecharconexao();

            return resp;

        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            Btn_Voltar.Visible = false;
            Btn_voltar2.Visible = true;

            if (txtProduto.Text.Equals("") || TxtDescricao.Text.Equals("") || string.IsNullOrWhiteSpace(cbxCategoria.Text))
            {
                MessageBox.Show("Favor preencher todos os campos");
                return;
            }

            decimal preco;
            if (!decimal.TryParse(mskPreco.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out preco) || preco <= 0)
            {
                MessageBox.Show("Informe um preço válido (ex: 125,50)");
                return;
            }
            else if (!int.TryParse(mskQuantidade.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Favor informar um valor maior que 0!!!");
            }
            else
            {
                int idCategoria = obterIdCategoria();
                if (idCategoria == -1)
                {
                    MessageBox.Show("Selecione uma categoria válida!");
                    return;
                }
                else if (AlterarProduto(idCategoria) == 1)
                {
                    MessageBox.Show("Alterado com sucesso!!!");
                    LimparCampos();
                    DesabilitarCampos();
                    Btn_Alterar.Visible = false;
                    Btn_Excluir.Visible = false;
                    FrmListaEstoque lista = new FrmListaEstoque();
                    lista.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar!!!");
                }
            }

            

        }




        public int AlterarProduto(int idCategoria)
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE produtos SET nomeProd = @nomeProd, descProd = @descProd, precoUnitario = @precoUnitario, qtdProd = @qtdProd, idCategoria = @idCategoria,ativoProd = 0 WHERE idProd = @idProd";

            comm.Parameters.Add("@idProd", MySqlDbType.Int32).Value = Convert.ToInt32(Txt_Codigo.Text);
            comm.Parameters.Add("@nomeProd", MySqlDbType.VarChar, 100).Value = txtProduto.Text;
            comm.Parameters.Add("@descProd", MySqlDbType.VarChar, 255).Value = TxtDescricao.Text;
            comm.Parameters.Add("@precoUnitario", MySqlDbType.Double).Value = double.Parse(mskPreco.Text);
            comm.Parameters.Add("@qtdProd", MySqlDbType.Int32).Value = Convert.ToInt32(mskQuantidade.Text);
            comm.Parameters.Add("@idCategoria", MySqlDbType.Int32).Value = idCategoria;
            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();
            Conexao.Fecharconexao();
            return resp;
        }
    }

}




