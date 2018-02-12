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
<<<<<<< HEAD
        double? dblLimiteCredito { get; set; }
        cmbLista cmbiEstadoCredito { get; set; }
=======
        decimal? dblLimiteCredito { get; set; }
        cmbLista  cmbiEstadoCredito { get; set; }
>>>>>>> 80a687236975e3e2b8b7068dc9cef4f5dcf6cc9b
        int? intNumeroTransporte { get; set; }
        string strTelefono { get; set; }
        string strEmail { get; set; }
        string strDomicilio { get; set; }
<<<<<<< HEAD
        dtpFecha dtpiFechaAlta { get; set; }
        dtpFecha dtpiFechaAltaCli { get; set; }
        dtpFecha dtpiFechaBajaCli { get; set; }
        dtpFecha dtpiFechaAltaPro { get; set; }
        dtpFecha dtpiFechaBajaPro { get; set; }
        long lgCodigoDomicilio { get; set; }
        long lgCodigoTelefono { get; set; }
        long lgCodigoEmail { get; set; }
        long lgCodigoObservacion { get; set; }
=======
>>>>>>> 80a687236975e3e2b8b7068dc9cef4f5dcf6cc9b
    }
}
