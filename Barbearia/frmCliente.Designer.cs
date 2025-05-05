namespace Barbearia
{
    partial class Cliente
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
            Btn_Novo = new Button();
            Btn_Cadastrar = new Button();
            Btn_Alterar = new Button();
            Btn_Excluir = new Button();
            Btn_Limpar = new Button();
            Btn_Pesquisar = new Button();
            Btn_Voltar = new Button();
            Gpb_Pesquisar = new GroupBox();
            rdbVip = new RadioButton();
            ltb_Pesquisar = new ListBox();
            Txt_Descricao = new TextBox();
            lblDescricao = new Label();
            rdbCodigo = new RadioButton();
            rdbNome = new RadioButton();
            btn_voltar2 = new Button();
            lblCodigo = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            Txt_Codigo = new TextBox();
            Msk_Telefone = new MaskedTextBox();
            Txt_nome = new TextBox();
            gpbVip = new GroupBox();
            rdbVipNao = new RadioButton();
            rdbVipSim = new RadioButton();
            Gpb_Cadastrar = new GroupBox();
            Gpb_Pesquisar.SuspendLayout();
            gpbVip.SuspendLayout();
            Gpb_Cadastrar.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Novo
            // 
            Btn_Novo.BackColor = SystemColors.ControlLightLight;
            Btn_Novo.Location = new Point(2, 600);
            Btn_Novo.Name = "Btn_Novo";
            Btn_Novo.Size = new Size(175, 75);
            Btn_Novo.TabIndex = 12;
            Btn_Novo.Text = "&Novo";
            Btn_Novo.UseVisualStyleBackColor = false;
            Btn_Novo.Click += Btn_Novo_Click;
            // 
            // Btn_Cadastrar
            // 
            Btn_Cadastrar.BackColor = SystemColors.ControlLightLight;
            Btn_Cadastrar.Location = new Point(183, 600);
            Btn_Cadastrar.Name = "Btn_Cadastrar";
            Btn_Cadastrar.Size = new Size(175, 75);
            Btn_Cadastrar.TabIndex = 13;
            Btn_Cadastrar.Text = "&Cadastrar";
            Btn_Cadastrar.UseVisualStyleBackColor = false;
            Btn_Cadastrar.Click += Btn_Cadastrar_Click;
            // 
            // Btn_Alterar
            // 
            Btn_Alterar.BackColor = SystemColors.ControlLightLight;
            Btn_Alterar.Location = new Point(540, 600);
            Btn_Alterar.Name = "Btn_Alterar";
            Btn_Alterar.Size = new Size(175, 75);
            Btn_Alterar.TabIndex = 15;
            Btn_Alterar.Text = "&Alterar";
            Btn_Alterar.UseVisualStyleBackColor = false;
            Btn_Alterar.Click += Btn_Alterar_Click;
            // 
            // Btn_Excluir
            // 
            Btn_Excluir.BackColor = SystemColors.ControlLightLight;
            Btn_Excluir.Location = new Point(721, 600);
            Btn_Excluir.Name = "Btn_Excluir";
            Btn_Excluir.Size = new Size(175, 75);
            Btn_Excluir.TabIndex = 17;
            Btn_Excluir.Text = "&Excluir";
            Btn_Excluir.UseVisualStyleBackColor = false;
            Btn_Excluir.Click += Btn_Excluir_Click;
            // 
            // Btn_Limpar
            // 
            Btn_Limpar.BackColor = SystemColors.ControlLightLight;
            Btn_Limpar.Location = new Point(364, 600);
            Btn_Limpar.Name = "Btn_Limpar";
            Btn_Limpar.Size = new Size(175, 75);
            Btn_Limpar.TabIndex = 14;
            Btn_Limpar.Text = "&Limpar";
            Btn_Limpar.UseVisualStyleBackColor = false;
            Btn_Limpar.Click += Btn_Limpar_Click;
            // 
            // Btn_Pesquisar
            // 
            Btn_Pesquisar.BackColor = SystemColors.ControlLightLight;
            Btn_Pesquisar.Location = new Point(902, 600);
            Btn_Pesquisar.Name = "Btn_Pesquisar";
            Btn_Pesquisar.Size = new Size(175, 75);
            Btn_Pesquisar.TabIndex = 16;
            Btn_Pesquisar.Text = "&Pesquisar";
            Btn_Pesquisar.UseVisualStyleBackColor = false;
            Btn_Pesquisar.Click += Btn_Pesquisar_Click;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.Location = new Point(1083, 600);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(175, 75);
            Btn_Voltar.TabIndex = 18;
            Btn_Voltar.Text = "&Voltar";
            Btn_Voltar.UseVisualStyleBackColor = true;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // Gpb_Pesquisar
            // 
            Gpb_Pesquisar.BackColor = SystemColors.ControlLightLight;
            Gpb_Pesquisar.Controls.Add(rdbVip);
            Gpb_Pesquisar.Controls.Add(ltb_Pesquisar);
            Gpb_Pesquisar.Controls.Add(Txt_Descricao);
            Gpb_Pesquisar.Controls.Add(lblDescricao);
            Gpb_Pesquisar.Controls.Add(rdbCodigo);
            Gpb_Pesquisar.Controls.Add(rdbNome);
            Gpb_Pesquisar.Location = new Point(12, 190);
            Gpb_Pesquisar.Name = "Gpb_Pesquisar";
            Gpb_Pesquisar.Size = new Size(1236, 404);
            Gpb_Pesquisar.TabIndex = 7;
            Gpb_Pesquisar.TabStop = false;
            Gpb_Pesquisar.Text = "Pesquisar por";
            // 
            // rdbVip
            // 
            rdbVip.AutoSize = true;
            rdbVip.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbVip.Location = new Point(709, 25);
            rdbVip.Name = "rdbVip";
            rdbVip.Size = new Size(61, 28);
            rdbVip.TabIndex = 14;
            rdbVip.TabStop = true;
            rdbVip.Text = "Vip";
            rdbVip.UseVisualStyleBackColor = true;
            // 
            // ltb_Pesquisar
            // 
            ltb_Pesquisar.Font = new Font("Arial", 12F);
            ltb_Pesquisar.FormattingEnabled = true;
            ltb_Pesquisar.ItemHeight = 18;
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
            // rdbCodigo
            // 
            rdbCodigo.AutoSize = true;
            rdbCodigo.Font = new Font("Arial Rounded MT Bold", 16F);
            rdbCodigo.Location = new Point(577, 25);
            rdbCodigo.Name = "rdbCodigo";
            rdbCodigo.Size = new Size(106, 30);
            rdbCodigo.TabIndex = 9;
            rdbCodigo.TabStop = true;
            rdbCodigo.Text = "Código";
            rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            rdbNome.AutoSize = true;
            rdbNome.Font = new Font("Arial Rounded MT Bold", 16F);
            rdbNome.Location = new Point(461, 23);
            rdbNome.Name = "rdbNome";
            rdbNome.Size = new Size(92, 30);
            rdbNome.TabIndex = 8;
            rdbNome.TabStop = true;
            rdbNome.Text = "Nome";
            rdbNome.UseVisualStyleBackColor = true;
            // 
            // btn_voltar2
            // 
            btn_voltar2.BackColor = SystemColors.ControlLightLight;
            btn_voltar2.Location = new Point(1083, 600);
            btn_voltar2.Name = "btn_voltar2";
            btn_voltar2.Size = new Size(175, 75);
            btn_voltar2.TabIndex = 19;
            btn_voltar2.Text = "&Voltar";
            btn_voltar2.UseVisualStyleBackColor = false;
            btn_voltar2.Visible = false;
            btn_voltar2.Click += btn_voltar2_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(10, 55);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(73, 18);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código :";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(191, 54);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 18);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome :";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(10, 115);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(86, 18);
            lblTelefone.TabIndex = 4;
            lblTelefone.Text = "Telefone :";
            // 
            // Txt_Codigo
            // 
            Txt_Codigo.Font = new Font("Arial", 12F);
            Txt_Codigo.Location = new Point(89, 52);
            Txt_Codigo.Name = "Txt_Codigo";
            Txt_Codigo.Size = new Size(100, 26);
            Txt_Codigo.TabIndex = 7;
            // 
            // Msk_Telefone
            // 
            Msk_Telefone.Font = new Font("Arial", 12F);
            Msk_Telefone.Location = new Point(102, 112);
            Msk_Telefone.Mask = "00000-9999";
            Msk_Telefone.Name = "Msk_Telefone";
            Msk_Telefone.Size = new Size(307, 26);
            Msk_Telefone.TabIndex = 2;
            Msk_Telefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // Txt_nome
            // 
            Txt_nome.Font = new Font("Arial", 12F);
            Txt_nome.Location = new Point(260, 51);
            Txt_nome.MaxLength = 100;
            Txt_nome.Name = "Txt_nome";
            Txt_nome.Size = new Size(724, 26);
            Txt_nome.TabIndex = 1;
            // 
            // gpbVip
            // 
            gpbVip.Controls.Add(rdbVipNao);
            gpbVip.Controls.Add(rdbVipSim);
            gpbVip.Location = new Point(528, 92);
            gpbVip.Name = "gpbVip";
            gpbVip.Size = new Size(292, 65);
            gpbVip.TabIndex = 12;
            gpbVip.TabStop = false;
            gpbVip.Text = "Vip";
            // 
            // rdbVipNao
            // 
            rdbVipNao.AutoSize = true;
            rdbVipNao.Location = new Point(189, 27);
            rdbVipNao.Name = "rdbVipNao";
            rdbVipNao.Size = new Size(58, 22);
            rdbVipNao.TabIndex = 5;
            rdbVipNao.TabStop = true;
            rdbVipNao.Text = "Não";
            rdbVipNao.UseVisualStyleBackColor = true;
            // 
            // rdbVipSim
            // 
            rdbVipSim.AutoSize = true;
            rdbVipSim.Location = new Point(63, 29);
            rdbVipSim.Name = "rdbVipSim";
            rdbVipSim.Size = new Size(55, 22);
            rdbVipSim.TabIndex = 4;
            rdbVipSim.TabStop = true;
            rdbVipSim.Text = "Sim";
            rdbVipSim.UseVisualStyleBackColor = true;
            // 
            // Gpb_Cadastrar
            // 
            Gpb_Cadastrar.BackColor = SystemColors.ControlLightLight;
            Gpb_Cadastrar.Controls.Add(gpbVip);
            Gpb_Cadastrar.Controls.Add(Txt_nome);
            Gpb_Cadastrar.Controls.Add(Msk_Telefone);
            Gpb_Cadastrar.Controls.Add(Txt_Codigo);
            Gpb_Cadastrar.Controls.Add(lblTelefone);
            Gpb_Cadastrar.Controls.Add(lblNome);
            Gpb_Cadastrar.Controls.Add(lblCodigo);
            Gpb_Cadastrar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Gpb_Cadastrar.Location = new Point(12, 13);
            Gpb_Cadastrar.Margin = new Padding(4);
            Gpb_Cadastrar.Name = "Gpb_Cadastrar";
            Gpb_Cadastrar.Padding = new Padding(4);
            Gpb_Cadastrar.Size = new Size(1236, 164);
            Gpb_Cadastrar.TabIndex = 0;
            Gpb_Cadastrar.TabStop = false;
            Gpb_Cadastrar.Text = "Cadastro";
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1260, 677);
            Controls.Add(btn_voltar2);
            Controls.Add(Gpb_Pesquisar);
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
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            Gpb_Pesquisar.ResumeLayout(false);
            Gpb_Pesquisar.PerformLayout();
            gpbVip.ResumeLayout(false);
            gpbVip.PerformLayout();
            Gpb_Cadastrar.ResumeLayout(false);
            Gpb_Cadastrar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Btn_Novo;
        private Button Btn_Cadastrar;
        private Button Btn_Alterar;
        private Button Btn_Excluir;
        private Button Btn_Limpar;
        private Button Btn_Pesquisar;
        private Button Btn_Voltar;
        private GroupBox Gpb_Pesquisar;
        private ListBox ltb_Pesquisar;
        private TextBox Txt_Descricao;
        private Label lblDescricao;
        private Button btn_voltar2;
        private RadioButton rdbVip;
        private RadioButton rdbCodigo;
        private RadioButton rdbNome;
        private Label lblCodigo;
        private Label lblNome;
        private Label lblTelefone;
        private TextBox Txt_Codigo;
        private MaskedTextBox Msk_Telefone;
        private TextBox Txt_nome;
        private GroupBox gpbVip;
        private RadioButton rdbVipNao;
        private RadioButton rdbVipSim;
        private GroupBox Gpb_Cadastrar;
    }
}