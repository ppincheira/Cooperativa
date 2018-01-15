using Business;
using Model;
using Service;
using System.Collections.Generic;

namespace AppProcesos.gesServicios.frmMedidoresModelosCrud
{
    public class UIMedidoresModelosCrud
    {
        private IVistaMedidoresModelosCrud _vista;
        Utility oUtil;

        public UIMedidoresModelosCrud(IVistaMedidoresModelosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar()
        {
            //Obtengo los tipos de contadores
            DominiosBus oDominios = new DominiosBus();
            _vista.TipoContador.DataSource = oDominios.DominiosGetByFilter("TIPO_CONTADOR");
            _vista.TipoContador.DisplayMember = "DmnDescripcion";
            _vista.TipoContador.ValueMember = "DmnValor";

            // Obtengo los grupos del Tipo de conexiones
            TipoConexionServiciosBus oTiposConexiones = new TipoConexionServiciosBus();
            _vista.TipoConexion.DataSource = oTiposConexiones.TipoConexionServiciosGetAll();
            _vista.TipoConexion.DisplayMember = "TcsDescripcion";
            _vista.TipoConexion.ValueMember = "TcsCodigo";

            if (_vista.Codigo != 0)
            {
                MedidoresModelos oMedidoresModelos = new MedidoresModelos();
                MedidoresModelosBus oMedidoresModelosBus = new MedidoresModelosBus();

                //oMedidoresModelos = oMedidoresModelosBus.MedidoresModelosGetById(_vista.sruNumero);
                //_vista.srvCodigo.SelectedValue = oMedidoresModelos.MMoCodigo;
                //_vista.Descripcion = oMedidoresModelos.MMoDescripcion;
                //_vista.DescripcionCorta = oMedidoresModelos.MMoDescripcionCorta;
                //_vista.estCodigo = oMedidoresModelos.EstCodigo;

                //// Obtengo el Objeto Gupo_detalle cuyo codigo:registro=sruNumero
                //GruposDetalles oGrD = new GruposDetalles();
                //GruposDetallesBus oGrDBus = new GruposDetallesBus();
                //oGrD = oGrDBus.GruposDetallesGetByCodReg(_vista.sruNumero.ToString());
                //_vista.grdCodigo = oGrD.GrdCodigo;
                //_vista.grdCodigoRegistro = oGrD.GrdCodigoRegistro;
                //_vista.grupo.SelectedValue = oGrD.GrpCodigo;
            }
        }



        public void Guardar()
        {
            long rtdo;
            MedidoresModelos oSRu = new MedidoresModelos();
            MedidoresModelosBus oSRuBus = new MedidoresModelosBus();

            //oSRu.MMoNumero = _vista.sruNumero;
            //oSRu.MMoDescripcion = _vista.Descripcion;
            //oSRu.MMoDescripcionCorta = _vista.DescripcionCorta;
            //oSRu.EstCodigo = _vista.estCodigo;
            //oSRu.MMoCodigo = _vista.srvCodigo.SelectedValue.ToString();

            //GruposDetalles oGDe = new GruposDetalles();
            //GruposDetallesBus oGDeBus = new GruposDetallesBus();
            //oGDe.GrpCodigo =long.Parse(_vista.grupo.SelectedValue.ToString());
            //oGDe.GrdCodigo = _vista.grdCodigo;
            //if (_vista.sruNumero == 0)
            //{
            //    rtdo = oSRuBus.MedidoresModelosAdd(oSRu);
            //    oSRu.MMoNumero = rtdo;
            //    //Creo un registro en Grupos_detalles con el grp_codigo seleccionado y el servicio de ruta en grd_codigo_registro
            //    oGDe.GrdCodigoRegistro = oSRu.MMoNumero.ToString();
            //    rtdo = oGDeBus.GruposDetallesAdd(oGDe);
            //}
            //else
            //{
            //    rtdo = (oSRuBus.MedidoresModelosUpdate(oSRu)) ? oSRu.MMoNumero : 0;
            //    oGDe.GrdCodigoRegistro = _vista.grdCodigoRegistro;
            //    // Actualizo en Grupos_detalles para el grd_codigo actual el grp_codigo nuevo
            //    rtdo = (oGDeBus.GruposDetallesUpdate(oGDe)) ? oGDe.GrdCodigo : 0;
            //}
        }

        public bool EliminarRuta(long idRuta)
        {
            MedidoresModelosBus oSRuBus = new MedidoresModelosBus();
            MedidoresModelos oSRu = oSRuBus.MedidoresModelosGetById(idRuta);
            oSRu.EstCodigo = "B";
            return oSRuBus.MedidoresModelosUpdate(oSRu);
       }


    }
}
