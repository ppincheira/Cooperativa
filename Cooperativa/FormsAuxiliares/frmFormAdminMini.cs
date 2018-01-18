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
using GesServicios.controles.forms;
using Controles.datos;
using Service;
using Controles.form;
using System.Windows.Forms;
using AppProcesos.gesServicios.frmRutasCrud;

namespace FormsAuxiliares
{
    public partial class frmFormAdminMini : gesForm, IVistaFormAdmin
    {


        #region << PROPIEDADES >>

        private string _Tabla;
        Utility _oUtil;
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
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                "frmFormAdminMini",
                                "frmFormAdminMini",
                                this.FindForm().Name);
            }

        }

        private void frmFormAdminMini_Load(object sender, EventArgs e)
        {
            try
            {
                _oFormAdmin.Inicializar(_Tabla);
                _oUtil = new Utility();
                _oUtil.HabilitarAllControlesInTrue(this, 1, "frmFormAdmin");
                //_oUtil.HabilitarControles(this, 1, "frmFormAdmin", "CAJA", null);
                switch (_Tabla)
                {
                    case "SCAT":
                        this.dgBusqueda.Columns["DESCRIPCION"].Visible = false;
                        this.Text = "Categorias";
                        break;

                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_Tabla)
                {
                    case "CALB":
                        frmCallesCrud oFrmCalCrud = new frmCallesCrud(0, "NQ");
                        if (oFrmCalCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                    case "SRUT":
                        frmRutasCrud oFrmRutCrud = new frmRutasCrud(0, "H");

                        if (oFrmRutCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                    case "TCS":
                        frmTiposConexionesCrud oFrmTCSCrud = new frmTiposConexionesCrud("", "H");

                        if (oFrmTCSCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                    case "":
                        Console.WriteLine("Case 2");
                        break;
                    case "COPB":

                        frmCodigoPostalCrud oFrmCodPostalCrud = new frmCodigoPostalCrud(0, "NQ");
                        if (oFrmCodPostalCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                    case "TME":

                        frmTiposMedidoresCrud oFrmTiposMedidores = new frmTiposMedidoresCrud(0, "");
                        if (oFrmTiposMedidores.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;

                    case "FAB":

                        frmFabricantesCrud oFrmFabricantes = new frmFabricantesCrud(0, "");
                        if (oFrmFabricantes.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                    case "SCAT":                        
                        frmCategoriasCrud oFrmCatCrud = new frmCategoriasCrud(0, "I");
                        if (oFrmCatCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;

                }


            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgBusqueda.CurrentRow;

                switch (_Tabla)
                {
                    case "CALB":
                        long idCalle = Convert.ToInt64(row.Cells[0].Value);
                        frmCallesCrud oFrmCalCrud = new frmCallesCrud(idCalle, "NQ");
                        if (oFrmCalCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;

                    case "SRUT":
                        long idRuta = Convert.ToInt64(row.Cells[0].Value);
                        frmRutasCrud oFrmRutCrud = new frmRutasCrud(idRuta, "H");
                        if (oFrmRutCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                    case "TCS":
                        string idTCS = row.Cells[0].Value.ToString();
                        frmTiposConexionesCrud oFrmTCSCrud = new frmTiposConexionesCrud(idTCS, "H");
                        if (oFrmTCSCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                    case "COPB":
                        long idCodPostal = Convert.ToInt64(row.Cells[0].Value);
                        frmCodigoPostalCrud oFrmCodPostalCrud = new frmCodigoPostalCrud(idCodPostal, "NQ");
                        if (oFrmCodPostalCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                    case "TME":
                        long idMedidor = Convert.ToInt64(row.Cells[0].Value);
                        string estadoMedidor = row.Cells[5].Value.ToString();
                        frmTiposMedidoresCrud oTiposMedidoresCrud = new frmTiposMedidoresCrud(idMedidor, estadoMedidor);
                        oTiposMedidoresCrud.bloquearFecha();
                        if (!oTiposMedidoresCrud.IsDisposed)// ESTE CONTROL SE HACE HASTA QUE LA GRILLA DEJE DE TRAER LOS REGISTROS QUE TENGAN EL ESTADO "B"
                        {
                            if (oTiposMedidoresCrud.ShowDialog() == DialogResult.OK)
                                _oFormAdmin.CargarGrilla(_Tabla);
                        }
                        break;
                    case "FAB":
                        long idFabricante = Convert.ToInt64(row.Cells[0].Value);
                        string estadoFabricante = row.Cells[2].Value.ToString();
                        frmFabricantesCrud oFabricantesCrud = new frmFabricantesCrud(idFabricante, estadoFabricante);
                        oFabricantesCrud.bloquearFecha();
                        if (!oFabricantesCrud.IsDisposed)
                            if (oFabricantesCrud.ShowDialog() == DialogResult.OK)
                                _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                    case "SCAT":
                        long id = Convert.ToInt64(row.Cells[0].Value);
                        frmCategoriasCrud oFrmCatCrud = new frmCategoriasCrud(id, "E");
                        if (oFrmCatCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgBusqueda.CurrentRow;
                switch (_Tabla)
                {
                    case "SRUT": 
                        long idRuta = Convert.ToInt64(row.Cells[0].Value);
                        frmRutasCrud oFrmRutCrud = new frmRutasCrud(idRuta, "B");
                        _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                    case "TCS":
                        string idTCS = row.Cells[0].Value.ToString();
                        frmTiposConexionesCrud oFrmTCSCrud = new frmTiposConexionesCrud(idTCS, "B");
                        if (oFrmTCSCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                    case "FAB":
                        long idFabricantes = Convert.ToInt64(row.Cells[0].Value);
                        frmFabricantesCrud oFrmFabricantesCrud = new frmFabricantesCrud(idFabricantes, "B");
                        _oFormAdmin.CargarGrilla(_Tabla);
                        break;

                    case "TME":
                        long idTme = Convert.ToInt64(row.Cells[0].Value);
                        frmTiposMedidoresCrud oFrmMedidorCrud = new frmTiposMedidoresCrud(idTme, "B");
                        _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                    case "SCAT":
                        long id = Convert.ToInt64(row.Cells[0].Value);
                        frmCategoriasCrud oFrmCatCrud = new frmCategoriasCrud(id, "B");
                        _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                }

            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex, e.ToString(),
                    ((Control) sender).Name,
                    this.FindForm().Name);
            }


        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgBusqueda.CurrentRow;
               
                switch (_Tabla)
                {
                    case "CALB":
                        long idCalle = Convert.ToInt64(row.Cells[0].Value);
                        frmCallesCrud oFrmCalCrud = new frmCallesCrud(idCalle, "NQ");
                        oFrmCalCrud.gbDatos.Enabled = false;
                        if (oFrmCalCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                    case "SRUT":
                        long idRuta = Convert.ToInt64(row.Cells[0].Value);
                        frmRutasCrud oFrmRutCrud = new frmRutasCrud(idRuta, "H");
                        oFrmRutCrud.gbDatos .Enabled = false;
                        if (oFrmRutCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                    case "TCS":
                        string idTCS = row.Cells[0].Value.ToString();
                        frmTiposConexionesCrud oFrmTCSCrud = new frmTiposConexionesCrud(idTCS, "H");
                        oFrmTCSCrud.gbDatos .Enabled = false;
                        if (oFrmTCSCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                    case "COPB":
                        int idCodPostal = Convert.ToInt32(row.Cells[0].Value);
                        frmCodigoPostalCrud oFrmCodPostalCrud = new frmCodigoPostalCrud(idCodPostal, "NQ");
                        oFrmCodPostalCrud.gbDatos.Enabled = false;
                        if (oFrmCodPostalCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;

                    case "SCAT":
                        long id = Convert.ToInt64(row.Cells[0].Value);
                        frmCategoriasCrud oFrmCatCrud = new frmCategoriasCrud(id, "V");
                        if (oFrmCatCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_Tabla);
                        break;
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                _oUtil.ExportarDataGridViewExcel(this.dgBusqueda);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _oFormAdmin.CargarGrilla(_Tabla);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
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


    }
}
