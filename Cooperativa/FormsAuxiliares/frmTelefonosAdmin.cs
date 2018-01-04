using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controles.form;
namespace FormsAuxiliares
{
    public partial class frmTelefonosAdmin: gesForm
    {
        private Controles.contenedores.gpbGrupo gpbGrupo4;
        private Controles.buttons.btnImprimir btnImprimir;
        private Controles.buttons.btnVer btnVer;
        private Controles.buttons.btnExportar btnExportar;
        private Controles.buttons.btnEliminar btnEliminar;
        private Controles.buttons.btnSalir btnSalir;
        private Controles.buttons.btnEditar btnEditar;
        private Controles.buttons.btnNuevo btnNuevo;
        private Controles.contenedores.gpbGrupo gpbGrupo1;
        private Controles.labels.lblEtiqueta lblCantidad;
        private Controles.datos.grdGrillaAdmin grdGrillaAdmin;

        public frmTelefonosAdmin() {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelefonosAdmin));
            this.gpbGrupo4 = new Controles.contenedores.gpbGrupo();
            this.btnImprimir = new Controles.buttons.btnImprimir();
            this.btnVer = new Controles.buttons.btnVer();
            this.btnExportar = new Controles.buttons.btnExportar();
            this.btnEliminar = new Controles.buttons.btnEliminar();
            this.btnSalir = new Controles.buttons.btnSalir();
            this.btnEditar = new Controles.buttons.btnEditar();
            this.btnNuevo = new Controles.buttons.btnNuevo();
            this.gpbGrupo1 = new Controles.contenedores.gpbGrupo();
            this.lblCantidad = new Controles.labels.lblEtiqueta();
            this.grdGrillaAdmin = new Controles.datos.grdGrillaAdmin();
            this.gpbGrupo4.SuspendLayout();
            this.gpbGrupo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaAdmin)).BeginInit();
            this.SuspendLayout();
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
            this.gpbGrupo4.Location = new System.Drawing.Point(319, 9);
            this.gpbGrupo4.Name = "gpbGrupo4";
            this.gpbGrupo4.Size = new System.Drawing.Size(336, 78);
            this.gpbGrupo4.TabIndex = 4;
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
            // gpbGrupo1
            // 
            this.gpbGrupo1.Controls.Add(this.lblCantidad);
            this.gpbGrupo1.Controls.Add(this.grdGrillaAdmin);
            this.gpbGrupo1.Location = new System.Drawing.Point(12, 93);
            this.gpbGrupo1.Name = "gpbGrupo1";
            this.gpbGrupo1.Size = new System.Drawing.Size(643, 328);
            this.gpbGrupo1.TabIndex = 3;
            this.gpbGrupo1.TabStop = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(3, 312);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // grdGrillaAdmin
            // 
            this.grdGrillaAdmin.AllowUserToAddRows = false;
            this.grdGrillaAdmin.Location = new System.Drawing.Point(6, 19);
            this.grdGrillaAdmin.Name = "grdGrillaAdmin";
            this.grdGrillaAdmin.Size = new System.Drawing.Size(631, 290);
            this.grdGrillaAdmin.TabIndex = 0;
            // 
            // frmTelefonosAdmin
            // 
            this.ClientSize = new System.Drawing.Size(668, 433);
            this.Controls.Add(this.gpbGrupo4);
            this.Controls.Add(this.gpbGrupo1);
            this.Name = "frmTelefonosAdmin";
            this.gpbGrupo4.ResumeLayout(false);
            this.gpbGrupo1.ResumeLayout(false);
            this.gpbGrupo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
