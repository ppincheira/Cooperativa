using Controles.datos;
using System;

namespace AppProcesos.gesServicios.frmMedidoresModelosCrud
{
    public interface IVistaMedidoresModelosCrud
    {

        long Codigo { get; set; }
        string Descripcion { get; set; }
        string DescripcionCorta { get; set; }
        long Digitos { get; set; }
        long Decimales { get; set; }
        long CantHilos { get; set; }
        long KWVueltas { get; set; }
        string Amperaje { get; set; }
        long Clase { get; set; }
        long Registrador { get; set; }
        Controles.datos.cmbLista TipoContador { get; set; }
        Controles.datos.cmbLista TipoConexion { get; set; }
        Controles.datos.cmbLista FabNumero { get; set; }
        Controles.datos.cmbLista TMeCodigo { get; set; }
        //long usrNumero { get; set; } 
        DateTime FechaCarga { get; set; }
        string estCodigo { get; set; }

    }
}
