﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class N_SalidaEmpleados
    {
        N_SalidaEmpleados objData = new N_SalidaEmpleados();

        public void SacarEmpleados (string buscar)
        {
            objData.SacarEmpleados(buscar);

        }
    }
}
