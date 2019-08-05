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
    public partial class FormInfEmpleadosInactivos : Form
    {
        public FormInfEmpleadosInactivos()
        {
            InitializeComponent();
        }
                
        private void FormInfEmpleadosInactivos_Load(object sender, EventArgs e)
        {
            crystalReportEmpleadosInactivos InfEmpleadosInactivos = new crystalReportEmpleadosInactivos();
            InfEmpleadosInactivos.SetParameterValue("@TotalInactivo", "Inactivo");
            crystalReportEmpleadosInactivos.ReportSource = InfEmpleadosInactivos;

        }
    }
}
