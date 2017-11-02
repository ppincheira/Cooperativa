///////////////////////////////////////////////////////////////////////////
//
// Creado por Pablo Pincheira
//
///////////////////////////////////////////////////////////////////////////

using System;


namespace Model
{
    public class Sectores
    {
        #region Private Properties
        private string _SecCodigo;
        private string _SecDescripcion;
		private int _DepNumero;
		private string _AreCodigo;
        #endregion

        #region Constructors

        public Sectores()
        {

        }

        public Sectores(string SecCodigo, string SecDescripcion, int DepNumero, string AreCodigo)
        {
			_SecCodigo=SecCodigo;
			_SecDescripcion=SecDescripcion;
			_DepNumero=DepNumero;
			_AreCodigo=AreCodigo;
		}

        #endregion

        #region Properties

        public string SecCodigo
        {
            get { return _SecCodigo; }
            set { _SecCodigo = value; }
        }

        public string SecDescripcion
        {
            get { return _SecDescripcion; }
            set { _SecDescripcion = value; }
        }

		public int DepNumero
        {
            get { return _DepNumero; }
            set { _DepNumero = value; }
        }

		public string AreCodigo
        {
            get { return _AreCodigo; }
            set { _AreCodigo = value; }
        }
        #endregion
    }
}