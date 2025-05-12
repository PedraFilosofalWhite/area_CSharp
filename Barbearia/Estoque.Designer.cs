namespace Barbearia
{
    partial class FrmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoque));
            Gpb_Estoque = new GroupBox();
            txt_preco = new TextBox();
            pctFotocubo = new PictureBox();
            txtProduto = new TextBox();
            lblPreco = new Label();
            txtQuantidade = new MaskedTextBox();
            TxtDescricao = new MaskedTextBox();
            lbldescricao = new Label();
            lblQuantidade = new Label();
            cbxCategoria = new ComboBox();
            Txt_Codigo = new TextBox();
            lblProduto = new Label();
            lblCategoria = new Label();
            lblCodigo = new Label();
            Btn_Voltar = new Button();
            Btn_Pesquisar = new Button();
            Btn_Limpar = new Button();
            Btn_Cadastrar = new Button();
            Btn_Novo = new Button();
            Btn_voltar2 = new Button();
            Gpb_Pesquisar = new GroupBox();
            cbxCategoriasDesc = new ComboBox();
            ltb_Pesquisar = new ListBox();
            Txt_Descricao = new TextBox();
            label1 = new Label();
            rdbCategoria = new RadioButton();
            rdbNome = new RadioButton();
            Btn_Excluir = new Button();
            Btn_Alterar = new Button();
            Gpb_Estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctFotocubo).BeginInit();
            Gpb_Pesquisar.SuspendLayout();
            SuspendLayout();
            // 
            // Gpb_Estoque
            // 
            Gpb_Estoque.Controls.Add(txt_preco);
            Gpb_Estoque.Controls.Add(pctFotocubo);
            Gpb_Estoque.Controls.Add(txtProduto);
            Gpb_Estoque.Controls.Add(lblPreco);
            Gpb_Estoque.Controls.Add(txtQuantidade);
            Gpb_Estoque.Controls.Add(TxtDescricao);
            Gpb_Estoque.Controls.Add(lbldescricao);
            Gpb_Estoque.Controls.Add(lblQuantidade);
            Gpb_Estoque.Controls.Add(cbxCategoria);
            Gpb_Estoque.Controls.Add(Txt_Codigo);
            Gpb_Estoque.Controls.Add(lblProduto);
            Gpb_Estoque.Controls.Add(lblCategoria);
            Gpb_Estoque.Controls.Add(lblCodigo);
            Gpb_Estoque.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Gpb_Estoque.Location = new Point(5, 4);
            Gpb_Estoque.Margin = new Padding(6, 5, 6, 5);
            Gpb_Estoque.Name = "Gpb_Estoque";
            Gpb_Estoque.Padding = new Padding(6, 5, 6, 5);
            Gpb_Estoque.Size = new Size(1246, 197);
            Gpb_Estoque.TabIndex = 1;
            Gpb_Estoque.TabStop = false;
            Gpb_Estoque.Text = "Cadastrar Produtos";
            // 
            // txt_preco
            // 
            txt_preco.Font = new Font("Arial", 12F);
            txt_preco.Location = new Point(678, 54);
            txt_preco.Name = "txt_preco";
            txt_preco.Size = new Size(169, 26);
            txt_preco.TabIndex = 3;
            txt_preco.KeyPress += txt_preco_KeyPress;
            // 
            // pctFotocubo
            // 
            pctFotocubo.Image = (Image)resources.GetObject("pctFotocubo.Image");
            pctFotocubo.Location = new Point(1164, 18);
            pctFotocubo.Margin = new Padding(4);
            pctFotocubo.Name = "pctFotocubo";
            pctFotocubo.Size = new Size(72, 72);
            pctFotocubo.SizeMode = PictureBoxSizeMode.AutoSize;
            pctFotocubo.TabIndex = 17;
            pctFotocubo.TabStop = false;
            // 
            // txtProduto
            // 
            txtProduto.Font = new Font("Arial", 12F);
            txtProduto.Location = new Point(113, 97);
            txtProduto.Margin = new Padding(4);
            txtProduto.MaxLength = 50;
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(210, 26);
            txtProduto.TabIndex = 1;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Arial Rounded MT Bold", 12F);
            lblPreco.Location = new Point(590, 58);
            lblPreco.Margin = new Padding(4, 0, 4, 0);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(87, 18);
            lblPreco.TabIndex = 14;
            lblPreco.Text = "Preço: R$";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Arial", 12F);
            txtQuantidade.Location = new Point(678, 97);
            txtQuantidade.Margin = new Padding(4);
            txtQuantidade.Mask = "000";
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(52, 26);
            txtQuantidade.TabIndex = 4;
            txtQuantidade.ValidatingType = typeof(int);
            txtQuantidade.KeyPress += txtQuantidade_KeyPress;
            // 
            // TxtDescricao
            // 
            TxtDescricao.Font = new Font("Arial", 12F);
            TxtDescricao.Location = new Point(113, 146);
            TxtDescricao.Margin = new Padding(4);
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(210, 26);
            TxtDescricao.TabIndex = 2;
            // 
            // lbldescricao
            // 
            lbldescricao.AutoSize = true;
            lbldescricao.Font = new Font("Arial Rounded MT Bold", 12F);
            lbldescricao.Location = new Point(10, 149);
            lbldescricao.Margin = new Padding(4, 0, 4, 0);
            lbldescricao.Name = "lbldescricao";
            lbldescricao.Size = new Size(95, 18);
            lbldescricao.TabIndex = 11;
            lbldescricao.Text = "Descrição:";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Arial Rounded MT Bold", 12F);
            lblQuantidade.Location = new Point(560, 107);
            lblQuantidade.Margin = new Padding(4, 0, 4, 0);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(106, 18);
            lblQuantidade.TabIndex = 10;
            lblQuantidade.Text = "Quantidade:";
            // 
            // cbxCategoria
            // 
            cbxCategoria.Font = new Font("Arial", 12F);
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(678, 141);
            cbxCategoria.Margin = new Padding(4);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(226, 26);
            cbxCategoria.TabIndex = 8;
            // 
            // Txt_Codigo
            // 
            Txt_Codigo.Enabled = false;
            Txt_Codigo.Font = new Font("Arial", 12F);
            Txt_Codigo.Location = new Point(113, 55);
            Txt_Codigo.Margin = new Padding(4);
            Txt_Codigo.Name = "Txt_Codigo";
            Txt_Codigo.Size = new Size(88, 26);
            Txt_Codigo.TabIndex = 7;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Arial Rounded MT Bold", 12F);
            lblProduto.Location = new Point(28, 107);
            lblProduto.Margin = new Padding(4, 0, 4, 0);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(77, 18);
            lblProduto.TabIndex = 4;
            lblProduto.Text = "Produto:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Arial Rounded MT Bold", 12F);
            lblCategoria.Location = new Point(571, 149);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(92, 18);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoria:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Arial Rounded MT Bold", 12F);
            lblCodigo.Location = new Point(32, 62);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(73, 18);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código :";
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = SystemColors.ControlLightLight;
            Btn_Voltar.Font = new Font("Arial Rounded MT Bold", 12F);
            Btn_Voltar.Location = new Point(1109, 593);
            Btn_Voltar.Margin = new Padding(4);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(143, 75);
            Btn_Voltar.TabIndex = 5;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.UseVisualStyleBackColor = false;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // Btn_Pesquisar
            // 
            Btn_Pesquisar.BackColor = SystemColors.ControlLightLight;
            Btn_Pesquisar.Font = new Font("Arial Rounded MT Bold", 12F);
            Btn_Pesquisar.Location = new Point(926, 593);
            Btn_Pesquisar.Margin = new Padding(4);
            Btn_Pesquisar.Name = "Btn_Pesquisar";
            Btn_Pesquisar.Size = new Size(175, 75);
            Btn_Pesquisar.TabIndex = 4;
            Btn_Pesquisar.Text = "Pesquisar";
            Btn_Pesquisar.UseVisualStyleBackColor = false;
            Btn_Pesquisar.Click += Btn_Pesquisar_Click;
            // 
            // Btn_Limpar
            // 
            Btn_Limpar.BackColor = SystemColors.ControlLightLight;
            Btn_Limpar.Font = new Font("Arial Rounded MT Bold", 12F);
            Btn_Limpar.Location = new Point(377, 593);
            Btn_Limpar.Margin = new Padding(4);
            Btn_Limpar.Name = "Btn_Limpar";
            Btn_Limpar.Size = new Size(175, 75);
            Btn_Limpar.TabIndex = 3;
            Btn_Limpar.Text = "Limpar";
            Btn_Limpar.UseVisualStyleBackColor = false;
            Btn_Limpar.Click += Btn_Limpar_Click;
            // 
            // Btn_Cadastrar
            // 
            Btn_Cadastrar.BackColor = SystemColors.ControlLightLight;
            Btn_Cadastrar.Font = new Font("Arial Rounded MT Bold", 12F);
            Btn_Cadastrar.Location = new Point(194, 593);
            Btn_Cadastrar.Margin = new Padding(4);
            Btn_Cadastrar.Name = "Btn_Cadastrar";
            Btn_Cadastrar.Size = new Size(175, 75);
            Btn_Cadastrar.TabIndex = 2;
            Btn_Cadastrar.Text = "Cadastrar";
            Btn_Cadastrar.UseVisualStyleBackColor = false;
            Btn_Cadastrar.Click += Btn_Cadastrar_Click;
            // 
            // Btn_Novo
            // 
            Btn_Novo.BackColor = SystemColors.ControlLightLight;
            Btn_Novo.Font = new Font("Arial Rounded MT Bold", 12F);
            Btn_Novo.Location = new Point(11, 593);
            Btn_Novo.Margin = new Padding(4);
            Btn_Novo.Name = "Btn_Novo";
            Btn_Novo.Size = new Size(175, 75);
            Btn_Novo.TabIndex = 1;
            Btn_Novo.Text = "Novo";
            Btn_Novo.UseVisualStyleBackColor = false;
            Btn_Novo.Click += Btn_Novo_Click;
            // 
            // Btn_voltar2
            // 
            Btn_voltar2.BackColor = SystemColors.ControlLightLight;
            Btn_voltar2.Font = new Font("Arial Rounded MT Bold", 12F);
            Btn_voltar2.Location = new Point(1109, 593);
            Btn_voltar2.Margin = new Padding(4);
            Btn_voltar2.Name = "Btn_voltar2";
            Btn_voltar2.Size = new Size(143, 75);
            Btn_voltar2.TabIndex = 6;
            Btn_voltar2.Text = "Voltar";
            Btn_voltar2.UseVisualStyleBackColor = false;
            Btn_voltar2.Click += Btn_voltar2_Click;
            // 
            // Gpb_Pesquisar
            // 
            Gpb_Pesquisar.BackColor = SystemColors.ControlLightLight;
            Gpb_Pesquisar.Controls.Add(cbxCategoriasDesc);
            Gpb_Pesquisar.Controls.Add(ltb_Pesquisar);
            Gpb_Pesquisar.Controls.Add(Txt_Descricao);
            Gpb_Pesquisar.Controls.Add(label1);
            Gpb_Pesquisar.Controls.Add(rdbCategoria);
            Gpb_Pesquisar.Controls.Add(rdbNome);
            Gpb_Pesquisar.Location = new Point(5, 209);
            Gpb_Pesquisar.Name = "Gpb_Pesquisar";
            Gpb_Pesquisar.Size = new Size(1246, 377);
            Gpb_Pesquisar.TabIndex = 8;
            Gpb_Pesquisar.TabStop = false;
            Gpb_Pesquisar.Text = "Pesquisar por";
            Gpb_Pesquisar.Visible = false;
            // 
            // cbxCategoriasDesc
            // 
            cbxCategoriasDesc.BackColor = SystemColors.Menu;
            cbxCategoriasDesc.FormattingEnabled = true;
            cbxCategoriasDesc.Location = new Point(115, 74);
            cbxCategoriasDesc.Name = "cbxCategoriasDesc";
            cbxCategoriasDesc.Size = new Size(1106, 26);
            cbxCategoriasDesc.TabIndex = 14;
            cbxCategoriasDesc.Visible = false;
            // 
            // ltb_Pesquisar
            // 
            ltb_Pesquisar.Font = new Font("Arial", 18F);
            ltb_Pesquisar.FormattingEnabled = true;
            ltb_Pesquisar.ItemHeight = 27;
            ltb_Pesquisar.Location = new Point(10, 106);
            ltb_Pesquisar.Name = "ltb_Pesquisar";
            ltb_Pesquisar.Size = new Size(1209, 247);
            ltb_Pesquisar.TabIndex = 11;
            ltb_Pesquisar.SelectedIndexChanged += ltb_Pesquisar_SelectedIndexChanged;
            // 
            // Txt_Descricao
            // 
            Txt_Descricao.BackColor = SystemColors.Menu;
            Txt_Descricao.Font = new Font("Arial", 12F);
            Txt_Descricao.Location = new Point(115, 74);
            Txt_Descricao.MaxLength = 100;
            Txt_Descricao.Name = "Txt_Descricao";
            Txt_Descricao.Size = new Size(1104, 26);
            Txt_Descricao.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 74);
            label1.Name = "label1";
            label1.Size = new Size(99, 18);
            label1.TabIndex = 13;
            label1.Text = "Descrição :";
            // 
            // rdbCategoria
            // 
            rdbCategoria.AutoSize = true;
            rdbCategoria.Font = new Font("Arial Rounded MT Bold", 16F);
            rdbCategoria.Location = new Point(577, 25);
            rdbCategoria.Name = "rdbCategoria";
            rdbCategoria.Size = new Size(136, 30);
            rdbCategoria.TabIndex = 9;
            rdbCategoria.Text = "Categoria";
            rdbCategoria.UseVisualStyleBackColor = true;
            rdbCategoria.CheckedChanged += rdbCategoria_CheckedChanged;
            // 
            // rdbNome
            // 
            rdbNome.AutoSize = true;
            rdbNome.Font = new Font("Arial Rounded MT Bold", 16F);
            rdbNome.Location = new Point(461, 23);
            rdbNome.Name = "rdbNome";
            rdbNome.Size = new Size(92, 30);
            rdbNome.TabIndex = 8;
            rdbNome.Text = "Nome";
            rdbNome.UseVisualStyleBackColor = true;
            rdbNome.CheckedChanged += rdbNome_CheckedChanged;
            // 
            // Btn_Excluir
            // 
            Btn_Excluir.BackColor = SystemColors.ControlLightLight;
            Btn_Excluir.Font = new Font("Arial Rounded MT Bold", 12F);
            Btn_Excluir.Location = new Point(743, 593);
            Btn_Excluir.Margin = new Padding(4);
            Btn_Excluir.Name = "Btn_Excluir";
            Btn_Excluir.Size = new Size(175, 75);
            Btn_Excluir.TabIndex = 29;
            Btn_Excluir.Text = "Excluir";
            Btn_Excluir.UseVisualStyleBackColor = false;
            Btn_Excluir.Click += Btn_Excluir_Click;
            // 
            // Btn_Alterar
            // 
            Btn_Alterar.BackColor = SystemColors.ControlLightLight;
            Btn_Alterar.Font = new Font("Arial Rounded MT Bold", 12F);
            Btn_Alterar.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Alterar.Location = new Point(560, 593);
            Btn_Alterar.Margin = new Padding(4);
            Btn_Alterar.Name = "Btn_Alterar";
            Btn_Alterar.Size = new Size(175, 75);
            Btn_Alterar.TabIndex = 28;
            Btn_Alterar.Text = "Alterar";
            Btn_Alterar.UseVisualStyleBackColor = false;
            Btn_Alterar.Click += Btn_Alterar_Click;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1264, 681);
            Controls.Add(Btn_Excluir);
            Controls.Add(Btn_Alterar);
            Controls.Add(Gpb_Pesquisar);
            Controls.Add(Btn_voltar2);
            Controls.Add(Btn_Voltar);
            Controls.Add(Btn_Pesquisar);
            Controls.Add(Btn_Limpar);
            Controls.Add(Btn_Cadastrar);
            Controls.Add(Btn_Novo);
            Controls.Add(Gpb_Estoque);
            Font = new Font("Arial Rounded MT Bold", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque";
            Load += FrmEstoque_Load;
            Gpb_Estoque.ResumeLayout(false);
            Gpb_Estoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctFotocubo).EndInit();
            Gpb_Pesquisar.ResumeLayout(false);
            Gpb_Pesquisar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox ltb_Pesquisar;
        private TextBox Txt_Descricao;
        private Label lbldescricao;
        private RadioButton Rb_Codigo;
        private RadioButton Rb_Nome;
        private GroupBox Gpb_Estoque;
        private TextBox Txt_Produto;
        
        private TextBox Txt_Codigo;
        private Label lblProduto;
        private Label lblCategoria;
        private Label lbl_Produto;
        private Label lblCodigo;
        private ComboBox cbxCategoria;
        private Button Btn_Voltar;
        private Button Btn_Pesquisar;
        private Button Btn_Limpar;
        private Button Btn_Cadastrar;
        private Button Btn_Novo;
        private MaskedTextBox txtQuantidade;
        private MaskedTextBox TxtDescricao;
        private Label lblQuantidade;
        private Label lblPreco;
        private TextBox txtProduto;
        public PictureBox pctFotocubo;
        private Button Btn_voltar2;
        private GroupBox Gpb_Pesquisar;
        private Label label1;
        private RadioButton rdbCategoria;
        private RadioButton rdbNome;
        private Button Btn_Excluir;
        private Button Btn_Alterar;
        private TextBox txt_preco;
        private ComboBox cbxCategoriasDesc;
    }
}