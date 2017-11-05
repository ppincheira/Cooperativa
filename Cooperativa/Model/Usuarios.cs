using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Usuarios
    {
        #region Private Properties
        private int _UsrNumero;
        private int _PrsNumero;
        private string _UsrNombre;
        private string _UsrBloqueado;
        private string _UsrClave;
        private DateTime _UsrFechaAlta;
        private DateTime _UsrFechaBaja;
        private string _UsrPerfil;
        #endregion

        #region Constructors

        public Usuarios()
        {

        }

        public Usuarios(int UsrNumero, int PrsNumero, string UsrNombre, string UsrBloqueado, string UsrClave, DateTime UsrFechaAlta, DateTime UsrFechaBaja, string UsrPerfil)
        {
            _UsrNumero = UsrNumero;
            _PrsNumero = PrsNumero;
            _UsrNombre = UsrNombre;
            _UsrBloqueado = UsrBloqueado;
            _UsrClave = UsrClave;
            _UsrFechaAlta = UsrFechaAlta;
            _UsrFechaBaja = UsrFechaBaja;
            _UsrPerfil = UsrPerfil;
        }

        #endregion

        #region Properties

        public int UsrNumero
        {
            get { return _UsrNumero; }
            set { _UsrNumero = value; }
        }

        public int PrsNumero
        {
            get { return _PrsNumero; }
            set { _PrsNumero = value; }
        }
        //public string MniDescripcion
        //{
        //    get { return _MniDescripcion; }
        //    set { _MniDescripcion = value; }
        //}
        //public string FrmNombre
        //{
        //    get { return _FrmNombre; }
        //    set { _FrmNombre = value; }
        //}
        //public string MniParametros
        //{
        //    get { return _MniParametros; }
        //    set { _MniParametros = value; }
        //}
        //public string SbsCodigo
        //{
        //    get { return _SbsCodigo; }
        //    set { _SbsCodigo = value; }
        //}
        #endregion
    }
}
