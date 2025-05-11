using Barbeariaz;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbearia
{
    public partial class Calendario_Dias : UserControl
    {
        public static string static_dia;
        public DateTime _Dia;

        public Calendario_Dias()
        {
            InitializeComponent();
            btnVizualizarAgenda.Enabled = false;
        }
        public void Dias(int NumeroDias)
        {
            Lb_Dias.Text = NumeroDias + "";
        }
        private void Calendario_Dias_Click(object sender, EventArgs e)
        {


            frmTela_Inicial telaPrincipal = Application.OpenForms.OfType<frmTela_Inicial>().LastOrDefault();

            if (telaPrincipal == null || !telaPrincipal.FuncionarioSelecionado)
            {
                MessageBox.Show("Escolha um Funcionário antes de prosseguir");
                return;
            }
            else
            {

                btnVizualizarAgenda.Enabled = true;
                static_dia = Lb_Dias.Text;

                var agendaAberta = Application.OpenForms.OfType<frmAgenda>().FirstOrDefault();
                agendaAberta?.Close();

                // Cria nova instância com os dados atualizados
                int idFunc = telaPrincipal.IdFuncionarioSelecionado;
                frmAgenda frmAgenda = new frmAgenda(idFunc);
                frmAgenda.Show();
            }

        }
        private void btnVizualizarAgenda_Click(object sender, EventArgs e)
        {

            frmTela_Inicial telaPrincipal = Application.OpenForms.OfType<frmTela_Inicial>().LastOrDefault();
            int idFunc = telaPrincipal.IdFuncionarioSelecionado;
            frmAgenda teste = new frmAgenda(idFunc);

            frmVisualizarAgenda frmVisual = new frmVisualizarAgenda(teste.gerarHorarios());
            frmVisual.Show();
        }

        private void Calendario_Dias_Load(object sender, EventArgs e)
        {

        }
    }
}
