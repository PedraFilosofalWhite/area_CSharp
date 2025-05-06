namespace Barbearia
{
    partial class frmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            label1 = new Label();
            lbl_PeriodoDe = new Label();
            panel1 = new Panel();
            Dgv_Pesquisar_cliente = new DataGridView();
            Txt_dias = new TextBox();
            Btn_Procurar = new Button();
            CB_Serviços = new ComboBox();
            label4 = new Label();
            CB_horarios = new ComboBox();
            label3 = new Label();
            Txt_Pesquisar = new TextBox();
            label2 = new Label();
            rdbVip = new RadioButton();
            rdbCodigo = new RadioButton();
            rdbNome = new RadioButton();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            Btn_limpar = new Button();
            Btn_Agendar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Pesquisar_cliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial Rounded MT Bold", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(624, 32);
            label1.TabIndex = 1;
            label1.Text = "Agendamento ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_PeriodoDe
            // 
            lbl_PeriodoDe.Font = new Font("Arial Rounded MT Bold", 12F);
            lbl_PeriodoDe.Location = new Point(101, 43);
            lbl_PeriodoDe.Name = "lbl_PeriodoDe";
            lbl_PeriodoDe.Size = new Size(282, 18);
            lbl_PeriodoDe.TabIndex = 26;
            lbl_PeriodoDe.Text = "Dia do Agendamento :";
            lbl_PeriodoDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(Dgv_Pesquisar_cliente);
            panel1.Controls.Add(Txt_dias);
            panel1.Controls.Add(Btn_Procurar);
            panel1.Controls.Add(CB_Serviços);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CB_horarios);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Txt_Pesquisar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(rdbVip);
            panel1.Controls.Add(rdbCodigo);
            panel1.Controls.Add(rdbNome);
            panel1.Controls.Add(lbl_PeriodoDe);
            panel1.Location = new Point(68, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 526);
            panel1.TabIndex = 28;
            // 
            // Dgv_Pesquisar_cliente
            // 
            Dgv_Pesquisar_cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Pesquisar_cliente.Location = new Point(16, 325);
            Dgv_Pesquisar_cliente.Name = "Dgv_Pesquisar_cliente";
            Dgv_Pesquisar_cliente.Size = new Size(449, 50);
            Dgv_Pesquisar_cliente.TabIndex = 39;
            // 
            // Txt_dias
            // 
            Txt_dias.Enabled = false;
            Txt_dias.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_dias.Location = new Point(101, 64);
            Txt_dias.Name = "Txt_dias";
            Txt_dias.Size = new Size(282, 45);
            Txt_dias.TabIndex = 32;
            Txt_dias.TextAlign = HorizontalAlignment.Center;
            // 
            // Btn_Procurar
            // 
            Btn_Procurar.Location = new Point(14, 381);
            Btn_Procurar.Name = "Btn_Procurar";
            Btn_Procurar.Size = new Size(107, 32);
            Btn_Procurar.TabIndex = 38;
            Btn_Procurar.Text = "Procurar";
            Btn_Procurar.UseVisualStyleBackColor = true;
            // 
            // CB_Serviços
            // 
            CB_Serviços.FormattingEnabled = true;
            CB_Serviços.Location = new Point(15, 464);
            CB_Serviços.Name = "CB_Serviços";
            CB_Serviços.Size = new Size(452, 26);
            CB_Serviços.TabIndex = 36;
            CB_Serviços.KeyDown += CB_Serviços_KeyDown;
            CB_Serviços.KeyPress += CB_Serviços_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 432);
            label4.Name = "label4";
            label4.Size = new Size(78, 18);
            label4.TabIndex = 35;
            label4.Text = "Serviços";
            // 
            // CB_horarios
            // 
            CB_horarios.FormattingEnabled = true;
            CB_horarios.Items.AddRange(new object[] { "05:00 - 05:50  ", "05:50 - 06:40  ", "06:40 - 07:30  ", "07:30 - 08:20  ", "08:20 - 09:10  ", "09:10 - 10:00  ", "10:00 - 10:50  ", "10:50 - 11:40  ", "11:40 - 12:30  ", "12:30 - 13:20  ", "13:20 - 14:10  ", "14:10 - 15:00  ", "15:00 - 15:50  ", "15:50 - 16:40  ", "16:40 - 17:30  ", "17:30 - 18:20  ", "18:20 - 19:10  ", "19:10 - 20:00  ", "20:00 - 20:50  ", "20:50 - 21:40  ", "21:40 - 22:30  ", "22:30 - 23:20" });
            CB_horarios.Location = new Point(16, 164);
            CB_horarios.Name = "CB_horarios";
            CB_horarios.Size = new Size(451, 26);
            CB_horarios.TabIndex = 34;
            CB_horarios.KeyDown += CB_horarios_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 143);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 33;
            label3.Text = "Horario :";
            // 
            // Txt_Pesquisar
            // 
            Txt_Pesquisar.Location = new Point(16, 293);
            Txt_Pesquisar.MaxLength = 50;
            Txt_Pesquisar.Name = "Txt_Pesquisar";
            Txt_Pesquisar.Size = new Size(451, 26);
            Txt_Pesquisar.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 231);
            label2.Name = "label2";
            label2.Size = new Size(161, 18);
            label2.TabIndex = 31;
            label2.Text = "Pesquisar Cliente  :";
            // 
            // rdbVip
            // 
            rdbVip.AutoSize = true;
            rdbVip.Font = new Font("Arial Rounded MT Bold", 12F);
            rdbVip.Location = new Point(298, 265);
            rdbVip.Name = "rdbVip";
            rdbVip.Size = new Size(51, 22);
            rdbVip.TabIndex = 30;
            rdbVip.TabStop = true;
            rdbVip.Text = "Vip";
            rdbVip.UseVisualStyleBackColor = true;
            // 
            // rdbCodigo
            // 
            rdbCodigo.AutoSize = true;
            rdbCodigo.Font = new Font("Arial Rounded MT Bold", 12F);
            rdbCodigo.Location = new Point(170, 265);
            rdbCodigo.Name = "rdbCodigo";
            rdbCodigo.Size = new Size(82, 22);
            rdbCodigo.TabIndex = 29;
            rdbCodigo.TabStop = true;
            rdbCodigo.Text = "Código";
            rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            rdbNome.AutoSize = true;
            rdbNome.Font = new Font("Arial Rounded MT Bold", 12F);
            rdbNome.Location = new Point(65, 265);
            rdbNome.Name = "rdbNome";
            rdbNome.Size = new Size(72, 22);
            rdbNome.TabIndex = 28;
            rdbNome.TabStop = true;
            rdbNome.Text = "Nome";
            rdbNome.UseVisualStyleBackColor = true;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Btn_limpar
            // 
            Btn_limpar.Location = new Point(249, 590);
            Btn_limpar.Name = "Btn_limpar";
            Btn_limpar.Size = new Size(175, 75);
            Btn_limpar.TabIndex = 30;
            Btn_limpar.Text = "Limpar";
            Btn_limpar.UseVisualStyleBackColor = true;
            Btn_limpar.Click += Btn_limpar_Click;
            // 
            // Btn_Agendar
            // 
            Btn_Agendar.Location = new Point(68, 590);
            Btn_Agendar.Name = "Btn_Agendar";
            Btn_Agendar.Size = new Size(175, 75);
            Btn_Agendar.TabIndex = 31;
            Btn_Agendar.Text = "Agendar";
            Btn_Agendar.UseVisualStyleBackColor = true;
            Btn_Agendar.Click += Btn_Agendar_Click;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 677);
            Controls.Add(Btn_Agendar);
            Controls.Add(Btn_limpar);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendamento";
            Load += Agenda_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Pesquisar_cliente).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label lbl_PeriodoDe;
        private Panel panel1;
        private Label label2;
        private RadioButton rdbCodigo;
        private RadioButton rdbNome;
        private TextBox Txt_Pesquisar;
        private RadioButton rdbVip;
        private Label label3;
        private ComboBox CB_horarios;
        private ComboBox CB_Serviços;
        private Label label4;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button Btn_Procurar;
        private Button Btn_limpar;
        private Button Btn_Agendar;
        private TextBox Txt_dias;
        private DataGridView Dgv_Pesquisar_cliente;
    }
}