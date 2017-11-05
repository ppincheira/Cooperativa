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

        private void frmBuscador_Load(object sender, EventArgs e)
        {
            inicializar();
        }
        #endregion
        #region << METODOS >>
        private void inicializar()
        {

            try
            {
                _dtCombo = new DataTable();
                _dtCombo.Columns.Add("DctColumna", typeof(string));
                _dtCombo.Columns.Add("DctDescripcion", typeof(string));
                DetallesColumnasTablasBus oDetalleBus = new DetallesColumnasTablasBus();
                List<DetallesColumnasTablas> ListDetalle = oDetalleBus.DetallesColumnasTablasGetByName(_Tabla);
                foreach (DetallesColumnasTablas oDetalle in ListDetalle)
                {
                  
                    _Campo = _Campo + ' ' + oDetalle.DctColumna + ' ' + oDetalle.DctDescripcion + ',';
                    
                    if (oDetalle.DctFiltroBusqueda == "S")
                    {
                        _dtCombo.Rows.Add(oDetalle.DctColumna, oDetalle.DctDescripcion);
                    }

                }
                this.cmbBuscar.DataSource = _dtCombo;
                this.cmbBuscar.ValueMember = "DctColumna";
                this.cmbBuscar.DisplayMember = "DctDescripcion";
                if (_Campo.Length > 0)
                    
                    _Campo = _Campo.Substring(0, _Campo.Length - 1);

               
                TablasBus oTablasBus = new TablasBus();
                this.dgBusqueda.DataSource = oTablasBus.TablasBusquedaGetAllFilter(_Tabla,_Campo, "", this.txtFiltro.Text);
                this.lblCantidad.Text = "Se encontraron " + this.dgBusqueda.VisibleRowCount.ToString() + " registros";
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private void CargarGrilla() {
            TablasBus oTablasBus = new TablasBus();
            this.dgBusqueda.DataSource = oTablasBus.TablasBusquedaGetAllFilter(_Tabla, _Campo, this.cmbBuscar.SelectedValue.ToString(), this.txtFiltro.Text);
            this.lblCantidad.Text= "Se encontraron "+this.dgBusqueda.VisibleRowCount.ToString()+ " registros";

        }


        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }







}
