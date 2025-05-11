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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarAgenda));
            dgvVizualizarAgenda = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVizualizarAgenda).BeginInit();
            SuspendLayout();
            // 
            // dgvVizualizarAgenda
            // 
            dgvVizualizarAgenda.AllowUserToAddRows = false;
            dgvVizualizarAgenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvVizualizarAgenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVizualizarAgenda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvVizualizarAgenda.BackgroundColor = SystemColors.ButtonHighlight;
            dgvVizualizarAgenda.BorderStyle = BorderStyle.Fixed3D;
            dgvVizualizarAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVizualizarAgenda.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVizualizarAgenda.Dock = DockStyle.Fill;
            dgvVizualizarAgenda.Enabled = false;
            dgvVizualizarAgenda.EnableHeadersVisualStyles = false;
            dgvVizualizarAgenda.Location = new Point(0, 0);
            dgvVizualizarAgenda.Name = "dgvVizualizarAgenda";
            dgvVizualizarAgenda.ReadOnly = true;
            dataGridViewCellStyle3.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvVizualizarAgenda.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvVizualizarAgenda.Size = new Size(1264, 681);
            dgvVizualizarAgenda.TabIndex = 0;
            // 
            // frmVisualizarAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(dgvVizualizarAgenda);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVisualizarAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizar Agenda";
            Load += frmVisualizarAgenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVizualizarAgenda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVizualizarAgenda;
    }
}