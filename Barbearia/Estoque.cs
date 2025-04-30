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
            cbxCategoria.SelectedIndex = -1;
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

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}




