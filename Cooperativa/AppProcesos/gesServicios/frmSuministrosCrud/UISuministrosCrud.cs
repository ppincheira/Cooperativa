using Business;
using Model;
using Service;

namespace AppProcesos.gesServicios.frmSuministrosCrud
{
    public class UISuministrosCrud
    {
        private IVistaSuministrosCrud _vista;
        Utility oUtil;

        public UISuministrosCrud(IVistaSuministrosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar()
        {
            //Obtengo los tipos de contadores
            ServiciosBus oServicios = new ServiciosBus();
            oUtil.CargarCombo(_vista.Servicio, oServicios.ServiciosGetAllDT(), "SRV_CODIGO", "SRV_DESCRIPCION", "SELECCIONE..");

            // Obtengo los grupos del Tipo de conexiones
            TipoConexionServiciosBus oTiposConexiones = new TipoConexionServiciosBus();
            oUtil.CargarCombo(_vista.TipoConexion, oTiposConexiones.TipoConexionServiciosGetAllDT(), "TCS_CODIGO", "TCS_DESCRIPCION", "SELECCIONE..");

            //// Obtengo los Fabricantes
            //FabricantesBus oFabricantes = new FabricantesBus();
            //oUtil.CargarCombo(_vista.FabNumero, oFabricantes.FabricantesGetAllDT(), "FAB_NUMERO", "FAB_DESCRIPCION", "SELECCIONE..");

            //// Obtengo los grupos del Tipo de medidores
            //TiposMedidoresBus oTiposMedidores = new TiposMedidoresBus();
            //oUtil.CargarCombo(_vista.TMeCodigo, oTiposMedidores.TiposMedidoresGetAllDT(), "TME_CODIGO", "TME_DESCRIPCION", "SELECCIONE..");

            if (_vista.Numero != 0)
            {
                Suministros oSuministros = new Suministros();
                SuministrosBus oSuministrosBus = new SuministrosBus();
                //Obtengo datos de la entidad principal que trabajo
                oSuministros = oSuministrosBus.SuministrosGetById(_vista.Numero);
                _vista.Servicio.SelectedValue = oSuministros.SrvCodigo;
                _vista.TipoConexion.SelectedValue = oSuministros.TcsCodigo;
                _vista.Categoria.SelectedValue = oSuministros.ScaNumero;
                _vista.OrdenRuta = oSuministros.SumOrdenRuta;
                _vista.EmpNumero = oSuministros.EmpNumero;
                _vista.FechaAlta = oSuministros.SumFechaAlta;
                _vista.EstCodigo = oSuministros.EstCodigo;
                _vista.ConsumoEstimado = oSuministros.SumConsumoEstimado;
                _vista.Voltaje = oSuministros.SumVoltaje;
                _vista.Conexion = oSuministros.SumConexion;
                _vista.PotenciaL1 = oSuministros.SumPotenciaL1;
                _vista.PotenciaL2 = oSuministros.SumPotenciaL2;
                _vista.PotenciaL3 = oSuministros.SumPotenciaL3;
                _vista.PermiteCorte = oSuministros.SumPermiteCorte;
                _vista.Medido = oSuministros.SumMedido;
                _vista.Ruta.SelectedValue = oSuministros.SruNumero;
                _vista.Zona.SelectedValue = oSuministros.SzoNumero;
                _vista.PermiteFactura = oSuministros.SumPermiteFactura;
                _vista.FechaCarga = oSuministros.SumFechaCarga;
            }
        }



        public void Guardar()
        {
            long rtdo;
            Suministros oSum = new Suministros();
            SuministrosBus oSumBus = new SuministrosBus();
            //Cargar los datos ingresados al objeto

            oSum.SumNumero = _vista.Numero;
            oSum.SrvCodigo = _vista.Servicio.SelectedValue.ToString();
            oSum.TcsCodigo = _vista.TipoConexion.SelectedValue.ToString();
            oSum.ScaNumero = long.Parse(_vista.Categoria.SelectedValue.ToString());
            oSum.SumOrdenRuta = _vista.OrdenRuta;
            oSum.EmpNumero = _vista.EmpNumero;
            oSum.SumFechaAlta = _vista.FechaAlta;
            oSum.EstCodigo = _vista.EstCodigo;
            oSum.SumConsumoEstimado = _vista.ConsumoEstimado;
            oSum.SumVoltaje = _vista.Voltaje;
            oSum.SumConexion = _vista.Conexion;
            oSum.SumPotenciaL1 = _vista.PotenciaL1;
            oSum.SumPotenciaL2 = _vista.PotenciaL2;
            oSum.SumPotenciaL3 = _vista.PotenciaL3;
            oSum.SumPermiteCorte = _vista.PermiteCorte;
            oSum.SumMedido = _vista.Medido;
            oSum.SruNumero = int.Parse(_vista.Ruta.SelectedValue.ToString());
            oSum.SzoNumero = int.Parse(_vista.Zona.SelectedValue.ToString());
            oSum.SumPermiteFactura = _vista.PermiteFactura;
            oSum.SumFechaCarga = _vista.FechaCarga;

            if (_vista.Numero == 0)
                oSum.SumNumero =  oSumBus.SuministrosAdd(oSum);
            else
                rtdo = (oSumBus.SuministrosUpdate(oSum)) ? oSum.SumNumero : 0;
        }

        public bool EliminarModeloMedidor(long idMedidor)
        {
            SuministrosBus oSumBus = new SuministrosBus();
            Suministros oSum = oSumBus.SuministrosGetById(idMedidor);
            oSum.EstCodigo = "B";
            return oSumBus.SuministrosUpdate(oSum);
       }


    }
}
