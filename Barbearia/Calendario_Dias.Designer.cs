﻿namespace Barbearia
{
    partial class Calendario_Dias
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Lb_Dias = new Label();
            btnVizualizarAgenda = new Button();
            SuspendLayout();
            // 
            // Lb_Dias
            // 
            Lb_Dias.AutoSize = true;
            Lb_Dias.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lb_Dias.Location = new Point(14, 14);
            Lb_Dias.Name = "Lb_Dias";
            Lb_Dias.Size = new Size(27, 19);
            Lb_Dias.TabIndex = 0;
            Lb_Dias.Text = "00";
            // 
            // btnVizualizarAgenda
            // 
            btnVizualizarAgenda.Location = new Point(3, 74);
            btnVizualizarAgenda.Name = "btnVizualizarAgenda";
            btnVizualizarAgenda.Size = new Size(165, 23);
            btnVizualizarAgenda.TabIndex = 1;
            btnVizualizarAgenda.Text = "Visualizar agendamento";
            btnVizualizarAgenda.UseVisualStyleBackColor = true;
            btnVizualizarAgenda.Click += btnVizualizarAgenda_Click;
            // 
            // Calendario_Dias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnVizualizarAgenda);
            Controls.Add(Lb_Dias);
            Name = "Calendario_Dias";
            Size = new Size(171, 100);
            Load += Calendario_Dias_Load;
            Click += Calendario_Dias_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lb_Dias;
        private Button btnVizualizarAgenda;
    }
}
