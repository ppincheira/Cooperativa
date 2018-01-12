using AppProcesos.gesServicios.frmMedidoresCrud;
using Controles.datos;
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
    public partial class frmTiposMedidoresCrud : gesForm, IVistaTiposMedidoresCrud
    {
        #region << PROPIEDADES >>
            UITiposMedidoresCrud _oMedidoresTipoCrud;
            Utility oUtil;
            string _SruNumero;
            string _EstCodigo;
        #endregion



        #region Implementation of IVistaTiposMedidoresCrud
            public string tmeCodigo
            {
            get { return this.txtTMECodigo.Text; }
            set { this.txtTMECodigo.Text = value; }
            }
         
            public string descripcion
        {
            get { return this.txtTMECodigo.Text; }
            set { this.txtTMECodigo.Text = value; }
        }
        public string descripcionCorta
        {
            get { return this.txtTMECodigo.Text; }
            set { this.txtTMECodigo.Text = value; }
        }
        public DateTime fechaCarga
        {
            get { return this.dtpFechaCarga.Value; }

            set
            {                
                this.dtpFechaCarga.Value= value;
            }
        }
        public cmbLista srvCodigo
        {
            get { return this.cmbSRVCodigo; }
            set { this.cmbSRVCodigo = value; }
        }
        public int usrNumero
        {
            get { return usrNumero; }
            set { usrNumero = value; }
        }
        public string estCodigo
        {
            get
            {
                if (this.chkEstado.Checked == true)
                    return "H";
                else
                { 
                if (this.chkEstado.Checked == false)
                    return "I";
                }
                return null;
            }
            set
            {
                if (value == "H")
                    this.chkEstado.Checked = true;
                if (value == "I")
                    this.chkEstado.Checked = false;
            }
        }
        #endregion

        public frmTiposMedidoresCrud(string SMedidorTipo, string Estado)
        {
            _SruNumero = SMedidorTipo;
            _EstCodigo = Estado;
            _oMedidoresTipoCrud = new UITiposMedidoresCrud(this);
            InitializeComponent();
            if (Estado == "B")
                if (MessageBox.Show("Desea eliminar El Tipo de Medidor Código: " + SMedidorTipo + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    _oMedidoresTipoCrud.EliminarMedidor(SMedidorTipo);
                    this.Close();
                }

        }

        private void frmTiposMedidoresCrud_Load(object sender, EventArgs e)
        {
            try
            {
                oUtil = new Utility();
                _oMedidoresTipoCrud.Inicializar();
                this.txtTMECodigo.REQUERIDO = "SI";
                this.txtTMEDescripcion.REQUERIDO = "SI";
                this.txtTMEDescripcionCorta.REQUERIDO = "SI";
                this.dtpFechaCarga.REQUERIDO = "SI";
                this.cmbSRVCodigo.REQUERIDO = "SI";
                this.chkEstado.REQUERIDO = "SI";
            }
            catch(Exception ex)
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
                usrNumero = 1;
                oUtil.ValidarFormulario(this, this, 3);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oMedidoresTipoCrud.Guardar();
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
