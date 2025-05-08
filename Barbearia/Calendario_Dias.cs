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
            static_dia = Lb_Dias.Text;
            frmAgenda frmAgenda = new frmAgenda();
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
