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
    public class D_Empleados
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=MASTER;Initial Catalog=RRHH;Integrated Security=True");
        ///SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Empleados> ListarEmpleados(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("BuscarEmpleados",conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Empleados> Listar = new List<E_Empleados>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Empleados
                {
                    IDEmpleados1 = LeerFilas.GetInt32(0),
                    CodEmpleados1 = LeerFilas.GetString(1),
                    NombreEmpleados1 = LeerFilas.GetString(2),
                    ApellidoEmpleados1 = LeerFilas.GetString(3),
                    TelefonoEmpleados1 = LeerFilas.GetString(4),
                    DepartamentoEmpleados1 = LeerFilas.GetString(5),
                    CargoEmpleados1 = LeerFilas.GetString(6),
                    FIngresoEmpleados1 = LeerFilas.GetString(7),
                    SalarioEmpleados1 = LeerFilas.GetInt32(8),
                    EstatusEmpleados1 = LeerFilas.GetString(9)

                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void InsertarEmpleados(E_Empleados Empleados)
        {
            SqlCommand cmd = new SqlCommand("InsertarEmpleados", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Empleados.NombreEmpleados1);
            cmd.Parameters.AddWithValue("@Apellido", Empleados.ApellidoEmpleados1);
            cmd.Parameters.AddWithValue("@Telefono", Empleados.TelefonoEmpleados1);
            cmd.Parameters.AddWithValue("@Departamento", Empleados.DepartamentoEmpleados1);
            cmd.Parameters.AddWithValue("@Cargo", Empleados.CargoEmpleados1);
            cmd.Parameters.AddWithValue("@FIngreso", Empleados.FIngresoEmpleados1);
            cmd.Parameters.AddWithValue("@Salario", Empleados.SalarioEmpleados1);
            cmd.Parameters.AddWithValue("@Estatus", Empleados.EstatusEmpleados1);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarEmpleados(E_Empleados Empleados)
        {
            SqlCommand cmd = new SqlCommand("EditarEmpleados", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDEmpleados", Empleados.IDEmpleados1);
            cmd.Parameters.AddWithValue("@Nombre", Empleados.NombreEmpleados1);
            cmd.Parameters.AddWithValue("@Apellido", Empleados.ApellidoEmpleados1);
            cmd.Parameters.AddWithValue("@Telefono", Empleados.TelefonoEmpleados1);
            cmd.Parameters.AddWithValue("@Departamento", Empleados.DepartamentoEmpleados1);
            cmd.Parameters.AddWithValue("@Cargo", Empleados.CargoEmpleados1);
            cmd.Parameters.AddWithValue("@FIngreso", Empleados.FIngresoEmpleados1);
            cmd.Parameters.AddWithValue("@Salario", Empleados.SalarioEmpleados1);
            cmd.Parameters.AddWithValue("@Estatus", Empleados.EstatusEmpleados1);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarEmpleados(E_Empleados Empleados)
        {
            SqlCommand cmd = new SqlCommand("EliminarEmpleado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDEmpleados", Empleados.IDEmpleados1);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    

    }
}
