using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmObservaciones
{
    public class UIObservacionesCrud
    {
        private IVistaObservacionesCrud _vista;
        Utility oUtil;

        public UIObservacionesCrud(IVistaObservacionesCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar() {

            if (_vista.codigo == 0) {
                _vista.fecha = DateTime.Now.Date;

            }
            else
            {
                Observaciones oObs = new Observaciones();
                ObservacionesBus oObsBus = new ObservacionesBus();
                oObs = oObsBus.ObservacionesGetById(_vista.codigo);
                _vista.codigoRegistro = oObs.ObsCodigoRegistro;
                _vista.detalle = oObs.ObsDetalle;
                _vista.tipoObservaciones = oObs.TobCodigo;
                _vista.fecha = oObs.ObsFechaAlta;
                _vista.adjunto = oObs.ObsDatoAdjunto;
            }
        }

     

        public void Guardar()
        {
            int rtdo;
            Observaciones oObs = new Observaciones();
            ObservacionesBus oObsBus = new ObservacionesBus();

            oObs.ObsCodigo = _vista.codigo;
            oObs.ObsCodigoRegistro = _vista.codigoRegistro;
            oObs.ObsDetalle = _vista.detalle;
            oObs.ObsFechaAlta = _vista.fecha;
            oObs.TobCodigo = _vista.tipoObservaciones;

            if (_vista.codigo == 0)
                rtdo = oObsBus.ObservacionesAdd(oObs);
            else
                rtdo = (oObsBus.ObservacionesUpdate(oObs)) ? oObs.ObsCodigo: 0;
        }
    }
}
