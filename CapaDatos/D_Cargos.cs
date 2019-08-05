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
    public class D_Cargos
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Cargos> ListarCargos(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("BuscarCargos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Cargos> Listar = new List<E_Cargos>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Cargos
                {
                    IDCargos1 = LeerFilas.GetInt32(0),
                    CODCargos1 = LeerFilas.GetString(1),
                    Cargo1 = LeerFilas.GetString(2),
                    

                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void InsertarCargos(E_Cargos Cargos)
        {
            SqlCommand cmd = new SqlCommand("InsertarCargos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Cargo", Cargos.Cargo1);
            
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarCargos(E_Cargos Cargos)
        {
            SqlCommand cmd = new SqlCommand("EditarCargos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCargos", Cargos.IDCargos1);
            cmd.Parameters.AddWithValue("@Cargo", Cargos.Cargo1);
            
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarCargos(E_Cargos Cargos)
        {
            SqlCommand cmd = new SqlCommand("EliminarCargos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCargos", Cargos.IDCargos1);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
    
}
