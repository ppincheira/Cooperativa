using Business;
using Model;
using System;
using Service;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.buscador
{
    public class UIBuscador
    {
        private IVistaBuscador _vista;
        Utility oUtil;
        #region << PROPIEDADES >>
        private string _Tabla;
        private string _Campo;
        private string _filtroCampos;
        private string _filtroValores;
        private DataTable _dtCombo;
        private string _Fecha;
        #endregion


        public void Inicializar(string tabla)
        {
            _filtroCampos = "";
            _filtroValores = "";
            _dtCombo = new DataTable();
            _dtCombo.Columns.Add("DctColumna", typeof(string));
            _dtCombo.Columns.Add("DctDescripcion", typeof(string));
            DetallesColumnasTablasBus oDetalleBus = new DetallesColumnasTablasBus();
            List<DetallesColumnasTablas> ListDetalle = oDetalleBus.DetallesColumnasTablasGetByCodigo(tabla);
            foreach (DetallesColumnasTablas oDetalle in ListDetalle)
            {

                _Campo = _Campo + ' ' + oDetalle.DctColumna + ' ' + oDetalle.DctDescripcion + ',';
                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl != "FECHA") && oDetalle.DctTipoControl != "ESTADO")
                {
                    _dtCombo.Rows.Add(oDetalle.DctColumna, oDetalle.DctDescripcion);
                }

                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "FECHA"))
                {
                    _vista.grupoFecha.Visible = true;
                    _vista.fechaDesde = DateTime.Now.Date.AddMonths(-1);
                    _vista.fechaHasta = DateTime.Now.Date;
                    _filtroCampos = _filtroCampos + oDetalle.DctColumna + "&";
                    _Fecha = oDetalle.DctColumna + "&";
                    _filtroValores = _filtroValores + _vista.fechaDesde.ToString() + "%" + _vista.fechaHasta.ToString()+ "&";
                }
                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "ESTADO"))
                {
                    _vista.grupoEstado.Visible = true;
                    _filtroCampos = _filtroCampos + oDetalle.DctColumna + "&";
                    _filtroValores = _filtroValores +_vista.comboEstado.Text + "&";
                }
            }

            oUtil.CargarCombo( _vista.comboBuscar, _dtCombo, "DctColumna", "DctDescripcion");
            //this.cmbBuscar.DataSource = _dtCombo;
            //this.cmbBuscar.ValueMember = "DctColumna";
            //this.cmbBuscar.DisplayMember = "DctDescripcion";
            if (_Campo.Length > 0)

                _Campo = _Campo.Substring(0, _Campo.Length - 1);
            TablasBus oTablasBus = new TablasBus();
            _vista.grilla.DataSource = oTablasBus.TablasBusquedaGetAllFilter(_Tabla, _Campo, _filtroCampos, _filtroValores);
            _vista.cantidad= "Se encontraron " + _vista.grilla.VisibleRowCount.ToString() + " registros";

        }


         public void CargarGrilla() {
            _filtroCampos = "";
            _filtroValores = "";

            if (_vista.grupoFecha.Visible) { 
                _filtroValores =_vista.fechaDesde + "%" + _vista.fechaHasta+ "&";
                _filtroCampos = _Fecha ;
            }
            if (_vista.grupoEstado.Visible)
                _filtroValores = _vista.comboEstado.Text + "&";

            _filtroCampos = _filtroCampos+_vista.comboBuscar.SelectedValue.ToString() + "&";
            _filtroValores = _filtroValores+_vista.filtro + "&";

            TablasBus oTablasBus = new TablasBus();
            _vista.grilla.DataSource = oTablasBus.TablasBusquedaGetAllFilter(_Tabla, _Campo, _filtroCampos, _filtroValores);
            _vista.cantidad= "Se encontraron "+ _vista.grilla.VisibleRowCount.ToString()+ " registros";

        }


    }
}
