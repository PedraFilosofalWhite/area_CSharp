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
            Txt_dias = new TextBox();
            button2 = new Button();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            rdbVip = new RadioButton();
            rdbCodigo = new RadioButton();
            rdbNome = new RadioButton();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            Btn_limpar = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(Txt_dias);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
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
            // button2
            // 
            button2.Location = new Point(14, 325);
            button2.Name = "button2";
            button2.Size = new Size(107, 32);
            button2.TabIndex = 38;
            button2.Text = "Procurar";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(16, 434);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(452, 26);
            comboBox2.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 402);
            label4.Name = "label4";
            label4.Size = new Size(78, 18);
            label4.TabIndex = 35;
            label4.Text = "Serviços";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "05:00 - 05:50  ", "05:50 - 06:40  ", "06:40 - 07:30  ", "07:30 - 08:20  ", "08:20 - 09:10  ", "09:10 - 10:00  ", "10:00 - 10:50  ", "10:50 - 11:40  ", "11:40 - 12:30  ", "12:30 - 13:20  ", "13:20 - 14:10  ", "14:10 - 15:00  ", "15:00 - 15:50  ", "15:50 - 16:40  ", "16:40 - 17:30  ", "17:30 - 18:20  ", "18:20 - 19:10  ", "19:10 - 20:00  ", "20:00 - 20:50  ", "20:50 - 21:40  ", "21:40 - 22:30  ", "22:30 - 23:20" });
            comboBox1.Location = new Point(16, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(451, 26);
            comboBox1.TabIndex = 34;
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
            // textBox1
            // 
            textBox1.Location = new Point(14, 293);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(451, 26);
            textBox1.TabIndex = 32;
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
            Btn_limpar.Location = new Point(193, 605);
            Btn_limpar.Name = "Btn_limpar";
            Btn_limpar.Size = new Size(175, 75);
            Btn_limpar.TabIndex = 30;
            Btn_limpar.Text = "Limpar";
            Btn_limpar.UseVisualStyleBackColor = true;
            Btn_limpar.Click += Btn_limpar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 605);
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
            ClientSize = new Size(620, 677);
            Controls.Add(button3);
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
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label lbl_PeriodoDe;
        private Panel panel1;
        private Label label2;
        private RadioButton rdbCodigo;
        private RadioButton rdbNome;
        private TextBox textBox1;
        private RadioButton rdbVip;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label4;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button button2;
        private Button Btn_limpar;
        private Button button3;
        private TextBox Txt_dias;
    }
}