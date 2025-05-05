namespace Barbearia
{
    partial class FrmListaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaEstoque));
            dataGridView1 = new DataGridView();
            btnCarregaGridView = new Button();
            lblCodigo = new Label();
            cbxCategoria = new ComboBox();
            lblNome = new Label();
            TxtNome = new MaskedTextBox();
            pctFotocubo = new PictureBox();
            Gpb_Pesquisar = new GroupBox();
            btn_Limpar = new Button();
            btnPesquisar = new Button();
            lblCategoria = new Label();
            BtnVoltar = new Button();
            button1 = new Button();
            Btn_Excluir = new Button();
            Btn_Alterar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctFotocubo).BeginInit();
            Gpb_Pesquisar.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1237, 355);
            dataGridView1.TabIndex = 0;
            // 
            // btnCarregaGridView
            // 
            btnCarregaGridView.BackColor = SystemColors.ControlLightLight;
            btnCarregaGridView.Font = new Font("Arial Rounded MT Bold", 12F);
            btnCarregaGridView.Location = new Point(12, 594);
            btnCarregaGridView.Name = "btnCarregaGridView";
            btnCarregaGridView.Size = new Size(175, 75);
            btnCarregaGridView.TabIndex = 1;
            btnCarregaGridView.Text = "Carregar Produtos";
            btnCarregaGridView.UseVisualStyleBackColor = false;
            btnCarregaGridView.Click += btnCarregaGridView_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Arial Rounded MT Bold", 12F);
            lblCodigo.Location = new Point(35, 64);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(0, 18);
            lblCodigo.TabIndex = 0;
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(561, 61);
            cbxCategoria.Margin = new Padding(4);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(215, 26);
            cbxCategoria.TabIndex = 8;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial Rounded MT Bold", 12F);
            lblNome.Location = new Point(98, 69);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(59, 18);
            lblNome.TabIndex = 11;
            lblNome.Text = "Nome:";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(165, 61);
            TxtNome.Margin = new Padding(4);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(210, 26);
            TxtNome.TabIndex = 12;
            // 
            // pctFotocubo
            // 
            pctFotocubo.Image = (Image)resources.GetObject("pctFotocubo.Image");
            pctFotocubo.Location = new Point(843, 15);
            pctFotocubo.Margin = new Padding(4);
            pctFotocubo.Name = "pctFotocubo";
            pctFotocubo.Size = new Size(72, 72);
            pctFotocubo.SizeMode = PictureBoxSizeMode.AutoSize;
            pctFotocubo.TabIndex = 17;
            pctFotocubo.TabStop = false;
            // 
            // Gpb_Pesquisar
            // 
            Gpb_Pesquisar.Controls.Add(btn_Limpar);
            Gpb_Pesquisar.Controls.Add(btnPesquisar);
            Gpb_Pesquisar.Controls.Add(pctFotocubo);
            Gpb_Pesquisar.Controls.Add(TxtNome);
            Gpb_Pesquisar.Controls.Add(lblNome);
            Gpb_Pesquisar.Controls.Add(cbxCategoria);
            Gpb_Pesquisar.Controls.Add(lblCategoria);
            Gpb_Pesquisar.Controls.Add(lblCodigo);
            Gpb_Pesquisar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Gpb_Pesquisar.Location = new Point(158, 14);
            Gpb_Pesquisar.Margin = new Padding(6, 5, 6, 5);
            Gpb_Pesquisar.Name = "Gpb_Pesquisar";
            Gpb_Pesquisar.Padding = new Padding(6, 5, 6, 5);
            Gpb_Pesquisar.Size = new Size(925, 196);
            Gpb_Pesquisar.TabIndex = 9;
            Gpb_Pesquisar.TabStop = false;
            Gpb_Pesquisar.Text = "Pesquisar Produtos:";
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = SystemColors.ControlLightLight;
            btn_Limpar.Font = new Font("Arial Rounded MT Bold", 12F);
            btn_Limpar.Location = new Point(451, 147);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(129, 41);
            btn_Limpar.TabIndex = 18;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = false;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = SystemColors.ControlLightLight;
            btnPesquisar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnPesquisar.Location = new Point(316, 147);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(129, 41);
            btnPesquisar.TabIndex = 10;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Arial Rounded MT Bold", 12F);
            lblCategoria.Location = new Point(461, 69);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(92, 18);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoria:";
            // 
            // BtnVoltar
            // 
            BtnVoltar.BackColor = SystemColors.ControlLightLight;
            BtnVoltar.Font = new Font("Arial Rounded MT Bold", 12F);
            BtnVoltar.Location = new Point(1077, 595);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(175, 75);
            BtnVoltar.TabIndex = 18;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = false;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Arial Rounded MT Bold", 12F);
            button1.Location = new Point(194, 595);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(175, 75);
            button1.TabIndex = 25;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = false;
            // 
            // Btn_Excluir
            // 
            Btn_Excluir.BackColor = SystemColors.ControlLightLight;
            Btn_Excluir.Font = new Font("Arial Rounded MT Bold", 12F);
            Btn_Excluir.Location = new Point(560, 595);
            Btn_Excluir.Margin = new Padding(4);
            Btn_Excluir.Name = "Btn_Excluir";
            Btn_Excluir.Size = new Size(175, 75);
            Btn_Excluir.TabIndex = 27;
            Btn_Excluir.Text = "Excluir";
            Btn_Excluir.UseVisualStyleBackColor = false;
            // 
            // Btn_Alterar
            // 
            Btn_Alterar.BackColor = SystemColors.ControlLightLight;
            Btn_Alterar.Font = new Font("Arial Rounded MT Bold", 12F);
            Btn_Alterar.Location = new Point(377, 595);
            Btn_Alterar.Margin = new Padding(4);
            Btn_Alterar.Name = "Btn_Alterar";
            Btn_Alterar.Size = new Size(175, 75);
            Btn_Alterar.TabIndex = 26;
            Btn_Alterar.Text = "Alterar";
            Btn_Alterar.UseVisualStyleBackColor = false;
            // 
            // FrmListaEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(button1);
            Controls.Add(Btn_Excluir);
            Controls.Add(Btn_Alterar);
            Controls.Add(Gpb_Pesquisar);
            Controls.Add(BtnVoltar);
            Controls.Add(btnCarregaGridView);
            Controls.Add(dataGridView1);
            Name = "FrmListaEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista Estoque";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctFotocubo).EndInit();
            Gpb_Pesquisar.ResumeLayout(false);
            Gpb_Pesquisar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCarregaGridView;
        private Label lblCodigo;
        private ComboBox cbxCategoria;
        private Label lblNome;
        private MaskedTextBox TxtNome;
        public PictureBox pctFotocubo;
        private GroupBox Gpb_Pesquisar;
        private Button button3;
        private Button BtnVoltar;
        private Button btnPesquisar;
        private Label lblCategoria;
        private Button btn_Limpar;
        private Button button1;
        private Button Btn_Excluir;
        private Button Btn_Alterar;
    }
}