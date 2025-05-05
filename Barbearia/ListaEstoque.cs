using MySql.Data.MySqlClient;
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
    public partial class FrmListaEstoque : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

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


        private void btnCarregaGridView_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.obterConexao())
                {
                    string query = "SELECT codfunc as Codigo, Produto, Descrição, Preço, Quantidade FROM Produtos";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        MessageBox.Show($"Código: {reader["Codigo"]} => Produto: {reader["Produto"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }     
        private void FrmListaEstoque_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}
