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
            Bt_Sair_agenda = new Button();
            SuspendLayout();
            // 
            // Bt_Sair_agenda
            // 
            Bt_Sair_agenda.Location = new Point(1073, 590);
            Bt_Sair_agenda.Name = "Bt_Sair_agenda";
            Bt_Sair_agenda.Size = new Size(175, 75);
            Bt_Sair_agenda.TabIndex = 0;
            Bt_Sair_agenda.Text = "Sair";
            Bt_Sair_agenda.UseVisualStyleBackColor = true;
            Bt_Sair_agenda.Click += Bt_Sair_agenda_Click;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 677);
            Controls.Add(Bt_Sair_agenda);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda";
            Load += Agenda_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Bt_Sair_agenda;
    }
}