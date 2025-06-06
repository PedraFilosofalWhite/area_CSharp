﻿using System;
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
using MySql.Data.MySqlClient;
using Barbeariaz;

namespace Barbearia
{
    public partial class frmTela_Inicial : Form
    {
        int mes, ano;
        public static int static_mes, static_ano;
        public bool FuncionarioSelecionado => cbxFuncionarios.SelectedIndex != -1;
        public int IdFuncionarioSelecionado
        {
            get
            {
                if (cbxFuncionarios.SelectedIndex == -1)
                    return 0;
                return obterIdFunc(cbxFuncionarios.Text);
            }
        }


        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmTela_Inicial()
        {
            InitializeComponent();
            
        }
        public void voltar_login()
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void Tela_Inicial_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

            displaydays();
            carregarFuncionarios();
            int idFunc = obterIdFunc(cbxFuncionarios.Text);
        }
        private void carregarFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nomeFunc from funcionarios;";

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbxFuncionarios.Items.Add(DR["nomeFunc"].ToString());
            }
            Conexao.Fecharconexao();

        }
        public int obterIdFunc(string nomeFunc)
        {
            int idFunc = 0;
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select idFunc from funcionarios where nomeFunc = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nomeFunc;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR = comm.ExecuteReader();
            if (DR.Read())
            {
                idFunc = DR.GetInt32(0);
            }
            Conexao.Fecharconexao();
            return idFunc;
        }
        private void Menu_cliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
            this.Hide();
        }
        private void Menu_Estoque_Click(object sender, EventArgs e)
        {
            FrmEstoque estoque = new FrmEstoque();
            estoque.Show();
            this.Hide();
        }
        private void Menu_Funcionario_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.Show();
            this.Hide();
        }
        private void Menu_Financa_Click(object sender, EventArgs e)
        {
            Finança finança = new Finança();
            finança.Show();
            this.Hide();
        }
        private void Menu_Sair_Click(object sender, EventArgs e)
        {
            voltar_login();
        }
        private void displaydays()
        {
            DateTime now = DateTime.Now;

            mes = now.Month;
            ano = now.Year;

            string nomemes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            Lb_mes.Text = nomemes + " " + ano;

            static_mes = mes;
            static_ano = ano;

            // Primeiro dia do mês
            DateTime Primeirodia = new DateTime(now.Year, now.Month, 1);

            // Obter a contagem dos dias dos meses
            int dias = DateTime.DaysInMonth(now.Year, now.Month);

            //conversão para deixar inteiro 
            int primeirosdias = Convert.ToInt32(Primeirodia.DayOfWeek.ToString("D")) + 1;

            // Ultilizando o userCalendario em branco

            for (int i = 1; i < primeirosdias; i++)
            {
                UserCalendario ucBranco = new UserCalendario();
                Flp_Calendario.Controls.Add(ucBranco);
            }

            //Criação do userControl para os dias 
            for (int i = 1; i <= dias; i++)
            {
                Calendario_Dias ucDias = new Calendario_Dias();
                ucDias.Dias(i);
                Flp_Calendario.Controls.Add((ucDias));
            }


        }
        private void Btn_avançar_mes_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                mes++;

                static_mes = mes;
                static_ano = ano;


                string nomemes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);

                Lb_mes.Text = nomemes + "  " + ano;

                Flp_Calendario.Controls.Clear();

                // Primeiro dia do mês
                DateTime Primeirodia = new DateTime(ano, mes, 1);

                // Obter a contagem dos dias dos meses
                int dias = DateTime.DaysInMonth(ano, mes);

                //conversão para deixar inteiro 
                int primeirosdias = Convert.ToInt32(Primeirodia.DayOfWeek.ToString("d")) + 1;

                // Ultilizando o userCalendario em branco

                for (int i = 1; i < primeirosdias; i++)
                {
                    UserCalendario ucBranco = new UserCalendario();
                    Flp_Calendario.Controls.Add(ucBranco);
                }

                //Criação do userControl para os dias 
                for (int i = 1; i <= dias; i++)
                {
                    Calendario_Dias ucDias = new Calendario_Dias();
                    ucDias.Dias(i);
                    Flp_Calendario.Controls.Add((ucDias));
                }
            }
            catch
            {
                MessageBox.Show("Data muito extensa para o periodo atual", "Informação ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DateTime now = DateTime.Now;
                mes--;
                static_mes = mes;
                static_ano = ano;

                string nomemes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);

                Lb_mes.Text = nomemes + "   " + ano;

                Flp_Calendario.Controls.Clear();

                // Primeiro dia do mês
                DateTime Primeirodia = new DateTime(ano, mes, 1);

                // Obter a contagem dos dias dos meses
                int dias = DateTime.DaysInMonth(ano, mes);

                //conversão para deixar inteiro 
                int primeirosdias = Convert.ToInt32(Primeirodia.DayOfWeek.ToString("d")) + 1;

                // Ultilizando o userCalendario em branco

                for (int i = 1; i < primeirosdias; i++)
                {
                    UserCalendario ucBranco = new UserCalendario();
                    Flp_Calendario.Controls.Add(ucBranco);
                }

                //Criação do userControl para os dias 
                for (int i = 1; i <= dias; i++)
                {
                    Calendario_Dias ucDias = new Calendario_Dias();
                    ucDias.Dias(i);
                    Flp_Calendario.Controls.Add((ucDias));
                }
                return;
            }
        }
        private void Btn_retornar_Click(object sender, EventArgs e)
        {


            try
            {
                DateTime now = DateTime.Now;
                mes--;
                string nomemes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);

                Lb_mes.Text = nomemes + "   " + ano;

                Flp_Calendario.Controls.Clear();

                // Primeiro dia do mês
                DateTime Primeirodia = new DateTime(ano, mes, 1);

                // Obter a contagem dos dias dos meses
                int dias = DateTime.DaysInMonth(ano, mes);

                //conversão para deixar inteiro 
                int primeirosdias = Convert.ToInt32(Primeirodia.DayOfWeek.ToString("d")) + 1;

                // Ultilizando o userCalendario em branco

                for (int i = 1; i < primeirosdias; i++)
                {
                    UserCalendario ucBranco = new UserCalendario();
                    Flp_Calendario.Controls.Add(ucBranco);
                }

                //Criação do userControl para os dias 
                for (int i = 1; i <= dias; i++)
                {
                    Calendario_Dias ucDias = new Calendario_Dias();
                    ucDias.Dias(i);
                    Flp_Calendario.Controls.Add((ucDias));
                }
            }
            catch
            {
                DateTime now = DateTime.Now;
                mes++;
                string nomemes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);

                Lb_mes.Text = nomemes + "   " + ano;

                Flp_Calendario.Controls.Clear();

                // Primeiro dia do mês
                DateTime Primeirodia = new DateTime(ano, mes, 1);

                // Obter a contagem dos dias dos meses
                int dias = DateTime.DaysInMonth(ano, mes);

                //conversão para deixar inteiro 
                int primeirosdias = Convert.ToInt32(Primeirodia.DayOfWeek.ToString("d")) + 1;

                // Ultilizando o userCalendario em branco

                for (int i = 1; i < primeirosdias; i++)
                {
                    UserCalendario ucBranco = new UserCalendario();
                    Flp_Calendario.Controls.Add(ucBranco);
                }

                //Criação do userControl para os dias 
                for (int i = 1; i <= dias; i++)
                {
                    Calendario_Dias ucDias = new Calendario_Dias();
                    ucDias.Dias(i);
                    Flp_Calendario.Controls.Add((ucDias));
                }

            }
        }
    }
} 

