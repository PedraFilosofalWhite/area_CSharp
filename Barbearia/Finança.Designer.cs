namespace Barbearia
{
    partial class Finança
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_Voltar = new Button();
            lb_Ordens_de_serv = new Label();
            lbl_PeriodoDe = new Label();
            lbl_Ate = new Label();
            lbl_Entradas = new Label();
            lbl_Saldo = new Label();
            dtp_PeriodoDe = new DateTimePicker();
            dtp_Ate = new DateTimePicker();
            gpb_ResumoFinanceiro = new GroupBox();
            Txt_Projetivo = new TextBox();
            label2 = new Label();
            txb_Saldo = new TextBox();
            txb_Entradas = new TextBox();
            lb_Informacoes = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            panel1 = new Panel();
            Txt_ProdVendidos = new TextBox();
            label4 = new Label();
            Txt_QuantCliente = new TextBox();
            label3 = new Label();
            Txt__ServPrestado = new TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            button1 = new Button();
            gpb_ResumoFinanceiro.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.Font = new Font("Arial Rounded MT Bold", 12F);
            Btn_Voltar.Location = new Point(1073, 599);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(175, 75);
            Btn_Voltar.TabIndex = 10;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.UseVisualStyleBackColor = true;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // lb_Ordens_de_serv
            // 
            lb_Ordens_de_serv.AutoSize = true;
            lb_Ordens_de_serv.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Ordens_de_serv.Location = new Point(33, 18);
            lb_Ordens_de_serv.Name = "lb_Ordens_de_serv";
            lb_Ordens_de_serv.Size = new Size(293, 33);
            lb_Ordens_de_serv.TabIndex = 20;
            lb_Ordens_de_serv.Text = "Ordens de Serviços";
            // 
            // lbl_PeriodoDe
            // 
            lbl_PeriodoDe.AutoSize = true;
            lbl_PeriodoDe.Font = new Font("Arial Rounded MT Bold", 12F);
            lbl_PeriodoDe.Location = new Point(14, 74);
            lbl_PeriodoDe.Name = "lbl_PeriodoDe";
            lbl_PeriodoDe.Size = new Size(105, 18);
            lbl_PeriodoDe.TabIndex = 22;
            lbl_PeriodoDe.Text = "Período - De";
            // 
            // lbl_Ate
            // 
            lbl_Ate.AutoSize = true;
            lbl_Ate.Font = new Font("Arial Rounded MT Bold", 12F);
            lbl_Ate.Location = new Point(266, 73);
            lbl_Ate.Name = "lbl_Ate";
            lbl_Ate.Size = new Size(36, 18);
            lbl_Ate.TabIndex = 23;
            lbl_Ate.Text = "Até";
            // 
            // lbl_Entradas
            // 
            lbl_Entradas.AutoSize = true;
            lbl_Entradas.Location = new Point(19, 35);
            lbl_Entradas.Name = "lbl_Entradas";
            lbl_Entradas.Size = new Size(86, 18);
            lbl_Entradas.TabIndex = 24;
            lbl_Entradas.Text = "Entradas:";
            // 
            // lbl_Saldo
            // 
            lbl_Saldo.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Saldo.Location = new Point(-2, 158);
            lbl_Saldo.Name = "lbl_Saldo";
            lbl_Saldo.Size = new Size(355, 32);
            lbl_Saldo.TabIndex = 25;
            lbl_Saldo.Text = "Saldo:";
            lbl_Saldo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtp_PeriodoDe
            // 
            dtp_PeriodoDe.Font = new Font("Arial Rounded MT Bold", 12F);
            dtp_PeriodoDe.Format = DateTimePickerFormat.Short;
            dtp_PeriodoDe.Location = new Point(123, 70);
            dtp_PeriodoDe.Name = "dtp_PeriodoDe";
            dtp_PeriodoDe.Size = new Size(133, 26);
            dtp_PeriodoDe.TabIndex = 1;
            // 
            // dtp_Ate
            // 
            dtp_Ate.Font = new Font("Arial Rounded MT Bold", 12F);
            dtp_Ate.Format = DateTimePickerFormat.Short;
            dtp_Ate.Location = new Point(305, 70);
            dtp_Ate.Name = "dtp_Ate";
            dtp_Ate.Size = new Size(135, 26);
            dtp_Ate.TabIndex = 2;
            // 
            // gpb_ResumoFinanceiro
            // 
            gpb_ResumoFinanceiro.Controls.Add(Txt_Projetivo);
            gpb_ResumoFinanceiro.Controls.Add(label2);
            gpb_ResumoFinanceiro.Controls.Add(txb_Saldo);
            gpb_ResumoFinanceiro.Controls.Add(txb_Entradas);
            gpb_ResumoFinanceiro.Controls.Add(lbl_Saldo);
            gpb_ResumoFinanceiro.Controls.Add(lbl_Entradas);
            gpb_ResumoFinanceiro.Font = new Font("Arial Rounded MT Bold", 12F);
            gpb_ResumoFinanceiro.Location = new Point(14, 124);
            gpb_ResumoFinanceiro.Name = "gpb_ResumoFinanceiro";
            gpb_ResumoFinanceiro.Size = new Size(353, 318);
            gpb_ResumoFinanceiro.TabIndex = 28;
            gpb_ResumoFinanceiro.TabStop = false;
            gpb_ResumoFinanceiro.Text = "Resumo Financeiro";
            // 
            // Txt_Projetivo
            // 
            Txt_Projetivo.Location = new Point(121, 89);
            Txt_Projetivo.Name = "Txt_Projetivo";
            Txt_Projetivo.Size = new Size(176, 26);
            Txt_Projetivo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 92);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 32;
            label2.Text = "Projetivo :";
            // 
            // txb_Saldo
            // 
            txb_Saldo.Location = new Point(84, 193);
            txb_Saldo.Name = "txb_Saldo";
            txb_Saldo.Size = new Size(176, 26);
            txb_Saldo.TabIndex = 5;
            txb_Saldo.TextChanged += txb_Saldo_TextChanged;
            // 
            // txb_Entradas
            // 
            txb_Entradas.Location = new Point(121, 27);
            txb_Entradas.Name = "txb_Entradas";
            txb_Entradas.Size = new Size(176, 26);
            txb_Entradas.TabIndex = 3;
            // 
            // lb_Informacoes
            // 
            lb_Informacoes.AutoSize = true;
            lb_Informacoes.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Informacoes.Location = new Point(550, 18);
            lb_Informacoes.Name = "lb_Informacoes";
            lb_Informacoes.Size = new Size(357, 33);
            lb_Informacoes.TabIndex = 30;
            lb_Informacoes.Text = "Informações Adicionais ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 20);
            label1.Name = "label1";
            label1.Size = new Size(172, 18);
            label1.TabIndex = 0;
            label1.Text = "Serviços prestados :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Txt_ProdVendidos);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Txt_QuantCliente);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Txt__ServPrestado);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(510, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 156);
            panel1.TabIndex = 6;
            // 
            // Txt_ProdVendidos
            // 
            Txt_ProdVendidos.Location = new Point(252, 108);
            Txt_ProdVendidos.Name = "Txt_ProdVendidos";
            Txt_ProdVendidos.Size = new Size(166, 26);
            Txt_ProdVendidos.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 108);
            label4.Name = "label4";
            label4.Size = new Size(166, 18);
            label4.TabIndex = 4;
            label4.Text = "Produtos vendidos :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txt_QuantCliente
            // 
            Txt_QuantCliente.Location = new Point(252, 59);
            Txt_QuantCliente.Name = "Txt_QuantCliente";
            Txt_QuantCliente.Size = new Size(166, 26);
            Txt_QuantCliente.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 67);
            label3.Name = "label3";
            label3.Size = new Size(201, 18);
            label3.TabIndex = 2;
            label3.Text = "Quantidade de clientes :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txt__ServPrestado
            // 
            Txt__ServPrestado.Location = new Point(252, 17);
            Txt__ServPrestado.Name = "Txt__ServPrestado";
            Txt__ServPrestado.Size = new Size(166, 26);
            Txt__ServPrestado.TabIndex = 7;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 12F);
            button1.Location = new Point(14, 465);
            button1.Name = "button1";
            button1.Size = new Size(175, 75);
            button1.TabIndex = 31;
            button1.Text = "Visualiazar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Finança
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 677);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(lb_Informacoes);
            Controls.Add(gpb_ResumoFinanceiro);
            Controls.Add(dtp_Ate);
            Controls.Add(dtp_PeriodoDe);
            Controls.Add(lbl_Ate);
            Controls.Add(lbl_PeriodoDe);
            Controls.Add(lb_Ordens_de_serv);
            Controls.Add(Btn_Voltar);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "Finança";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Finança";
            gpb_ResumoFinanceiro.ResumeLayout(false);
            gpb_ResumoFinanceiro.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Voltar;
        private Label lb_Ordens_de_serv;
        private Label lbl_PeriodoDe;
        private Label lbl_Ate;
        private Label lbl_Entradas;
        private Label lbl_Saldo;
        private DateTimePicker dtp_PeriodoDe;
        private DateTimePicker dtp_Ate;
        private GroupBox gpb_ResumoFinanceiro;
        private TextBox txb_Saldo;
        private TextBox txb_Entradas;
        private Label label2;
        private TextBox Txt_Projetivo;
        private Label lb_Informacoes;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private TextBox Txt_ProdVendidos;
        private Label label4;
        private TextBox Txt_QuantCliente;
        private Label label3;
        private TextBox Txt__ServPrestado;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button button1;
    }
}