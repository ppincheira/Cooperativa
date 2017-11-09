using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business;
using Model;


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
                List<DetallesColumnasTablas> ListDetalle = oDetalleBus.DetallesColumnasTablasGetByName(_Tabla);
                foreach (DetallesColumnasTablas oDetalle in ListDetalle)
                {

                    _Campo = _Campo + ' ' + oDetalle.DctColumna + ' ' + oDetalle.DctDescripcion + ',';
                    if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl!="Fecha" ) && oDetalle.DctTipoControl != "Estado") { 
                        _dtCombo.Rows.Add(oDetalle.DctColumna, oDetalle.DctDescripcion);
                     
                    }

                    if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "Fecha"))
                    { 
                        this.gpbGrupoFecha.Visible = true;
                        _filtroCampos = oDetalle.DctColumna + "&";
                        _filtroValores = this.dtpFechaDesde.Text + "%" + this.dtpFechaHasta.Text + "&";
                    }
                    if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "Estado")) { 
                        this.gpbGrupoEstado.Visible = true;
                        _filtroCampos = oDetalle.DctColumna + "&";
                        _filtroValores = this.cmbEstado.Text + "&";
                    }
                }

                if (this.gpbGrupoFecha.Visible) {
                    this.dtpFechaDesde.Text = DateTime.Now.AddMonths(-1).ToString("dd/MM/yyyy");
                    this.dtpFechaHasta.Text = DateTime.Now.ToString("dd/MM/yyyy");
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

            
            if (this.gpbGrupoFecha.Visible)
                _filtroValores = this.dtpFechaDesde.Text + "%" + this.dtpFechaHasta.Text + "&";
            if (this.gpbGrupoEstado.Visible)
                _filtroValores = this.cmbEstado.Text + "&";

            _filtroCampos = this.cmbBuscar.SelectedValue.ToString() + "&";
            _filtroValores = this.txtFiltro.Text + "&";

            TablasBus oTablasBus = new TablasBus();
            this.dgBusqueda.DataSource = oTablasBus.TablasBusquedaGetAllFilter(_Tabla, _Campo, _filtroCampos, _filtroValores);
            this.lblCantidad.Text= "Se encontraron "+this.dgBusqueda.VisibleRowCount.ToString()+ " registros";

        }


        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

    }







}
