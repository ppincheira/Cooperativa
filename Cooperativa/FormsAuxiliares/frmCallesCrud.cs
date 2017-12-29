using AppProcesos.formsAuxiliares.frmCalles;
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

namespace FormsAuxiliares
{
    public partial class frmCallesCrud : gesForm, IVistaCallesCrud
    {

        #region << PROPIEDADES >>
        UICallesCrud _oCallesCrud;
        Utility oUtil;
        long _codigo;
        string _codigoProvincia;
        string _accion;
        #endregion
        public frmCallesCrud(long codigo, string codigoProvincia, string accion)
        {
            try { 
            InitializeComponent();
            _codigo = codigo;
            _codigoProvincia = codigoProvincia;
            _accion = accion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }


        #region Implementation of IVistaCallesCrud


        public long codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public string codigoProvincia
        {
            get { return _codigoProvincia; }
            set { _codigoProvincia = value; }
        }

        public string txtDescripcion
        {
            get { return this.txtDescripcionCorta.Text; }
            set { this.txtDescripcionCorta.Text =  value; }
        }
        public cmbLista cmbLocalidad
        {
            get { return this.cmbLista; }
            set { this.cmbLista= value; }
        }

        #endregion

        private void frmCallesCrud_Load(object sender, EventArgs e)
        {
            try { 
            this.txtDescripcionCorta.REQUERIDO = "SI";
            this.cmbLista.REQUERIDO = "SI";
            _oCallesCrud.Inicializar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                oUtil.ValidarFormulario(this, this, 5);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oCallesCrud.Guardar();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
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
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }
    }
}
