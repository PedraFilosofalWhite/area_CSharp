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
    public partial class frmAgenda : Form
    {

        public void tela_inicial()
        {
            frmTela_Inicial tela_Inicial = new frmTela_Inicial();
            tela_Inicial.Show();
            this.Hide();


        }

        public frmAgenda()
        {
            InitializeComponent();
            Rb_Nao.Checked = true;
        }
        public void checagem()
        {
            if (!Rb_Nome_prod.Checked && !Rb_Codigo_prod.Checked)
            {
                MessageBox.Show("Selecione o nome do Produto ou Categoria");
            }
            /*if (Txt_Pesquisa_prod.Text == "")
            {
                MessageBox.Show("Escreva o nome do Produto ou Categoria ");
            }*/
            else
            {
                if (Nup_Quantidade.Value == 0)
                {
                    MessageBox.Show("Coloque a quantidade de Produtos");
                }
                else
                {
                    if (!Rb_nome2.Checked && !Rb_codigo2.Checked)
                    {
                        MessageBox.Show("Selecione o nome do Cliente ou Código ");
                    }
                    /* if (Txt_Pesquisa_prod.Text == "")
                     {
                         MessageBox.Show("Escreva o nome do Produto ou Categoria ");
                     }*/
                }
            }


        }
        private void Bt_Sair_agenda_Click(object sender, EventArgs e)
        {
            tela_inicial();
        }




        private void Agenda_Load(object sender, EventArgs e)
        {

            Txt_dias.Text = Calendario_Dias.static_dia + "/" + frmTela_Inicial.static_mes + "/" + frmTela_Inicial.static_ano;
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            CB_horarios.SelectedIndex = -1;
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            rdbVip.Checked = false;
            Txt_Pesquisar.Clear();
            CB_Serviços.SelectedIndex = -1;
        }

        private void CB_Serviços_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CB_horarios_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CB_horarios_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true; // Bloqueia a tecla
        }

        private void CB_Serviços_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true; // Bloqueia a tecla
        }

        private void Btn_Agendar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CB_horarios.Text) ||
    string.IsNullOrWhiteSpace(CB_Serviços.Text) ||
    (!rdbCodigo.Checked && !rdbNome.Checked && !rdbVip.Checked))
            {
                MessageBox.Show("Favor preencher todos os campos!!!");
            }


        }

        private void Rb_Sim_CheckedChanged(object sender, EventArgs e)
        {
            Gb_Produtos.Visible = true;
            Btn_registrar.Visible = true;
        }

        private void Rb_Nao_CheckedChanged(object sender, EventArgs e)
        {
            Gb_Produtos.Visible = false;
            Btn_registrar.Visible = false;
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            checagem();
        }

        private void Btn_Procurar_prod_Click(object sender, EventArgs e)
        {
            if (!Rb_Nome_prod.Checked && !Rb_Codigo_prod.Checked)
            {
                MessageBox.Show("Selecione o nome do Produto ou Categoria");
            }
            /*if (Txt_Pesquisa_prod.Text == "")
            {
                MessageBox.Show("Escreva o nome do Produto ou Categoria ");
            }*/

        }

        private void Btn_procura_cliente_Click(object sender, EventArgs e)
        {
            if (!Rb_nome2.Checked && !Rb_codigo2.Checked)
            {
                MessageBox.Show("Selecione o nome do Cliente ou Código ");
            }
        }

        private void Nup_Quantidade_ValueChanged(object sender, EventArgs e)
        {
            /* int quantidade;
             Nup_Quantidade.Value = quantidade;
             //value é a quantidade selecionado */
        }
    }


}
