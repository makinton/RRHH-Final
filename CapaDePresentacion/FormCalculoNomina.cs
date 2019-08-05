using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CapaDePresentacion
{
    public partial class FormCalculoNomina : Form
    {
        DATAS obj = new DATAS();
        public FormCalculoNomina()
        {
            InitializeComponent();
        }
        public enum Meses
        {
            Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Dicienbre
        }
       /*public enum TimeDesde
        {
            
        }
        public enum TimeHasta
        {

        }
        */
        private void FormCalculoNomina_Load(object sender, EventArgs e)
        {
            // dateTimeDesde = tablaCalculoNomina.DataGridWiew[0].Value.ToString();
            //  dateTimeHasta = Enum.GetValues(typeof());
            comboBoxMeses.DataSource = Enum.GetValues(typeof(Meses));
        }

        private void btnCalcularNomina_Click(object sender, EventArgs e)
        {
            

        }
    }
}
