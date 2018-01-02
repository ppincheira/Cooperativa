using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmDomicilios
{
    public class UIDomiciliosCrud
    {

        private IVistaDomiciliosCrud _vista;
        Utility oUtil;


        public UIDomiciliosCrud(IVistaDomiciliosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }

        public void Inicializar()
        {
            LocalidadesBus oLocalidadesBus = new LocalidadesBus();
            CallesLocalidadesBus oCallesLocBus = new CallesLocalidadesBus();

            oUtil.CargarCombo(_vista.cmbiLocalidad,oLocalidadesBus.LocalidadesGetByProvincia("NQ"),"LOC_NUMERO","LOC_DESCRIPCION");

            if (_vista.domCodigo != 0)
            {
                Domicilios oDomicilio = new Domicilios();
                DomiciliosBus oDomicilioBus = new DomiciliosBus();
                oDomicilio = oDomicilioBus.DomiciliosGetById(_vista.domCodigo);
                _vista.bloque = oDomicilio.DomBloque;
                _vista.cmbiCalle.SelectedValue = oDomicilio.CalNumero;
                _vista.cmbiCalleDesde.SelectedValue = oDomicilio.CalNumeroDesde;
                _vista.cmbiCalleHasta.SelectedValue = oDomicilio.CalNumeroHasta;
                _vista.cmbiLocalidad.SelectedValue = oDomicilio.LocNumero;
                _vista.codigoPostal = oDomicilio.CplNumero;
                _vista.departamento = oDomicilio.DomDepartamento;
                _vista.domCodigoRegistro = oDomicilio.DomCodigoRegistro;
                _vista.gisX = oDomicilio.DomGisX;
                _vista.gisY = oDomicilio.DomGisY;
                _vista.numero = oDomicilio.DomNumero;
                _vista.parcela = oDomicilio.DomParcela;
                _vista.piso = oDomicilio.DomPiso;
                _vista.tabCodigo = oDomicilio.TabCodigo;
                _vista.tdoCodigo = oDomicilio.TdoCodigo;
            }

        }

    }

}
