using Controles.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmDomicilios
{
    public interface IVistaDomiciliosCrud
    {
        long domCodigo { get; set; }
        string tabCodigo { get; set; }
        long domCodigoRegistro { get; set; }
        string tdoCodigo { get; set; }
        cmbLista cmbiLocalidad { get; set; } 
        cmbLista cmbiCalle { get; set; }
        int numero { get; set; }
        string bloque { get; set; }
        string departamento { get; set; }
        string piso { get; set; }
        string parcela { get; set; }
        cmbLista cmbiCalleDesde { get; set; }
        cmbLista cmbiCalleHasta { get; set; }
        int codigoPostal { get; set; }
        decimal gisX { get; set; }
        decimal gisY { get; set; }


    }
}
