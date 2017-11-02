///////////////////////////////////////////////////////////////////////////
//
// Creado por Pablo Pincheira
//
///////////////////////////////////////////////////////////////////////////

using System;


namespace Model
{
    public class Areas
    {
        #region Private Properties
        private string _AreCodigo;
        private string _AreDescripcion;
        #endregion

        #region Constructors

        public Areas()
        {

        }

        public Areas(string AreCodigo, string AreDescripcion)
        {
			_AreCodigo=AreCodigo;
			_AreDescripcion=AreDescripcion;			
        }

        #endregion

        #region Properties

        public string AreCodigo
        {
            get { return _AreCodigo; }
            set { _AreCodigo = value; }
        }

        public string AreDescripcion
        {
            get { return _AreDescripcion; }
            set { _AreDescripcion = value; }
        }

        #endregion
    }
}
