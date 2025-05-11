using Barbeariaz;
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

namespace Barbearia
{
    public partial class frmVisualizarAgenda : Form
    {
        DateTime _Dia;

        public frmVisualizarAgenda(DateTime dia)
        {
            InitializeComponent();
            _Dia = dia;
        }
        private void frmVisualizarAgenda_Load(object sender, EventArgs e)
        {
            frmTela_Inicial telaPrincipal = Application.OpenForms.OfType<frmTela_Inicial>().LastOrDefault();
            int idFunc = telaPrincipal.IdFuncionarioSelecionado;
            CarregarAgendamentosNoGrid(dgvVizualizarAgenda, idFunc);
        }
        public void CarregarAgendamentosNoGrid(DataGridView dataGridView, int idFuncionario)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = @"
                    SELECT 
    TIME(hd.dataHorario) AS Horarios,
    CASE 
        WHEN hd.disponivel = TRUE AND a.idAgendamento IS NULL THEN 'Disponível'
        WHEN a.statusAgendamento = 'agendado' THEN 'Agendado'
        WHEN a.statusAgendamento = 'concluido' THEN 'Concluído'
        WHEN a.statusAgendamento = 'cancelado' THEN 'Cancelado'
        WHEN a.statusAgendamento = 'falta' THEN 'Falta'
        ELSE ''
    END AS Status,
    CONCAT(
        DATE_FORMAT(hd.dataHorario, '%d/%m'), ' - ',
        CASE 
            WHEN DAYOFWEEK(hd.dataHorario) = 1 THEN 'Domingo'
            WHEN DAYOFWEEK(hd.dataHorario) = 2 THEN 'Segunda'
            WHEN DAYOFWEEK(hd.dataHorario) = 3 THEN 'Terça'
            WHEN DAYOFWEEK(hd.dataHorario) = 4 THEN 'Quarta'
            WHEN DAYOFWEEK(hd.dataHorario) = 5 THEN 'Quinta'
            WHEN DAYOFWEEK(hd.dataHorario) = 6 THEN 'Sexta'
            WHEN DAYOFWEEK(hd.dataHorario) = 7 THEN 'Sábado'
        END
    ) AS Data_da_Semana,
    IFNULL(c.nomeCli, '') AS Cliente,
    IFNULL(s.descServ, '') AS Servico,
    f.nomeFunc AS Funcionario
FROM 
    Horarios_Disponiveis hd
JOIN 
    Funcionarios f ON hd.idFunc = f.idFunc
LEFT JOIN 
    Agendamentos a ON hd.dataHorario = a.dataAgendamento AND f.idFunc = a.idFunc
LEFT JOIN 
    Clientes c ON a.idCli = c.idCli
LEFT JOIN 
    Detalhes_Agendamentos da ON a.idAgendamento = da.idAgendamento
LEFT JOIN 
    Servicos s ON da.idServ = s.idServ
WHERE 
    DATE(hd.dataHorario) = @dataFiltro
    AND f.ativoFunc = TRUE
    AND f.idFunc = @idFuncionario
ORDER BY 
    hd.dataHorario;";

            comm.CommandType = CommandType.Text;

            comm.Parameters.Add("@idFuncionario", MySqlDbType.Int32).Value = idFuncionario;
            comm.Parameters.Add("@dataFiltro", MySqlDbType.Date).Value = _Dia.Date;
            comm.Connection = Conexao.obterConexao();

            MySqlDataAdapter adapter = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView.DataSource = dt;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Conexao.Fecharconexao();
        }
    }
}

