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
using System.Runtime.InteropServices;
using System.Globalization;



namespace Barbearia
{
    public partial class Cliente : Form
    {


        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

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
            Msk_Telefone.Clear();
            rdbVipNao.Checked = false;
            rdbVipSim.Checked = false;
            ltb_Pesquisar.Items.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            rdbVip.Checked = false;
            Txt_Descricao.Clear();
        }
        private void Cliente_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            rdbVipNao.Checked = false;
            rdbVipSim.Checked = false;
            rdbVipNao.Checked = false;

            Txt_Descricao.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            rdbVip.Checked = false;

            ltb_Pesquisar.Items.Clear();

            Txt_nome.Focus();
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
            Btn_Cadastrar.Visible = true;
            Btn_Cadastrar.Enabled = false;
            Gpb_Pesquisar.Visible = true;
            

            if (rdbCodigo.Checked)
            {
                pesquisarPorCodigo((Txt_Descricao.Text));
            }
            else if (rdbNome.Checked)
            {
                pesquisarPorNome(Txt_Descricao.Text);
            }
            else if (rdbVip.Checked)
            {
                pesquisarVip(Txt_Descricao.Text);
            }

        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        public void btn_voltar2_Click(object sender, EventArgs e)
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
        public int cadastrarCliente()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into Clientes (nomeCli, TelCelCli, vipCli) values (@nomeCli, @TelCelCli, @vipCli);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeCli", MySqlDbType.VarChar, 100).Value = Txt_nome.Text;
            comm.Parameters.Add("@telCelCli", MySqlDbType.VarChar, 10).Value = Msk_Telefone.Text;
            if (rdbVipSim.Checked)
            {
                comm.Parameters.Add("@vipCli", MySqlDbType.Int16).Value = 1;

            }
            if (rdbVipNao.Checked)
            {
                comm.Parameters.Add("@vipCli", MySqlDbType.Int16).Value = 0;
            }

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.Fecharconexao();

            return resp;


        }
        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {

            if (Txt_nome.Text.Equals("") ||
                !Msk_Telefone.MaskFull ||
                (!rdbVipSim.Checked && !rdbVipNao.Checked))
            {
                MessageBox.Show("Favor preencher todos os campos!!!");
            }
            else
            {
                if (cadastrarCliente() == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso!!!");
                    limpar();
                    DesabilitarCampos();

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
                else
                {
                    MessageBox.Show("Erro ao cadastrar!!!");

                }

            }
        }
        public void pesquisarPorNome(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Por favor, informe um nome para pesquisa");
                return;
            }

            ltb_Pesquisar.Items.Clear();

            MySqlConnection conn = Conexao.obterConexao();
            MySqlCommand comm = new MySqlCommand();
            {
                comm.Connection = conn;
                comm.CommandText = "SELECT nomeCli FROM Clientes WHERE nomeCli LIKE CONCAT('%', @nome, '%') and ativoCli = true";
                comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = descricao;

                using (MySqlDataReader DR = comm.ExecuteReader())
                {
                    while (DR.Read())
                    {
                        ltb_Pesquisar.Items.Add(DR.GetString(0));
                    }
                }
            }
        }
        public void pesquisarPorCodigo(string descricao)
        {
            if (!int.TryParse(descricao, out int idCliente))
            {
                MessageBox.Show("Código inválido. Informe um número válido.");
                Txt_Descricao.Clear();
                Txt_Descricao.Focus();
                return;
            }
            
            ltb_Pesquisar.Items.Clear();

            MySqlConnection conn = Conexao.obterConexao();
            MySqlCommand comm = new MySqlCommand();
            {
                comm.Connection = conn;
                comm.CommandText = "SELECT nomeCli FROM Clientes WHERE idCli = @idCliente and ativoCli = true;";
                comm.Parameters.Add("@idCliente", MySqlDbType.Int32).Value = idCliente;

                using (MySqlDataReader DR = comm.ExecuteReader())
                {
                    if (DR.Read())
                    {
                        ltb_Pesquisar.Items.Add(DR.GetString(0));
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado");
                        Txt_Descricao.Clear();
                        Txt_Descricao.Focus();
                    }
                }
            }
        }
        public void pesquisarVip(string descricao)
        {
            bool? isVip = null;

            if (descricao.Equals("Sim", StringComparison.OrdinalIgnoreCase))
                isVip = true;
            else if (descricao.Equals("Não", StringComparison.OrdinalIgnoreCase))
                isVip = false;
            else
            {
                MessageBox.Show("Informe 'Sim' ou 'Não' para pesquisa VIP");
                return;
            }

            ltb_Pesquisar.Items.Clear();

            using (MySqlConnection conn = Conexao.obterConexao())
            using (MySqlCommand comm = new MySqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = "SELECT nomeCli FROM Clientes WHERE vipCli = @vip and ativoCli = true";
                comm.Parameters.Add("@vip", MySqlDbType.Int16).Value = isVip.Value;

                using (MySqlDataReader DR = comm.ExecuteReader())
                {
                    while (DR.Read())
                    {
                        ltb_Pesquisar.Items.Add(DR.GetString(0));
                    }
                }
            }
        }

        private void ltb_Pesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltb_Pesquisar.SelectedItem != null)
            {
                string nomeCliente = ltb_Pesquisar.SelectedItem.ToString();
                CarregarDadosCliente(nomeCliente);
                HabilitarCampos();
                Btn_Alterar.Enabled = true;
                Btn_Cadastrar.Enabled = false;
                Btn_Pesquisar.Enabled = false;
            }

        }
        public void CarregarDadosCliente(string nomeCliente)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT idCli, nomeCli, TelCelCli, vipCli FROM Clientes WHERE nomeCli = @nome;";
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nomeCliente;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR = comm.ExecuteReader();

            if (DR.Read())
            {
                Txt_Codigo.Text = DR["idCli"].ToString();
                Txt_nome.Text = DR["nomeCli"].ToString();
                Msk_Telefone.Text = DR["TelCelCli"].ToString();
                rdbVipSim.Checked = Convert.ToBoolean(DR["vipCli"]);
                rdbVipNao.Checked = !rdbVipSim.Checked;
            }

            Conexao.Fecharconexao();
        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            if (Txt_nome.Text.Equals("") ||
                !Msk_Telefone.MaskFull ||
                (!rdbVipSim.Checked && !rdbVipNao.Checked))
            {
                MessageBox.Show("Favor preencher todos os campos!!!");
            }
            else
            {
                if (AlterarCliente() == 1)
                {
                    MessageBox.Show("Cliente atualizado com sucesso!");
                    limpar();
                    DesabilitarCampos();
                    Btn_Novo.Enabled = true;
                    Btn_Pesquisar.Enabled = true;
                    Gpb_Pesquisar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar.");
                }
            }
        }

        public int AlterarCliente()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE Clientes SET nomeCli = @nome, TelCelCli = @telefone, vipCli = @vip WHERE idCli = @id;";
            comm.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(Txt_Codigo.Text);
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = Txt_nome.Text;
            comm.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = Msk_Telefone.Text;
            comm.Parameters.Add("@vip", MySqlDbType.Bit).Value = rdbVipSim.Checked ? 1 : 0;
            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();
            Conexao.Fecharconexao();
            return resp;
        }

        public int excluirClientes(int idCli)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update Clientes " +
                "set ativoCli = FALSE " +
                "where idCli = @idCli;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@idCli", MySqlDbType.Int32).Value = idCli;

            int resp = comm.ExecuteNonQuery();

            Conexao.Fecharconexao();

            return resp;
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir?",
                "Mensagem do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                excluirClientes(Convert.ToInt32(Txt_Codigo.Text));
                MessageBox.Show("Cliente Excluido com sucesso!");
                limpar();
                DesabilitarCampos();
                Btn_Novo.Enabled = true;
                Btn_Pesquisar.Enabled = true;
                Gpb_Pesquisar.Visible = true;
            }
            else
            {
                MessageBox.Show("Operação Abortada",
                "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void Cliente_Load_1(object sender, EventArgs e)
        {

        }
    }
}

