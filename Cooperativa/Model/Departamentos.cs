///////////////////////////////////////////////////////////////////////////
//
// Creado por Pablo Pincheira
//
///////////////////////////////////////////////////////////////////////////

using System;


namespace Model
{
    public class Departamentos
    {
        #region Private Properties
        private int _DepNumero;
        private string _DepDescripcion;
		private string _AreCodigo;
        #endregion

        #region Constructors

        public Departamentos()
        {

        }

        public Departamentos(int DepNumero, string DepDescripcion, string AreCodigo)
        {
			_DepNumero=DepNumero;
			_DepDescripcion=DepDescripcion;
			_AreCodigo=AreCodigo;			
        }

        #endregion

        #region Properties

        public int DepNumero
        {
            get { return _DepNumero; }
            set { _DepNumero = value; }
        }

        public string DepDescripcion
        {
            get { return _DepDescripcion; }
            set { _DepDescripcion = value; }
        }

		public string AreCodigo
        {
            get { return _AreCodigo; }
            set { _AreCodigo = value; }
        }

        #endregion
    }
}