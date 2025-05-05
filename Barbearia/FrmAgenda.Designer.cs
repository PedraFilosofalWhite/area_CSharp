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
            Bt_Sair_agenda = new Button();
            label1 = new Label();
            lbl_PeriodoDe = new Label();
            panel1 = new Panel();
            button2 = new Button();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            monthCalendar1 = new MonthCalendar();
            textBox1 = new TextBox();
            label2 = new Label();
            rdbVip = new RadioButton();
            rdbCodigo = new RadioButton();
            rdbNome = new RadioButton();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            button1 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Bt_Sair_agenda
            // 
            Bt_Sair_agenda.Location = new Point(1073, 590);
            Bt_Sair_agenda.Name = "Bt_Sair_agenda";
            Bt_Sair_agenda.Size = new Size(175, 75);
            Bt_Sair_agenda.TabIndex = 0;
            Bt_Sair_agenda.Text = "Sair";
            Bt_Sair_agenda.UseVisualStyleBackColor = true;
            Bt_Sair_agenda.Click += Bt_Sair_agenda_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(214, 32);
            label1.TabIndex = 1;
            label1.Text = "Agendamento ";
            // 
            // lbl_PeriodoDe
            // 
            lbl_PeriodoDe.AutoSize = true;
            lbl_PeriodoDe.Font = new Font("Arial Rounded MT Bold", 12F);
            lbl_PeriodoDe.Location = new Point(9, 17);
            lbl_PeriodoDe.Name = "lbl_PeriodoDe";
            lbl_PeriodoDe.Size = new Size(183, 18);
            lbl_PeriodoDe.TabIndex = 26;
            lbl_PeriodoDe.Text = "Dia do Agendamento :";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(rdbVip);
            panel1.Controls.Add(rdbCodigo);
            panel1.Controls.Add(rdbNome);
            panel1.Controls.Add(lbl_PeriodoDe);
            panel1.Location = new Point(12, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 526);
            panel1.TabIndex = 28;
            // 
            // button2
            // 
            button2.Location = new Point(16, 396);
            button2.Name = "button2";
            button2.Size = new Size(107, 32);
            button2.TabIndex = 38;
            button2.Text = "Procurar";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(18, 479);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(452, 26);
            comboBox2.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 447);
            label4.Name = "label4";
            label4.Size = new Size(78, 18);
            label4.TabIndex = 35;
            label4.Text = "Serviços";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "05:00 - 05:50  ", "05:50 - 06:40  ", "06:40 - 07:30  ", "07:30 - 08:20  ", "08:20 - 09:10  ", "09:10 - 10:00  ", "10:00 - 10:50  ", "10:50 - 11:40  ", "11:40 - 12:30  ", "12:30 - 13:20  ", "13:20 - 14:10  ", "14:10 - 15:00  ", "15:00 - 15:50  ", "15:50 - 16:40  ", "16:40 - 17:30  ", "17:30 - 18:20  ", "18:20 - 19:10  ", "19:10 - 20:00  ", "20:00 - 20:50  ", "20:50 - 21:40  ", "21:40 - 22:30  ", "22:30 - 23:20" });
            comboBox1.Location = new Point(16, 246);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(451, 26);
            comboBox1.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 225);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 33;
            label3.Text = "Horario :";
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(2, 1);
            monthCalendar1.Location = new Point(9, 44);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 364);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(451, 26);
            textBox1.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 302);
            label2.Name = "label2";
            label2.Size = new Size(161, 18);
            label2.TabIndex = 31;
            label2.Text = "Pesquisar Cliente  :";
            // 
            // rdbVip
            // 
            rdbVip.AutoSize = true;
            rdbVip.Font = new Font("Arial Rounded MT Bold", 12F);
            rdbVip.Location = new Point(300, 336);
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
            rdbCodigo.Location = new Point(172, 336);
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
            rdbNome.Location = new Point(67, 336);
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
            // button1
            // 
            button1.Location = new Point(892, 590);
            button1.Name = "button1";
            button1.Size = new Size(175, 75);
            button1.TabIndex = 30;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(711, 590);
            button3.Name = "button3";
            button3.Size = new Size(175, 75);
            button3.TabIndex = 31;
            button3.Text = "Agendar";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 677);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(Bt_Sair_agenda);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bt_Sair_agenda;
        private Label label1;
        private Label lbl_PeriodoDe;
        private Panel panel1;
        private Label label2;
        private RadioButton rdbCodigo;
        private RadioButton rdbNome;
        private MonthCalendar monthCalendar1;
        private TextBox textBox1;
        private RadioButton rdbVip;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label4;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}