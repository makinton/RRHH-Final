using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;
using System.Data.SqlClient;

namespace CapaDePresentacion
{
    public partial class FormSalidaEmpleados : Form
    {
        DATAS obj = new DATAS();
      

        public FormSalidaEmpleados()
        {
            InitializeComponent();
        }

        private void FormSalidaEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rRHHDataSet.MantEmpleados' Puede moverla o quitarla según sea necesario.
          //  this.mantEmpleadosTableAdapter.Fill(this.rRHHDataSet.MantEmpleados);
            SqlCommand cmd = new SqlCommand("exec ObtenerEmpleados", obj.conectar());
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtEmpleado.DataSource = dt;

            txtEmpleado.DisplayMember = "Nombre";
            txtEmpleado.ValueMember = "IDEmpleados";
            obj.CerrarConexion();
        }
        

        private void btnSalidaEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update MantEmpleados set Estatus = 'Inactivo' where IDEmpleados='" + txtEmpleado.SelectedValue + "'", obj.conectar());
                cmd.ExecuteNonQuery();
                obj.CerrarConexion();
                                
                SqlCommand cmd2 = new SqlCommand("insert into SalidaEmpleados values ('" + txtTipoSalida.Text + "','" +txtMotivo.Text+ "','" +txtEmpleado.SelectedValue + "')", obj.conectar());
                cmd2.ExecuteNonQuery();
                obj.CerrarConexion();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            MessageBox.Show("Estudiante inactivado...");
        }

        private void txtEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
