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

namespace Controles.forms
{
    public partial class frmBuscador : Controles.gesForm
    {




        #region << PROPIEDADES >>
        private string _Tabla;
        private string _Campo;
        private string _filtroCampos;
        private string _filtroValores;
        private DataTable _dtCombo;
        private string _Fecha;
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
                CargarGrilla();
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
                CargarGrilla();
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
                CargarGrilla();
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
                CargarGrilla();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmBuscador_Load(object sender, EventArgs e)
        {
            try { 
                Inicializar();
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
        #region << METODOS >>
        private void Inicializar()
        {
                _filtroCampos = "";
                _filtroValores = "";
                _dtCombo = new DataTable();
                _dtCombo.Columns.Add("DctColumna", typeof(string));
                _dtCombo.Columns.Add("DctDescripcion", typeof(string));
                DetallesColumnasTablasBus oDetalleBus = new DetallesColumnasTablasBus();
                List<DetallesColumnasTablas> ListDetalle = oDetalleBus.DetallesColumnasTablasGetByCodigo(_Tabla);
                foreach (DetallesColumnasTablas oDetalle in ListDetalle)
                {

                    _Campo = _Campo + ' ' + oDetalle.DctColumna + ' ' + oDetalle.DctDescripcion + ',';
                    if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl!="FECHA" ) && oDetalle.DctTipoControl != "ESTADO") { 
                        _dtCombo.Rows.Add(oDetalle.DctColumna, oDetalle.DctDescripcion);
                    }

                    if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "FECHA"))
                    { 
                        this.gpbGrupoFecha.Visible = true;
                        this.dtpFechaDesde.Value = DateTime.Now.Date.AddMonths(-1);
                        this.dtpFechaHasta.Value = DateTime.Now.Date;
                        _filtroCampos = _filtroCampos+ oDetalle.DctColumna + "&";
                        _Fecha=oDetalle.DctColumna + "&";
                        _filtroValores = _filtroValores+this.dtpFechaDesde.Text + "%" + this.dtpFechaHasta.Text + "&";
                    }
                    if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "ESTADO")) { 
                        this.gpbGrupoEstado.Visible = true;
                        _filtroCampos = _filtroCampos+oDetalle.DctColumna + "&";
                        _filtroValores = _filtroValores+this.cmbEstado.Text + "&";
                    }
                }

                this.cmbBuscar.DataSource = _dtCombo;
                this.cmbBuscar.ValueMember = "DctColumna";
                this.cmbBuscar.DisplayMember = "DctDescripcion";
                if (_Campo.Length > 0)
                    
                    _Campo = _Campo.Substring(0, _Campo.Length - 1);
                TablasBus oTablasBus = new TablasBus();
                this.dgBusqueda.DataSource = oTablasBus.TablasBusquedaGetAllFilter(_Tabla,_Campo, _filtroCampos, _filtroValores);
                this.lblCantidad.Text = "Se encontraron " + this.dgBusqueda.VisibleRowCount.ToString() + " registros";
        
        }

        private void CargarGrilla() {
            _filtroCampos = "";
            _filtroValores = "";

            if (this.gpbGrupoFecha.Visible) { 
                _filtroValores = this.dtpFechaDesde.Text + "%" + this.dtpFechaHasta.Text + "&";
                _filtroCampos = _Fecha ;
            }
            if (this.gpbGrupoEstado.Visible)
                _filtroValores = this.cmbEstado.Text + "&";

            _filtroCampos = _filtroCampos+this.cmbBuscar.SelectedValue.ToString() + "&";
            _filtroValores = _filtroValores+this.txtFiltro.Text + "&";

            TablasBus oTablasBus = new TablasBus();
            this.dgBusqueda.DataSource = oTablasBus.TablasBusquedaGetAllFilter(_Tabla, _Campo, _filtroCampos, _filtroValores);
            this.lblCantidad.Text= "Se encontraron "+this.dgBusqueda.VisibleRowCount.ToString()+ " registros";

        }




        #endregion

  
    }







}
