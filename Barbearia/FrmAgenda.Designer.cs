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
            Gb_Produtos = new GroupBox();
            Btn_procura_cliente = new Button();
            dataGridView1 = new DataGridView();
            Nup_Quantidade = new NumericUpDown();
            label6 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            Btn_Procurar_prod = new Button();
            Rb_codigo2 = new RadioButton();
            Dgv_produto = new DataGridView();
            Rb_nome2 = new RadioButton();
            label5 = new Label();
            Txt_Pesquisa_prod = new TextBox();
            Rb_Codigo_prod = new RadioButton();
            Rb_Nome_prod = new RadioButton();
            label7 = new Label();
            Gb_Pergunta = new GroupBox();
            Rb_Nao = new RadioButton();
            Rb_Sim = new RadioButton();
            Btn_registrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Pesquisar_cliente).BeginInit();
            Gb_Produtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Nup_Quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_produto).BeginInit();
            Gb_Pergunta.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial Rounded MT Bold", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(483, 32);
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
            panel1.Location = new Point(12, 44);
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
            Btn_limpar.Location = new Point(193, 590);
            Btn_limpar.Name = "Btn_limpar";
            Btn_limpar.Size = new Size(175, 75);
            Btn_limpar.TabIndex = 30;
            Btn_limpar.Text = "Limpar";
            Btn_limpar.UseVisualStyleBackColor = true;
            Btn_limpar.Click += Btn_limpar_Click;
            // 
            // Btn_Agendar
            // 
            Btn_Agendar.Location = new Point(12, 590);
            Btn_Agendar.Name = "Btn_Agendar";
            Btn_Agendar.Size = new Size(175, 75);
            Btn_Agendar.TabIndex = 31;
            Btn_Agendar.Text = "Agendar";
            Btn_Agendar.UseVisualStyleBackColor = true;
            Btn_Agendar.Click += Btn_Agendar_Click;
            // 
            // Gb_Produtos
            // 
            Gb_Produtos.Controls.Add(Btn_procura_cliente);
            Gb_Produtos.Controls.Add(dataGridView1);
            Gb_Produtos.Controls.Add(Nup_Quantidade);
            Gb_Produtos.Controls.Add(label6);
            Gb_Produtos.Controls.Add(textBox1);
            Gb_Produtos.Controls.Add(label8);
            Gb_Produtos.Controls.Add(Btn_Procurar_prod);
            Gb_Produtos.Controls.Add(Rb_codigo2);
            Gb_Produtos.Controls.Add(Dgv_produto);
            Gb_Produtos.Controls.Add(Rb_nome2);
            Gb_Produtos.Controls.Add(label5);
            Gb_Produtos.Controls.Add(Txt_Pesquisa_prod);
            Gb_Produtos.Controls.Add(Rb_Codigo_prod);
            Gb_Produtos.Controls.Add(Rb_Nome_prod);
            Gb_Produtos.Location = new Point(512, 111);
            Gb_Produtos.Name = "Gb_Produtos";
            Gb_Produtos.Size = new Size(263, 459);
            Gb_Produtos.TabIndex = 32;
            Gb_Produtos.TabStop = false;
            Gb_Produtos.Text = "Produtos ";
            Gb_Produtos.Visible = false;
            // 
            // Btn_procura_cliente
            // 
            Btn_procura_cliente.Location = new Point(6, 421);
            Btn_procura_cliente.Name = "Btn_procura_cliente";
            Btn_procura_cliente.Size = new Size(107, 32);
            Btn_procura_cliente.TabIndex = 40;
            Btn_procura_cliente.Text = "Procurar";
            Btn_procura_cliente.UseVisualStyleBackColor = true;
            Btn_procura_cliente.Click += Btn_procura_cliente_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 354);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(242, 50);
            dataGridView1.TabIndex = 45;
            // 
            // Nup_Quantidade
            // 
            Nup_Quantidade.Location = new Point(135, 224);
            Nup_Quantidade.Name = "Nup_Quantidade";
            Nup_Quantidade.Size = new Size(109, 26);
            Nup_Quantidade.TabIndex = 45;
            Nup_Quantidade.ValueChanged += Nup_Quantidade_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 226);
            label6.Name = "label6";
            label6.Size = new Size(110, 18);
            label6.TabIndex = 44;
            label6.Text = "Quantidade :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 322);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 26);
            textBox1.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 260);
            label8.Name = "label8";
            label8.Size = new Size(161, 18);
            label8.TabIndex = 42;
            label8.Text = "Pesquisar Cliente  :";
            // 
            // Btn_Procurar_prod
            // 
            Btn_Procurar_prod.Location = new Point(6, 180);
            Btn_Procurar_prod.Name = "Btn_Procurar_prod";
            Btn_Procurar_prod.Size = new Size(107, 32);
            Btn_Procurar_prod.TabIndex = 40;
            Btn_Procurar_prod.Text = "Procurar";
            Btn_Procurar_prod.UseVisualStyleBackColor = true;
            Btn_Procurar_prod.Click += Btn_Procurar_prod_Click;
            // 
            // Rb_codigo2
            // 
            Rb_codigo2.AutoSize = true;
            Rb_codigo2.Font = new Font("Arial Rounded MT Bold", 12F);
            Rb_codigo2.Location = new Point(142, 294);
            Rb_codigo2.Name = "Rb_codigo2";
            Rb_codigo2.Size = new Size(82, 22);
            Rb_codigo2.TabIndex = 41;
            Rb_codigo2.TabStop = true;
            Rb_codigo2.Text = "Código";
            Rb_codigo2.UseVisualStyleBackColor = true;
            // 
            // Dgv_produto
            // 
            Dgv_produto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_produto.Location = new Point(6, 115);
            Dgv_produto.Name = "Dgv_produto";
            Dgv_produto.Size = new Size(244, 59);
            Dgv_produto.TabIndex = 43;
            // 
            // Rb_nome2
            // 
            Rb_nome2.AutoSize = true;
            Rb_nome2.Font = new Font("Arial Rounded MT Bold", 12F);
            Rb_nome2.Location = new Point(42, 294);
            Rb_nome2.Name = "Rb_nome2";
            Rb_nome2.Size = new Size(72, 22);
            Rb_nome2.TabIndex = 40;
            Rb_nome2.TabStop = true;
            Rb_nome2.Text = "Nome";
            Rb_nome2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 34);
            label5.Name = "label5";
            label5.Size = new Size(165, 18);
            label5.TabIndex = 0;
            label5.Text = "Pesquisar Produto :";
            // 
            // Txt_Pesquisa_prod
            // 
            Txt_Pesquisa_prod.Location = new Point(6, 83);
            Txt_Pesquisa_prod.MaxLength = 50;
            Txt_Pesquisa_prod.Name = "Txt_Pesquisa_prod";
            Txt_Pesquisa_prod.Size = new Size(244, 26);
            Txt_Pesquisa_prod.TabIndex = 42;
            // 
            // Rb_Codigo_prod
            // 
            Rb_Codigo_prod.AutoSize = true;
            Rb_Codigo_prod.Font = new Font("Arial Rounded MT Bold", 12F);
            Rb_Codigo_prod.Location = new Point(122, 55);
            Rb_Codigo_prod.Name = "Rb_Codigo_prod";
            Rb_Codigo_prod.Size = new Size(105, 22);
            Rb_Codigo_prod.TabIndex = 41;
            Rb_Codigo_prod.TabStop = true;
            Rb_Codigo_prod.Text = "Categoria";
            Rb_Codigo_prod.UseVisualStyleBackColor = true;
            // 
            // Rb_Nome_prod
            // 
            Rb_Nome_prod.AutoSize = true;
            Rb_Nome_prod.Font = new Font("Arial Rounded MT Bold", 12F);
            Rb_Nome_prod.Location = new Point(29, 55);
            Rb_Nome_prod.Name = "Rb_Nome_prod";
            Rb_Nome_prod.Size = new Size(72, 22);
            Rb_Nome_prod.TabIndex = 40;
            Rb_Nome_prod.TabStop = true;
            Rb_Nome_prod.Text = "Nome";
            Rb_Nome_prod.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(506, 44);
            label7.Name = "label7";
            label7.Size = new Size(0, 18);
            label7.TabIndex = 33;
            // 
            // Gb_Pergunta
            // 
            Gb_Pergunta.Controls.Add(Rb_Nao);
            Gb_Pergunta.Controls.Add(Rb_Sim);
            Gb_Pergunta.Location = new Point(512, 33);
            Gb_Pergunta.Name = "Gb_Pergunta";
            Gb_Pergunta.Size = new Size(263, 72);
            Gb_Pergunta.TabIndex = 34;
            Gb_Pergunta.TabStop = false;
            Gb_Pergunta.Text = "Houve compra  de  Produto ?";
            // 
            // Rb_Nao
            // 
            Rb_Nao.AutoSize = true;
            Rb_Nao.Font = new Font("Arial Rounded MT Bold", 15.75F);
            Rb_Nao.Location = new Point(142, 36);
            Rb_Nao.Name = "Rb_Nao";
            Rb_Nao.Size = new Size(69, 28);
            Rb_Nao.TabIndex = 47;
            Rb_Nao.TabStop = true;
            Rb_Nao.Text = "Não";
            Rb_Nao.UseVisualStyleBackColor = true;
            Rb_Nao.CheckedChanged += Rb_Nao_CheckedChanged;
            // 
            // Rb_Sim
            // 
            Rb_Sim.AutoSize = true;
            Rb_Sim.Font = new Font("Arial Rounded MT Bold", 15.75F);
            Rb_Sim.Location = new Point(49, 36);
            Rb_Sim.Name = "Rb_Sim";
            Rb_Sim.Size = new Size(67, 28);
            Rb_Sim.TabIndex = 46;
            Rb_Sim.TabStop = true;
            Rb_Sim.Text = "Sim";
            Rb_Sim.UseVisualStyleBackColor = true;
            Rb_Sim.CheckedChanged += Rb_Sim_CheckedChanged;
            // 
            // Btn_registrar
            // 
            Btn_registrar.Location = new Point(512, 590);
            Btn_registrar.Name = "Btn_registrar";
            Btn_registrar.Size = new Size(263, 75);
            Btn_registrar.TabIndex = 35;
            Btn_registrar.Text = "Registrar";
            Btn_registrar.UseVisualStyleBackColor = true;
            Btn_registrar.Visible = false;
            Btn_registrar.Click += Btn_registrar_Click;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 677);
            Controls.Add(Btn_registrar);
            Controls.Add(Gb_Pergunta);
            Controls.Add(label7);
            Controls.Add(Gb_Produtos);
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
            Gb_Produtos.ResumeLayout(false);
            Gb_Produtos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Nup_Quantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_produto).EndInit();
            Gb_Pergunta.ResumeLayout(false);
            Gb_Pergunta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private GroupBox Gb_Produtos;
        private Label label5;
        private NumericUpDown Nup_Quantidade;
        private Label label6;
        private Button Btn_Procurar_prod;
        private DataGridView Dgv_produto;
        private TextBox Txt_Pesquisa_prod;
        private RadioButton Rb_Codigo_prod;
        private RadioButton Rb_Nome_prod;
        private Label label7;
        private GroupBox Gb_Pergunta;
        private RadioButton Rb_Nao;
        private RadioButton Rb_Sim;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label8;
        private RadioButton Rb_codigo2;
        private RadioButton Rb_nome2;
        private Button Btn_registrar;
        private Button Btn_procura_cliente;
    }
}