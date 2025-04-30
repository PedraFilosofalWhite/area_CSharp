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

namespace Barbearia
{
    public partial class FrmFuncionario : Form
    {
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

        

        private void Btn_Limpar_Click(object sender, EventArgs e)
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
