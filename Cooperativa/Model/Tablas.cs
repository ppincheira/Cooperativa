
///////////////////////////////////////////////////////////////////////////
//
// Creado por Pablo Pincheira
//
///////////////////////////////////////////////////////////////////////////

using System;


namespace Model
{
    public class Tablas
    {
        #region Private Properties
        private string _TabCodigo;
        private string _TabNombre;
        private string _TabDescripcion;
        private string _TabQueryJoin;
        
        #endregion

        #region Constructors

        public Tablas()
        {

        }

        public Tablas(string TabCodigo, string TabNombre, string TabDescripcion)
        {
            _TabCodigo = TabCodigo;
            _TabNombre = TabNombre;
            _TabDescripcion = TabDescripcion;
            
        }

        #endregion

        #region Properties

        public string TabCodigo
        {
            get { return _TabCodigo; }
            set { _TabCodigo = value; }
        }

        public string TabNombre
        {
            get { return _TabNombre; }
            set { _TabNombre = value; }
        }

        public string TabDescripcion
        {
            get { return _TabDescripcion; }
            set {_TabDescripcion = value; }
        }

        public string TabQueryJoin
        {
            get { return _TabQueryJoin; }
            set { _TabQueryJoin = value; }
        }

        #endregion
    }
}
