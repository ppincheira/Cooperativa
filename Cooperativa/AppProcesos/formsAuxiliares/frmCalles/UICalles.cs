using Business;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmCalles
{
    public class UICalles
    {
        private IVistaCalles _vista;
        Utility oUtil;


        public UICalles(IVistaCalles vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }




        public void Inicializar()
        {

            LocalidadesBus oLocalidadesBus = new LocalidadesBus();

            oUtil.CargarCombo(_vista.cmbLocalidad, oLocalidadesBus.LocalidadesGetByProvincia(_vista.codigoProvincia),"LOC_NUMERO","LOC_DESCRIPCION");
            //if (_vista == 0)
            //{

            //    _vista.fecha = DateTime.Now.Date;

            //}
            //else
            //{
            //    Observaciones oObs = new Observaciones();
            //    ObservacionesBus oObsBus = new ObservacionesBus();
            //    oObs = oObsBus.ObservacionesGetById(_vista.codigo);
            //    _vista.codigoRegistro = oObs.ObsCodigoRegistro;
            //    _vista.detalle = oObs.ObsDetalle;
            //    _vista.tipoObservaciones = oObs.TobCodigo;
            //    _vista.fecha = oObs.ObsFechaAlta;
            //    Adjuntos oAdj = new Adjuntos();
            //    AdjuntosBus oAdjBus = new AdjuntosBus();
            //    oAdj = oAdjBus.AdjuntosGetByCodigoRegistro(long.Parse(_vista.codigo.ToString()), "OBSE");
            //    _vista.adjunto = oAdj;
            //}
        }

    }
}
