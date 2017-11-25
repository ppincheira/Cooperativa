using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business;
using Model;
using System.Globalization;
using AppProcesos.formsAuxiliares.buscador;
using Controles.datos;
using Controles.contenedores;

namespace FormsAuxiliares
{
    public partial class frmBuscador : gesForm, IVistaBuscador
    {

        private UIBuscador _oBuscador;
        #region << PROPIEDADES >>
        private string _Tabla;
        private string _Campo;
        private string _filtroCampos;
        private string _filtroValores;
        private DataTable _dtCombo;
        private string _Fecha;
        #endregion
        #region Implementation of IVistaBuscador
        public gpbGrupo grupoEstado
        {
            get { return this.gpbGrupoEstado; }
            set { this.gpbGrupoEstado = value; }
        }
        public gpbGrupo grupoFecha
        {
            get { return this.gpbGrupoFecha; }
            set { this.gpbGrupoFecha = value; }
        }


        public grdGrillaAdmin grilla
        {
            get { return this.grilla; }
            set { this.grilla = value; }
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
        #region << EVENTOS >>

        public frmBuscador(string tabla)
        {
            _Tabla = tabla;
            InitializeComponent();
        }


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _oBuscador.CargarGrilla();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    


        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _oBuscador.CargarGrilla();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _oBuscador.CargarGrilla();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _oBuscador.CargarGrilla();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmBuscador_Load(object sender, EventArgs e)
        {
            try {

                _oBuscador.Inicializar(_Tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
        #endregion






    }







}
