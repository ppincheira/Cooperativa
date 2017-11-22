using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.forms
{
    public partial class frmObservaciones:gesForm
    {
        private contenedores.gpbGrupo gpbGrupo2;
        private contenedores.gpbGrupo gpbGrupo3;
        private contenedores.gpbGrupo gpbGrupo4;
        private buttons.btnNuevo btnNuevo1;
        private buttons.btnEditar btnEditar1;
        private buttons.btnSalir btnSalir1;
        private buttons.btnEliminar btnEliminar1;
        private buttons.btnExportar btnExportar1;
        private buttons.btnVer btnVer1;
        private buttons.btnImprimir btnImprimir1;
        private datos.grdGrillaAdmin grdGrillaAdmin1;
        private labels.lblEtiqueta lblEtiqueta1;
        private labels.lblEtiqueta lblEtiqueta2;
        private txtFiltro txtFiltro1;
        private datos.cmbLista cmbLista1;
        private labels.lblEtiqueta lblEtiqueta3;
        private contenedores.gpbGrupo gpbGrupo1;

        public frmObservaciones() {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObservaciones));
            this.gpbGrupo1 = new Controles.contenedores.gpbGrupo();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.grdGrillaAdmin1 = new Controles.datos.grdGrillaAdmin();
            this.gpbGrupo2 = new Controles.contenedores.gpbGrupo();
            this.gpbGrupo3 = new Controles.contenedores.gpbGrupo();
            this.lblEtiqueta3 = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.txtFiltro1 = new Controles.txtFiltro();
            this.cmbLista1 = new Controles.datos.cmbLista();
            this.gpbGrupo4 = new Controles.contenedores.gpbGrupo();
            this.btnImprimir1 = new Controles.buttons.btnImprimir();
            this.btnVer1 = new Controles.buttons.btnVer();
            this.btnExportar1 = new Controles.buttons.btnExportar();
            this.btnEliminar1 = new Controles.buttons.btnEliminar();
            this.btnSalir1 = new Controles.buttons.btnSalir();
            this.btnEditar1 = new Controles.buttons.btnEditar();
            this.btnNuevo1 = new Controles.buttons.btnNuevo();
            this.gpbGrupo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaAdmin1)).BeginInit();
            this.gpbGrupo3.SuspendLayout();
            this.gpbGrupo4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbGrupo1
            // 
            this.gpbGrupo1.Controls.Add(this.lblEtiqueta1);
            this.gpbGrupo1.Controls.Add(this.grdGrillaAdmin1);
            this.gpbGrupo1.Location = new System.Drawing.Point(12, 87);
            this.gpbGrupo1.Name = "gpbGrupo1";
            this.gpbGrupo1.Size = new System.Drawing.Size(643, 235);
            this.gpbGrupo1.TabIndex = 0;
            this.gpbGrupo1.TabStop = false;
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(7, 218);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(62, 13);
            this.lblEtiqueta1.TabIndex = 1;
            this.lblEtiqueta1.Text = "Cantidad";
            // 
            // grdGrillaAdmin1
            // 
            this.grdGrillaAdmin1.DataMember = "";
            this.grdGrillaAdmin1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grdGrillaAdmin1.Location = new System.Drawing.Point(6, 19);
            this.grdGrillaAdmin1.Name = "grdGrillaAdmin1";
            this.grdGrillaAdmin1.Size = new System.Drawing.Size(631, 197);
            this.grdGrillaAdmin1.TabIndex = 0;
            // 
            // gpbGrupo2
            // 
            this.gpbGrupo2.Location = new System.Drawing.Point(12, 328);
            this.gpbGrupo2.Name = "gpbGrupo2";
            this.gpbGrupo2.Size = new System.Drawing.Size(643, 141);
            this.gpbGrupo2.TabIndex = 1;
            this.gpbGrupo2.TabStop = false;
            // 
            // gpbGrupo3
            // 
            this.gpbGrupo3.Controls.Add(this.lblEtiqueta3);
            this.gpbGrupo3.Controls.Add(this.lblEtiqueta2);
            this.gpbGrupo3.Controls.Add(this.txtFiltro1);
            this.gpbGrupo3.Controls.Add(this.cmbLista1);
            this.gpbGrupo3.Location = new System.Drawing.Point(12, 3);
            this.gpbGrupo3.Name = "gpbGrupo3";
            this.gpbGrupo3.Size = new System.Drawing.Size(301, 78);
            this.gpbGrupo3.TabIndex = 1;
            this.gpbGrupo3.TabStop = false;
            // 
            // lblEtiqueta3
            // 
            this.lblEtiqueta3.AutoSize = true;
            this.lblEtiqueta3.Location = new System.Drawing.Point(28, 50);
            this.lblEtiqueta3.Name = "lblEtiqueta3";
            this.lblEtiqueta3.Size = new System.Drawing.Size(45, 13);
            this.lblEtiqueta3.TabIndex = 3;
            this.lblEtiqueta3.Text = "FILTRO";
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(27, 26);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(78, 13);
            this.lblEtiqueta2.TabIndex = 2;
            this.lblEtiqueta2.Text = "FILTRAR POR";
            // 
            // txtFiltro1
            // 
            this.txtFiltro1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro1.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtFiltro1.Location = new System.Drawing.Point(120, 47);
            this.txtFiltro1.Name = "txtFiltro1";
            this.txtFiltro1.Size = new System.Drawing.Size(175, 20);
            this.txtFiltro1.TabIndex = 1;
            this.txtFiltro1.TextoVacio = "<Descripcion>";
            // 
            // cmbLista1
            // 
            this.cmbLista1.FormattingEnabled = true;
            this.cmbLista1.Location = new System.Drawing.Point(120, 19);
            this.cmbLista1.Name = "cmbLista1";
            this.cmbLista1.Size = new System.Drawing.Size(175, 21);
            this.cmbLista1.TabIndex = 0;
            // 
            // gpbGrupo4
            // 
            this.gpbGrupo4.Controls.Add(this.btnImprimir1);
            this.gpbGrupo4.Controls.Add(this.btnVer1);
            this.gpbGrupo4.Controls.Add(this.btnExportar1);
            this.gpbGrupo4.Controls.Add(this.btnEliminar1);
            this.gpbGrupo4.Controls.Add(this.btnSalir1);
            this.gpbGrupo4.Controls.Add(this.btnEditar1);
            this.gpbGrupo4.Controls.Add(this.btnNuevo1);
            this.gpbGrupo4.Location = new System.Drawing.Point(319, 3);
            this.gpbGrupo4.Name = "gpbGrupo4";
            this.gpbGrupo4.Size = new System.Drawing.Size(336, 78);
            this.gpbGrupo4.TabIndex = 2;
            this.gpbGrupo4.TabStop = false;
            // 
            // btnImprimir1
            // 
            this.btnImprimir1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir1.BackgroundImage")));
            this.btnImprimir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir1.Location = new System.Drawing.Point(237, 19);
            this.btnImprimir1.Name = "btnImprimir1";
            this.btnImprimir1.Size = new System.Drawing.Size(40, 40);
            this.btnImprimir1.TabIndex = 6;
            this.btnImprimir1.UseVisualStyleBackColor = true;
            // 
            // btnVer1
            // 
            this.btnVer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVer1.BackgroundImage")));
            this.btnVer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVer1.Location = new System.Drawing.Point(145, 20);
            this.btnVer1.Name = "btnVer1";
            this.btnVer1.Size = new System.Drawing.Size(40, 40);
            this.btnVer1.TabIndex = 5;
            this.btnVer1.UseVisualStyleBackColor = true;
            // 
            // btnExportar1
            // 
            this.btnExportar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar1.BackgroundImage")));
            this.btnExportar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar1.Location = new System.Drawing.Point(191, 20);
            this.btnExportar1.Name = "btnExportar1";
            this.btnExportar1.Size = new System.Drawing.Size(40, 40);
            this.btnExportar1.TabIndex = 4;
            this.btnExportar1.UseVisualStyleBackColor = true;
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar1.BackgroundImage")));
            this.btnEliminar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar1.Location = new System.Drawing.Point(99, 20);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar1.TabIndex = 3;
            this.btnEliminar1.UseVisualStyleBackColor = true;
            // 
            // btnSalir1
            // 
            this.btnSalir1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir1.BackgroundImage")));
            this.btnSalir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir1.Location = new System.Drawing.Point(283, 19);
            this.btnSalir1.Name = "btnSalir1";
            this.btnSalir1.Size = new System.Drawing.Size(40, 40);
            this.btnSalir1.TabIndex = 2;
            this.btnSalir1.UseVisualStyleBackColor = true;
            // 
            // btnEditar1
            // 
            this.btnEditar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar1.BackgroundImage")));
            this.btnEditar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar1.Location = new System.Drawing.Point(53, 20);
            this.btnEditar1.Name = "btnEditar1";
            this.btnEditar1.Size = new System.Drawing.Size(40, 40);
            this.btnEditar1.TabIndex = 1;
            this.btnEditar1.UseVisualStyleBackColor = true;
            // 
            // btnNuevo1
            // 
            this.btnNuevo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo1.BackgroundImage")));
            this.btnNuevo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo1.Location = new System.Drawing.Point(6, 19);
            this.btnNuevo1.Name = "btnNuevo1";
            this.btnNuevo1.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo1.TabIndex = 0;
            this.btnNuevo1.UseVisualStyleBackColor = true;
            // 
            // frmObservaciones
            // 
            this.ClientSize = new System.Drawing.Size(667, 481);
            this.Controls.Add(this.gpbGrupo4);
            this.Controls.Add(this.gpbGrupo3);
            this.Controls.Add(this.gpbGrupo2);
            this.Controls.Add(this.gpbGrupo1);
            this.Name = "frmObservaciones";
            this.gpbGrupo1.ResumeLayout(false);
            this.gpbGrupo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaAdmin1)).EndInit();
            this.gpbGrupo3.ResumeLayout(false);
            this.gpbGrupo3.PerformLayout();
            this.gpbGrupo4.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
