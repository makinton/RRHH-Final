using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class N_Cargos
    {
        D_Cargos objData = new D_Cargos();

        public List<E_Cargos> ListarCargos(string buscar)
        {
            return objData.ListarCargos(buscar);

        }

        public void InsertarCargos(E_Cargos Cargos)
        {
            objData.InsertarCargos(Cargos);

        }

        public void EditarCargos(E_Cargos Cargos)
        {
            objData.EditarCargos(Cargos);

        }

        public void EliminarCargos(E_Cargos Cargos)
        {
            objData.EliminarCargos(Cargos);

        }
    }
}
