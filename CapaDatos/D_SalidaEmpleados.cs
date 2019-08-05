using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;


namespace CapaDatos
{
    public class D_SalidaEmpleados
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
               
        
        public void SacarEmpleados(E_SalidaEmpleados SalidaEmpleados)
        {
            SqlCommand cmd = new SqlCommand("SalidaEmpleadosProc", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDSalidas", SalidaEmpleados.IDEmpleados1);
            cmd.Parameters.AddWithValue("@CODSalidas", SalidaEmpleados.CODSalidas1);
            cmd.Parameters.AddWithValue("@TipoSalida", SalidaEmpleados.TipoSalida1);
            cmd.Parameters.AddWithValue("@Motivo", SalidaEmpleados.Motivo1);
           
            conexion.Close();

        }
    }
}
