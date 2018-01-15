using Controles.datos;
using System;

namespace AppProcesos.gesServicios.frmMedidoresCrud
{
    public interface IVistaMedidoresCrud
    {

        long Numero { get; set; }
        string NumeroSerie { get; set; }
        Controles.datos.cmbLista NumeroProv { get; set; }
        decimal Registrador { get; set; }
        int Digitos { get; set; }
        string EstCodigo { get; set; }
        double FactorCalib { get; set; }
        decimal? GisX { get; set; }
        decimal? GisY { get; set; }
        string DmeCodigo { get; set; }
        int UsrNumero { get; set; } 
        DateTime FechaCarga { get; set; }
        Controles.datos.cmbLista MmoCodigo { get; set; }

    }
}
