using AppProcesos.gesServicios.frmRutasCrud;
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
    public partial class frmRutasCrud: gesForm, IVistaRutasCrud
    {

        #region << PROPIEDADES >>

        UIRutasCrud _oRutasCrud;
        Utility oUtil;

        long _SruNumero;
        string _EstCodigo;
        long _DomCodigoRegistro;
        string _TdoCodigo;
      


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
        public frmRutasCrud()
        {
            InitializeComponent();
        }

        private void frmRutasCrud_Load(object sender, EventArgs e)
        {


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbCalle_Click(object sender, EventArgs e)
        {

        }
    }
}
