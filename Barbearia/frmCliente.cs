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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            DesabilitarCampos();
        }
        public void DesabilitarCampos()
        {
            Gpb_Cadastrar.Enabled = false;
            Txt_Codigo.Enabled = false;
            Btn_Alterar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Cadastrar.Enabled = false;
            Btn_Limpar.Enabled = false;
        }
        public void HabilitarCampos()
        {
            Gpb_Cadastrar.Enabled = true;
            Btn_Alterar.Enabled = true;
            Btn_Excluir.Enabled = true;
            Btn_Cadastrar.Enabled = true;
            Btn_Limpar.Enabled = true;
            Gpb_Pesquisar.Visible = false;
            Btn_Novo.Enabled = false;

        }
        public void limpar()
        {
            Txt_nome.Clear();
            Txt_Email.Clear();
            Msk_Telefone.Clear();
            Rb_Feminino.Checked = false;
            Rb_Masculino.Checked = false;
            Rb_NaoInfo.Checked = false;
        }
        private void Cliente_Load(object sender, EventArgs e)
        {

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
            Btn_Cadastrar.Location = new Point(2, 600);
            Btn_Limpar.Location = new Point(183, 600);
            Btn_Pesquisar.Location = new Point(364, 600);
            Btn_Novo.Visible = false;
            Btn_Alterar.Visible = false;
            Btn_Excluir.Visible = false;
            btn_voltar2.Visible = true;
            Btn_Voltar.Visible = false;
            btn_voltar2.Location = new Point(1083, 600);
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Gpb_Pesquisar.Visible = true;
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_voltar2_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            Btn_Novo.Visible = true;
            Btn_Alterar.Visible = true;
            Btn_Excluir.Visible = true;
            btn_voltar2.Visible = false;
            Btn_Voltar.Visible = true;
            Btn_Novo.Location = new Point(2, 600);
            Btn_Cadastrar.Location = new Point(183, 600);
            Btn_Limpar.Location = new Point(364, 600);
            Btn_Alterar.Location = new Point(540, 600);
            Btn_Excluir.Location = new Point(721, 600);
            Btn_Pesquisar.Location = new Point(902, 600);
            Btn_Novo.Enabled = true;

        }

        private void Txt_Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
