using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbearia
{
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
            DesabilitarCampos();
        }
        public void DesabilitarCampos()
        {
            Gpb_Estoque.Enabled = false;
            Txt_Codigo.Enabled = false;
            Btn_Alterar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Limpar.Enabled = false;
            Btn_Cadastrar.Enabled = false;
        }
        public void HabilitarCampos()
        {
            Gpb_Estoque.Enabled = true;
            Txt_Codigo.Enabled = true;
            Btn_Alterar.Enabled = true;
            Btn_Excluir.Enabled = true;
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
            cbxCategoria.Items.Clear();
            TxtDescricao.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text.Equals("") ||
                txtProduto.Text.Equals("") ||
                TxtDescricao.Text.Equals("") ||
                txtPreco.Text.Equals("") ||
                txtQuantidade.Equals("") ||
                cbxCategoria.Equals(""))
            {
                MessageBox.Show("Favor preencher os campos!!!");
            }
        }
    }
}




