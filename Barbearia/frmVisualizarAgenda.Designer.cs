namespace Barbearia
{
    partial class frmVisualizarAgenda
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
            dtpVizualizarAgenda = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtpVizualizarAgenda).BeginInit();
            SuspendLayout();
            // 
            // dtpVizualizarAgenda
            // 
            dtpVizualizarAgenda.BackgroundColor = SystemColors.ButtonHighlight;
            dtpVizualizarAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtpVizualizarAgenda.Dock = DockStyle.Fill;
            dtpVizualizarAgenda.Location = new Point(0, 0);
            dtpVizualizarAgenda.Name = "dtpVizualizarAgenda";
            dtpVizualizarAgenda.Size = new Size(1264, 681);
            dtpVizualizarAgenda.TabIndex = 0;
            // 
            // frmVisualizarAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(dtpVizualizarAgenda);
            Name = "frmVisualizarAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisualizarAgenda";
            Load += frmVisualizarAgenda_Load;
            ((System.ComponentModel.ISupportInitialize)dtpVizualizarAgenda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtpVizualizarAgenda;
    }
}