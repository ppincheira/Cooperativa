using Business;
using Model;
using Service;

namespace AppProcesos.gesServicios.frmMedidoresCrud
{
    public class UIMedidoresMasivosCrud
    {
        private IVistaMedidoresMasivosCrud _vista;
        Utility oUtil;

        public UIMedidoresMasivosCrud(IVistaMedidoresMasivosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar()
        {
            //Obtengo los Modelos de medidores
            MedidoresModelosBus oMModelo = new MedidoresModelosBus();
            _vista.MmoCodigo.DataSource = oMModelo.MedidoresModelosGetAll();
            _vista.MmoCodigo.DisplayMember = "MmoDescripcion";
            _vista.MmoCodigo.ValueMember = "MmoCodigo";

            // Obtengo las empresas Proveedoras
            EmpresasBus oTiposConexiones = new EmpresasBus();
            _vista.NumeroProv.DataSource = oTiposConexiones.EmpresasGetAll();
            _vista.NumeroProv.DisplayMember = "EmpRazonSocial";
            _vista.NumeroProv.ValueMember = "EmpNumero";


            //if (_vista.Numero != 0)
            //{
            //    Medidores oMedidores = new Medidores();
            //    MedidoresBus oMedidoresBus = new MedidoresBus();
            //    //Obtengo datos de la entidad principal que trabajo
            //    oMedidores = oMedidoresBus.MedidoresGetById(_vista.Numero);
            //    _vista.NumeroSerie = oMedidores.MedNumeroserie;
            //    _vista.Digitos = oMedidores.MedDigitos;
            //    _vista.EstCodigo = oMedidores.EstCodigo;
            //    _vista.FactorCalib = oMedidores.MedFactorCalib;
            //    _vista.GisX = oMedidores.GisX;
            //    _vista.GisY = oMedidores.GisY;
            //    _vista.UsrNumero = oMedidores.UsrNumero;
            //    _vista.FechaCarga = oMedidores.MedFechaCarga;
            //}
        }



        public void Guardar()
        {
            long rtdo;
            Medidores oMMO = new Medidores();
            MedidoresBus oMMOBus = new MedidoresBus();
            //Cargar los datos ingresados al objeto

            oMMO.MedNumero = _vista.Numero;
            oMMO.EmpNumeroProveedor = long.Parse(_vista.NumeroProv.SelectedValue.ToString());
            oMMO.MedDigitos = _vista.Digitos;
            oMMO.EstCodigo = _vista.EstCodigo;
            oMMO.MedFactorCalib = _vista.FactorCalib;
            oMMO.GisX = _vista.GisX;
            oMMO.GisY = _vista.GisY;
            oMMO.UsrNumero = _vista.UsrNumero;
            oMMO.MedFechaCarga = _vista.FechaCarga;
            oMMO.MmoCodigo = short.Parse(_vista.MmoCodigo.SelectedValue.ToString());
            for (long NumeroSerie=_vista.NumeroSerieDesde; NumeroSerie <= _vista.NumeroSerieHasta; NumeroSerie++)
            {
                oMMO.MedNumeroserie = NumeroSerie;
                oMMO.MedNumero =  oMMOBus.MedidoresAdd(oMMO);

            }
            //if (_vista.Numero == 0)
            //else
            //    rtdo = (oMMOBus.MedidoresUpdate(oMMO)) ? oMMO.MedNumero : 0;
        }

       // public bool EliminarModeloMedidor(long idMedidor)
       // {
       //     MedidoresBus oMMOBus = new MedidoresBus();
       //     Medidores oMMO = oMMOBus.MedidoresGetById(idMedidor);
       //     oMMO.EstCodigo = "B";
       //     return oMMOBus.MedidoresUpdate(oMMO);
       //}


    }
}
