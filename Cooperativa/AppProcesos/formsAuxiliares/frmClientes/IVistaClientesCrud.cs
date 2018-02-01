using Controles.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmClientes
{
    public interface IVistaClientesCrud
    {
        long empNumero { get; set; }
        string strRazonSocial { get; set; }
        string strDenominacionComercial { get; set; }
        string strCuit { get; set; }
        cmbLista cmbiTipoIva { get; set; }
        string strObservacion { get; set; }
        string strTitularCheques { get; set; }
        string strPropia { get; set; }
        string strCliente { get; set; }
        string strCategoriaMonotributo { get; set; }
        cmbLista cmbiTipoDocumento { get; set; }
        string strNroDocumento { get; set; }
        string strApellido { get; set; }
        string strNombre { get; set; }
        decimal? dblLimiteCredito { get; set; }
        cmbLista  cmbiEstadoCredito { get; set; }
        int? intNumeroTransporte { get; set; }
        string strTelefono { get; set; }
        string strEmail { get; set; }
        string strDomicilio { get; set; }
    }
}
