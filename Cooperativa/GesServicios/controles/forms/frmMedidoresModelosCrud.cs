using AppProcesos.gesServicios.frmMedidoresModelosCrud;
using Controles.datos;
using Controles.form;
using Service;
using System;
using System.Windows.Forms;

namespace GesServicios.controles.forms
{
    public partial class frmMedidoresModelosCrud : gesForm, IVistaMedidoresModelosCrud
    {

        #region << PROPIEDADES >>

        UIMedidoresModelosCrud _oMedidoresModelosCrud;
        Utility oUtil;

        long _usrNumero, _MmoCodigo;
        string _EstCodigo;

        #endregion
        #region Implementation of IVistaMedidoresModelosCrud


        public long Codigo
        {
            get { return _MmoCodigo; }
            set { _MmoCodigo = value; }
        }
        public string Descripcion
        {
            get { return this.txtDescripcion.Text; }
            set { this.txtDescripcion.Text = value; }
        }

        public string DescripcionCorta
        {
            get { return this.txtDescripcionCorta.Text; }
            set { this.txtDescripcionCorta.Text = value; }
        }

        public long Digitos
        {
            get { return long.Parse(TextBoxDigitos.Text); }
            set { TextBoxDigitos.Text = value.ToString(); }
        }

        public long Decimales
        {
            get { return long.Parse(TextBoxDecimales.Text); }
            set { TextBoxDecimales.Text = value.ToString(); }
        }

        public long CantHilos
        {
            get { return long.Parse(TextBoxCantHilos.Text); }
            set { TextBoxCantHilos.Text = value.ToString(); }
        }

        public long KWVueltas
        {
            get { return long.Parse(TextBoxKWVueltas.Text); }
            set { TextBoxKWVueltas.Text = value.ToString(); }
        }

        public string Amperaje
        {
            get { return this.TextBoxAmperaje.Text; }
            set { this.TextBoxAmperaje.Text = value; }
        }

        public long Clase
        {
            get { return long.Parse(TextBoxClase.Text); }
            set { TextBoxClase.Text = value.ToString(); }
        }

        public long Registrador
        {
            get { return long.Parse(TextBoxRegistrador.Text); }
            set { TextBoxRegistrador.Text = value.ToString(); }
        }

        public cmbLista TipoContador
        {
            get { return this.cmbTipoContador; }
            set { this.cmbTipoContador = value; }
        }
        public cmbLista TipoConexion
        {
            get { return this.cmbTipoConexion; }
            set { this.cmbTipoConexion = value; }
        }
        public cmbLista FabNumero
        {
            get { return this.cmbFabricante; }
            set { this.cmbFabricante = value; }
        }
        public cmbLista TMeCodigo
        {
            get { return this.cmbTipoMedidor; }
            set { this.cmbTipoMedidor = value; }
        }
        public DateTime FechaCarga
        {
            get { return DateTime.Parse(dtpFechaCarga.Text); }
            set { dtpFechaCarga.Text = value.ToString(); }
        }
        public string estCodigo
        {
            get { return this.chkEstado.Checked ? "H" : "I"; }
            set { this.chkEstado.Checked = (value == "H"); }
        }

        #endregion
        public frmMedidoresModelosCrud(long ModeloMedidor, string Estado, long Usuario)
            //SRuta, Estado 
        {
            //try
            //{
                _MmoCodigo=ModeloMedidor;
                _EstCodigo = Estado;
                _usrNumero = Usuario;
                _oMedidoresModelosCrud = new UIMedidoresModelosCrud(this);
                InitializeComponent();
            if (Estado == "B")
                if (MessageBox.Show("Desea eliminar el Modelo de Medidor Código: " + ModeloMedidor + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    //_oMedidoresModelosCrud.EliminarModeloMedidor(ModeloMedidor);
                    this.Close();
                }
            //}
            //catch (Exception ex)
            //{
            //    Cursor.Current = Cursors.Default;
            //    ManejarError Err = new ManejarError();
            //    Err.CargarError(ex,
            //                    e.ToString(),
            //                    ((Control)sender).Name,
            //                    this.FindForm().Name);
            //}
        }

        private void frmMedidoresModelosCrud_Load(object sender, EventArgs e)
        {
            try
            {
                oUtil = new Utility();
                _oMedidoresModelosCrud.Inicializar();
                this.txtDescripcion.REQUERIDO = "SI";
                this.txtDescripcionCorta.REQUERIDO = "SI";
                this.TextBoxAmperaje.REQUERIDO = "SI";
                this.cmbFabricante.REQUERIDO = "SI";
                this.cmbTipoMedidor.REQUERIDO = "SI";
                this.dtpFechaCarga.REQUERIDO = "SI";
                this.chkEstado.REQUERIDO = "NO";
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.VALIDARFORM = true;
                oUtil.ValidarFormulario(this, this, 4);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oMedidoresModelosCrud.Guardar();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }

        }

    }
}
