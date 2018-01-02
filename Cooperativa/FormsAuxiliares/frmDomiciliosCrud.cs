using AppProcesos.formsAuxiliares.frmDomicilios;
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
    public partial class frmDomiciliosCrud: gesForm, IVistaDomiciliosCrud
    {

        #region << PROPIEDADES >>

        UIDomiciliosCrud _oDomicilioCrud;
        Utility oUtil;

        long _DomCodigo;
        string _TabCodigo;
        long _DomCodigoRegistro;
        string _TdoCodigo;
      


        #endregion
        #region Implementation of IVistaObservacionesCrud


        public long domCodigo
        {
            get { return _DomCodigo; }
            set { _DomCodigo = value; }
        }
        public string tabCodigo
        {
            get { return _TabCodigo; }
            set { _TabCodigo = value; }
        }

        public long  domCodigoRegistro
        {
            get { return _DomCodigoRegistro; }
            set { _DomCodigoRegistro = value; }
        }
        public string tdoCodigo
        {
            get { return _TdoCodigo; }
            set { _TdoCodigo = value; }
        }

        public cmbLista cmbiLocalidad
        {
            get { return this.cmbLocalidad; }
            set { this.cmbLocalidad = value; }
        }
        public cmbLista cmbiCalle
        {
            get { return this.cmbCalle; }
            set { this.cmbCalle = value; }
        }

        public int numero
        {
            get { return int.Parse(this.txtNumero.Text); }
            set { this.txtNumero.Text = value.ToString(); }
        }

        public string bloque
        {
            get { return this.txtBloque.Text; }
            set { this.txtBloque.Text = value; }
        }
        public string departamento
        {
            get { return this.txtDepartamento.Text; }
            set { this.txtDepartamento.Text = value; }
        }
        public string piso
        {
            get { return this.txtPiso.Text; }
            set { this.txtPiso.Text = value; }
        }
        public string parcela
        {
            get { return this.txtParcela.Text; }
            set { this.txtParcela.Text = value; }
        }

        public cmbLista cmbiCalleDesde
        {
            get { return this.cmbCalleDesde; }
            set { this.cmbCalleDesde = value; }
        }
        public cmbLista cmbiCalleHasta
        {
            get { return this.cmbCalleHasta; }
            set { this.cmbCalleHasta = value; }
        }
        
        public int codigoPostal
        {
            get { return int.Parse(this.txtCodigoPostal.Text); }
            set { this.txtCodigoPostal.Text = value.ToString(); }
        }

        public decimal gisX
        {
            get { return decimal.Parse(this.txtGisX.Text); }
            set { this.txtGisX.Text = value.ToString(); }
        }

        public decimal gisY
        {
            get { return decimal.Parse(this.txtGisY.Text); }
            set { this.txtGisY.Text = value.ToString(); }
        }
        #endregion
        public frmDomiciliosCrud()
        {
            InitializeComponent();
        }

        private void frmDomiciliosCrud_Load(object sender, EventArgs e)
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
    }
}
