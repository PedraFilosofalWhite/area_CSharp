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
    public partial class Finança : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public Finança()
        {
            InitializeComponent();
            DesabilitarCampos();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            frmTela_Inicial tela = new frmTela_Inicial();
            tela.Show();
            this.Hide();

        }
        private void AtualizarResumo()
        {
            DateTime inicio = dtp_PeriodoDe.Value.Date;
            DateTime fim = dtp_Ate.Value.Date;

            decimal totalEntradas = 0;
            decimal saldo = 0;

            saldo += totalEntradas;

            txb_Entradas.Text = totalEntradas.ToString("C");
            txb_Saldo.Text = saldo.ToString("C");
        }

        private void txb_Saldo_TextChanged(object sender, EventArgs e)
        {

        }

        public void DesabilitarCampos()
        {
            txb_Entradas.Enabled = false;
            txb_Saldo.Enabled = false;
            Txt_Projetivo.Enabled = false;
            Txt_QuantCliente.Enabled = false;
            Txt__ServPrestado.Enabled = false;
            Txt_ProdVendidos.Enabled = false;
        }

        private void Finança_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lb1.Visible = !lb1.Visible;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Lb2.Visible = !Lb2.Visible;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lb3.Visible = !lb3.Visible;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Lb4.Visible = !Lb4.Visible;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Lb5.Visible = !Lb5.Visible;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Lb6.Visible = !Lb6.Visible;
        }
    }
}
