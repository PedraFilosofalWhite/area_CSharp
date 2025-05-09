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
    public partial class Calendario_Dias : UserControl
    {
        public static string static_dia;

        public Calendario_Dias()
        {
            InitializeComponent();
        }
        public void Dias(int NumeroDias)
        {
            Lb_Dias.Text = NumeroDias + "";
        }
        private void Calendario_Dias_Click(object sender, EventArgs e)
        {
            frmTela_Inicial telaPrincipal = Application.OpenForms.OfType<frmTela_Inicial>().FirstOrDefault();

            if (telaPrincipal == null || !telaPrincipal.FuncionarioSelecionado)
            {
                MessageBox.Show("Escolha um Funcionário antes de prosseguir");
                return;
            }

            static_dia = Lb_Dias.Text;

            // Fecha qualquer instância existente de frmAgenda
            var agendaAberta = Application.OpenForms.OfType<frmAgenda>().FirstOrDefault();
            agendaAberta?.Close();

            // Cria nova instância com os dados atualizados
            int idFunc = telaPrincipal.IdFuncionarioSelecionado;
            frmAgenda frmAgenda = new frmAgenda(idFunc);
            frmAgenda.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmVisualizarAgenda frmVisual = new frmVisualizarAgenda();
            frmVisual.Show();
        }
        private void Calendario_Dias_Load(object sender, EventArgs e)
        {

        }
    }
}
