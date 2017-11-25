using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Model;
using Controles;
namespace FormsAuxiliares
{
    public partial class frmFormAdmin :gesForm
    {
        private Controles.contenedores.gpbGrupo gpbFiltro;
        private txtFiltro txtFiltro;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.labels.lblEtiqueta lblFiltro;
        private Controles.contenedores.gpbGrupo gpbFecha;
        private Controles.contenedores.gpbGrupo gpbGrupo3;
        private Controles.contenedores.gpbGrupo gpbGrupo4;
        private Controles.labels.lblEtiqueta lblCantidad;
        private Controles.labels.lblEtiqueta lblEFechaHasta;
        private Controles.labels.lblEtiqueta lblEFechaDesde;
        private Controles.Fecha.dtpFecha dtpFechaHasta;
        private Controles.Fecha.dtpFecha dtpFechaDesde;
        private Controles.buttons.btnNuevo btnNuevo;
        private Controles.buttons.btnSalir btnSalir;
        private Controles.buttons.btnExportar btnExportar;
        private Controles.buttons.btnImprimir btnImprimir;
        private Controles.buttons.btnVer btnVer;
        private Controles.buttons.btnEditar btnEditar;
        private Controles.contenedores.gpbGrupo gpbGrupoEstado;
        public System.Windows.Forms.ComboBox cmbEstado;
        private Controles.labels.lblEtiqueta lblEEstado;
        private Controles.buttons.btnEliminar btnEliminar1;
        private Controles.datos.gesGrid dgBusqueda;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormAdmin));
            this.gpbFiltro = new Controles.contenedores.gpbGrupo();
            this.txtFiltro = new Controles.txtFiltro();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.lblFiltro = new Controles.labels.lblEtiqueta();
            this.gpbFecha = new Controles.contenedores.gpbGrupo();
            this.lblEFechaHasta = new Controles.labels.lblEtiqueta();
            this.lblEFechaDesde = new Controles.labels.lblEtiqueta();
            this.dtpFechaHasta = new Controles.Fecha.dtpFecha();
            this.dtpFechaDesde = new Controles.Fecha.dtpFecha();
            this.gpbGrupo3 = new Controles.contenedores.gpbGrupo();
            this.btnEliminar1 = new Controles.buttons.btnEliminar();
            this.btnSalir = new Controles.buttons.btnSalir();
            this.btnExportar = new Controles.buttons.btnExportar();
            this.btnImprimir = new Controles.buttons.btnImprimir();
            this.btnVer = new Controles.buttons.btnVer();
            this.btnEditar = new Controles.buttons.btnEditar();
            this.btnNuevo = new Controles.buttons.btnNuevo();
            this.gpbGrupo4 = new Controles.contenedores.gpbGrupo();
            this.lblCantidad = new Controles.labels.lblEtiqueta();
            this.dgBusqueda = new Controles.datos.gesGrid();
            this.gpbGrupoEstado = new Controles.contenedores.gpbGrupo();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEEstado = new Controles.labels.lblEtiqueta();
            this.gpbFiltro.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.gpbGrupo3.SuspendLayout();
            this.gpbGrupo4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).BeginInit();
            this.gpbGrupoEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.txtFiltro);
            this.gpbFiltro.Controls.Add(this.cmbBuscar);
            this.gpbFiltro.Controls.Add(this.lblEtiqueta2);
            this.gpbFiltro.Controls.Add(this.lblFiltro);
            this.gpbFiltro.Location = new System.Drawing.Point(12, 1);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(381, 101);
            this.gpbFiltro.TabIndex = 0;
            this.gpbFiltro.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtFiltro.Location = new System.Drawing.Point(86, 58);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(289, 20);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextoVacio = "<Descripcion>";
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(86, 14);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(289, 21);
            this.cmbBuscar.TabIndex = 2;
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(6, 64);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(45, 13);
            this.lblEtiqueta2.TabIndex = 1;
            this.lblEtiqueta2.Text = "FILTRO";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(6, 22);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(78, 13);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "FILTRAR POR";
            // 
            // gpbFecha
            // 
            this.gpbFecha.Controls.Add(this.lblEFechaHasta);
            this.gpbFecha.Controls.Add(this.lblEFechaDesde);
            this.gpbFecha.Controls.Add(this.dtpFechaHasta);
            this.gpbFecha.Controls.Add(this.dtpFechaDesde);
            this.gpbFecha.Enabled = false;
            this.gpbFecha.Location = new System.Drawing.Point(399, 1);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Size = new System.Drawing.Size(200, 103);
            this.gpbFecha.TabIndex = 1;
            this.gpbFecha.TabStop = false;
            // 
            // lblEFechaHasta
            // 
            this.lblEFechaHasta.AutoSize = true;
            this.lblEFechaHasta.Location = new System.Drawing.Point(4, 65);
            this.lblEFechaHasta.Name = "lblEFechaHasta";
            this.lblEFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.lblEFechaHasta.TabIndex = 11;
            this.lblEFechaHasta.Text = "Fecha Hasta";
            // 
            // lblEFechaDesde
            // 
            this.lblEFechaDesde.AutoSize = true;
            this.lblEFechaDesde.Location = new System.Drawing.Point(4, 23);
            this.lblEFechaDesde.Name = "lblEFechaDesde";
            this.lblEFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblEFechaDesde.TabIndex = 10;
            this.lblEFechaDesde.Text = "Fecha Desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(81, 58);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaHasta.TabIndex = 9;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(81, 17);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaDesde.TabIndex = 8;
            // 
            // gpbGrupo3
            // 
            this.gpbGrupo3.Controls.Add(this.btnEliminar1);
            this.gpbGrupo3.Controls.Add(this.btnSalir);
            this.gpbGrupo3.Controls.Add(this.btnExportar);
            this.gpbGrupo3.Controls.Add(this.btnImprimir);
            this.gpbGrupo3.Controls.Add(this.btnVer);
            this.gpbGrupo3.Controls.Add(this.btnEditar);
            this.gpbGrupo3.Controls.Add(this.btnNuevo);
            this.gpbGrupo3.Location = new System.Drawing.Point(605, 1);
            this.gpbGrupo3.Name = "gpbGrupo3";
            this.gpbGrupo3.Size = new System.Drawing.Size(332, 53);
            this.gpbGrupo3.TabIndex = 1;
            this.gpbGrupo3.TabStop = false;
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar1.BackgroundImage")));
            this.btnEliminar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar1.Location = new System.Drawing.Point(98, 9);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar1.TabIndex = 7;
            this.btnEliminar1.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(282, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.Location = new System.Drawing.Point(190, 8);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(40, 40);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Location = new System.Drawing.Point(236, 8);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(40, 40);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVer.BackgroundImage")));
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVer.Location = new System.Drawing.Point(144, 8);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(40, 40);
            this.btnVer.TabIndex = 2;
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(52, 9);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(40, 40);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(6, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gpbGrupo4
            // 
            this.gpbGrupo4.Controls.Add(this.lblCantidad);
            this.gpbGrupo4.Controls.Add(this.dgBusqueda);
            this.gpbGrupo4.Location = new System.Drawing.Point(12, 110);
            this.gpbGrupo4.Name = "gpbGrupo4";
            this.gpbGrupo4.Size = new System.Drawing.Size(925, 351);
            this.gpbGrupo4.TabIndex = 1;
            this.gpbGrupo4.TabStop = false;
            this.gpbGrupo4.Text = "Datos";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(7, 333);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dgBusqueda
            // 
            this.dgBusqueda.DataMember = "";
            this.dgBusqueda.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgBusqueda.Location = new System.Drawing.Point(6, 19);
            this.dgBusqueda.Name = "dgBusqueda";
            this.dgBusqueda.Size = new System.Drawing.Size(913, 312);
            this.dgBusqueda.TabIndex = 0;
            // 
            // gpbGrupoEstado
            // 
            this.gpbGrupoEstado.Controls.Add(this.cmbEstado);
            this.gpbGrupoEstado.Controls.Add(this.lblEEstado);
            this.gpbGrupoEstado.Enabled = false;
            this.gpbGrupoEstado.Location = new System.Drawing.Point(605, 56);
            this.gpbGrupoEstado.Name = "gpbGrupoEstado";
            this.gpbGrupoEstado.Size = new System.Drawing.Size(332, 46);
            this.gpbGrupoEstado.TabIndex = 8;
            this.gpbGrupoEstado.TabStop = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(55, 13);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(188, 21);
            this.cmbEstado.TabIndex = 8;
            // 
            // lblEEstado
            // 
            this.lblEEstado.AutoSize = true;
            this.lblEEstado.Location = new System.Drawing.Point(6, 16);
            this.lblEEstado.Name = "lblEEstado";
            this.lblEEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEEstado.TabIndex = 8;
            this.lblEEstado.Text = "Estado";
            // 
            // frmFormAdmin
            // 
            this.ClientSize = new System.Drawing.Size(949, 487);
            this.Controls.Add(this.gpbGrupoEstado);
            this.Controls.Add(this.gpbGrupo4);
            this.Controls.Add(this.gpbGrupo3);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.gpbFiltro);
            this.Name = "frmFormAdmin";
            this.Load += new System.EventHandler(this.frmFormAdmin_Load);
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.gpbGrupo3.ResumeLayout(false);
            this.gpbGrupo4.ResumeLayout(false);
            this.gpbGrupo4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).EndInit();
            this.gpbGrupoEstado.ResumeLayout(false);
            this.gpbGrupoEstado.PerformLayout();
            this.ResumeLayout(false);

        }




        #region << PROPIEDADES >>
        private string _Tabla;
        private string _Campo;
        private string _filtroCampos;
        private string _filtroValores;
        private DataTable _dtCombo;
        private string _Fecha;
        #endregion

        #region << EVENTOS >>


        public frmFormAdmin(string tabla)
        {
            _Tabla = tabla;
            InitializeComponent();
        }
        private void frmFormAdmin_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABM  ofrm = new frmABM(_Tabla);
            ofrm.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
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
                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl != "FECHA") && oDetalle.DctTipoControl != "ESTADO")
                {
                    _dtCombo.Rows.Add(oDetalle.DctColumna, oDetalle.DctDescripcion);
                }

                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "FECHA"))
                {
                    this.gpbFecha.Enabled = true;
                    this.dtpFechaDesde.Value = DateTime.Now.Date.AddMonths(-1);
                    this.dtpFechaHasta.Value = DateTime.Now.Date;
                    _filtroCampos = _filtroCampos + oDetalle.DctColumna + "&";
                    _Fecha = oDetalle.DctColumna + "&";
                    _filtroValores = _filtroValores + this.dtpFechaDesde.Text + "%" + this.dtpFechaHasta.Text + "&";
                }
                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "ESTADO"))
                {
                    this.gpbGrupoEstado.Enabled = true;
                    _filtroCampos = _filtroCampos + oDetalle.DctColumna + "&";
                    _filtroValores = _filtroValores + this.cmbEstado.Text + "&";
                }
            }

            this.cmbBuscar.DataSource = _dtCombo;
            this.cmbBuscar.ValueMember = "DctColumna";
            this.cmbBuscar.DisplayMember = "DctDescripcion";
            if (_Campo.Length > 0)

                _Campo = _Campo.Substring(0, _Campo.Length - 1);
            TablasBus oTablasBus = new TablasBus();
            this.dgBusqueda.DataSource = oTablasBus.TablasBusquedaGetAllFilter(_Tabla, _Campo, _filtroCampos, _filtroValores);
            this.lblCantidad.Text = "Se encontraron " + this.dgBusqueda.VisibleRowCount.ToString() + " registros";


        }

        private void CargarGrilla()
        {
            _filtroCampos = "";
            _filtroValores = "";

            if (this.gpbFecha.Enabled)
            {
                _filtroValores = this.dtpFechaDesde.Text + "%" + this.dtpFechaHasta.Text + "&";
                _filtroCampos = _Fecha;
            }
            if (this.gpbGrupoEstado.Enabled)
                _filtroValores = this.cmbEstado.Text + "&";

            _filtroCampos = _filtroCampos + this.cmbBuscar.SelectedValue.ToString() + "&";
            _filtroValores = _filtroValores + this.txtFiltro.Text + "&";

            TablasBus oTablasBus = new TablasBus();
            this.dgBusqueda.DataSource = oTablasBus.TablasBusquedaGetAllFilter(_Tabla, _Campo, _filtroCampos, _filtroValores);
            this.lblCantidad.Text = "Se encontraron " + this.dgBusqueda.VisibleRowCount.ToString() + " registros";

        }


        #endregion

    }
}
