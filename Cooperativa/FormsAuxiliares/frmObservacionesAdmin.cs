using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProcesos.formsAuxiliares.frmObservaciones;
using Controles.datos;

namespace FormsAuxiliares
{
    public partial class frmObservacionesAdmin:gesForm, IVistaObservaciones
    {
        #region << PROPIEDADES >>
        private UIObservaciones _oUIObservaciones;
        string _tabCodigo;
        int _tobCodigo;
        string _obsCodigoRegistro;

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
        private Controles.textBoxes.txtObservaciones txtObservaciones;
        private Controles.labels.lblEtiqueta lblEFechaHasta;
        private Controles.labels.lblEtiqueta lblEFechaDesde;
        private Controles.Fecha.dtpFecha dtpFechaHasta;
        private Controles.Fecha.dtpFecha dtpFechaDesde;
        private Controles.contenedores.gpbGrupo gpbGrupo1;

        #region Implementation of IVistaObservaciones
        
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
            set { this.txtObservaciones.Text = value; }
        }
        #endregion

        public frmObservacionesAdmin(string tabCodigo, int tobCodigo, string obsCodigoRegistro) {
            InitializeComponent();
            _oUIObservaciones = new UIObservaciones(this);
            _tabCodigo = tabCodigo;
            _tobCodigo = tobCodigo;
            _obsCodigoRegistro = obsCodigoRegistro;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObservacionesAdmin));
            this.gpbGrupo1 = new Controles.contenedores.gpbGrupo();
            this.lblCantidad = new Controles.labels.lblEtiqueta();
            this.grdGrillaAdmin = new Controles.datos.grdGrillaAdmin();
            this.gpbGrupo2 = new Controles.contenedores.gpbGrupo();
            this.txtObservaciones = new Controles.textBoxes.txtObservaciones();
            this.gpbGrupo3 = new Controles.contenedores.gpbGrupo();
            this.gpbGrupo4 = new Controles.contenedores.gpbGrupo();
            this.btnImprimir = new Controles.buttons.btnImprimir();
            this.btnVer = new Controles.buttons.btnVer();
            this.btnExportar = new Controles.buttons.btnExportar();
            this.btnEliminar = new Controles.buttons.btnEliminar();
            this.btnSalir = new Controles.buttons.btnSalir();
            this.btnEditar = new Controles.buttons.btnEditar();
            this.btnNuevo = new Controles.buttons.btnNuevo();
            this.lblEFechaHasta = new Controles.labels.lblEtiqueta();
            this.lblEFechaDesde = new Controles.labels.lblEtiqueta();
            this.dtpFechaHasta = new Controles.Fecha.dtpFecha();
            this.dtpFechaDesde = new Controles.Fecha.dtpFecha();
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
            this.grdGrillaAdmin.DataMember = "";
           
            this.grdGrillaAdmin.Location = new System.Drawing.Point(6, 19);
            this.grdGrillaAdmin.Name = "grdGrillaAdmin";
            this.grdGrillaAdmin.Size = new System.Drawing.Size(631, 197);
            this.grdGrillaAdmin.TabIndex = 0;
            // 
            // gpbGrupo2
            // 
            this.gpbGrupo2.Controls.Add(this.txtObservaciones);
            this.gpbGrupo2.Location = new System.Drawing.Point(12, 328);
            this.gpbGrupo2.Name = "gpbGrupo2";
            this.gpbGrupo2.Size = new System.Drawing.Size(643, 141);
            this.gpbGrupo2.TabIndex = 1;
            this.gpbGrupo2.TabStop = false;
            this.gpbGrupo2.Text = "Detalle de la observacionseleccionada";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Location = new System.Drawing.Point(10, 19);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(627, 102);
            this.txtObservaciones.TabIndex = 0;
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
            // frmObservacionesAdmin
            // 
            this.ClientSize = new System.Drawing.Size(667, 481);
            this.Controls.Add(this.gpbGrupo4);
            this.Controls.Add(this.gpbGrupo3);
            this.Controls.Add(this.gpbGrupo2);
            this.Controls.Add(this.gpbGrupo1);
            this.Name = "frmObservacionesAdmin";
            this.Text = "[OBSERVACIONES]";
            this.Load += new System.EventHandler(this.frmObservacionesAdmin_Load);
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

        private void frmObservacionesAdmin_Load(object sender, EventArgs e)
        {
            _oUIObservaciones.Inicializar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmObservacionesCrud ofrmObs = new frmObservacionesCrud();
            ofrmObs.Show();
        }
    }
}
