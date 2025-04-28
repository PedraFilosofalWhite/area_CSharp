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
        public Calendario_Dias()
        {
            InitializeComponent();
        }
        public void Dias(int NumeroDias)
        {
            Lb_Dias.Text = NumeroDias + "";
        }
    }
}
