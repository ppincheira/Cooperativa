using Business;
using Model;
using System;
using Service;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AppProcesos.formsAuxiliares.frmCrudGrilla
{
    public partial class UICrudGrilla
    {
        private IVistaCrudGrilla _vista;
        Utility oUtil;

        private string _Campo;
        private string _filtroCampos;
        private string _filtroValores;
        private DataTable _dtCombo;
        private string _Fecha;
        public string columnaClave = "";

        public UICrudGrilla(IVistaCrudGrilla vista)
        {
            _vista = vista;
            oUtil = new Utility();

        }

        public void Inicializar(string tabla, string campoClave)
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
                    _vista.grupoFecha = true;
                    _vista.fechaDesde = DateTime.Now.Date.AddMonths(-1);
                    _vista.fechaHasta = DateTime.Now.Date;
                    _filtroCampos = _filtroCampos + oDetalle.DctColumna + "&";
                    _Fecha = oDetalle.DctColumna + "&";
                    _filtroValores = _filtroValores + _vista.fechaDesde.ToString("dd/MM/yyyy") + "%" + _vista.fechaHasta.ToString("dd/MM/yyyy") + "&";
                }
                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "ESTADO"))
                {
                    _vista.grupoEstado = true;
                    _filtroCampos = _filtroCampos + oDetalle.DctColumna + "&";
                    _filtroValores = _filtroValores + _vista.comboEstado.Text + "&";
                }
                if (campoClave == oDetalle.DctDescripcion)
                    columnaClave = oDetalle.DctColumna;
            }

            oUtil.CargarCombo(_vista.comboBuscar, _dtCombo, "DctColumna", "DctDescripcion");
            if (_Campo.Length > 0)
                _Campo = _Campo.Substring(0, _Campo.Length - 1);
            TablasBus oTablasBus = new TablasBus();
            DataTable dt = oTablasBus.TablasBusquedaGetAllFilter(tabla, _Campo, _filtroCampos, _filtroValores);
            _vista.cantidad = "Se encontraron " + oUtil.CargarGrilla(_vista.grilla, dt) + " registros";
            _vista.grilla.Columns.Add("Estado", "");
            _vista.grilla.Columns[campoClave].ReadOnly = true;
            _vista.grilla.Columns[_vista.grilla.ColumnCount - 1].Visible = false;
            foreach (DataGridViewRow row in _vista.grilla.Rows)
            {
                //  if (!row.IsNewRow)
                row.Cells[_vista.grilla.ColumnCount - 1].Value = "0";
            }
        }

        public void CargarGrilla(string tabla, string campoClave)
        {
            _filtroCampos = "";
            _filtroValores = "";

            if (_vista.grupoFecha)
            {
                _filtroValores = _vista.fechaDesde.ToString("dd/MM/yyyy") + "%" + _vista.fechaHasta.ToString("dd/MM/yyyy") + "&";
                _filtroCampos = _Fecha;
            }
            if (_vista.grupoEstado)
                _filtroValores = _vista.comboEstado.Text + "&";

            _filtroCampos = _filtroCampos + _vista.comboBuscar.SelectedValue.ToString() + "&";
            _filtroValores = _filtroValores + _vista.filtro + "&";

            TablasBus oTablasBus = new TablasBus();
            _vista.grilla.DataSource = oTablasBus.TablasBusquedaGetAllFilter(tabla, _Campo, _filtroCampos, _filtroValores);
            _vista.cantidad = "Se encontraron " + _vista.grilla.RowCount.ToString() + " registros";
        }

        public void ActualizaTabla(string Tabla, string campoClave)
        {
            // Obtener de DetallesColumnasTablas todos los campos de la tabla menos el campo clave
            // Pasar esos campos a un arreglo de campos y valores
            // actualizar
            Tablas otabla = new Tablas();
            TablasBus tablasGrd = new TablasBus();
            otabla = tablasGrd.TablasGetById(Tabla);
            DetallesColumnasTablasBus oDetalleGrd = new DetallesColumnasTablasBus();
            List<DetallesColumnasTablas> ListDetalle = oDetalleGrd.DetallesColumnasTablasGetByCodigo(Tabla);
            foreach (DataGridViewRow row in _vista.grilla.Rows)
            {
                if (!row.IsNewRow)
                {
                    string[] nombreCampos = { };
                    string[] valoresCampos = { };
                    string valorClave = "";
                    string columnaClave = "";
                    int posicion = 0;
                    // Actualizar tabla
                    foreach (DetallesColumnasTablas oDetalle in ListDetalle)
                    {
                        posicion++;
                        if (oDetalle.DctDescripcion != campoClave)
                        {
                            Array.Resize(ref nombreCampos, nombreCampos.Length + 1);
                            Array.Resize(ref valoresCampos, valoresCampos.Length + 1);
                            nombreCampos[nombreCampos.Length - 1] = oDetalle.DctColumna;
                            valoresCampos[valoresCampos.Length - 1] = row.Cells[posicion - 1].Value.ToString();
                        }
                        else
                        {
                            valorClave = row.Cells[posicion - 1].Value.ToString();
                            columnaClave = oDetalle.DctColumna;
                        }
                    };
                    if (row.Cells[_vista.grilla.ColumnCount - 1].Value.ToString() == "1" && !row.IsNewRow)
                    {
                        // Update
                        tablasGrd.TablaActualizaGrid(otabla.TabNombre, nombreCampos, valoresCampos, columnaClave + "='" + valorClave + "'", "U");
                    }
                    else if (row.Cells[_vista.grilla.ColumnCount - 1].Value.ToString() == "2" && !row.IsNewRow)
                    {
                        // Delete
                        tablasGrd.TablaActualizaGrid(otabla.TabNombre, nombreCampos, valoresCampos, columnaClave + "='" + valorClave + "'", "D");
                    }
                    else if (row.Cells[_vista.grilla.ColumnCount - 1].Value.ToString() == "3" && !row.IsNewRow)
                    {
                        // Insert
                        tablasGrd.TablaActualizaGrid(otabla.TabNombre, nombreCampos, valoresCampos, columnaClave + "='" + valorClave + "'", "I");
                    };
                }

            };
        }
    }
}
