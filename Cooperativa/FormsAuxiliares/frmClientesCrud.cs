using AppProcesos.formsAuxiliares.frmClientes;
using Controles.datos;
using Controles.form;
using Model;
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
    public partial class frmClientesCrud : gesForm
    {

        #region << PROPIEDADES >>
        UIClientesCrud _oClientesCrud;
        Utility oUtil;
        long _EmpNumero;

        #endregion


        #region Implementation of IVistaClientesCrud
        public long empNumero
        {
            get { return _EmpNumero; }
            set { _EmpNumero = value; }
        }
        public string strRazonSocial
        {
            get { return this.txtRazonSocial.Text; }
            set { this.txtRazonSocial.Text = value; }
        }
        public string strDenominacionComercial
        {
            get { return this.txtDenominacionComercial.Text; }
            set { this.txtDenominacionComercial.Text = value; }
        }
        public string strCuit
        {
            get { return this.rbIndividual.Checked ? this.txtCuitI.Text: this.txtCuit.Text; }
            set { this.txtCuitI.Text = value; this.txtCuit.Text= value; }
        }

        public cmbLista cmbiTipoIva
        {
            get { return this.rbIndividual.Checked ? this.cmbTipoIvaI:this.cmbTipoIVA; }
            set { this.cmbTipoIvaI = value; this.cmbTipoIVA = value;}
        }
        public string strObservacion
        {
            get { return this.txtObservaciones.Text; }
            set { this.txtObservaciones.Text = value; }
        }
        public string strTitularCheques
        {
            get { return this.txtTitularCheques.Text; }
            set { this.txtTitularCheques.Text = value; }
        }
        public string strPropia
        {
            get { return this.chkEmpPropia.Checked?"S":"N"; }
            set { this.chkEmpPropia.Checked = value=="S"?true:false; }
        }
        public string strCliente
        {
            get { return this.chkEsCliente.Checked ? "S" : "N"; }
            set { this.chkEsCliente.Checked = value == "S" ? true : false; }
        }
        public string strCategoriaMonotributo
        {
            get { return null; }
        }
        public cmbLista cmbiTipoDocumento
        {
            get { return this.cmbTipoDniI; }
            set { this.cmbTipoDniI = value;}
        }
        public string strNroDocumento
        {
            get { return this.txtDNII.Text; }
            set { this.txtDNII.Text = value; }
        }
        public string strApellido
        {
            get { return this.txtApellidoI.Text; }
            set { this.txtApellidoI.Text = value; }
        }
        public string strNombre
        {
            get { return this.txtNombreI.Text; }
            set { this.txtNombreI.Text = value; }
        }
        public decimal? dblLimiteCredito
        {
            get { return this.txtLimiteCredito.Text!=""? decimal.Parse(this.txtLimiteCredito.Text):0; }
            set { this.txtLimiteCredito.Text = value.ToString(); }
        }
        public cmbLista cmbiEstadoCredito
        {
            get { return this.cmbEstadoCredito; }
            set { this.cmbEstadoCredito = value; }
        }

        public int? intNumeroTransporte
        {
            get { return this.txtNroTransporte.Text==""?0:int.Parse(this.txtNroTransporte.Text); }
            set { this.txtNroTransporte.Text = value.ToString(); }
        }
        #endregion



        public frmClientesCrud()
        {
            InitializeComponent();
        }

        private void frmClientesCrud_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "DOMB";
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
            frmbus.ShowDialog();
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "TETE";
            oAdmin.Tipo = Admin.enumTipoForm.Selector;
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            if (frmbus.ShowDialog() == DialogResult.OK)
            {
                string nombre = frmbus.striRdoCodigo;
                
            }
            frmbus.ShowDialog();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "TEEM";
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
            frmbus.ShowDialog();

        }

        private void rbIndividual_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlEmpresa.Visible = false;
            this.pnlIndividuo.Visible = true;
        }

        private void rbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlEmpresa.Visible = true;
            this.pnlIndividuo.Visible = false;
        }
    }
}
