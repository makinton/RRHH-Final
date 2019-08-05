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
    public class D_Departamentos
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Departamentos> ListarDepartamentos(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("BuscarDepartamentos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Departamentos> Listar = new List<E_Departamentos>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Departamentos
                {
                    IDDepartamentos1 = LeerFilas.GetInt32(0),
                    CodDepartamentos1 = LeerFilas.GetString(1),
                    NombreDepartamentos1 = LeerFilas.GetString(2),
                    EncargadoDepartamentos1 = LeerFilas.GetString(3),


                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void InsertarDepartamentos(E_Departamentos Departamentos)
        {
            SqlCommand cmd = new SqlCommand("InsertarDepartamentos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NombreDepartamentos", Departamentos.NombreDepartamentos1);
            cmd.Parameters.AddWithValue("@EncargadoDepartamentos", Departamentos.EncargadoDepartamentos1);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarDepartamentos(E_Departamentos Departamentos)
        {
            SqlCommand cmd = new SqlCommand("EditarDepartamentos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDDepartamentos", Departamentos.IDDepartamentos1);
            cmd.Parameters.AddWithValue("@NombreDepartamentos", Departamentos.NombreDepartamentos1);
            cmd.Parameters.AddWithValue("@EncargadoDepartamentos", Departamentos.EncargadoDepartamentos1);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarDepartamentos(E_Departamentos Departamentos)
        {
            SqlCommand cmd = new SqlCommand("EliminarDepartamentos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDDepartamentos", Departamentos.IDDepartamentos1);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
