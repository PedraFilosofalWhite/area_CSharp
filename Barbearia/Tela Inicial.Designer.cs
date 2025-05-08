namespace Barbearia
{
    partial class frmTela_Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTela_Inicial));
            msNavBar = new MenuStrip();
            menuVizualizarAgenda = new ToolStripMenuItem();
            Menu_cliente = new ToolStripMenuItem();
            Menu_Estoque = new ToolStripMenuItem();
            Menu_Funcionario = new ToolStripMenuItem();
            Menu_Financa = new ToolStripMenuItem();
            Menu_Sair = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Flp_Calendario = new FlowLayoutPanel();
            Lb_mes = new Label();
            Btn_avançar_mes = new Button();
            Btn_retornar = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            msNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // msNavBar
            // 
            msNavBar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msNavBar.Items.AddRange(new ToolStripItem[] { menuVizualizarAgenda, Menu_cliente, Menu_Estoque, Menu_Funcionario, Menu_Financa, Menu_Sair });
            msNavBar.Location = new Point(0, 0);
            msNavBar.Name = "msNavBar";
            msNavBar.RenderMode = ToolStripRenderMode.Professional;
            msNavBar.Size = new Size(1260, 26);
            msNavBar.TabIndex = 5;
            msNavBar.Text = "menuStrip1";
            // 
            // menuVizualizarAgenda
            // 
            menuVizualizarAgenda.Name = "menuVizualizarAgenda";
            menuVizualizarAgenda.Size = new Size(163, 22);
            menuVizualizarAgenda.Text = "Visualizar Agenda";
            menuVizualizarAgenda.Click += menuVizualizarAgenda_Click;
            // 
            // Menu_cliente
            // 
            Menu_cliente.Name = "Menu_cliente";
            Menu_cliente.Size = new Size(85, 22);
            Menu_cliente.Text = "&Clientes";
            Menu_cliente.Click += Menu_cliente_Click;
            // 
            // Menu_Estoque
            // 
            Menu_Estoque.Name = "Menu_Estoque";
            Menu_Estoque.Size = new Size(86, 22);
            Menu_Estoque.Text = "&Estoque";
            Menu_Estoque.Click += Menu_Estoque_Click;
            // 
            // Menu_Funcionario
            // 
            Menu_Funcionario.Name = "Menu_Funcionario";
            Menu_Funcionario.Size = new Size(124, 22);
            Menu_Funcionario.Text = "&Funcionarios";
            Menu_Funcionario.Click += Menu_Funcionario_Click;
            // 
            // Menu_Financa
            // 
            Menu_Financa.Name = "Menu_Financa";
            Menu_Financa.Size = new Size(93, 22);
            Menu_Financa.Text = "&Finanças";
            Menu_Financa.Click += Menu_Financa_Click;
            // 
            // Menu_Sair
            // 
            Menu_Sair.Name = "Menu_Sair";
            Menu_Sair.Size = new Size(52, 22);
            Menu_Sair.Text = "&Sair";
            Menu_Sair.Click += Menu_Sair_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1269, 1);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(8, 78);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 8;
            label1.Text = "Domingo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 18F, FontStyle.Bold);
            label2.Location = new Point(188, 78);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 9;
            label2.Text = "Segunda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(542, 78);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 11;
            label3.Text = "Quarta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(365, 78);
            label4.Name = "label4";
            label4.Size = new Size(74, 28);
            label4.TabIndex = 10;
            label4.Text = "Terça";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 18F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(896, 78);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 13;
            label5.Text = "Sexta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 18F, FontStyle.Bold);
            label6.Location = new Point(719, 78);
            label6.Name = "label6";
            label6.Size = new Size(89, 28);
            label6.TabIndex = 12;
            label6.Text = "Quinta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 18F, FontStyle.Bold);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(1073, 78);
            label7.Name = "label7";
            label7.Size = new Size(96, 28);
            label7.TabIndex = 14;
            label7.Text = "Sabado";
            // 
            // Flp_Calendario
            // 
            Flp_Calendario.Location = new Point(8, 115);
            Flp_Calendario.Name = "Flp_Calendario";
            Flp_Calendario.Size = new Size(1240, 780);
            Flp_Calendario.TabIndex = 6;
            // 
            // Lb_mes
            // 
            Lb_mes.Font = new Font("Gadugi", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_mes.Location = new Point(365, 30);
            Lb_mes.Name = "Lb_mes";
            Lb_mes.Size = new Size(427, 48);
            Lb_mes.TabIndex = 15;
            Lb_mes.Text = "Mês ano";
            Lb_mes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn_avançar_mes
            // 
            Btn_avançar_mes.BackColor = Color.Transparent;
            Btn_avançar_mes.ForeColor = Color.White;
            Btn_avançar_mes.Image = (Image)resources.GetObject("Btn_avançar_mes.Image");
            Btn_avançar_mes.Location = new Point(798, 29);
            Btn_avançar_mes.Name = "Btn_avançar_mes";
            Btn_avançar_mes.Size = new Size(82, 44);
            Btn_avançar_mes.TabIndex = 16;
            Btn_avançar_mes.UseVisualStyleBackColor = false;
            Btn_avançar_mes.Click += Btn_avançar_mes_Click;
            // 
            // Btn_retornar
            // 
            Btn_retornar.BackColor = Color.Transparent;
            Btn_retornar.Image = (Image)resources.GetObject("Btn_retornar.Image");
            Btn_retornar.Location = new Point(277, 30);
            Btn_retornar.Name = "Btn_retornar";
            Btn_retornar.Size = new Size(82, 44);
            Btn_retornar.TabIndex = 17;
            Btn_retornar.UseVisualStyleBackColor = false;
            Btn_retornar.Click += Btn_retornar_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmTela_Inicial
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 677);
            Controls.Add(Btn_retornar);
            Controls.Add(Btn_avançar_mes);
            Controls.Add(Lb_mes);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(Flp_Calendario);
            Controls.Add(msNavBar);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = msNavBar;
            Margin = new Padding(4);
            Name = "frmTela_Inicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela inicial";
            Load += Tela_Inicial_Load;
            msNavBar.ResumeLayout(false);
            msNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip msNavBar;
        private ToolStripMenuItem Menu_cliente;
        private ToolStripMenuItem Menu_Estoque;
        private ToolStripMenuItem Menu_Funcionario;
        private ToolStripMenuItem Menu_Financa;
        private ToolStripMenuItem Menu_Sair;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private FlowLayoutPanel Flp_Calendario;
        private Label Lb_mes;
        private Button Btn_avançar_mes;
        private Button Btn_retornar;
        private FileSystemWatcher fileSystemWatcher1;
        private ToolStripMenuItem menuVizualizarAgenda;
    }
}