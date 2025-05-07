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
            btnCarregaGridView = new Button();
            lblCodigo = new Label();
            cbxCategoria = new ComboBox();
            lblNome = new Label();
            TxtNome = new MaskedTextBox();
            Gpb_Pesquisar = new GroupBox();
            rdbCategoria = new RadioButton();
            rdbNome = new RadioButton();
            btn_Limpar = new Button();
            lblCategoria = new Label();
            BtnVoltar = new Button();
            button1 = new Button();
            Btn_Excluir = new Button();
            Btn_Alterar = new Button();
            ltbPesquisar = new ListBox();
            Gpb_Pesquisar.SuspendLayout();
            SuspendLayout();
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
            cbxCategoria.Location = new Point(619, 99);
            cbxCategoria.Margin = new Padding(4);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(215, 26);
            cbxCategoria.TabIndex = 8;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial Rounded MT Bold", 12F);
            lblNome.Location = new Point(117, 103);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(59, 18);
            lblNome.TabIndex = 11;
            lblNome.Text = "Nome:";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(184, 99);
            TxtNome.Margin = new Padding(4);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(210, 26);
            TxtNome.TabIndex = 12;
            // 
            // Gpb_Pesquisar
            // 
            Gpb_Pesquisar.Controls.Add(rdbCategoria);
            Gpb_Pesquisar.Controls.Add(rdbNome);
            Gpb_Pesquisar.Controls.Add(btn_Limpar);
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
            // rdbCategoria
            // 
            rdbCategoria.AutoSize = true;
            rdbCategoria.Location = new Point(519, 40);
            rdbCategoria.Name = "rdbCategoria";
            rdbCategoria.Size = new Size(105, 22);
            rdbCategoria.TabIndex = 20;
            rdbCategoria.TabStop = true;
            rdbCategoria.Text = "Categoria";
            rdbCategoria.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            rdbNome.AutoSize = true;
            rdbNome.Location = new Point(322, 40);
            rdbNome.Name = "rdbNome";
            rdbNome.Size = new Size(72, 22);
            rdbNome.TabIndex = 19;
            rdbNome.TabStop = true;
            rdbNome.Text = "Nome";
            rdbNome.UseVisualStyleBackColor = true;
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = SystemColors.ControlLightLight;
            btn_Limpar.Font = new Font("Arial Rounded MT Bold", 12F);
            btn_Limpar.Location = new Point(390, 147);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(129, 41);
            btn_Limpar.TabIndex = 18;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = false;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Arial Rounded MT Bold", 12F);
            lblCategoria.Location = new Point(519, 102);
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
            Btn_Alterar.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Alterar.Location = new Point(377, 595);
            Btn_Alterar.Margin = new Padding(4);
            Btn_Alterar.Name = "Btn_Alterar";
            Btn_Alterar.Size = new Size(175, 75);
            Btn_Alterar.TabIndex = 26;
            Btn_Alterar.Text = "Alterar";
            Btn_Alterar.UseVisualStyleBackColor = false;
            // 
            // ltbPesquisar
            // 
            ltbPesquisar.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ltbPesquisar.FormattingEnabled = true;
            ltbPesquisar.ItemHeight = 29;
            ltbPesquisar.Location = new Point(15, 233);
            ltbPesquisar.Name = "ltbPesquisar";
            ltbPesquisar.Size = new Size(1237, 352);
            ltbPesquisar.TabIndex = 28;
            // 
            // FrmListaEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(ltbPesquisar);
            Controls.Add(button1);
            Controls.Add(Btn_Excluir);
            Controls.Add(Btn_Alterar);
            Controls.Add(Gpb_Pesquisar);
            Controls.Add(BtnVoltar);
            Controls.Add(btnCarregaGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmListaEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista Estoque";
            Load += FrmListaEstoque_Load;
            Gpb_Pesquisar.ResumeLayout(false);
            Gpb_Pesquisar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCarregaGridView;
        private Label lblCodigo;
        private ComboBox cbxCategoria;
        private Label lblNome;
        private MaskedTextBox TxtNome;
        private GroupBox Gpb_Pesquisar;
        private Button button3;
        private Button BtnVoltar;
        private Label lblCategoria;
        private Button btn_Limpar;
        private Button button1;
        private Button Btn_Excluir;
        private Button Btn_Alterar;
        private RadioButton rdbCategoria;
        private RadioButton rdbNome;
        private ListBox ltbPesquisar;
    }
}