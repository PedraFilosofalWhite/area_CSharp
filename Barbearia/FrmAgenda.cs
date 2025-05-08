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
using static Barbearia.FrmEstoque;



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
            CarregarHorarios();
            carregarFuncionarios();
            carregarServicos();
            gerarHorarios();

        }
        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            CB_horarios.SelectedIndex = -1;
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            rdbVip.Checked = false;
            Txt_Pesquisar.Clear();
            CB_Servicos.SelectedIndex = -1;
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
                string.IsNullOrWhiteSpace(CB_Servicos.Text) ||
                (!rdbCodigo.Checked && !rdbNome.Checked && !rdbVip.Checked))
            {
                MessageBox.Show("Favor preencher todos os campos!!!");
            }

            int horario = CB_horarios.SelectedIndex;
            horario = horario + 1;

            int idFuncionario = cbxFuncionarios.SelectedIndex;
            idFuncionario = idFuncionario + 1;

            int servico = CB_Servicos.SelectedIndex;
            servico = servico + 1;
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

        private void CarregarHorarios()
        {
            
            string dataSelecionada = Txt_dias.Text;
            DateTime data = DateTime.ParseExact(dataSelecionada, "d/M/yyyy", CultureInfo.InvariantCulture);
            string dataMySql = data.ToString("yyyy-MM-dd");

            CB_horarios.Items.Clear();

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT hd.idHorario,f.nomeFunc AS funcionario,CONCAT(DATE_FORMAT(hd.dataHorario, '%H:%i'),' - ',DATE_FORMAT(ADDTIME(hd.dataHorario, '00:50:00'), '%H:%i')) AS intervalo_disponivel,DATE_FORMAT(hd.dataHorario, '%d/%m/%Y') AS data_formatada FROM Horarios_Disponiveis hd JOIN Funcionarios f ON hd.idFunc = f.idFunc WHERE hd.disponivel = TRUE AND hd.idFunc = 1 AND DATE(hd.dataHorario) = @data ORDER BY hd.dataHorario;";
            
            comm.Parameters.Clear();
            comm.Parameters.Add("@data", MySqlDbType.Date).Value = data;
                
            
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR = comm.ExecuteReader();

            while (DR.Read())
            {
                CB_horarios.Items.Add(DR["intervalo_disponivel"].ToString());
            }
            Conexao.Fecharconexao();
        }

        private void carregarFuncionarios()
        {
            

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nomeFunc from funcionarios;";

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR = comm.ExecuteReader();

            while (DR.Read()){
                cbxFuncionarios.Items.Add(DR["nomeFunc"].ToString());
            }
            Conexao.Fecharconexao();
           
        }

        private void carregarServicos()
        {
            int idFuncionario = cbxFuncionarios.SelectedIndex;
            idFuncionario = idFuncionario + 1;

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select descServ from servicos;";

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR = comm.ExecuteReader();

            while (DR.Read())
            {
                CB_Servicos.Items.Add(DR["descServ"].ToString());
            }
            Conexao.Fecharconexao();
            
        }

        private void gerarHorarios()
        {
            string dataSelecionada = Txt_dias.Text;
            DateTime data = DateTime.ParseExact(dataSelecionada, "d/M/yyyy", CultureInfo.InvariantCulture);
            string dataMySql = data.ToString("yyyy-MM-dd");

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "    INSERT INTO Horarios_Disponiveis (idFunc, dataHorario, disponivel) SELECT f.idFunc,CONCAT(@data, ' ', h.horario) AS dataHorario, TRUE AS disponivel FROM Horarios_Fixos h CROSS JOIN Funcionarios f WHERE f.ativoFunc = TRUE AND NOT EXISTS ( SELECT 1 FROM Horarios_Disponiveis hd WHERE hd.idFunc = f.idFunc AND hd.dataHorario = CONCAT(@data, ' ', h.horario) );";

            comm.CommandType = CommandType.Text; 
            
            comm.Parameters.Clear();
            comm.Parameters.Add("@data", MySqlDbType.Date).Value = data ;

            int resp = comm.ExecuteNonQuery();
            Conexao.Fecharconexao();
        }
    }
}


