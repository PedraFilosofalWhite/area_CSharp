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
    }
}

