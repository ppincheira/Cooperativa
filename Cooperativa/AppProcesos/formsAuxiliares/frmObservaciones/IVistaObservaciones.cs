﻿using Controles.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmObservaciones
{
    public interface IVistaObservaciones
    {

        string tabCodigo { get; set; }
        int tobCodigo { get; set; }
        string obsCodigoRegistro { get; set; }
        grdGrillaAdmin grilla { get; set; }
        DateTime fechaDesde { get; set; }
        DateTime fechaHasta { get; set; }
        string cantidad { set; }
        string detalle { set; }

    }
}
