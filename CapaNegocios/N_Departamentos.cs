using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class N_Departamentos
    {
        D_Departamentos objData = new D_Departamentos();

        public List<E_Departamentos> ListarDepartamentos(string buscar)
        {
            return objData.ListarDepartamentos(buscar);

        }

        public void InsertarDepartamentos(E_Departamentos Departamentos)
        {
            objData.InsertarDepartamentos(Departamentos);

        }

        public void EditarDepartamentos(E_Departamentos Departamentos)
        {
            objData.EditarDepartamentos(Departamentos);

        }

        public void EliminarDepartamentos(E_Departamentos Departamentos)
        {
            objData.EliminarDepartamentos(Departamentos);

        }
    }
}
