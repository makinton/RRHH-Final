namespace CapaDePresentacion
{
    partial class FormSalidaEmpleados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalidaEmpleados));
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.MEs = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.ComboBox();
            this.mantEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rRHHDataSet = new CapaDePresentacion.RRHHDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mantEmpleadosTableAdapter = new CapaDePresentacion.RRHHDataSetTableAdapters.MantEmpleadosTableAdapter();
            this.txtTipoSalida = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalidaEmpleado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mantEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMotivo
            // 
            this.txtMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(855, 338);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(375, 142);
            this.txtMotivo.TabIndex = 110;
            // 
            // MEs
            // 
            this.MEs.AutoSize = true;
            this.MEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MEs.Location = new System.Drawing.Point(840, 156);
            this.MEs.Name = "MEs";
            this.MEs.Size = new System.Drawing.Size(89, 20);
            this.MEs.TabIndex = 109;
            this.MEs.Text = "Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(840, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 108;
            this.label4.Text = "Motivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "ID";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.FormattingEnabled = true;
            this.txtEmpleado.Location = new System.Drawing.Point(844, 179);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(217, 26);
            this.txtEmpleado.TabIndex = 101;
            this.txtEmpleado.SelectedIndexChanged += new System.EventHandler(this.txtEmpleado_SelectedIndexChanged);
            // 
            // mantEmpleadosBindingSource
            // 
            this.mantEmpleadosBindingSource.DataMember = "MantEmpleados";
            this.mantEmpleadosBindingSource.DataSource = this.rRHHDataSet;
            // 
            // rRHHDataSet
            // 
            this.rRHHDataSet.DataSetName = "RRHHDataSet";
            this.rRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 301);
            this.dataGridView1.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 111;
            this.label2.Text = "Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 112;
            this.label3.Text = "Motivo";
            // 
            // mantEmpleadosTableAdapter
            // 
            this.mantEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // txtTipoSalida
            // 
            this.txtTipoSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoSalida.FormattingEnabled = true;
            this.txtTipoSalida.Items.AddRange(new object[] {
            "Renuncia",
            "Despido",
            "Desahucio"});
            this.txtTipoSalida.Location = new System.Drawing.Point(844, 256);
            this.txtTipoSalida.Name = "txtTipoSalida";
            this.txtTipoSalida.Size = new System.Drawing.Size(217, 26);
            this.txtTipoSalida.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(840, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 114;
            this.label5.Text = "Tipo de Salida";
            // 
            // btnSalidaEmpleado
            // 
            this.btnSalidaEmpleado.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnSalidaEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnSalidaEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalidaEmpleado.BorderRadius = 7;
            this.btnSalidaEmpleado.ButtonText = "            Guardar Salida Empleado";
            this.btnSalidaEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalidaEmpleado.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalidaEmpleado.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalidaEmpleado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSalidaEmpleado.Iconimage")));
            this.btnSalidaEmpleado.Iconimage_right = null;
            this.btnSalidaEmpleado.Iconimage_right_Selected = null;
            this.btnSalidaEmpleado.Iconimage_Selected = null;
            this.btnSalidaEmpleado.IconMarginLeft = 0;
            this.btnSalidaEmpleado.IconMarginRight = 0;
            this.btnSalidaEmpleado.IconRightVisible = true;
            this.btnSalidaEmpleado.IconRightZoom = 0D;
            this.btnSalidaEmpleado.IconVisible = true;
            this.btnSalidaEmpleado.IconZoom = 90D;
            this.btnSalidaEmpleado.IsTab = false;
            this.btnSalidaEmpleado.Location = new System.Drawing.Point(844, 546);
            this.btnSalidaEmpleado.Name = "btnSalidaEmpleado";
            this.btnSalidaEmpleado.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnSalidaEmpleado.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnSalidaEmpleado.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalidaEmpleado.selected = false;
            this.btnSalidaEmpleado.Size = new System.Drawing.Size(386, 48);
            this.btnSalidaEmpleado.TabIndex = 107;
            this.btnSalidaEmpleado.Text = "            Guardar Salida Empleado";
            this.btnSalidaEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalidaEmpleado.Textcolor = System.Drawing.Color.White;
            this.btnSalidaEmpleado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidaEmpleado.Click += new System.EventHandler(this.btnSalidaEmpleado_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CapaDePresentacion.Properties.Resources.CajaTexto;
            this.pictureBox7.Location = new System.Drawing.Point(844, 328);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(399, 161);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 102;
            this.pictureBox7.TabStop = false;
            // 
            // FormSalidaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 642);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTipoSalida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.MEs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalidaEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSalidaEmpleados";
            this.Text = "FormSalidaEmpleados";
            this.Load += new System.EventHandler(this.FormSalidaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mantEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label MEs;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalidaEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ComboBox txtEmpleado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RRHHDataSet rRHHDataSet;
        private System.Windows.Forms.BindingSource mantEmpleadosBindingSource;
        private RRHHDataSetTableAdapters.MantEmpleadosTableAdapter mantEmpleadosTableAdapter;
        private System.Windows.Forms.ComboBox txtTipoSalida;
        private System.Windows.Forms.Label label5;
    }
}