namespace Barbearia
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            Panel_1 = new Panel();
            Bt_Sair = new Button();
            Bt_Entrar = new Button();
            Tb_Senha = new TextBox();
            Tb_Usuario = new TextBox();
            label2 = new Label();
            Panel_1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F);
            label1.Location = new Point(15, 56);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 0;
            label1.Text = "Usuário :";
            // 
            // Panel_1
            // 
            Panel_1.Controls.Add(Bt_Sair);
            Panel_1.Controls.Add(Bt_Entrar);
            Panel_1.Controls.Add(Tb_Senha);
            Panel_1.Controls.Add(Tb_Usuario);
            Panel_1.Controls.Add(label2);
            Panel_1.Controls.Add(label1);
            Panel_1.Location = new Point(291, 351);
            Panel_1.Name = "Panel_1";
            Panel_1.Size = new Size(669, 237);
            Panel_1.TabIndex = 0;
            Panel_1.Paint += Panel_1_Paint;
            // 
            // Bt_Sair
            // 
            Bt_Sair.Font = new Font("Arial", 20.25F);
            Bt_Sair.Location = new Point(514, 181);
            Bt_Sair.Name = "Bt_Sair";
            Bt_Sair.Size = new Size(140, 42);
            Bt_Sair.TabIndex = 4;
            Bt_Sair.Text = "Sair";
            Bt_Sair.UseVisualStyleBackColor = true;
            Bt_Sair.Click += Bt_Sair_Click;
            // 
            // Bt_Entrar
            // 
            Bt_Entrar.Font = new Font("Arial", 20.25F);
            Bt_Entrar.Location = new Point(15, 181);
            Bt_Entrar.Name = "Bt_Entrar";
            Bt_Entrar.Size = new Size(140, 42);
            Bt_Entrar.TabIndex = 3;
            Bt_Entrar.Text = "Entrar";
            Bt_Entrar.UseVisualStyleBackColor = true;
            Bt_Entrar.Click += Bt_Entrar_Click;
            // 
            // Tb_Senha
            // 
            Tb_Senha.Font = new Font("Arial", 20.25F);
            Tb_Senha.Location = new Point(144, 119);
            Tb_Senha.Name = "Tb_Senha";
            Tb_Senha.Size = new Size(510, 39);
            Tb_Senha.TabIndex = 2;
            // 
            // Tb_Usuario
            // 
            Tb_Usuario.Font = new Font("Arial", 20.25F);
            Tb_Usuario.Location = new Point(144, 53);
            Tb_Usuario.Name = "Tb_Usuario";
            Tb_Usuario.Size = new Size(510, 39);
            Tb_Usuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F);
            label2.Location = new Point(15, 119);
            label2.Name = "label2";
            label2.Size = new Size(108, 32);
            label2.TabIndex = 1;
            label2.Text = "Senha :";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 677);
            Controls.Add(Panel_1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            Panel_1.ResumeLayout(false);
            Panel_1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel Panel_1;
        private TextBox Tb_Senha;
        private TextBox Tb_Usuario;
        private Label label2;
        private Button Bt_Sair;
        private Button Bt_Entrar;
    }
}
