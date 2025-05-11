namespace Barbearia
{
    partial class FrmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            btn_voltar2 = new Button();
            Gpb_Pesquisar = new GroupBox();
            ltb_Pesquisar = new ListBox();
            Txt_Descricao = new TextBox();
            lblDescricao = new Label();
            Rb_Codigo = new RadioButton();
            Rb_Nome = new RadioButton();
            Btn_Voltar = new Button();
            Btn_Pesquisar = new Button();
            Btn_Limpar = new Button();
            Btn_Excluir = new Button();
            Btn_Alterar = new Button();
            Btn_Cadastrar = new Button();
            Btn_Novo = new Button();
            Gpb_Cadastrar = new GroupBox();
            mskAluguel = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtLogin = new TextBox();
            lblLogin = new Label();
            label2 = new Label();
            mskCPF = new MaskedTextBox();
            label1 = new Label();
            Txt_nome = new TextBox();
            Msk_Telefone = new MaskedTextBox();
            Txt_Codigo = new TextBox();
            lblTelefone = new Label();
            lblNome = new Label();
            lblCodigo = new Label();
            Gpb_Pesquisar.SuspendLayout();
            Gpb_Cadastrar.SuspendLayout();
            SuspendLayout();
            // 
            // btn_voltar2
            // 
            btn_voltar2.BackColor = SystemColors.ControlLightLight;
            btn_voltar2.Location = new Point(1083, 600);
            btn_voltar2.Name = "btn_voltar2";
            btn_voltar2.Size = new Size(175, 75);
            btn_voltar2.TabIndex = 29;
            btn_voltar2.Text = "&Voltar";
            btn_voltar2.UseVisualStyleBackColor = false;
            btn_voltar2.Click += btn_voltar2_Click;
            // 
            // Gpb_Pesquisar
            // 
            Gpb_Pesquisar.BackColor = SystemColors.ControlLightLight;
            Gpb_Pesquisar.Controls.Add(ltb_Pesquisar);
            Gpb_Pesquisar.Controls.Add(Txt_Descricao);
            Gpb_Pesquisar.Controls.Add(lblDescricao);
            Gpb_Pesquisar.Controls.Add(Rb_Codigo);
            Gpb_Pesquisar.Controls.Add(Rb_Nome);
            Gpb_Pesquisar.Location = new Point(12, 184);
            Gpb_Pesquisar.Name = "Gpb_Pesquisar";
            Gpb_Pesquisar.Size = new Size(1236, 404);
            Gpb_Pesquisar.TabIndex = 21;
            Gpb_Pesquisar.TabStop = false;
            Gpb_Pesquisar.Text = "Pesquisar por";
            // 
            // ltb_Pesquisar
            // 
            ltb_Pesquisar.Font = new Font("Arial", 18F);
            ltb_Pesquisar.FormattingEnabled = true;
            ltb_Pesquisar.ItemHeight = 27;
            ltb_Pesquisar.Location = new Point(10, 106);
            ltb_Pesquisar.Name = "ltb_Pesquisar";
            ltb_Pesquisar.Size = new Size(1209, 274);
            ltb_Pesquisar.TabIndex = 11;
            ltb_Pesquisar.SelectedIndexChanged += ltb_Pesquisar_SelectedIndexChanged;
            // 
            // Txt_Descricao
            // 
            Txt_Descricao.Font = new Font("Arial", 12F);
            Txt_Descricao.Location = new Point(115, 74);
            Txt_Descricao.MaxLength = 100;
            Txt_Descricao.Name = "Txt_Descricao";
            Txt_Descricao.Size = new Size(1104, 26);
            Txt_Descricao.TabIndex = 10;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(10, 74);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(99, 18);
            lblDescricao.TabIndex = 13;
            lblDescricao.Text = "Descrição :";
            // 
            // Rb_Codigo
            // 
            Rb_Codigo.AutoSize = true;
            Rb_Codigo.Font = new Font("Arial Rounded MT Bold", 16F);
            Rb_Codigo.Location = new Point(621, 25);
            Rb_Codigo.Name = "Rb_Codigo";
            Rb_Codigo.Size = new Size(106, 30);
            Rb_Codigo.TabIndex = 9;
            Rb_Codigo.TabStop = true;
            Rb_Codigo.Text = "Código";
            Rb_Codigo.UseVisualStyleBackColor = true;
            // 
            // Rb_Nome
            // 
            Rb_Nome.AutoSize = true;
            Rb_Nome.Font = new Font("Arial Rounded MT Bold", 16F);
            Rb_Nome.Location = new Point(466, 25);
            Rb_Nome.Name = "Rb_Nome";
            Rb_Nome.Size = new Size(92, 30);
            Rb_Nome.TabIndex = 8;
            Rb_Nome.TabStop = true;
            Rb_Nome.Text = "Nome";
            Rb_Nome.UseVisualStyleBackColor = true;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = SystemColors.ControlLightLight;
            Btn_Voltar.Location = new Point(1083, 600);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(175, 75);
            Btn_Voltar.TabIndex = 28;
            Btn_Voltar.Text = "&Voltar";
            Btn_Voltar.UseVisualStyleBackColor = false;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // Btn_Pesquisar
            // 
            Btn_Pesquisar.BackColor = SystemColors.ControlLightLight;
            Btn_Pesquisar.Location = new Point(902, 600);
            Btn_Pesquisar.Name = "Btn_Pesquisar";
            Btn_Pesquisar.Size = new Size(175, 75);
            Btn_Pesquisar.TabIndex = 26;
            Btn_Pesquisar.Text = "&Pesquisar";
            Btn_Pesquisar.UseVisualStyleBackColor = false;
            Btn_Pesquisar.Click += Btn_Pesquisar_Click;
            // 
            // Btn_Limpar
            // 
            Btn_Limpar.BackColor = SystemColors.ControlLightLight;
            Btn_Limpar.Location = new Point(364, 600);
            Btn_Limpar.Name = "Btn_Limpar";
            Btn_Limpar.Size = new Size(175, 75);
            Btn_Limpar.TabIndex = 24;
            Btn_Limpar.Text = "&Limpar";
            Btn_Limpar.UseVisualStyleBackColor = false;
            Btn_Limpar.Click += Btn_Limpar_Click;
            // 
            // Btn_Excluir
            // 
            Btn_Excluir.BackColor = SystemColors.ControlLightLight;
            Btn_Excluir.Location = new Point(721, 600);
            Btn_Excluir.Name = "Btn_Excluir";
            Btn_Excluir.Size = new Size(175, 75);
            Btn_Excluir.TabIndex = 27;
            Btn_Excluir.Text = "&Excluir";
            Btn_Excluir.UseVisualStyleBackColor = false;
            Btn_Excluir.Click += Btn_Excluir_Click;
            // 
            // Btn_Alterar
            // 
            Btn_Alterar.BackColor = SystemColors.ControlLightLight;
            Btn_Alterar.Location = new Point(540, 600);
            Btn_Alterar.Name = "Btn_Alterar";
            Btn_Alterar.Size = new Size(175, 75);
            Btn_Alterar.TabIndex = 25;
            Btn_Alterar.Text = "&Alterar";
            Btn_Alterar.UseVisualStyleBackColor = false;
            Btn_Alterar.Click += Btn_Alterar_Click;
            // 
            // Btn_Cadastrar
            // 
            Btn_Cadastrar.BackColor = SystemColors.ControlLightLight;
            Btn_Cadastrar.Location = new Point(183, 600);
            Btn_Cadastrar.Name = "Btn_Cadastrar";
            Btn_Cadastrar.Size = new Size(175, 75);
            Btn_Cadastrar.TabIndex = 23;
            Btn_Cadastrar.Text = "&Cadastrar";
            Btn_Cadastrar.UseVisualStyleBackColor = false;
            Btn_Cadastrar.Click += Btn_Cadastrar_Click;
            // 
            // Btn_Novo
            // 
            Btn_Novo.BackColor = SystemColors.ControlLightLight;
            Btn_Novo.Location = new Point(2, 600);
            Btn_Novo.Name = "Btn_Novo";
            Btn_Novo.Size = new Size(175, 75);
            Btn_Novo.TabIndex = 22;
            Btn_Novo.Text = "&Novo";
            Btn_Novo.UseVisualStyleBackColor = false;
            Btn_Novo.Click += Btn_Novo_Click;
            // 
            // Gpb_Cadastrar
            // 
            Gpb_Cadastrar.BackColor = SystemColors.ControlLightLight;
            Gpb_Cadastrar.Controls.Add(mskAluguel);
            Gpb_Cadastrar.Controls.Add(txtSenha);
            Gpb_Cadastrar.Controls.Add(lblSenha);
            Gpb_Cadastrar.Controls.Add(txtLogin);
            Gpb_Cadastrar.Controls.Add(lblLogin);
            Gpb_Cadastrar.Controls.Add(label2);
            Gpb_Cadastrar.Controls.Add(mskCPF);
            Gpb_Cadastrar.Controls.Add(label1);
            Gpb_Cadastrar.Controls.Add(Txt_nome);
            Gpb_Cadastrar.Controls.Add(Msk_Telefone);
            Gpb_Cadastrar.Controls.Add(Txt_Codigo);
            Gpb_Cadastrar.Controls.Add(lblTelefone);
            Gpb_Cadastrar.Controls.Add(lblNome);
            Gpb_Cadastrar.Controls.Add(lblCodigo);
            Gpb_Cadastrar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Gpb_Cadastrar.Location = new Point(12, 7);
            Gpb_Cadastrar.Margin = new Padding(4);
            Gpb_Cadastrar.Name = "Gpb_Cadastrar";
            Gpb_Cadastrar.Padding = new Padding(4);
            Gpb_Cadastrar.Size = new Size(1236, 164);
            Gpb_Cadastrar.TabIndex = 20;
            Gpb_Cadastrar.TabStop = false;
            Gpb_Cadastrar.Text = "Cadastro";
            // 
            // mskAluguel
            // 
            mskAluguel.Font = new Font("Arial", 12F);
            mskAluguel.Location = new Point(393, 112);
            mskAluguel.MaxLength = 5;
            mskAluguel.Name = "mskAluguel";
            mskAluguel.Size = new Size(89, 26);
            mskAluguel.TabIndex = 5;
            mskAluguel.KeyPress += mskAluguel_KeyPress;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Arial", 12F);
            txtSenha.Location = new Point(779, 112);
            txtSenha.MaxLength = 10;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(440, 26);
            txtSenha.TabIndex = 7;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(709, 116);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(64, 18);
            lblSenha.TabIndex = 14;
            lblSenha.Text = "Senha:";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Arial", 12F);
            txtLogin.Location = new Point(721, 52);
            txtLogin.MaxLength = 50;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(498, 26);
            txtLogin.TabIndex = 3;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(658, 55);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(57, 18);
            lblLogin.TabIndex = 12;
            lblLogin.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 116);
            label2.Name = "label2";
            label2.Size = new Size(194, 18);
            label2.TabIndex = 11;
            label2.Text = "Aluguel da Cadeira: R$ ";
            // 
            // mskCPF
            // 
            mskCPF.Font = new Font("Arial", 12F);
            mskCPF.Location = new Point(539, 112);
            mskCPF.Mask = "000,000,000-99";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(164, 26);
            mskCPF.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(488, 116);
            label1.Name = "label1";
            label1.Size = new Size(50, 18);
            label1.TabIndex = 9;
            label1.Text = "CPF :";
            // 
            // Txt_nome
            // 
            Txt_nome.Font = new Font("Arial", 12F);
            Txt_nome.Location = new Point(264, 52);
            Txt_nome.MaxLength = 100;
            Txt_nome.Name = "Txt_nome";
            Txt_nome.Size = new Size(384, 26);
            Txt_nome.TabIndex = 2;
            // 
            // Msk_Telefone
            // 
            Msk_Telefone.Font = new Font("Arial", 12F);
            Msk_Telefone.Location = new Point(103, 112);
            Msk_Telefone.Mask = "99999-9999";
            Msk_Telefone.Name = "Msk_Telefone";
            Msk_Telefone.Size = new Size(99, 26);
            Msk_Telefone.TabIndex = 4;
            // 
            // Txt_Codigo
            // 
            Txt_Codigo.Font = new Font("Arial", 12F);
            Txt_Codigo.Location = new Point(89, 52);
            Txt_Codigo.Name = "Txt_Codigo";
            Txt_Codigo.Size = new Size(100, 26);
            Txt_Codigo.TabIndex = 1;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(11, 116);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(86, 18);
            lblTelefone.TabIndex = 4;
            lblTelefone.Text = "Telefone :";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(195, 56);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 18);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome :";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(11, 56);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(73, 18);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código :";
            // 
            // FrmFuncionario
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 677);
            Controls.Add(Gpb_Pesquisar);
            Controls.Add(btn_voltar2);
            Controls.Add(Btn_Voltar);
            Controls.Add(Btn_Pesquisar);
            Controls.Add(Btn_Limpar);
            Controls.Add(Btn_Excluir);
            Controls.Add(Btn_Alterar);
            Controls.Add(Btn_Cadastrar);
            Controls.Add(Btn_Novo);
            Controls.Add(Gpb_Cadastrar);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionários";
            Load += FrmFuncionario_Load;
            Gpb_Pesquisar.ResumeLayout(false);
            Gpb_Pesquisar.PerformLayout();
            Gpb_Cadastrar.ResumeLayout(false);
            Gpb_Cadastrar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_voltar2;
        private GroupBox Gpb_Pesquisar;
        private ListBox ltb_Pesquisar;
        private TextBox Txt_Descricao;
        private Label lblDescricao;
        private RadioButton Rb_Codigo;
        private RadioButton Rb_Nome;
        private Button Btn_Voltar;
        private Button Btn_Pesquisar;
        private Button Btn_Limpar;
        private Button Btn_Excluir;
        private Button Btn_Alterar;
        private Button Btn_Cadastrar;
        private Button Btn_Novo;
        private GroupBox Gpb_Cadastrar;
        private Label label2;
        private MaskedTextBox mskCPF;
        private Label label1;
        private TextBox Txt_nome;
        private MaskedTextBox Msk_Telefone;
        private TextBox Txt_Codigo;
        private Label lblTelefone;
        private Label lblNome;
        private Label lblCodigo;
        private Label lblLogin;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtLogin;
        private TextBox mskAluguel;
    }
}