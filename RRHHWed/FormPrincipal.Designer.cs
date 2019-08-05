namespace CapaDePresentacion
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMantenimientos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelProcesos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelInformes = new System.Windows.Forms.FlowLayoutPanel();
            this.SliderPanelMantenimiento = new System.Windows.Forms.Timer(this.components);
            this.SliderPanelProcesos = new System.Windows.Forms.Timer(this.components);
            this.SliderPanelInformes = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMantenimientos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmpleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDepartamentos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCargos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProcesos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCalculoNomina = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSalidaEmpleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVacaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPermisos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLicencias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInformes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNominas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmpleadosActivos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmpleadosInactivos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCabecera.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelMantenimientos.SuspendLayout();
            this.panelProcesos.SuspendLayout();
            this.panelInformes.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.panelCabecera.Controls.Add(this.bunifuCustomLabel1);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1558, 61);
            this.panelCabecera.TabIndex = 0;
            this.panelCabecera.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCabecera_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.flowLayoutPanel1);
            this.panelMenu.Location = new System.Drawing.Point(0, 61);
            this.panelMenu.MaximumSize = new System.Drawing.Size(264, 642);
            this.panelMenu.MinimumSize = new System.Drawing.Size(264, 642);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(264, 642);
            this.panelMenu.TabIndex = 1;
            // 
            // panelMantenimientos
            // 
            this.panelMantenimientos.Controls.Add(this.btnMantenimientos);
            this.panelMantenimientos.Controls.Add(this.btnEmpleados);
            this.panelMantenimientos.Controls.Add(this.btnDepartamentos);
            this.panelMantenimientos.Controls.Add(this.btnCargos);
            this.panelMantenimientos.Location = new System.Drawing.Point(3, 3);
            this.panelMantenimientos.MaximumSize = new System.Drawing.Size(210, 230);
            this.panelMantenimientos.MinimumSize = new System.Drawing.Size(210, 50);
            this.panelMantenimientos.Name = "panelMantenimientos";
            this.panelMantenimientos.Size = new System.Drawing.Size(210, 50);
            this.panelMantenimientos.TabIndex = 0;
            // 
            // panelProcesos
            // 
            this.panelProcesos.Controls.Add(this.btnProcesos);
            this.panelProcesos.Controls.Add(this.btnCalculoNomina);
            this.panelProcesos.Controls.Add(this.btnSalidaEmpleados);
            this.panelProcesos.Controls.Add(this.btnVacaciones);
            this.panelProcesos.Controls.Add(this.btnPermisos);
            this.panelProcesos.Controls.Add(this.btnLicencias);
            this.panelProcesos.Location = new System.Drawing.Point(3, 59);
            this.panelProcesos.MaximumSize = new System.Drawing.Size(210, 330);
            this.panelProcesos.MinimumSize = new System.Drawing.Size(210, 50);
            this.panelProcesos.Name = "panelProcesos";
            this.panelProcesos.Size = new System.Drawing.Size(210, 50);
            this.panelProcesos.TabIndex = 1;
            // 
            // panelInformes
            // 
            this.panelInformes.Controls.Add(this.btnInformes);
            this.panelInformes.Controls.Add(this.btnNominas);
            this.panelInformes.Controls.Add(this.btnEmpleadosActivos);
            this.panelInformes.Controls.Add(this.btnEmpleadosInactivos);
            this.panelInformes.Location = new System.Drawing.Point(3, 115);
            this.panelInformes.MaximumSize = new System.Drawing.Size(210, 220);
            this.panelInformes.MinimumSize = new System.Drawing.Size(210, 50);
            this.panelInformes.Name = "panelInformes";
            this.panelInformes.Size = new System.Drawing.Size(210, 50);
            this.panelInformes.TabIndex = 2;
            // 
            // SliderPanelMantenimiento
            // 
            this.SliderPanelMantenimiento.Interval = 10;
            this.SliderPanelMantenimiento.Tick += new System.EventHandler(this.SliderPanelMantenimiento_Tick);
            // 
            // SliderPanelProcesos
            // 
            this.SliderPanelProcesos.Interval = 10;
            this.SliderPanelProcesos.Tick += new System.EventHandler(this.SliderPanelProcesos_Tick);
            // 
            // SliderPanelInformes
            // 
            this.SliderPanelInformes.Interval = 10;
            this.SliderPanelInformes.Tick += new System.EventHandler(this.SliderPanelInformes_Tick);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(270, 64);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1284, 642);
            this.panelContenedor.TabIndex = 2;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel1.ImageKey = "(ninguno)";
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(373, 29);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Gestion de Recursos Humanos";
            // 
            // btnSalir
            // 
            this.btnSalir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.BorderRadius = 7;
            this.btnSalir.ButtonText = "Salir";
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSalir.Iconimage")));
            this.btnSalir.Iconimage_right = null;
            this.btnSalir.Iconimage_right_Selected = null;
            this.btnSalir.Iconimage_Selected = null;
            this.btnSalir.IconMarginLeft = 0;
            this.btnSalir.IconMarginRight = 0;
            this.btnSalir.IconRightVisible = true;
            this.btnSalir.IconRightZoom = 0D;
            this.btnSalir.IconVisible = true;
            this.btnSalir.IconZoom = 90D;
            this.btnSalir.IsTab = false;
            this.btnSalir.Location = new System.Drawing.Point(0, 594);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnSalir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnSalir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalir.selected = false;
            this.btnSalir.Size = new System.Drawing.Size(212, 48);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Textcolor = System.Drawing.Color.White;
            this.btnSalir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMantenimientos
            // 
            this.btnMantenimientos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnMantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnMantenimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMantenimientos.BorderRadius = 7;
            this.btnMantenimientos.ButtonText = "Mantenimientos";
            this.btnMantenimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMantenimientos.DisabledColor = System.Drawing.Color.White;
            this.btnMantenimientos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMantenimientos.Iconimage = global::CapaDePresentacion.Properties.Resources.maintenance_30px;
            this.btnMantenimientos.Iconimage_right = null;
            this.btnMantenimientos.Iconimage_right_Selected = null;
            this.btnMantenimientos.Iconimage_Selected = null;
            this.btnMantenimientos.IconMarginLeft = 0;
            this.btnMantenimientos.IconMarginRight = 0;
            this.btnMantenimientos.IconRightVisible = true;
            this.btnMantenimientos.IconRightZoom = 0D;
            this.btnMantenimientos.IconVisible = true;
            this.btnMantenimientos.IconZoom = 90D;
            this.btnMantenimientos.IsTab = false;
            this.btnMantenimientos.Location = new System.Drawing.Point(3, 3);
            this.btnMantenimientos.Name = "btnMantenimientos";
            this.btnMantenimientos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnMantenimientos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnMantenimientos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMantenimientos.selected = false;
            this.btnMantenimientos.Size = new System.Drawing.Size(197, 47);
            this.btnMantenimientos.TabIndex = 0;
            this.btnMantenimientos.Text = "Mantenimientos";
            this.btnMantenimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimientos.Textcolor = System.Drawing.Color.White;
            this.btnMantenimientos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientos.Click += new System.EventHandler(this.btnMantenimientos_Click_1);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpleados.BorderRadius = 7;
            this.btnEmpleados.ButtonText = "Empleados";
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmpleados.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.Iconimage = global::CapaDePresentacion.Properties.Resources.google_classroom_32px;
            this.btnEmpleados.Iconimage_right = null;
            this.btnEmpleados.Iconimage_right_Selected = null;
            this.btnEmpleados.Iconimage_Selected = null;
            this.btnEmpleados.IconMarginLeft = 0;
            this.btnEmpleados.IconMarginRight = 0;
            this.btnEmpleados.IconRightVisible = true;
            this.btnEmpleados.IconRightZoom = 0D;
            this.btnEmpleados.IconVisible = true;
            this.btnEmpleados.IconZoom = 90D;
            this.btnEmpleados.IsTab = false;
            this.btnEmpleados.Location = new System.Drawing.Point(10, 56);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnEmpleados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnEmpleados.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmpleados.selected = false;
            this.btnEmpleados.Size = new System.Drawing.Size(197, 48);
            this.btnEmpleados.TabIndex = 3;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Textcolor = System.Drawing.Color.White;
            this.btnEmpleados.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnDepartamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnDepartamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDepartamentos.BorderRadius = 7;
            this.btnDepartamentos.ButtonText = "Departamentos";
            this.btnDepartamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartamentos.DisabledColor = System.Drawing.Color.Gray;
            this.btnDepartamentos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDepartamentos.Iconimage = global::CapaDePresentacion.Properties.Resources.org_unit_30px;
            this.btnDepartamentos.Iconimage_right = null;
            this.btnDepartamentos.Iconimage_right_Selected = null;
            this.btnDepartamentos.Iconimage_Selected = null;
            this.btnDepartamentos.IconMarginLeft = 0;
            this.btnDepartamentos.IconMarginRight = 0;
            this.btnDepartamentos.IconRightVisible = true;
            this.btnDepartamentos.IconRightZoom = 0D;
            this.btnDepartamentos.IconVisible = true;
            this.btnDepartamentos.IconZoom = 90D;
            this.btnDepartamentos.IsTab = false;
            this.btnDepartamentos.Location = new System.Drawing.Point(10, 110);
            this.btnDepartamentos.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnDepartamentos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnDepartamentos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDepartamentos.selected = false;
            this.btnDepartamentos.Size = new System.Drawing.Size(197, 48);
            this.btnDepartamentos.TabIndex = 1;
            this.btnDepartamentos.Text = "Departamentos";
            this.btnDepartamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartamentos.Textcolor = System.Drawing.Color.White;
            this.btnDepartamentos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartamentos.Click += new System.EventHandler(this.btnDepartamentos_Click);
            // 
            // btnCargos
            // 
            this.btnCargos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnCargos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargos.BorderRadius = 7;
            this.btnCargos.ButtonText = "Cargos";
            this.btnCargos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargos.DisabledColor = System.Drawing.Color.Gray;
            this.btnCargos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCargos.Iconimage = global::CapaDePresentacion.Properties.Resources.police_badge_32px;
            this.btnCargos.Iconimage_right = null;
            this.btnCargos.Iconimage_right_Selected = null;
            this.btnCargos.Iconimage_Selected = null;
            this.btnCargos.IconMarginLeft = 0;
            this.btnCargos.IconMarginRight = 0;
            this.btnCargos.IconRightVisible = true;
            this.btnCargos.IconRightZoom = 0D;
            this.btnCargos.IconVisible = true;
            this.btnCargos.IconZoom = 90D;
            this.btnCargos.IsTab = false;
            this.btnCargos.Location = new System.Drawing.Point(10, 164);
            this.btnCargos.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnCargos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnCargos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCargos.selected = false;
            this.btnCargos.Size = new System.Drawing.Size(197, 50);
            this.btnCargos.TabIndex = 2;
            this.btnCargos.Text = "Cargos";
            this.btnCargos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargos.Textcolor = System.Drawing.Color.White;
            this.btnCargos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click_1);
            // 
            // btnProcesos
            // 
            this.btnProcesos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnProcesos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcesos.BorderRadius = 7;
            this.btnProcesos.ButtonText = "Procesos";
            this.btnProcesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesos.DisabledColor = System.Drawing.Color.Gray;
            this.btnProcesos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProcesos.Iconimage = global::CapaDePresentacion.Properties.Resources.services_32px;
            this.btnProcesos.Iconimage_right = null;
            this.btnProcesos.Iconimage_right_Selected = null;
            this.btnProcesos.Iconimage_Selected = null;
            this.btnProcesos.IconMarginLeft = 0;
            this.btnProcesos.IconMarginRight = 0;
            this.btnProcesos.IconRightVisible = true;
            this.btnProcesos.IconRightZoom = 0D;
            this.btnProcesos.IconVisible = true;
            this.btnProcesos.IconZoom = 90D;
            this.btnProcesos.IsTab = false;
            this.btnProcesos.Location = new System.Drawing.Point(3, 3);
            this.btnProcesos.Name = "btnProcesos";
            this.btnProcesos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnProcesos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnProcesos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProcesos.selected = false;
            this.btnProcesos.Size = new System.Drawing.Size(197, 47);
            this.btnProcesos.TabIndex = 7;
            this.btnProcesos.Text = "Procesos";
            this.btnProcesos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesos.Textcolor = System.Drawing.Color.White;
            this.btnProcesos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesos.Click += new System.EventHandler(this.btnProcesos_Click);
            // 
            // btnCalculoNomina
            // 
            this.btnCalculoNomina.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnCalculoNomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnCalculoNomina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculoNomina.BorderRadius = 7;
            this.btnCalculoNomina.ButtonText = "Calculo de Nomina";
            this.btnCalculoNomina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculoNomina.DisabledColor = System.Drawing.Color.Gray;
            this.btnCalculoNomina.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalculoNomina.Iconimage = global::CapaDePresentacion.Properties.Resources.calculator_30px;
            this.btnCalculoNomina.Iconimage_right = null;
            this.btnCalculoNomina.Iconimage_right_Selected = null;
            this.btnCalculoNomina.Iconimage_Selected = null;
            this.btnCalculoNomina.IconMarginLeft = 0;
            this.btnCalculoNomina.IconMarginRight = 0;
            this.btnCalculoNomina.IconRightVisible = true;
            this.btnCalculoNomina.IconRightZoom = 0D;
            this.btnCalculoNomina.IconVisible = true;
            this.btnCalculoNomina.IconZoom = 90D;
            this.btnCalculoNomina.IsTab = false;
            this.btnCalculoNomina.Location = new System.Drawing.Point(10, 56);
            this.btnCalculoNomina.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnCalculoNomina.Name = "btnCalculoNomina";
            this.btnCalculoNomina.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnCalculoNomina.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnCalculoNomina.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalculoNomina.selected = false;
            this.btnCalculoNomina.Size = new System.Drawing.Size(197, 48);
            this.btnCalculoNomina.TabIndex = 2;
            this.btnCalculoNomina.Text = "Calculo de Nomina";
            this.btnCalculoNomina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculoNomina.Textcolor = System.Drawing.Color.White;
            this.btnCalculoNomina.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculoNomina.Click += new System.EventHandler(this.btnCalculoNomina_Click);
            // 
            // btnSalidaEmpleados
            // 
            this.btnSalidaEmpleados.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnSalidaEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnSalidaEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalidaEmpleados.BorderRadius = 7;
            this.btnSalidaEmpleados.ButtonText = "Salida Empleados";
            this.btnSalidaEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalidaEmpleados.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalidaEmpleados.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalidaEmpleados.Iconimage = global::CapaDePresentacion.Properties.Resources.exit_sign_32px;
            this.btnSalidaEmpleados.Iconimage_right = null;
            this.btnSalidaEmpleados.Iconimage_right_Selected = null;
            this.btnSalidaEmpleados.Iconimage_Selected = null;
            this.btnSalidaEmpleados.IconMarginLeft = 0;
            this.btnSalidaEmpleados.IconMarginRight = 0;
            this.btnSalidaEmpleados.IconRightVisible = true;
            this.btnSalidaEmpleados.IconRightZoom = 0D;
            this.btnSalidaEmpleados.IconVisible = true;
            this.btnSalidaEmpleados.IconZoom = 90D;
            this.btnSalidaEmpleados.IsTab = false;
            this.btnSalidaEmpleados.Location = new System.Drawing.Point(10, 110);
            this.btnSalidaEmpleados.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnSalidaEmpleados.Name = "btnSalidaEmpleados";
            this.btnSalidaEmpleados.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnSalidaEmpleados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnSalidaEmpleados.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalidaEmpleados.selected = false;
            this.btnSalidaEmpleados.Size = new System.Drawing.Size(197, 48);
            this.btnSalidaEmpleados.TabIndex = 3;
            this.btnSalidaEmpleados.Text = "Salida Empleados";
            this.btnSalidaEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalidaEmpleados.Textcolor = System.Drawing.Color.White;
            this.btnSalidaEmpleados.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidaEmpleados.Click += new System.EventHandler(this.btnSalidaEmpleados_Click);
            // 
            // btnVacaciones
            // 
            this.btnVacaciones.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnVacaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnVacaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVacaciones.BorderRadius = 7;
            this.btnVacaciones.ButtonText = "Vacaciones";
            this.btnVacaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVacaciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnVacaciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVacaciones.Iconimage = global::CapaDePresentacion.Properties.Resources.beach_filled_50px;
            this.btnVacaciones.Iconimage_right = null;
            this.btnVacaciones.Iconimage_right_Selected = null;
            this.btnVacaciones.Iconimage_Selected = null;
            this.btnVacaciones.IconMarginLeft = 0;
            this.btnVacaciones.IconMarginRight = 0;
            this.btnVacaciones.IconRightVisible = true;
            this.btnVacaciones.IconRightZoom = 0D;
            this.btnVacaciones.IconVisible = true;
            this.btnVacaciones.IconZoom = 90D;
            this.btnVacaciones.IsTab = false;
            this.btnVacaciones.Location = new System.Drawing.Point(10, 164);
            this.btnVacaciones.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnVacaciones.Name = "btnVacaciones";
            this.btnVacaciones.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnVacaciones.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnVacaciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVacaciones.selected = false;
            this.btnVacaciones.Size = new System.Drawing.Size(197, 48);
            this.btnVacaciones.TabIndex = 4;
            this.btnVacaciones.Text = "Vacaciones";
            this.btnVacaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVacaciones.Textcolor = System.Drawing.Color.White;
            this.btnVacaciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVacaciones.Click += new System.EventHandler(this.btnVacaciones_Click);
            // 
            // btnPermisos
            // 
            this.btnPermisos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnPermisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnPermisos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPermisos.BorderRadius = 7;
            this.btnPermisos.ButtonText = "Permisos";
            this.btnPermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPermisos.DisabledColor = System.Drawing.Color.Gray;
            this.btnPermisos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPermisos.Iconimage = global::CapaDePresentacion.Properties.Resources.approval_30px;
            this.btnPermisos.Iconimage_right = null;
            this.btnPermisos.Iconimage_right_Selected = null;
            this.btnPermisos.Iconimage_Selected = null;
            this.btnPermisos.IconMarginLeft = 0;
            this.btnPermisos.IconMarginRight = 0;
            this.btnPermisos.IconRightVisible = true;
            this.btnPermisos.IconRightZoom = 0D;
            this.btnPermisos.IconVisible = true;
            this.btnPermisos.IconZoom = 90D;
            this.btnPermisos.IsTab = false;
            this.btnPermisos.Location = new System.Drawing.Point(10, 218);
            this.btnPermisos.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnPermisos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnPermisos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPermisos.selected = false;
            this.btnPermisos.Size = new System.Drawing.Size(197, 48);
            this.btnPermisos.TabIndex = 5;
            this.btnPermisos.Text = "Permisos";
            this.btnPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermisos.Textcolor = System.Drawing.Color.White;
            this.btnPermisos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // btnLicencias
            // 
            this.btnLicencias.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnLicencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnLicencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLicencias.BorderRadius = 7;
            this.btnLicencias.ButtonText = "Licencias";
            this.btnLicencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLicencias.DisabledColor = System.Drawing.Color.Gray;
            this.btnLicencias.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLicencias.Iconimage = global::CapaDePresentacion.Properties.Resources.diploma_1_26px;
            this.btnLicencias.Iconimage_right = null;
            this.btnLicencias.Iconimage_right_Selected = null;
            this.btnLicencias.Iconimage_Selected = null;
            this.btnLicencias.IconMarginLeft = 0;
            this.btnLicencias.IconMarginRight = 0;
            this.btnLicencias.IconRightVisible = true;
            this.btnLicencias.IconRightZoom = 0D;
            this.btnLicencias.IconVisible = true;
            this.btnLicencias.IconZoom = 90D;
            this.btnLicencias.IsTab = false;
            this.btnLicencias.Location = new System.Drawing.Point(10, 272);
            this.btnLicencias.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnLicencias.Name = "btnLicencias";
            this.btnLicencias.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnLicencias.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnLicencias.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLicencias.selected = false;
            this.btnLicencias.Size = new System.Drawing.Size(197, 48);
            this.btnLicencias.TabIndex = 6;
            this.btnLicencias.Text = "Licencias";
            this.btnLicencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLicencias.Textcolor = System.Drawing.Color.White;
            this.btnLicencias.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicencias.Click += new System.EventHandler(this.btnLicencias_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnInformes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInformes.BorderRadius = 7;
            this.btnInformes.ButtonText = "Informes";
            this.btnInformes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformes.DisabledColor = System.Drawing.Color.Gray;
            this.btnInformes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInformes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInformes.Iconimage")));
            this.btnInformes.Iconimage_right = null;
            this.btnInformes.Iconimage_right_Selected = null;
            this.btnInformes.Iconimage_Selected = null;
            this.btnInformes.IconMarginLeft = 0;
            this.btnInformes.IconMarginRight = 0;
            this.btnInformes.IconRightVisible = true;
            this.btnInformes.IconRightZoom = 0D;
            this.btnInformes.IconVisible = true;
            this.btnInformes.IconZoom = 90D;
            this.btnInformes.IsTab = false;
            this.btnInformes.Location = new System.Drawing.Point(3, 3);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnInformes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnInformes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInformes.selected = false;
            this.btnInformes.Size = new System.Drawing.Size(197, 45);
            this.btnInformes.TabIndex = 5;
            this.btnInformes.Text = "Informes";
            this.btnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Textcolor = System.Drawing.Color.White;
            this.btnInformes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnNominas
            // 
            this.btnNominas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnNominas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnNominas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNominas.BorderRadius = 7;
            this.btnNominas.ButtonText = "Nominas";
            this.btnNominas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNominas.DisabledColor = System.Drawing.Color.Gray;
            this.btnNominas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNominas.Iconimage = global::CapaDePresentacion.Properties.Resources.payroll_30px;
            this.btnNominas.Iconimage_right = null;
            this.btnNominas.Iconimage_right_Selected = null;
            this.btnNominas.Iconimage_Selected = null;
            this.btnNominas.IconMarginLeft = 0;
            this.btnNominas.IconMarginRight = 0;
            this.btnNominas.IconRightVisible = true;
            this.btnNominas.IconRightZoom = 0D;
            this.btnNominas.IconVisible = true;
            this.btnNominas.IconZoom = 90D;
            this.btnNominas.IsTab = false;
            this.btnNominas.Location = new System.Drawing.Point(10, 54);
            this.btnNominas.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnNominas.Name = "btnNominas";
            this.btnNominas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnNominas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnNominas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNominas.selected = false;
            this.btnNominas.Size = new System.Drawing.Size(197, 47);
            this.btnNominas.TabIndex = 2;
            this.btnNominas.Text = "Nominas";
            this.btnNominas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNominas.Textcolor = System.Drawing.Color.White;
            this.btnNominas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnEmpleadosActivos
            // 
            this.btnEmpleadosActivos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnEmpleadosActivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnEmpleadosActivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpleadosActivos.BorderRadius = 7;
            this.btnEmpleadosActivos.ButtonText = "Empleados Activos";
            this.btnEmpleadosActivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleadosActivos.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmpleadosActivos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmpleadosActivos.Iconimage = global::CapaDePresentacion.Properties.Resources.exercise_30px;
            this.btnEmpleadosActivos.Iconimage_right = null;
            this.btnEmpleadosActivos.Iconimage_right_Selected = null;
            this.btnEmpleadosActivos.Iconimage_Selected = null;
            this.btnEmpleadosActivos.IconMarginLeft = 0;
            this.btnEmpleadosActivos.IconMarginRight = 0;
            this.btnEmpleadosActivos.IconRightVisible = true;
            this.btnEmpleadosActivos.IconRightZoom = 0D;
            this.btnEmpleadosActivos.IconVisible = true;
            this.btnEmpleadosActivos.IconZoom = 90D;
            this.btnEmpleadosActivos.IsTab = false;
            this.btnEmpleadosActivos.Location = new System.Drawing.Point(10, 107);
            this.btnEmpleadosActivos.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnEmpleadosActivos.Name = "btnEmpleadosActivos";
            this.btnEmpleadosActivos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnEmpleadosActivos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnEmpleadosActivos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmpleadosActivos.selected = false;
            this.btnEmpleadosActivos.Size = new System.Drawing.Size(197, 47);
            this.btnEmpleadosActivos.TabIndex = 3;
            this.btnEmpleadosActivos.Text = "Empleados Activos";
            this.btnEmpleadosActivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleadosActivos.Textcolor = System.Drawing.Color.White;
            this.btnEmpleadosActivos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleadosActivos.Click += new System.EventHandler(this.btnEmpleadosActivos_Click);
            // 
            // btnEmpleadosInactivos
            // 
            this.btnEmpleadosInactivos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnEmpleadosInactivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnEmpleadosInactivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpleadosInactivos.BorderRadius = 7;
            this.btnEmpleadosInactivos.ButtonText = "Empleados Inactivos";
            this.btnEmpleadosInactivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleadosInactivos.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmpleadosInactivos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmpleadosInactivos.Iconimage = global::CapaDePresentacion.Properties.Resources.access_for_blind_filled_50px;
            this.btnEmpleadosInactivos.Iconimage_right = null;
            this.btnEmpleadosInactivos.Iconimage_right_Selected = null;
            this.btnEmpleadosInactivos.Iconimage_Selected = null;
            this.btnEmpleadosInactivos.IconMarginLeft = 0;
            this.btnEmpleadosInactivos.IconMarginRight = 0;
            this.btnEmpleadosInactivos.IconRightVisible = true;
            this.btnEmpleadosInactivos.IconRightZoom = 0D;
            this.btnEmpleadosInactivos.IconVisible = true;
            this.btnEmpleadosInactivos.IconZoom = 90D;
            this.btnEmpleadosInactivos.IsTab = false;
            this.btnEmpleadosInactivos.Location = new System.Drawing.Point(10, 160);
            this.btnEmpleadosInactivos.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnEmpleadosInactivos.Name = "btnEmpleadosInactivos";
            this.btnEmpleadosInactivos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnEmpleadosInactivos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.btnEmpleadosInactivos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmpleadosInactivos.selected = false;
            this.btnEmpleadosInactivos.Size = new System.Drawing.Size(197, 47);
            this.btnEmpleadosInactivos.TabIndex = 4;
            this.btnEmpleadosInactivos.Text = "Empleados Inactivos";
            this.btnEmpleadosInactivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleadosInactivos.Textcolor = System.Drawing.Color.White;
            this.btnEmpleadosInactivos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleadosInactivos.Click += new System.EventHandler(this.btnEmpleadosInactivos_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelMantenimientos);
            this.flowLayoutPanel1.Controls.Add(this.panelProcesos);
            this.flowLayoutPanel1.Controls.Add(this.panelInformes);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 102);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(233, 423);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 709);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecera);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMantenimientos.ResumeLayout(false);
            this.panelProcesos.ResumeLayout(false);
            this.panelInformes.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalir;
        private System.Windows.Forms.Timer SliderPanelMantenimiento;
        private System.Windows.Forms.Timer SliderPanelProcesos;
        private System.Windows.Forms.Timer SliderPanelInformes;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.FlowLayoutPanel panelMantenimientos;
        private Bunifu.Framework.UI.BunifuFlatButton btnDepartamentos;
        private Bunifu.Framework.UI.BunifuFlatButton btnMantenimientos;
        private Bunifu.Framework.UI.BunifuFlatButton btnCargos;
        private System.Windows.Forms.FlowLayoutPanel panelProcesos;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalculoNomina;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalidaEmpleados;
        private Bunifu.Framework.UI.BunifuFlatButton btnVacaciones;
        private Bunifu.Framework.UI.BunifuFlatButton btnPermisos;
        private Bunifu.Framework.UI.BunifuFlatButton btnLicencias;
        private System.Windows.Forms.FlowLayoutPanel panelInformes;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmpleados;
        private Bunifu.Framework.UI.BunifuFlatButton btnProcesos;
        private Bunifu.Framework.UI.BunifuFlatButton btnNominas;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmpleadosActivos;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmpleadosInactivos;
        private Bunifu.Framework.UI.BunifuFlatButton btnInformes;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}