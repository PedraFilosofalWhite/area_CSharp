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
            
        }
    }


}
