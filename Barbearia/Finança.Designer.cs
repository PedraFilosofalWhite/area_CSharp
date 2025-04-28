namespace Barbearia
{
    partial class Finança
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
            Btn_Voltar = new Button();
            label1 = new Label();
            lbl_PeriodoDe = new Label();
            lbl_Ate = new Label();
            lbl_Entradas = new Label();
            lbl_Saldo = new Label();
            dtp_PeriodoDe = new DateTimePicker();
            dtp_Ate = new DateTimePicker();
            gpb_ResumoFinanceiro = new GroupBox();
            txb_Saldo = new TextBox();
            txb_Entradas = new TextBox();
            gpb_ResumoFinanceiro.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.Font = new Font("Arial Rounded MT Bold", 12F);
            Btn_Voltar.Location = new Point(12, 590);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(175, 75);
            Btn_Voltar.TabIndex = 19;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.UseVisualStyleBackColor = true;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(165, 18);
            label1.TabIndex = 20;
            label1.Text = "Ordens de Serviços";
            // 
            // lbl_PeriodoDe
            // 
            lbl_PeriodoDe.AutoSize = true;
            lbl_PeriodoDe.Font = new Font("Arial Rounded MT Bold", 12F);
            lbl_PeriodoDe.Location = new Point(418, 240);
            lbl_PeriodoDe.Name = "lbl_PeriodoDe";
            lbl_PeriodoDe.Size = new Size(105, 18);
            lbl_PeriodoDe.TabIndex = 22;
            lbl_PeriodoDe.Text = "Período - De";
            // 
            // lbl_Ate
            // 
            lbl_Ate.AutoSize = true;
            lbl_Ate.Font = new Font("Arial Rounded MT Bold", 12F);
            lbl_Ate.Location = new Point(670, 239);
            lbl_Ate.Name = "lbl_Ate";
            lbl_Ate.Size = new Size(36, 18);
            lbl_Ate.TabIndex = 23;
            lbl_Ate.Text = "Até";
            // 
            // lbl_Entradas
            // 
            lbl_Entradas.AutoSize = true;
            lbl_Entradas.Location = new Point(39, 79);
            lbl_Entradas.Name = "lbl_Entradas";
            lbl_Entradas.Size = new Size(86, 18);
            lbl_Entradas.TabIndex = 24;
            lbl_Entradas.Text = "Entradas:";
            // 
            // lbl_Saldo
            // 
            lbl_Saldo.AutoSize = true;
            lbl_Saldo.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Saldo.Location = new Point(50, 161);
            lbl_Saldo.Name = "lbl_Saldo";
            lbl_Saldo.Size = new Size(68, 22);
            lbl_Saldo.TabIndex = 25;
            lbl_Saldo.Text = "Saldo:";
            // 
            // dtp_PeriodoDe
            // 
            dtp_PeriodoDe.Font = new Font("Arial Rounded MT Bold", 12F);
            dtp_PeriodoDe.Format = DateTimePickerFormat.Short;
            dtp_PeriodoDe.Location = new Point(527, 236);
            dtp_PeriodoDe.Name = "dtp_PeriodoDe";
            dtp_PeriodoDe.Size = new Size(133, 26);
            dtp_PeriodoDe.TabIndex = 26;
            // 
            // dtp_Ate
            // 
            dtp_Ate.Font = new Font("Arial Rounded MT Bold", 12F);
            dtp_Ate.Format = DateTimePickerFormat.Short;
            dtp_Ate.Location = new Point(709, 236);
            dtp_Ate.Name = "dtp_Ate";
            dtp_Ate.Size = new Size(135, 26);
            dtp_Ate.TabIndex = 27;
            // 
            // gpb_ResumoFinanceiro
            // 
            gpb_ResumoFinanceiro.Controls.Add(txb_Saldo);
            gpb_ResumoFinanceiro.Controls.Add(txb_Entradas);
            gpb_ResumoFinanceiro.Controls.Add(lbl_Saldo);
            gpb_ResumoFinanceiro.Controls.Add(lbl_Entradas);
            gpb_ResumoFinanceiro.Font = new Font("Arial Rounded MT Bold", 12F);
            gpb_ResumoFinanceiro.Location = new Point(447, 271);
            gpb_ResumoFinanceiro.Name = "gpb_ResumoFinanceiro";
            gpb_ResumoFinanceiro.Size = new Size(362, 251);
            gpb_ResumoFinanceiro.TabIndex = 28;
            gpb_ResumoFinanceiro.TabStop = false;
            gpb_ResumoFinanceiro.Text = "Resumo Financeiro";
            // 
            // txb_Saldo
            // 
            txb_Saldo.Location = new Point(202, 161);
            txb_Saldo.Name = "txb_Saldo";
            txb_Saldo.Size = new Size(100, 26);
            txb_Saldo.TabIndex = 30;
            // 
            // txb_Entradas
            // 
            txb_Entradas.Location = new Point(202, 76);
            txb_Entradas.Name = "txb_Entradas";
            txb_Entradas.Size = new Size(100, 26);
            txb_Entradas.TabIndex = 29;
            // 
            // Finança
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 677);
            Controls.Add(gpb_ResumoFinanceiro);
            Controls.Add(dtp_Ate);
            Controls.Add(dtp_PeriodoDe);
            Controls.Add(lbl_Ate);
            Controls.Add(lbl_PeriodoDe);
            Controls.Add(label1);
            Controls.Add(Btn_Voltar);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "Finança";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Finança";
            gpb_ResumoFinanceiro.ResumeLayout(false);
            gpb_ResumoFinanceiro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Voltar;
        private Label label1;
        private Label lbl_PeriodoDe;
        private Label lbl_Ate;
        private Label lbl_Entradas;
        private Label lbl_Saldo;
        private DateTimePicker dtp_PeriodoDe;
        private DateTimePicker dtp_Ate;
        private GroupBox gpb_ResumoFinanceiro;
        private TextBox txb_Saldo;
        private TextBox txb_Entradas;
    }
}