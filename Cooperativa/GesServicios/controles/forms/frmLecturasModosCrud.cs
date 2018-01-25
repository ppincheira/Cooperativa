using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controles.datos;
using Controles.form;

namespace GesServicios.controles.forms
{
    class frmLecturasModosCrud:gesForm
    {
        private Controles.contenedores.gesGroup gesGroup1;
        private grdGrillaEdit grdGrillaEdit1;
        private Controles.contenedores.gesGroup gesGroup3;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        private Controles.contenedores.gesGroup gesGroup2;

        public frmLecturasModosCrud()
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLecturasModosCrud));
            this.gesGroup1 = new Controles.contenedores.gesGroup();
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.gesGroup3 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.grdGrillaEdit1 = new Controles.datos.grdGrillaEdit();
            this.gesGroup2.SuspendLayout();
            this.gesGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gesGroup1
            // 
            this.gesGroup1.Location = new System.Drawing.Point(12, 12);
            this.gesGroup1.Name = "gesGroup1";
            this.gesGroup1.Size = new System.Drawing.Size(577, 181);
            this.gesGroup1.TabIndex = 0;
            this.gesGroup1.TabStop = false;
            this.gesGroup1.Text = "gesGroup1";
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.grdGrillaEdit1);
            this.gesGroup2.Location = new System.Drawing.Point(12, 214);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(577, 184);
            this.gesGroup2.TabIndex = 1;
            this.gesGroup2.TabStop = false;
            this.gesGroup2.Text = "Conceptos asociados";
            // 
            // gesGroup3
            // 
            this.gesGroup3.Controls.Add(this.btnCancelar);
            this.gesGroup3.Controls.Add(this.btnAceptar);
            this.gesGroup3.Location = new System.Drawing.Point(397, 404);
            this.gesGroup3.Name = "gesGroup3";
            this.gesGroup3.Size = new System.Drawing.Size(192, 89);
            this.gesGroup3.TabIndex = 6;
            this.gesGroup3.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(6, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(101, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // grdGrillaEdit1
            // 
            this.grdGrillaEdit1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGrillaEdit1.Location = new System.Drawing.Point(6, 19);
            this.grdGrillaEdit1.Name = "grdGrillaEdit1";
            this.grdGrillaEdit1.Size = new System.Drawing.Size(560, 150);
            this.grdGrillaEdit1.TabIndex = 0;
            // 
            // frmLecturasModosCrud
            // 
            this.ClientSize = new System.Drawing.Size(615, 496);
            this.Controls.Add(this.gesGroup3);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gesGroup1);
            this.Name = "frmLecturasModosCrud";
            this.gesGroup2.ResumeLayout(false);
            this.gesGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaEdit1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
