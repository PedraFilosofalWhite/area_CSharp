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
            Gpb_Cadastrar = new GroupBox();
            Gpb_Sexo = new GroupBox();
            Rb_NaoInfo = new RadioButton();
            Rb_Feminino = new RadioButton();
            Rb_Masculino = new RadioButton();
            Txt_Email = new TextBox();
            Txt_nome = new TextBox();
            Msk_Telefone = new MaskedTextBox();
            Txt_Codigo = new TextBox();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblNome = new Label();
            lblCodigo = new Label();
            Btn_Novo = new Button();
            Btn_Cadastrar = new Button();
            Btn_Alterar = new Button();
            Btn_Excluir = new Button();
            Btn_Limpar = new Button();
            Btn_Pesquisar = new Button();
            Btn_Voltar = new Button();
            Gpb_Pesquisar = new GroupBox();
            ltb_Pesquisar = new ListBox();
            Txt_Descricao = new TextBox();
            lblDescricao = new Label();
            Rb_Codigo = new RadioButton();
            Rb_Nome = new RadioButton();
            btn_voltar2 = new Button();
            Gpb_Cadastrar.SuspendLayout();
            Gpb_Sexo.SuspendLayout();
            Gpb_Pesquisar.SuspendLayout();
            SuspendLayout();
            // 
            // Gpb_Cadastrar
            // 
            Gpb_Cadastrar.BackColor = SystemColors.ControlLightLight;
            Gpb_Cadastrar.Controls.Add(Gpb_Sexo);
            Gpb_Cadastrar.Controls.Add(Txt_Email);
            Gpb_Cadastrar.Controls.Add(Txt_nome);
            Gpb_Cadastrar.Controls.Add(Msk_Telefone);
            Gpb_Cadastrar.Controls.Add(Txt_Codigo);
            Gpb_Cadastrar.Controls.Add(lblTelefone);
            Gpb_Cadastrar.Controls.Add(lblEmail);
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
            // Gpb_Sexo
            // 
            Gpb_Sexo.Controls.Add(Rb_NaoInfo);
            Gpb_Sexo.Controls.Add(Rb_Feminino);
            Gpb_Sexo.Controls.Add(Rb_Masculino);
            Gpb_Sexo.Location = new Point(1026, 26);
            Gpb_Sexo.Name = "Gpb_Sexo";
            Gpb_Sexo.Size = new Size(193, 120);
            Gpb_Sexo.TabIndex = 12;
            Gpb_Sexo.TabStop = false;
            Gpb_Sexo.Text = "Sexo";
            // 
            // Rb_NaoInfo
            // 
            Rb_NaoInfo.AutoSize = true;
            Rb_NaoInfo.Location = new Point(16, 85);
            Rb_NaoInfo.Name = "Rb_NaoInfo";
            Rb_NaoInfo.Size = new Size(130, 22);
            Rb_NaoInfo.TabIndex = 6;
            Rb_NaoInfo.TabStop = true;
            Rb_NaoInfo.Text = "Não Informar";
            Rb_NaoInfo.UseVisualStyleBackColor = true;
            // 
            // Rb_Feminino
            // 
            Rb_Feminino.AutoSize = true;
            Rb_Feminino.Location = new Point(16, 58);
            Rb_Feminino.Name = "Rb_Feminino";
            Rb_Feminino.Size = new Size(98, 22);
            Rb_Feminino.TabIndex = 5;
            Rb_Feminino.TabStop = true;
            Rb_Feminino.Text = "Feminino";
            Rb_Feminino.UseVisualStyleBackColor = true;
            // 
            // Rb_Masculino
            // 
            Rb_Masculino.AutoSize = true;
            Rb_Masculino.Location = new Point(16, 30);
            Rb_Masculino.Name = "Rb_Masculino";
            Rb_Masculino.Size = new Size(106, 22);
            Rb_Masculino.TabIndex = 4;
            Rb_Masculino.TabStop = true;
            Rb_Masculino.Text = "Masculino";
            Rb_Masculino.UseVisualStyleBackColor = true;
            // 
            // Txt_Email
            // 
            Txt_Email.Font = new Font("Arial", 12F);
            Txt_Email.Location = new Point(477, 110);
            Txt_Email.Name = "Txt_Email";
            Txt_Email.Size = new Size(525, 26);
            Txt_Email.TabIndex = 3;
            Txt_Email.TextChanged += Txt_Email_TextChanged;
            // 
            // Txt_nome
            // 
            Txt_nome.Font = new Font("Arial", 12F);
            Txt_nome.Location = new Point(278, 52);
            Txt_nome.Name = "Txt_nome";
            Txt_nome.Size = new Size(724, 26);
            Txt_nome.TabIndex = 1;
            // 
            // Msk_Telefone
            // 
            Msk_Telefone.Font = new Font("Arial", 12F);
            Msk_Telefone.Location = new Point(102, 112);
            Msk_Telefone.Name = "Msk_Telefone";
            Msk_Telefone.Size = new Size(307, 26);
            Msk_Telefone.TabIndex = 2;
            // 
            // Txt_Codigo
            // 
            Txt_Codigo.Font = new Font("Arial", 12F);
            Txt_Codigo.Location = new Point(89, 52);
            Txt_Codigo.Name = "Txt_Codigo";
            Txt_Codigo.Size = new Size(100, 26);
            Txt_Codigo.TabIndex = 7;
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
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(415, 115);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(56, 18);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(209, 55);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 18);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome :";
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
            Gpb_Pesquisar.Controls.Add(ltb_Pesquisar);
            Gpb_Pesquisar.Controls.Add(Txt_Descricao);
            Gpb_Pesquisar.Controls.Add(lblDescricao);
            Gpb_Pesquisar.Controls.Add(Rb_Codigo);
            Gpb_Pesquisar.Controls.Add(Rb_Nome);
            Gpb_Pesquisar.Location = new Point(12, 190);
            Gpb_Pesquisar.Name = "Gpb_Pesquisar";
            Gpb_Pesquisar.Size = new Size(1236, 404);
            Gpb_Pesquisar.TabIndex = 7;
            Gpb_Pesquisar.TabStop = false;
            Gpb_Pesquisar.Text = "Pesquisar por";
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
            Load += Cliente_Load;
            Gpb_Cadastrar.ResumeLayout(false);
            Gpb_Cadastrar.PerformLayout();
            Gpb_Sexo.ResumeLayout(false);
            Gpb_Sexo.PerformLayout();
            Gpb_Pesquisar.ResumeLayout(false);
            Gpb_Pesquisar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Gpb_Cadastrar;
        private Button Btn_Novo;
        private Button Btn_Cadastrar;
        private Button Btn_Alterar;
        private Button Btn_Excluir;
        private Button Btn_Limpar;
        private Button Btn_Pesquisar;
        private Button Btn_Voltar;
        private TextBox Txt_Codigo;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblNome;
        private Label lblCodigo;
        private TextBox Txt_Email;
        private TextBox Txt_nome;
        private MaskedTextBox Msk_Telefone;
        private GroupBox Gpb_Sexo;
        private RadioButton Rb_NaoInfo;
        private RadioButton Rb_Feminino;
        private RadioButton Rb_Masculino;
        private GroupBox Gpb_Pesquisar;
        private ListBox ltb_Pesquisar;
        private TextBox Txt_Descricao;
        private Label lblDescricao;
        private RadioButton Rb_Codigo;
        private RadioButton Rb_Nome;
        private Button btn_voltar2;
    }
}