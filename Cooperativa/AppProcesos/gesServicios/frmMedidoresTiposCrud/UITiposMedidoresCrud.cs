using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.gesServicios.frmMedidoresCrud
{
    public class UITiposMedidoresCrud
    {
        private IVistaTiposMedidoresCrud _vista;
        Utility oUtil;

        public UITiposMedidoresCrud(IVistaTiposMedidoresCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar()
        {
            ServiciosBus oServiciosBus = new ServiciosBus();
       
            _vista.srvCodigo.DataSource = oServiciosBus.ServiciosGetAll();
            _vista.srvCodigo.DisplayMember = "SrvDescripcion";
            _vista.srvCodigo.ValueMember = "SrvCodigo";
    
            if (_vista.tmeCodigo != "")
                {
                TiposMedidores oSMedidor = new TiposMedidores();
                TiposMedidoresBus oSMedidorBus = new TiposMedidoresBus();

                oSMedidor = oSMedidorBus.TiposMedidoresGetById(_vista.tmeCodigo);
                _vista.tmeCodigo = oSMedidor.TmeCodigo;
                _vista.srvCodigo.SelectedValue = oSMedidor.SrvCodigo;
                _vista.descripcion = oSMedidor.TmeDescripcion;
                _vista.descripcionCorta = oSMedidor.TmeDescripcionCorta;
                _vista.fechaCarga = oSMedidor.TmeFechaCarga;
                _vista.usrNumero = oSMedidor.UsrNumero;
                _vista.estCodigo = oSMedidor.EstCodigo;
            }
        }

        public void Guardar()
        {
            long rtdo;
            TiposMedidores oSMedidor = new TiposMedidores();
            TiposMedidoresBus oSMeBus = new TiposMedidoresBus();

            oSMedidor.UsrNumero = _vista.usrNumero;
            oSMedidor.TmeDescripcion = _vista.descripcion;
            oSMedidor.TmeDescripcionCorta = _vista.descripcionCorta;
            oSMedidor.EstCodigo = _vista.estCodigo;
            oSMedidor.SrvCodigo = _vista.srvCodigo.SelectedValue.ToString();
            oSMedidor.TmeFechaCarga = _vista.fechaCarga;


            if (_vista.tmeCodigo == "")
                rtdo = oSMeBus.TiposMedidoresAdd(oSMedidor);
     //       else
  //              rtdo = (oSMeBus.TiposMedidoresUpdate(oSMedidor)) ? oSMedidor.TmeCodigo : 0;
        }

        public bool EliminarMedidor(string idMedidor)
        {
            TiposMedidoresBus oSMeBus = new TiposMedidoresBus();            
            TiposMedidores oSMe = oSMeBus.TiposMedidoresGetById(idMedidor);
            oSMe.EstCodigo = "B";
            return oSMeBus.TiposMedidoresUpdate(oSMe);
        }


    }
}
