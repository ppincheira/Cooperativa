using AppProcesos.formsAuxiliares.frmObservaciones;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controles.form;

namespace FormsAuxiliares
{

    public partial class frmObservacionesCrud : gesForm,IVistaObservacionesCrud
    {
        #region << PROPIEDADES >>
        UIObservacionesCrud _oObservacionCrud;
        Utility oUtility;
        int _Codigo;
        int _TipoObservaciones;
        string _CodigoRegistro;
        string _Adjunto;
        string _Accion;

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

        #region << EVENTOS >>
        public frmObservacionesCrud(int Codigo, int TobCodigo, string CodigoRegistro, string Accion)
        {
            InitializeComponent();
            _oObservacionCrud = new  UIObservacionesCrud (this);
            _Codigo = Codigo;
            _TipoObservaciones = TobCodigo;
            _CodigoRegistro = CodigoRegistro;
            _Accion = Accion;
        }

        private void frmObservacionesCrud_Load(object sender, EventArgs e)
        {
            
            _oObservacionCrud.Inicializar();
            oUtility = new Utility();
            this.dtpFecha.REQUERIDO = "SI";
            this.txtDetalle.REQUERIDO = "SI";
            if (_Accion == "V") 
                this.gbDatos.Enabled = false;
        }
       
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            oUtility.ValidarFormulario(this, this, 5);
            if    (this.VALIDARFORM)
            {
                DialogResult = DialogResult.OK; 
                _oObservacionCrud.Guardar();
                this.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

      
    }
}