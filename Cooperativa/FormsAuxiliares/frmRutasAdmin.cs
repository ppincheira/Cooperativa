using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AppProcesos.formsAuxiliares.frmRutas;
using Controles.datos;
using Controles.form;
using System.Windows.Forms;
using Service;

namespace FormsAuxiliares
{
    public partial class frmRutasAdmin : frmFormAdminMini
        //gesForm//, IVistaRutas
    {
        #region << PROPIEDADES >>
        //private UIRutas _oUIRutas;
        string _tabCodigo;
        int _tobCodigo;
        string _obsCodigoRegistro;
        private Utility _oUtility;

        #endregion

        private Controles.contenedores.gpbGrupo gpbGrupo2;
        private Controles.contenedores.gpbGrupo gpbGrupo3;
        private Controles.contenedores.gpbGrupo gpbGrupo4;
        private Controles.buttons.btnNuevo btnNuevo;
        private Controles.buttons.btnEditar btnEditar;
        private Controles.buttons.btnSalir btnSalir;
        private Controles.buttons.btnEliminar btnEliminar;
        private Controles.buttons.btnExportar btnExportar;
        private Controles.buttons.btnVer btnVer;
        private Controles.buttons.btnImprimir btnImprimir;
        private Controles.datos.grdGrillaAdmin grdGrillaAdmin;
        private Controles.labels.lblEtiqueta lblCantidad;
        //private Controles.textBoxes.txtRutas txtRutas;
        private Controles.labels.lblEtiqueta lblEFechaHasta;
        private Controles.labels.lblEtiqueta lblEFechaDesde;
        private Controles.Fecha.dtpFecha dtpFechaHasta;
        private Controles.Fecha.dtpFecha dtpFechaDesde;
        private Controles.contenedores.gpbGrupo gpbGrupo1;

        #region Implementation of IVistaRutas

        public string tabCodigo
        {
            get { return this._tabCodigo; }
            set { this._tabCodigo = value; }
        }

        public int tobCodigo
        {
            get { return this._tobCodigo; }
            set { this._tobCodigo = value; }
        }

        public string obsCodigoRegistro
        {
            get { return _obsCodigoRegistro; }
            set { _obsCodigoRegistro = value; }
        }
        public grdGrillaAdmin grilla
        {
            get { return this.grdGrillaAdmin; }
            set { this.grdGrillaAdmin = value; }
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
        public string cantidad
        {
            set { this.lblCantidad.Text = value; }
        }
        public string detalle
        {
            set { this.txtRutas.Text = value; }
        }
        #endregion

        public frmRutasAdmin(string tabCodigo, int tobCodigo, string obsCodigoRegistro)
        {
            InitializeComponent();
            //_oUIRutas = new UIRutas(this);
            _tabCodigo = tabCodigo;
            _tobCodigo = tobCodigo;
            _obsCodigoRegistro = obsCodigoRegistro;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRutasAdmin));
            this.gpbGrupo1 = new Controles.contenedores.gpbGrupo();
            this.lblCantidad = new Controles.labels.lblEtiqueta();
            this.grdGrillaAdmin = new Controles.datos.grdGrillaAdmin();
            this.gpbGrupo2 = new Controles.contenedores.gpbGrupo();
            this.txtRutas = new Controles.textBoxes.txtRutas();
            this.gpbGrupo3 = new Controles.contenedores.gpbGrupo();
            this.lblEFechaHasta = new Controles.labels.lblEtiqueta();
            this.lblEFechaDesde = new Controles.labels.lblEtiqueta();
            this.dtpFechaHasta = new Controles.Fecha.dtpFecha();
            this.dtpFechaDesde = new Controles.Fecha.dtpFecha();
            this.gpbGrupo4 = new Controles.contenedores.gpbGrupo();
            this.btnImprimir = new Controles.buttons.btnImprimir();
            this.btnVer = new Controles.buttons.btnVer();
            this.btnExportar = new Controles.buttons.btnExportar();
            this.btnEliminar = new Controles.buttons.btnEliminar();
            this.btnSalir = new Controles.buttons.btnSalir();
            this.btnEditar = new Controles.buttons.btnEditar();
            this.btnNuevo = new Controles.buttons.btnNuevo();
            this.gpbGrupo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaAdmin)).BeginInit();
            this.gpbGrupo2.SuspendLayout();
            this.gpbGrupo3.SuspendLayout();
            this.gpbGrupo4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbGrupo1
            // 
            this.gpbGrupo1.Controls.Add(this.lblCantidad);
            this.gpbGrupo1.Controls.Add(this.grdGrillaAdmin);
            this.gpbGrupo1.Location = new System.Drawing.Point(12, 87);
            this.gpbGrupo1.Name = "gpbGrupo1";
            this.gpbGrupo1.Size = new System.Drawing.Size(643, 235);
            this.gpbGrupo1.TabIndex = 0;
            this.gpbGrupo1.TabStop = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(7, 218);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // grdGrillaAdmin
            // 
            this.grdGrillaAdmin.AllowUserToAddRows = false;
            this.grdGrillaAdmin.Location = new System.Drawing.Point(6, 19);
            this.grdGrillaAdmin.Name = "grdGrillaAdmin";
            this.grdGrillaAdmin.Size = new System.Drawing.Size(631, 197);
            this.grdGrillaAdmin.TabIndex = 0;
            this.grdGrillaAdmin.SelectionChanged += new System.EventHandler(this.grdGrillaAdmin_SelectionChanged);
            // 
            // gpbGrupo2
            // 
            this.gpbGrupo2.Controls.Add(this.txtRutas);
            this.gpbGrupo2.Location = new System.Drawing.Point(12, 328);
            this.gpbGrupo2.Name = "gpbGrupo2";
            this.gpbGrupo2.Size = new System.Drawing.Size(643, 141);
            this.gpbGrupo2.TabIndex = 1;
            this.gpbGrupo2.TabStop = false;
            this.gpbGrupo2.Text = "Detalle de la observacionseleccionada";
            // 
            // txtRutas
            // 
            this.txtRutas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRutas.Location = new System.Drawing.Point(10, 19);
            this.txtRutas.Multiline = true;
            this.txtRutas.Name = "txtRutas";
            this.txtRutas.Size = new System.Drawing.Size(627, 102);
            this.txtRutas.TabIndex = 0;
            // 
            // gpbGrupo3
            // 
            this.gpbGrupo3.Controls.Add(this.lblEFechaHasta);
            this.gpbGrupo3.Controls.Add(this.lblEFechaDesde);
            this.gpbGrupo3.Controls.Add(this.dtpFechaHasta);
            this.gpbGrupo3.Controls.Add(this.dtpFechaDesde);
            this.gpbGrupo3.Location = new System.Drawing.Point(12, 3);
            this.gpbGrupo3.Name = "gpbGrupo3";
            this.gpbGrupo3.Size = new System.Drawing.Size(301, 78);
            this.gpbGrupo3.TabIndex = 1;
            this.gpbGrupo3.TabStop = false;
            // 
            // lblEFechaHasta
            // 
            this.lblEFechaHasta.AutoSize = true;
            this.lblEFechaHasta.Location = new System.Drawing.Point(10, 50);
            this.lblEFechaHasta.Name = "lblEFechaHasta";
            this.lblEFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.lblEFechaHasta.TabIndex = 15;
            this.lblEFechaHasta.Text = "Fecha Hasta";
            // 
            // lblEFechaDesde
            // 
            this.lblEFechaDesde.AutoSize = true;
            this.lblEFechaDesde.Location = new System.Drawing.Point(7, 19);
            this.lblEFechaDesde.Name = "lblEFechaDesde";
            this.lblEFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblEFechaDesde.TabIndex = 14;
            this.lblEFechaDesde.Text = "Fecha Desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(105, 44);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(109, 20);
            this.dtpFechaHasta.TabIndex = 13;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(105, 12);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(109, 20);
            this.dtpFechaDesde.TabIndex = 12;
            // 
            // gpbGrupo4
            // 
            this.gpbGrupo4.Controls.Add(this.btnImprimir);
            this.gpbGrupo4.Controls.Add(this.btnVer);
            this.gpbGrupo4.Controls.Add(this.btnExportar);
            this.gpbGrupo4.Controls.Add(this.btnEliminar);
            this.gpbGrupo4.Controls.Add(this.btnSalir);
            this.gpbGrupo4.Controls.Add(this.btnEditar);
            this.gpbGrupo4.Controls.Add(this.btnNuevo);
            this.gpbGrupo4.Location = new System.Drawing.Point(319, 3);
            this.gpbGrupo4.Name = "gpbGrupo4";
            this.gpbGrupo4.Size = new System.Drawing.Size(336, 78);
            this.gpbGrupo4.TabIndex = 2;
            this.gpbGrupo4.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Location = new System.Drawing.Point(237, 19);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(40, 40);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVer.BackgroundImage")));
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVer.Location = new System.Drawing.Point(145, 20);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(40, 40);
            this.btnVer.TabIndex = 5;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.Location = new System.Drawing.Point(191, 20);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(40, 40);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(99, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(283, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(53, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(40, 40);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(6, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmRutasAdmin
            // 
            this.ClientSize = new System.Drawing.Size(667, 481);
            this.Controls.Add(this.gpbGrupo4);
            this.Controls.Add(this.gpbGrupo3);
            this.Controls.Add(this.gpbGrupo2);
            this.Controls.Add(this.gpbGrupo1);
            this.Name = "frmRutasAdmin";
            this.Text = "[OBSERVACIONES]";
            this.Load += new System.EventHandler(this.frmRutasAdmin_Load);
            this.gpbGrupo1.ResumeLayout(false);
            this.gpbGrupo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaAdmin)).EndInit();
            this.gpbGrupo2.ResumeLayout(false);
            this.gpbGrupo2.PerformLayout();
            this.gpbGrupo3.ResumeLayout(false);
            this.gpbGrupo3.PerformLayout();
            this.gpbGrupo4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void frmRutasAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                _oUIRutas.Inicializar();
                _oUtility = new Utility();
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
                frmRutasCrud ofrmObs = new frmRutasCrud(0, _tobCodigo, _obsCodigoRegistro, "I");
                if (ofrmObs.ShowDialog() == DialogResult.OK)
                    _oUIRutas.CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.grdGrillaAdmin.CurrentRow;
                long id = Convert.ToInt64(row.Cells[0].Value);
                frmRutasCrud ofrmObs = new frmRutasCrud(id, _tobCodigo, _obsCodigoRegistro, "E");
                if (ofrmObs.ShowDialog() == DialogResult.OK)
                    _oUIRutas.CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                _oUtility.ExportarDataGridViewExcel(this.grdGrillaAdmin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.grdGrillaAdmin.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                frmRutasCrud ofrmObs = new frmRutasCrud(id, _tobCodigo, _obsCodigoRegistro, "V");

                ofrmObs.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        private void grdGrillaAdmin_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                _oUIRutas.CargarDetalle(this.grdGrillaAdmin.CurrentRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }
    }
}
