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
    public partial class FormMantDepartamentos : Form
    {
        E_Departamentos objEntidad = new E_Departamentos();
        N_Departamentos objNegocio = new N_Departamentos();

        private string IDDepartamentos;
        private bool ActualizarInfTabla;
        public FormMantDepartamentos()
        {
            InitializeComponent();
        }

        private void FormMantDepartamentos_Load(object sender, EventArgs e)
        {
            BuscarTablaDepartamentos("");
            accionesTabla();
        }
        public void accionesTabla()
        {
            TablaDepartamentos.Columns[0].Width = 150;
            TablaDepartamentos.Columns[1].Width = 200;
            TablaDepartamentos.Columns[2].Width = 200;
            TablaDepartamentos.Columns[3].Width = 200;

            TablaDepartamentos.ClearSelection();
        }
        public void BuscarTablaDepartamentos(string buscar)
        {
            N_Departamentos objData = new CapaNegocios.N_Departamentos();
            TablaDepartamentos.DataSource = objData.ListarDepartamentos(buscar);

        }
        private void txtBuscar_OnTextChance(object sender, EventArgs e)
        {
            BuscarTablaDepartamentos(txtBuscar.Text);
        }
        private void LimpiarCajas()
        {
            ActualizarInfTabla = false;

            txtCOD.Text = "";
            txtNombre.Text = "";
            txtEncargado.Text = "";

            txtNombre.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (TablaDepartamentos.SelectedRows.Count > 0)
            {
                ActualizarInfTabla = true;

                IDDepartamentos = TablaDepartamentos.CurrentRow.Cells[0].Value.ToString();
                txtCOD.Text = TablaDepartamentos.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = TablaDepartamentos.CurrentRow.Cells[2].Value.ToString();
                txtEncargado.Text = TablaDepartamentos.CurrentRow.Cells[3].Value.ToString();


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
                    objEntidad.NombreDepartamentos1 = txtNombre.Text.ToUpper();
                    objEntidad.EncargadoDepartamentos1 = txtEncargado.Text.ToUpper();

                    objNegocio.InsertarDepartamentos(objEntidad);

                    MessageBox.Show("Se guardo el registro");
                    BuscarTablaDepartamentos("");
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
                    objEntidad.IDDepartamentos1 = Convert.ToInt32(IDDepartamentos);
                    objEntidad.NombreDepartamentos1 = txtNombre.Text.ToUpper();
                    objEntidad.EncargadoDepartamentos1 = txtEncargado.Text.ToUpper();

                    objNegocio.EditarDepartamentos(objEntidad);

                    MessageBox.Show("Se Edito el registro");
                    BuscarTablaDepartamentos("");
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
            if (TablaDepartamentos.SelectedRows.Count > 0)
            {
                objEntidad.IDDepartamentos1 = Convert.ToInt32(TablaDepartamentos.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminarDepartamentos(objEntidad);

                MessageBox.Show("Se elimino correctamente");
                BuscarTablaDepartamentos("");

            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea eliminar");
            }
        }
    }
}
