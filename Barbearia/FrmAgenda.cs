using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;


namespace Barbearia
{
    public partial class frmAgenda : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
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
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }

}
