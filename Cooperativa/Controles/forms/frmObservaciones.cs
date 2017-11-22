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
        private contenedores.gpbGrupo gpbGrupo1;

        public frmObservaciones() {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObservaciones));
            this.gpbGrupo1 = new Controles.contenedores.gpbGrupo();
            this.gpbGrupo2 = new Controles.contenedores.gpbGrupo();
            this.gpbGrupo3 = new Controles.contenedores.gpbGrupo();
            this.gpbGrupo4 = new Controles.contenedores.gpbGrupo();
            this.btnSalir1 = new Controles.buttons.btnSalir();
            this.btnEditar1 = new Controles.buttons.btnEditar();
            this.btnNuevo1 = new Controles.buttons.btnNuevo();
            this.btnEliminar1 = new Controles.buttons.btnEliminar();
            this.gpbGrupo4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbGrupo1
            // 
            this.gpbGrupo1.Location = new System.Drawing.Point(12, 87);
            this.gpbGrupo1.Name = "gpbGrupo1";
            this.gpbGrupo1.Size = new System.Drawing.Size(643, 235);
            this.gpbGrupo1.TabIndex = 0;
            this.gpbGrupo1.TabStop = false;
            this.gpbGrupo1.Text = "[Filtros]";
            // 
            // gpbGrupo2
            // 
            this.gpbGrupo2.Location = new System.Drawing.Point(12, 328);
            this.gpbGrupo2.Name = "gpbGrupo2";
            this.gpbGrupo2.Size = new System.Drawing.Size(643, 141);
            this.gpbGrupo2.TabIndex = 1;
            this.gpbGrupo2.TabStop = false;
            this.gpbGrupo2.Text = "gpbGrupo2";
            // 
            // gpbGrupo3
            // 
            this.gpbGrupo3.Location = new System.Drawing.Point(12, 3);
            this.gpbGrupo3.Name = "gpbGrupo3";
            this.gpbGrupo3.Size = new System.Drawing.Size(378, 78);
            this.gpbGrupo3.TabIndex = 1;
            this.gpbGrupo3.TabStop = false;
            this.gpbGrupo3.Text = "gpbGrupo3";
            // 
            // gpbGrupo4
            // 
            this.gpbGrupo4.Controls.Add(this.btnEliminar1);
            this.gpbGrupo4.Controls.Add(this.btnSalir1);
            this.gpbGrupo4.Controls.Add(this.btnEditar1);
            this.gpbGrupo4.Controls.Add(this.btnNuevo1);
            this.gpbGrupo4.Location = new System.Drawing.Point(396, 3);
            this.gpbGrupo4.Name = "gpbGrupo4";
            this.gpbGrupo4.Size = new System.Drawing.Size(259, 78);
            this.gpbGrupo4.TabIndex = 2;
            this.gpbGrupo4.TabStop = false;
            this.gpbGrupo4.Text = "gpbGrupo4";
            // 
            // btnSalir1
            // 
            this.btnSalir1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir1.BackgroundImage")));
            this.btnSalir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir1.Location = new System.Drawing.Point(213, 20);
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
            // btnEliminar1
            // 
            this.btnEliminar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar1.BackgroundImage")));
            this.btnEliminar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar1.Location = new System.Drawing.Point(113, 15);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(50, 50);
            this.btnEliminar1.TabIndex = 3;
            this.btnEliminar1.Text = "btnEliminar1";
            this.btnEliminar1.UseVisualStyleBackColor = true;
            // 
            // frmObservaciones
            // 
            this.ClientSize = new System.Drawing.Size(667, 481);
            this.Controls.Add(this.gpbGrupo4);
            this.Controls.Add(this.gpbGrupo3);
            this.Controls.Add(this.gpbGrupo2);
            this.Controls.Add(this.gpbGrupo1);
            this.Name = "frmObservaciones";
            this.gpbGrupo4.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
