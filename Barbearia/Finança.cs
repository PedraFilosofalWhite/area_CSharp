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
    public partial class Finança : Form
    {
        public Finança()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            frmTela_Inicial tela = new frmTela_Inicial();
            tela.Show();
            this.Hide();
            // aaaaaaaaaaaaaaaaaaaaaa
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
        public enum TipoFinanceiro
        {
            Entrada,
            Saida
        }

    }
}
