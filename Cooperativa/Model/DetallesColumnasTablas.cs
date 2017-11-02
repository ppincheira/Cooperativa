///////////////////////////////////////////////////////////////////////////
//
// Creado por Pablo Pincheira
//
///////////////////////////////////////////////////////////////////////////

using System;


namespace Model
{
    public class DetallesColumnasTablas
    {
        #region Private Properties
        private string _TabCodigo;
        private string _DctCodigoTabla;
        private int _DctNroOrden;
        private string _DctColumna;
        private string _DctHabilitado;
        private string _DctRequerido;
        private string _DctDescripcion;
        private string _DctEtiqueta;
        private string _DctTipoControl;
		private string _DctListaValores;
		private string _DctFiltroBusqueda;
        #endregion

        #region Constructors

        public DetallesColumnasTablas()
        {

        }

        public DetallesColumnasTablas(string TabCodigo, string DctCodigoTabla, int DctNroOrden, string DctColumna, string DctHabilitado, string DctRequerido
		,string DctDescripcion, string DctEtiqueta, string DctTipoControl, string DctListaValores, string DctFiltroBusqueda)
        {
            _TabCodigo=TabCodigo;
			_DctCodigoTabla=DctCodigoTabla;
			_DctNroOrden=DctNroOrden;
			_DctColumna=DctColumna;
			_DctHabilitado=DctHabilitado;
			_DctRequerido=DctRequerido;
			_DctDescripcion=DctDescripcion;
			_DctEtiqueta=DctEtiqueta;
			_DctTipoControl=DctTipoControl;
			_DctListaValores=DctListaValores;
			_DctFiltroBusqueda=DctFiltroBusqueda;            
        }

        #endregion

        #region Properties

        public string TabCodigo
        {
            get { return _TabCodigo; }
            set { _TabCodigo = value; }
        }

        public string DctCodigoTabla
        {
            get { return _DctCodigoTabla; }
            set { _DctCodigoTabla = value; }
        }

        public int DctNroOrden
        {
            get { return _DctNroOrden; }
            set {_DctNroOrden = value; }
        }
		
		public string DctColumna
        {
            get { return _DctColumna; }
            set {_DctColumna = value; }
        }
		
		public string DctHabilitado
        {
            get { return _DctHabilitado; }
            set {_DctHabilitado = value; }
        }
		
		public string DctRequerido
        {
            get { return _DctRequerido; }
            set {_DctRequerido = value; }
        }
		
		public string DctDescripcion
        {
            get { return _DctDescripcion; }
            set {_DctDescripcion = value; }
        }
		
		public string DctEtiqueta
        {
            get { return _DctEtiqueta; }
            set {_DctEtiqueta = value; }
        }
		
		public string DctTipoControl
        {
            get { return _DctTipoControl; }
            set {_DctTipoControl = value; }
        }
		
		public string DctListaValores
        {
            get { return _DctListaValores; }
            set {_DctListaValores = value; }
        }
        
		public string DctFiltroBusqueda
        {
            get { return _DctFiltroBusqueda; }
            set {_DctFiltroBusqueda = value; }
        }
        
		
        #endregion
    }
}
