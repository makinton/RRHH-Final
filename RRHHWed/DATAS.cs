using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDePresentacion
{
    class DATAS
    {
        SqlConnection conexion = new SqlConnection();

        public SqlConnection conectar()
        {
            conexion.ConnectionString = "Data Source=MASTER;Initial Catalog=RRHH;Integrated Security=True";
            conexion.Open();

            return conexion;

        }

        public void CerrarConexion()
        {
            conexion.Close();
        }







    }
}
