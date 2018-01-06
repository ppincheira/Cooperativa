using AppProcesos.gesServicios.frmRutasCrud;
using Controles.datos;
using Controles.form;
using Service;
using System;
using System.Windows.Forms;

namespace GesServicios.controles.forms
{
    public partial class frmRutasCrud : gesForm, IVistaRutasCrud
    {

        #region << PROPIEDADES >>

        UIRutasCrud _oRutasCrud;
        Utility oUtil;

        long _SruNumero;
        string _EstCodigo;

        #endregion
        #region Implementation of IVistaRutasCrud


        public long sruNumero
        {
            get { return _SruNumero; }
            set { _SruNumero = value; }
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

        public string estCodigo
        {
            get { return _EstCodigo; }
            set { _EstCodigo = value; }
        }

        public cmbLista srvCodigo
        {
            get { return this.cmbServicio; }
            set { this.cmbServicio = value; }
        }
        #endregion
        public frmRutasCrud(long SRuta, string Estado)
            //SRuta, Estado 
        {
            try
            {
                InitializeComponent();
                _SruNumero=SRuta;
                _EstCodigo = Estado;
                _oRutasCrud = new UIRutasCrud(this);
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

        private void frmRutasCrud_Load(object sender, EventArgs e)
        {
            try
            {
                oUtil = new Utility();
                _oRutasCrud.Inicializar();
                this.txtDescripcion.REQUERIDO = "SI";
                this.txtDescripcionCorta.REQUERIDO = "SI";
                this.cmbServicio.REQUERIDO = "SI";
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
                oUtil.ValidarFormulario(this, this, 3);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oRutasCrud.Guardar();

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
