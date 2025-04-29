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
    public partial class FrmListaEstoque : Form
    {
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
    }
}
