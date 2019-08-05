namespace CapaDePresentacion
{
    partial class FormInfEmpleadosInactivos
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
            this.crystalReportEmpleadosInactivos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportEmpleadosInactivos1 = new CapaDePresentacion.crystalReportEmpleadosInactivos();
            this.SuspendLayout();
            // 
            // crystalReportEmpleadosInactivos
            // 
            this.crystalReportEmpleadosInactivos.ActiveViewIndex = 0;
            this.crystalReportEmpleadosInactivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportEmpleadosInactivos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportEmpleadosInactivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportEmpleadosInactivos.Location = new System.Drawing.Point(0, 0);
            this.crystalReportEmpleadosInactivos.Name = "crystalReportEmpleadosInactivos";
            this.crystalReportEmpleadosInactivos.ReportSource = this.crystalReportEmpleadosInactivos1;
            this.crystalReportEmpleadosInactivos.Size = new System.Drawing.Size(1284, 642);
            this.crystalReportEmpleadosInactivos.TabIndex = 0;
            // 
            // FormInfEmpleadosInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 642);
            this.Controls.Add(this.crystalReportEmpleadosInactivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInfEmpleadosInactivos";
            this.Text = "FormInfEmpleadosInactivos";
            this.Load += new System.EventHandler(this.FormInfEmpleadosInactivos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CapaDePresentacion.InfEmpleadosInactivos InfEmpleadosInactivos1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportEmpleadosInactivos;
        private crystalReportEmpleadosInactivos crystalReportEmpleadosInactivos1;
    }
}