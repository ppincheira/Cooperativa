using Business;
using Model;
using Service;
using System.Collections.Generic;

namespace AppProcesos.gesServicios.frmRutasCrud
{
    public class UIRutasCrud
    {
        private IVistaRutasCrud _vista;
        Utility oUtil;

        public UIRutasCrud(IVistaRutasCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar()
        {
            ServiciosBus oServiciosBus = new ServiciosBus();

            //List<Servicios> lista = oServiciosBus.ServiciosGetAll();
            //foreach (Servicios item in lista)
            //{
            //    string valor = item.SrvCodigo;
            //}
            _vista.srvCodigo.DataSource = oServiciosBus.ServiciosGetAll();
            _vista.srvCodigo.DisplayMember = "SrvDescripcion";
            _vista.srvCodigo.ValueMember = "SrvCodigo";

            if (_vista.sruNumero != 0)
            {
                ServiciosRutas oSRutas = new ServiciosRutas();
                ServiciosRutasBus oSRutasBus = new ServiciosRutasBus();

                oSRutas = oSRutasBus.ServiciosRutasGetById(_vista.sruNumero);
                _vista.srvCodigo.SelectedValue = oSRutas.SrvCodigo;
                _vista.Descripcion = oSRutas.SruDescripcion;
                _vista.DescripcionCorta = oSRutas.SruDescripcionCorta;
                _vista.estCodigo = oSRutas.EstCodigo;
            }
        }



        public void Guardar()
        {
            long rtdo;
            ServiciosRutas oSRu = new ServiciosRutas();
            ServiciosRutasBus oSRuBus = new ServiciosRutasBus();

            oSRu.SruNumero = _vista.sruNumero;
            oSRu.SruDescripcion = _vista.Descripcion;
            oSRu.SruDescripcionCorta = _vista.DescripcionCorta;
            oSRu.EstCodigo = _vista.estCodigo;
            oSRu.SrvCodigo = _vista.srvCodigo.SelectedValue.ToString();
            if (_vista.sruNumero == 0)
                rtdo = oSRuBus.ServiciosRutasAdd(oSRu)
                ;
            else
                rtdo = (oSRuBus.ServiciosRutasUpdate(oSRu)) ? oSRu.SruNumero : 0;

        }


    }
}
