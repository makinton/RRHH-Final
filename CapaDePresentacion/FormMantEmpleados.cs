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
    public partial class FormMantEmpleados : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=MASTER;Initial Catalog=RRHH;Integrated Security=True");
        E_Empleados objEntidad = new E_Empleados();
        N_Empleados objNegocios = new N_Empleados();

        private string IDEmpleados;
        private bool ActualizarInfTabla;

        public FormMantEmpleados()
        {
            InitializeComponent();
        }

        private void FormMantEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rRHHDataSetDepartamentos.MantDepartamentos' Puede moverla o quitarla según sea necesario.
            this.mantDepartamentosTableAdapter.Fill(this.rRHHDataSetDepartamentos.MantDepartamentos);
            // TODO: esta línea de código carga datos en la tabla 'rRHHDataSetCargos.MantCargos' Puede moverla o quitarla según sea necesario.
            this.mantCargosTableAdapter.Fill(this.rRHHDataSetCargos.MantCargos);
            BuscarTablaEmpleados("");
            accionesTabla();
        }

        public void accionesTabla()
        {
            TablaEmpleados.Columns[0].Visible = false;
            TablaEmpleados.Columns[1].Width = 40;
            TablaEmpleados.Columns[2].Width = 80;
            TablaEmpleados.Columns[3].Width = 80;
            TablaEmpleados.Columns[4].Width = 80;
            TablaEmpleados.Columns[5].Width = 80;
            TablaEmpleados.Columns[6].Width = 80;
            TablaEmpleados.Columns[7].Width = 80;
            TablaEmpleados.Columns[8].Width = 80;
            TablaEmpleados.Columns[9].Width = 80;

            TablaEmpleados.ClearSelection();
        }

        public void BuscarTablaEmpleados(string buscar)
        {
            N_Empleados objData = new CapaNegocios.N_Empleados();
            TablaEmpleados.DataSource = objData.ListarEmpleados(buscar);



        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            BuscarTablaEmpleados(txtBuscar.Text);
        }

        private void LimpiarCajas()
        {
            ActualizarInfTabla = false;

            txtCOD.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
           // txtTelefono.Text = "";
            txtDepartamento.Text = "";
            txtCargo.Text = "";
            txtFIngreso.Text = "";
            txtSalario.Text = "";
            txtEstatus.Text = "";
            txtNombre.Focus();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (TablaEmpleados.SelectedRows.Count > 0)
            {
                ActualizarInfTabla = true;

                IDEmpleados = TablaEmpleados.CurrentRow.Cells[0].Value.ToString();
                txtCOD.Text = TablaEmpleados.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = TablaEmpleados.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = TablaEmpleados.CurrentRow.Cells[3].Value.ToString();
                //  txtTelefono.Text = TablaEmpleados.CurrentRow.Cells[4].Value.ToString();
                txtDepartamento.Text = TablaEmpleados.CurrentRow.Cells[5].Value.ToString();
                txtCargo.Text = TablaEmpleados.CurrentRow.Cells[6].Value.ToString();
                txtFIngreso.Text = TablaEmpleados.CurrentRow.Cells[7].Value.ToString();
                txtSalario.Text = TablaEmpleados.CurrentRow.Cells[8].Value.ToString();
                txtEstatus.Text = TablaEmpleados.CurrentRow.Cells[9].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ActualizarInfTabla == false)
            {
                try
                {
                    objEntidad.NombreEmpleados1 = txtNombre.Text.ToUpper();
                    objEntidad.ApellidoEmpleados1 = txtApellido.Text.ToUpper();
                    objEntidad.DepartamentoEmpleados1 = txtDepartamento.Text.ToUpper();
                    objEntidad.CargoEmpleados1 = txtCargo.Text.ToUpper();
                    objEntidad.FIngresoEmpleados1 = txtFIngreso.Text.ToUpper();
                    objEntidad.SalarioEmpleados1 = Convert.ToInt32(txtSalario);
                    objEntidad.EstatusEmpleados1 = txtEstatus.Text.ToUpper();

                    objNegocios.InsertarEmpleado(objEntidad);

                    MessageBox.Show("Se guardo el registro");
                    BuscarTablaEmpleados("");
                    LimpiarCajas();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }
            }
            if (ActualizarInfTabla == true)
            {
                try
                {
                    objEntidad.IDEmpleados1 = Convert.ToInt32(IDEmpleados);
                    objEntidad.NombreEmpleados1 = txtNombre.Text.ToUpper();
                    objEntidad.ApellidoEmpleados1 = txtApellido.Text.ToUpper();
                    objEntidad.DepartamentoEmpleados1 = txtDepartamento.Text.ToUpper();
                    objEntidad.CargoEmpleados1 = txtCargo.Text.ToUpper();
                    objEntidad.FIngresoEmpleados1 = txtFIngreso.Text.ToUpper();
                    objEntidad.SalarioEmpleados1 = Convert.ToInt32(txtSalario.Text);
                    objEntidad.EstatusEmpleados1 = txtEstatus.Text.ToUpper();

                    objNegocios.EditarEmpleados(objEntidad);

                    MessageBox.Show("Se edito el registro");
                    BuscarTablaEmpleados("");
                    LimpiarCajas();
                    ActualizarInfTabla = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (TablaEmpleados.SelectedRows.Count > 0)
            {
                objEntidad.IDEmpleados1 = Convert.ToInt32(TablaEmpleados.CurrentRow.Cells[0].Value.ToString());
                objNegocios.EliminarEmpleados(objEntidad);

                MessageBox.Show("Se Elimino correctamente");
                BuscarTablaEmpleados("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea eliminar");
            }
        }
    }
}
