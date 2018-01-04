using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Controles;
using AppProcesos.formsAuxiliares.formAdmin;
using Controles.datos;
using Service;
using Controles.form;
using System.Windows.Forms;

namespace FormsAuxiliares
{
    public partial class frmFormAdminMini : gesForm, IVistaFormAdmin
    {


        #region << PROPIEDADES >>

        private string _Tabla;
        Utility oUtil;
        private UIFormAdmin _oFormAdmin;
        #endregion

        #region Implementation of IVistaBuscador
        public Boolean grupoEstado
        {
            get { return this.gpbGrupoEstado.Visible; }
            set { this.gpbGrupoEstado.Visible = value; }
        }
        public Boolean grupoFecha
        {
            get { return this.gpbFecha.Visible; }
            set { this.gpbFecha.Visible = value; }
        }

        public grdGrillaAdmin grilla
        {
            get { return this.dgBusqueda; }
            set { this.dgBusqueda = value; }
        }
        public DateTime fechaDesde
        {
            get { return this.dtpFechaDesde.Value; }
            set { this.dtpFechaDesde.Value = value; }
        }
        public DateTime fechaHasta
        {
            get { return this.dtpFechaHasta.Value; }
            set { this.dtpFechaHasta.Value = value; }
        }
        public cmbLista comboBuscar
        {
            get { return this.cmbBuscar; }
            set { this.cmbBuscar = value; }
        }
        public string filtro
        {
            get { return this.txtFiltro.Text; }
            set { this.txtFiltro.Text = value; }
        }
        public cmbLista comboEstado
        {
            get { return this.cmbEstado; }
            set { this.cmbEstado = value; }
        }
        public string cantidad
        {

            set { this.lblCantidad.Text = value; }
        }

        #endregion
        public frmFormAdminMini(string tabCodigo, FuncionalidadesFoms oPerForm)
        {
            try
            {
                InitializeComponent();
                AsignarFuncionalidad(oPerForm);
                _Tabla = tabCodigo;

                _oFormAdmin = new UIFormAdmin(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        private void frmFormAdminMini_Load(object sender, EventArgs e)
        {
            try
            {
                _oFormAdmin.Inicializar(_Tabla);
                oUtil = new Utility();
                oUtil.HabilitarControles(this, 1, "frmFormAdmin", "CAJA", null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmABM ofrm = new frmABM(_Tabla);
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _oFormAdmin.CargarGrilla(_Tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        #region << METODOS >>
        public void AsignarFuncionalidad(FuncionalidadesFoms oPerForm)
        {
            //Esta funcion asigna la funcionalidad a los controles de este dinamico
            this.btnNuevo.FUN_CODIGO = oPerForm.New;
            this.btnEditar.FUN_CODIGO = oPerForm.Edit;
            this.btnExportar.FUN_CODIGO = oPerForm.Exp;
            this.btnEliminar.FUN_CODIGO = oPerForm.Del;
            this.btnImprimir.FUN_CODIGO = oPerForm.Imp;
        }
        #endregion

        private void gpbGrupo4_Enter(object sender, EventArgs e)
        {

        }
    }
}
