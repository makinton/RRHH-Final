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
    public partial class FormMantCargos : Form
    {
        E_Cargos objEntidad = new E_Cargos();
        N_Cargos objNegocio = new N_Cargos();

        private string IDCargos;
        private bool ActualizarInfTabla;


        public FormMantCargos()
        {
            InitializeComponent();
        }

        private void FormMantCargos_Load(object sender, EventArgs e)
        {
            BuscarTablaCargos("");
            accionesTabla();
        }

        public void accionesTabla()
        {
            tablaCargos.Columns[0].Width = 200;
            tablaCargos.Columns[1].Width = 300 ;
            tablaCargos.Columns[2].Width = 300;

            tablaCargos.ClearSelection();
        }
        public void BuscarTablaCargos(string buscar)
        {
            N_Cargos objData = new CapaNegocios.N_Cargos();
            tablaCargos.DataSource = objData.ListarCargos(buscar);



        }
        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            BuscarTablaCargos(txtBuscar.Text);
        }
        private void LimpiarCajas()
        {
            ActualizarInfTabla = false;

            txtCOD.Text = "";
            txtCargo.Text = "";
            txtCargo.Focus();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }


        private void tablaCargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaCargos.SelectedRows.Count > 0)
            {
                ActualizarInfTabla = true;

                IDCargos = tablaCargos.CurrentRow.Cells[0].Value.ToString();
                txtCOD.Text = tablaCargos.CurrentRow.Cells[1].Value.ToString();
                txtCargo.Text = tablaCargos.CurrentRow.Cells[2].Value.ToString();


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
                    objEntidad.Cargo1 = txtCargo.Text.ToUpper();

                    objNegocio.InsertarCargos(objEntidad);

                    MessageBox.Show("Se guardo el registro");
                    BuscarTablaCargos("");
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
                    objEntidad.IDCargos1 = Convert.ToInt32(IDCargos);
                    objEntidad.Cargo1 = txtCargo.Text.ToUpper();

                    objNegocio.EditarCargos(objEntidad);

                    MessageBox.Show("Se Edito el registro");
                    BuscarTablaCargos("");
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
            if (tablaCargos.SelectedRows.Count > 0)
            {
                objEntidad.IDCargos1 = Convert.ToInt32(tablaCargos.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminarCargos(objEntidad);

                MessageBox.Show("Se elimino correctamente");
                BuscarTablaCargos("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que sea eliminar");
            }
        }
    }
}
