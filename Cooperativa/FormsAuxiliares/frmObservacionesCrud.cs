using AppProcesos.formsAuxiliares.frmObservaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAuxiliares
{

    public partial class frmObservacionesCrud : Form,IVistaObservacionesCrud
    {
        #region << PROPIEDADES >>
        UIObservacionesCrud _oObservacionCrud;
        int _Codigo;
        int _TipoObservaciones;
        string _CodigoRegistro;
        string _Adjunto;

        #endregion

        #region Implementation of IVistaObservaciones


        public int codigo
        {
            get { return _Codigo; }
            set { _Codigo= value; }
        }
        public int tipoObservaciones
        {
            get { return _TipoObservaciones; }
            set { _TipoObservaciones= value; }
        }

        public string codigoRegistro
        {
            get { return _CodigoRegistro; }
            set { _CodigoRegistro = value; }
        }
        public DateTime fecha
        {
            get { return this.dtpFecha.Value; }
            set { this.dtpFecha.Value = value; }
        }
 
        public string detalle
        {
            get { return this.txtDetalle.Text; }
            set { this.txtDetalle.Text = value; }
        }

        public string adjunto
        {
            get { return _Adjunto; }
            set { _Adjunto = value; }
        }
        #endregion
        public frmObservacionesCrud(                                                                                                   )
        {
            InitializeComponent();
            _oObservacionCrud = new  UIObservacionesCrud (this);
        }

        private void btnGeneral1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar1_Click(object sender, EventArgs e)
        {

        }

        private void frmObservacionesCrud_Load(object sender, EventArgs e)
        {

        }
    }
}
