﻿using Controles.datos;

namespace AppProcesos.gesServicios.frmRutasCrud
{
    public interface IVistaRutasCrud
    {

        long sruNumero { get; set; }
        string Descripcion { get; set; }
        string DescripcionCorta { get; set; }
        string estCodigo { get; set; }
        Controles.datos.cmbLista srvCodigo { get; set; }

    }
}
