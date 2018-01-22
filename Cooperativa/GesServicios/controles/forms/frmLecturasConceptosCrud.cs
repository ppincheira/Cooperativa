using AppProcesos.gesServicios.frmLecturasConceptosCrud;
using Controles.Fecha;
using Controles.form;
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

namespace GesServicios.controles.forms
{
    public partial class frmLecturasConceptosCrud : gesForm , IVistaLecturasConceptosCrud
    {
        UILecturasConceptosCrud _oLecturasConceptosCrud;
        Utility oUtil;
        int _UsrNumero;
        string _EstCodigo;
        long _LecCodigo;

        public long lecCodigo { get { return this._LecCodigo; } set { this._LecCodigo = value; } }
        public string lecDescripcion { get { return this.txtLCDescripcion.Text; } set { this.txtLCDescripcion.Text = value; } }
        public string lecDescripcionCorta { get { return this.txtLCDescripcionCorta.Text; } set { this.txtLCDescripcionCorta.Text = value; } }
        public dtpFecha lecFechaAlta { get { return this.dtpFechaCarga; } set { this.dtpFechaCarga = value; } }
        public string estCodigo { get { return this._EstCodigo; } set { this._EstCodigo = value; } }
        public int usrCodigo { get { return this._UsrNumero; } set { this._UsrNumero = value; } }


        public frmLecturasConceptosCrud(long idLC, string estado)
        {
            _LecCodigo = idLC;
            _EstCodigo = estado;
            _oLecturasConceptosCrud = new UILecturasConceptosCrud(this);
            InitializeComponent();

            if (this._EstCodigo == "H")
            {
                this.chkEstado.Checked = true;
            }
            else
            if (this._EstCodigo == "I")
            {
                this.chkEstado.Checked = false;
            }


            if (estado == "B")
                if (MessageBox.Show("Desea eliminar la LEctura Concepto Código: " + _LecCodigo + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    _oLecturasConceptosCrud.EliminarLecturasConceptos(_LecCodigo);
                    this.Close();
                }
        }

        private void frmLecturasConceptosCrud_Load(object sender, EventArgs e)
        {
            try
            {

                oUtil = new Utility();
                _oLecturasConceptosCrud.Inicializar();

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                _UsrNumero = 1;
                if (this.chkEstado.Checked == true)
                {
                    this._EstCodigo = "H";
                }
                else
                    this._EstCodigo = "I";
                //               oUtil.ValidarFormulario(this, this, 3);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oLecturasConceptosCrud.Guardar();
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
         
        public void bloquearFecha()
        {
            this.dtpFechaCarga.Enabled = false;
        }

  
    }
}
