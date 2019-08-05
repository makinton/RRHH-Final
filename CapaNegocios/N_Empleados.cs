using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class N_Empleados
    {
        D_Empleados objData = new CapaDatos.D_Empleados();

        public List<E_Empleados> ListarEmpleados(string buscar)
        {
            return objData.ListarEmpleados(buscar);
        }

        public void InsertarEmpleado(E_Empleados Empleados)
        {
            objData.InsertarEmpleados(Empleados);
        }

        public void EditarEmpleados(E_Empleados Empleados)
        {
            objData.EditarEmpleados(Empleados);
        }

        public void EliminarEmpleados(E_Empleados Empleados)
        {
            objData.EliminarEmpleados(Empleados);
        }
    }
}
