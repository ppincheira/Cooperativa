using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmClientes
{
    public class UIClientesCrud
    {

        private IVistaClientesCrud _vista;
        Utility oUtil;


        public UIClientesCrud(IVistaClientesCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar()
        {
            CargarTipoIva();
            CargarEstadoCredito();
            CargarTiposDni();
        }

        public void CargarTelefonos(long id)
        {
            Telefonos oTelefono = new Telefonos();
            TelefonosBus oTelefonoBus = new TelefonosBus();
            oTelefono = oTelefonoBus.TelefonosGetById( id);
            _vista.strTelefono = oTelefono.TelCodigo + " - " + oTelefono.TelNumero;

        }

        public void CargarEmail(long id)
        {
            Telefonos oTelefono = new Telefonos();
            TelefonosBus oTelefonoBus = new TelefonosBus();
            oTelefono = oTelefonoBus.TelefonosGetById(id);
            _vista.strEmail = oTelefono.TelEmail;
        }

        public void CargarObservaciones(long id)
        {
            Domicilios oDomicilio = new Domicilios();
            DomiciliosBus oDomicilioBus = new DomiciliosBus();
            oDomicilio = oDomicilioBus.DomiciliosGetById(id);
            CallesLocalidadesBus oCalleBus = new CallesLocalidadesBus();
            _vista.strDomicilio = oCalleBus.CallesLocalidadesGetById(oDomicilio.CalNumero).CalDescripcion + " Nro.: " + oDomicilio.DomNumero + " "
                + " Dpto:" + oDomicilio.DomDepartamento;



        }


        private void CargarTipoIva()
        {
            TiposIvaBus oTipoIvaBus = new TiposIvaBus();
            oUtil.CargarCombo(_vista.cmbiTipoIva, oTipoIvaBus.TiposIvaGetAllDT(), "TIV_CODIGO", "TIV_DESCRIPCION", "SELECCIONE..");
        }

        private void CargarEstadoCredito()
        {
            EstadosBus oEstadoBus = new EstadosBus();
            oUtil.CargarCombo(_vista.cmbiEstadoCredito, oEstadoBus.EstadosGetByFilterDT("EMPRESAS", "EST_CODIGO_CREDITO"), "EST_CODIGO", "EST_DESCRIPCION", "SELECCIONE.."); 
        }
        
        private void CargarTiposDni()
        {
            TiposIdentificadoresBus oTipoIdentificadoresBus = new TiposIdentificadoresBus();
            oUtil.CargarCombo(_vista.cmbiTipoDocumento, oTipoIdentificadoresBus.TiposIdentificadoresGetAllDT(), "tid_codigo", "tid_codigo", "..");
        }

    }
}
