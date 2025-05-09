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

        private int _idFunc;

        public void tela_inicial()
        {
            frmTela_Inicial tela_Inicial = new frmTela_Inicial();
            tela_Inicial.Show();
            this.Hide();
        }
        public frmAgenda(int idFunc)
        {
            InitializeComponent();
            _idFunc = idFunc;
            Rb_Nao.Checked = true;
            Txt_dias.Text = Calendario_Dias.static_dia + "/" + frmTela_Inicial.static_mes + "/" + frmTela_Inicial.static_ano;

            // Limpa todos os controles antes de recarregar
            LimparCampos();

            // Recarrega os dados com o novo idFunc
            gerarHorarios();
            carregarFuncionarios();
            carregarServicos();
            CarregarHorarios();
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


        }
        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void CB_horarios_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        private void Btn_Agendar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CB_horarios.Text))
            {
                MessageBox.Show("Selecione um horário disponível!");
                return;
            }

            if (string.IsNullOrWhiteSpace(cbxFuncionarios.Text))
            {
                MessageBox.Show("Selecione um barbeiro!");
                return;
            }

            if (ltbPesquisar.SelectedItem == null && string.IsNullOrWhiteSpace(Txt_Pesquisar.Text))
            {
                MessageBox.Show("Pesquise e selecione um cliente!");
                return;
            }

            if (string.IsNullOrWhiteSpace(CB_Servicos.Text))
            {
                MessageBox.Show("Selecione um serviço!");
                return;
            }

            try
            {
                string nomeCliente = ltbPesquisar.SelectedItem.ToString();
                string intervaloHorario = CB_horarios.Text;
                string horarioSelecionado = intervaloHorario.Split('-')[0].Trim();
                string servicoSelecionado = CB_Servicos.Text;
                string funcionarioSelecionado = cbxFuncionarios.Text;

                DateTime data = DateTime.ParseExact(Txt_dias.Text, "d/M/yyyy", CultureInfo.InvariantCulture);
                TimeSpan hora = TimeSpan.ParseExact(horarioSelecionado, "hh\\:mm", CultureInfo.InvariantCulture);
                DateTime dataHoraAgendamento = data.Date + hora;

                int idCliente = obterIdCliente(nomeCliente);
                int idFuncionario = _idFunc;
                int idServico = obterIdServ(servicoSelecionado);

                if (Agendar(idServico, idCliente, dataHoraAgendamento))
                {
                    MessageBox.Show("Agendamento realizado com sucesso!");
                    LimparCampos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao agendar: {ex.Message}");
            }

        }
        public void pesquisarPorNome(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Por favor, informe um nome para pesquisa");
                return;
            }

            ltbPesquisar.Items.Clear();

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
                        ltbPesquisar.Items.Add(DR.GetString(0));
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

            ltbPesquisar.Items.Clear();

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
                        ltbPesquisar.Items.Add(DR.GetString(0));
                    }
                }
            }
        }
        public void pesquisarPorCodigo(string descricao)
        {
            if (!int.TryParse(descricao, out int idCliente))
            {
                MessageBox.Show("Código inválido. Informe um número válido.");
                Txt_Pesquisar.Clear();
                Txt_Pesquisar.Focus();
                return;
            }

            ltbPesquisar.Items.Clear();

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
                        ltbPesquisar.Items.Add(DR.GetString(0));
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado");
                        Txt_Pesquisar.Clear();
                        Txt_Pesquisar.Focus();
                    }
                }
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
        private void CarregarHorarios()
        {

            string dataSelecionada = Txt_dias.Text;
            DateTime data = DateTime.ParseExact(dataSelecionada, "d/M/yyyy", CultureInfo.InvariantCulture);
            string dataMySql = data.ToString("yyyy-MM-dd");

            CB_horarios.Items.Clear();

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT hd.idHorario,f.nomeFunc AS funcionario,CONCAT(DATE_FORMAT(hd.dataHorario, '%H:%i'),' - ',DATE_FORMAT(ADDTIME(hd.dataHorario, '00:50:00'), '%H:%i')) AS intervalo_disponivel,DATE_FORMAT(hd.dataHorario, '%d/%m/%Y') AS data_formatada FROM horarios_disponiveis hd JOIN Funcionarios f ON hd.idFunc = f.idFunc WHERE hd.disponivel = TRUE AND f.idFunc = @idFunc AND f.ativoFunc = true AND DATE(hd.dataHorario) = @data ORDER BY hd.dataHorario;";

            comm.Parameters.Clear();
            comm.Parameters.Add("@data", MySqlDbType.Date).Value = data;
            comm.Parameters.Add("@idFunc", MySqlDbType.Int32).Value = _idFunc;


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
            cbxFuncionarios.Items.Clear(); // Limpa antes de adicionar

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT nomeFunc FROM funcionarios WHERE idFunc = @idFunc;";
            comm.Parameters.Clear();
            comm.Parameters.Add("@idFunc", MySqlDbType.Int32).Value = _idFunc;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbxFuncionarios.Items.Add(DR["nomeFunc"].ToString());
            }

            // Seleciona automaticamente o funcionário
            if (cbxFuncionarios.Items.Count > 0)
            {
                cbxFuncionarios.SelectedIndex = 0;
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

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = @"INSERT INTO Horarios_Disponiveis (idFunc, dataHorario, disponivel) 
            SELECT @idFunc, 
                   TIMESTAMP(@data, h.horario) AS dataHorario, 
                   TRUE AS disponivel 
            FROM Horarios_Fixos h 
            WHERE NOT EXISTS (
                SELECT 1 
                FROM Horarios_Disponiveis hd 
                WHERE hd.idFunc = @idFunc 
                AND hd.dataHorario = TIMESTAMP(@data, h.horario)
            );";

            comm.Parameters.Clear();
            comm.Parameters.Add("@data", MySqlDbType.Date).Value = data;
            comm.Parameters.Add("@idFunc", MySqlDbType.Int32).Value = _idFunc;

            comm.Connection = Conexao.obterConexao();
            comm.ExecuteNonQuery();
            Conexao.Fecharconexao();
        }
        private void Btn_Procurar_Click(object sender, EventArgs e)
        {
            ltbPesquisar.Visible = true;
            if (rdbCodigo.Checked)
            {
                pesquisarPorCodigo((Txt_Pesquisar.Text));
            }
            else if (rdbNome.Checked)
            {
                pesquisarPorNome(Txt_Pesquisar.Text);
            }
            else if (rdbVip.Checked)
            {
                pesquisarVip(Txt_Pesquisar.Text);
            }
        }
        public int obterIdServ(string descServ)
        {
            int idProd = 0;
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select idServ from servicos where descServ = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = descServ;

            comm.Connection = Conexao.obterConexao();
            comm.ExecuteNonQuery();

            MySqlDataReader DR = comm.ExecuteReader();

            if (DR.Read())
            {
                idProd = DR.GetInt32(0);
            }


            return idProd;

        }
        public int obterIdCliente(string nomeClie)
        {
            int idClie = 0;
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select idCli from clientes where nomeCli = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nomeClie;

            comm.Connection = Conexao.obterConexao();
            comm.ExecuteNonQuery();

            MySqlDataReader DR = comm.ExecuteReader();

            if (DR.Read())
            {
                idClie = DR.GetInt32(0);
            }


            return idClie;

        }
        public bool Agendar(int idServ, int idCliente, DateTime dataHora)
        {
            MySqlConnection conn = Conexao.obterConexao();

            MySqlTransaction transaction = conn.BeginTransaction();
            {
                try
                {
                    // 1. Inserir o agendamento principal
                    MySqlCommand comm = new MySqlCommand();
                    comm.Connection = conn;
                    comm.Transaction = transaction;

                    comm.CommandText = @"INSERT INTO Agendamentos 
                            (dataAgendamento, idCli, idFunc, statusAgendamento) 
                            VALUES (@dataHora, @idCliente,@idFunc, 'agendado');
                            SELECT LAST_INSERT_ID();";
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@dataHora", dataHora);
                    comm.Parameters.AddWithValue("@idCliente", idCliente);
                    comm.Parameters.AddWithValue("@idFunc", _idFunc);

                    int idAgendamento = Convert.ToInt32(comm.ExecuteScalar());

                    comm.CommandText = @"INSERT INTO Detalhes_Agendamentos 
                            (idAgendamento, idServ, idProd, qtdServicoAgendamento, 
                             qtdProdutoAgendamento, subtotalDetalhe)
                            SELECT @idAgendamento, @idServ, 
                                   CASE WHEN @idProd > 0 THEN @idProd ELSE NULL END, 
                                   1, 
                                   CASE WHEN @idProd > 0 THEN @quantidade ELSE 0 END, 
                                   valorServ 
                            FROM Servicos WHERE idServ = @idServ";

                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@idAgendamento", idAgendamento);
                    comm.Parameters.AddWithValue("@idServ", idServ);

                    // Verifica se há produto selecionado
                    int idProduto = 0;
                    int quantidade = 0;

                    if (Rb_Sim.Checked && !string.IsNullOrWhiteSpace(Txt_Pesquisa_prod.Text))
                    {
                        idProduto = obterIdProduto(Txt_Pesquisa_prod.Text);
                        quantidade = (int)Nup_Quantidade.Value;
                    }

                    comm.Parameters.AddWithValue("@idProd", idProduto);
                    comm.Parameters.AddWithValue("@quantidade", quantidade);
                    comm.ExecuteNonQuery();

                    // 3. Atualizar valores totais
                    comm.CommandText = @"UPDATE Agendamentos 
                               SET valorTotalAgendamento = (
                                   SELECT SUM(subtotalDetalhe) 
                                   FROM Detalhes_Agendamentos 
                                   WHERE idAgendamento = @idAgendamento
                               ),
                               sinalAgendamento = (
                                   SELECT SUM(subtotalDetalhe) * 0.5
                                   FROM Detalhes_Agendamentos 
                                   WHERE idAgendamento = @idAgendamento
                               )
                               WHERE idAgendamento = @idAgendamento";

                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@idAgendamento", idAgendamento);
                    comm.ExecuteNonQuery();

                    // 4. Marcar horário como indisponível
                    comm.CommandText = "UPDATE Horarios_Disponiveis SET disponivel = FALSE WHERE dataHorario = @dataHora AND idFunc = @idFunc";
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@dataHora", dataHora);
                    comm.Parameters.AddWithValue("@idFunc", _idFunc);
                    comm.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Erro na transação: {ex.Message} Verifique se todos os produtos e serviços estão cadastrados corretamente.");
                    return false;
                }

            }
        }
        public int obterIdProduto(string nomeProduto)
        {
            int idProd = 0;
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT idProd FROM Produtos WHERE nomeProd = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nomeProduto;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR = comm.ExecuteReader();
            if (DR.Read())
            {
                idProd = DR.GetInt32(0);
            }
            Conexao.Fecharconexao();

            return idProd;
        }
        private void LimparCampos()
        {
            CB_horarios.Items.Clear();
            CB_horarios.SelectedIndex = -1;
            CB_Servicos.Items.Clear();
            CB_Servicos.SelectedIndex = -1;
            cbxFuncionarios.Items.Clear();
            cbxFuncionarios.SelectedIndex = -1;
            ltbPesquisar.Items.Clear();
            Txt_Pesquisar.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            rdbVip.Checked = false;
            Rb_Nao.Checked = true;
            Txt_Pesquisa_prod.Clear();
            Nup_Quantidade.Value = 0;
        }
        private void CB_Servicos_KeyDown_1(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_Pesquisar.Text = ltbPesquisar.SelectedItem.ToString();
            ltbPesquisar.Visible = false;
        }
    }
}


