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

    }
}
