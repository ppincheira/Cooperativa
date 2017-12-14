using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmObservaciones
{
    public interface IVistaObservacionesCrud
    {
        int codigo { get; set; }
        int tipoObservaciones { get; set; }
        string codigoRegistro { get; set; }
        DateTime fecha { get; set; }
        string detalle { get; set; }
        string adjunto { get; set; }

    }
}
