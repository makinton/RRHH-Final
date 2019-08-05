using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class FormPrincipal : Form
    {
        private bool SliderMant;
        private bool SliderProc;
        private bool SliderInf;

        public FormPrincipal()
        {
            InitializeComponent();
            SliderPanelMantenimiento.Start();
            SliderPanelProcesos.Start();
            SliderPanelInformes.Start();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
                
        private void SliderPanelMantenimiento_Tick(object sender, EventArgs e)
        {
            if (SliderMant)
            {
                panelMantenimientos.Height += 10;
                if (panelMantenimientos.Size == panelMantenimientos.MaximumSize)
                {
                    SliderPanelMantenimiento.Stop();
                    SliderMant = false;
                }
            }
            else
            {
                panelMantenimientos.Height -= 10;
                if (panelMantenimientos.Size == panelMantenimientos.MinimumSize)
                {
                    SliderPanelMantenimiento.Stop();
                    SliderMant = true;
                }
            }
        }
        private void btnMantenimientos_Click_1(object sender, EventArgs e)
        {
            SliderPanelMantenimiento.Start();
        }

        private void SliderPanelInformes_Tick(object sender, EventArgs e)
        {
            if (SliderInf)
            {
                panelInformes.Height += 10;
                if (panelInformes.Size == panelInformes.MaximumSize)
                {
                    SliderPanelInformes.Stop();
                    SliderInf = false;
                }
            }
            else
            {
                panelInformes.Height -= 10;
                if (panelInformes.Size == panelInformes.MinimumSize)
                {
                    SliderPanelInformes.Stop();
                    SliderInf = true;
                }
            }
        }
        private void btnInformes_Click(object sender, EventArgs e)
        {
            SliderPanelInformes.Start();
        }


        private void SliderPanelProcesos_Tick(object sender, EventArgs e)
        {
            if (SliderProc)
            {
                panelProcesos.Height += 10;
                if (panelProcesos.Size == panelProcesos.MaximumSize)
                {
                    SliderPanelProcesos.Stop();
                    SliderProc = false;
                }
            }
            else
            {
                panelProcesos.Height -= 10;
                if (panelProcesos.Size == panelProcesos.MinimumSize)
                {
                    SliderPanelProcesos.Stop();
                    SliderProc = true;
                }
            }
        }

        
        private void btnProcesos_Click(object sender, EventArgs e)
        {
            SliderPanelProcesos.Start();
        }
        
        private void AbrirFormPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormMantEmpleados());
        }
        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormMantDepartamentos());
        }
        private void btnCargos_Click_1(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormMantCargos());
        }
        private void panelMantenimientos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCabecera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCargos_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculoNomina_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormCalculoNomina());
        }

        private void btnSalidaEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormSalidaEmpleados());
        }

        private void btnVacaciones_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormVacaciones());
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormPermisos());
        }

        private void btnLicencias_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormLicencias());
        }

        private void btnEmpleadosInactivos_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormInfEmpleadosInactivos());
        }

        private void btnEmpleadosActivos_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormInfEmpleadosActivos());
        }
    }

}
