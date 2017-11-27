using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsAuxiliares
{
    public partial class frmCrudGrilla:gesForm
    {
        private Controles.contenedores.gpbGrupo gpbGrupo2;
        private Controles.contenedores.gpbGrupo gpbGrupo3;
        private Controles.buttons.btnCancelar btnCancelar1;
        private Controles.buttons.btnAceptar btnAceptar1;
        private Controles.labels.lblEtiqueta lblEtiqueta3;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.txtFiltro txtFiltro1;
        private Controles.datos.cmbLista cmbLista1;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private Controles.datos.grdGrillaEdit grdGrillaEdit1;
        private Controles.contenedores.gpbGrupo gpbGrupo1;

        public frmCrudGrilla() {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrudGrilla));
            this.gpbGrupo1 = new Controles.contenedores.gpbGrupo();
            this.gpbGrupo2 = new Controles.contenedores.gpbGrupo();
            this.gpbGrupo3 = new Controles.contenedores.gpbGrupo();
            this.btnCancelar1 = new Controles.buttons.btnCancelar();
            this.btnAceptar1 = new Controles.buttons.btnAceptar();
            this.lblEtiqueta3 = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.txtFiltro1 = new Controles.txtFiltro();
            this.cmbLista1 = new Controles.datos.cmbLista();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.grdGrillaEdit1 = new Controles.datos.grdGrillaEdit();
            this.gpbGrupo1.SuspendLayout();
            this.gpbGrupo2.SuspendLayout();
            this.gpbGrupo3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbGrupo1
            // 
            this.gpbGrupo1.Controls.Add(this.lblEtiqueta3);
            this.gpbGrupo1.Controls.Add(this.lblEtiqueta2);
            this.gpbGrupo1.Controls.Add(this.txtFiltro1);
            this.gpbGrupo1.Controls.Add(this.cmbLista1);
            this.gpbGrupo1.Location = new System.Drawing.Point(12, 6);
            this.gpbGrupo1.Name = "gpbGrupo1";
            this.gpbGrupo1.Size = new System.Drawing.Size(535, 78);
            this.gpbGrupo1.TabIndex = 0;
            this.gpbGrupo1.TabStop = false;
            // 
            // gpbGrupo2
            // 
            this.gpbGrupo2.Controls.Add(this.grdGrillaEdit1);
            this.gpbGrupo2.Controls.Add(this.lblEtiqueta1);
            this.gpbGrupo2.Location = new System.Drawing.Point(12, 90);
            this.gpbGrupo2.Name = "gpbGrupo2";
            this.gpbGrupo2.Size = new System.Drawing.Size(535, 629);
            this.gpbGrupo2.TabIndex = 1;
            this.gpbGrupo2.TabStop = false;
            // 
            // gpbGrupo3
            // 
            this.gpbGrupo3.Controls.Add(this.btnCancelar1);
            this.gpbGrupo3.Controls.Add(this.btnAceptar1);
            this.gpbGrupo3.Location = new System.Drawing.Point(358, 725);
            this.gpbGrupo3.Name = "gpbGrupo3";
            this.gpbGrupo3.Size = new System.Drawing.Size(189, 84);
            this.gpbGrupo3.TabIndex = 1;
            this.gpbGrupo3.TabStop = false;
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar1.Image")));
            this.btnCancelar1.Location = new System.Drawing.Point(100, 14);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar1.TabIndex = 1;
            this.btnCancelar1.UseVisualStyleBackColor = true;
            // 
            // btnAceptar1
            // 
            this.btnAceptar1.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar1.Image")));
            this.btnAceptar1.Location = new System.Drawing.Point(9, 14);
            this.btnAceptar1.Name = "btnAceptar1";
            this.btnAceptar1.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar1.TabIndex = 0;
            this.btnAceptar1.UseVisualStyleBackColor = true;
            // 
            // lblEtiqueta3
            // 
            this.lblEtiqueta3.AutoSize = true;
            this.lblEtiqueta3.Location = new System.Drawing.Point(7, 47);
            this.lblEtiqueta3.Name = "lblEtiqueta3";
            this.lblEtiqueta3.Size = new System.Drawing.Size(45, 13);
            this.lblEtiqueta3.TabIndex = 7;
            this.lblEtiqueta3.Text = "FILTRO";
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(6, 23);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(78, 13);
            this.lblEtiqueta2.TabIndex = 6;
            this.lblEtiqueta2.Text = "FILTRAR POR";
            // 
            // txtFiltro1
            // 
            this.txtFiltro1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro1.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtFiltro1.Location = new System.Drawing.Point(99, 44);
            this.txtFiltro1.Name = "txtFiltro1";
            this.txtFiltro1.Size = new System.Drawing.Size(175, 20);
            this.txtFiltro1.TabIndex = 5;
            this.txtFiltro1.TextoVacio = "<Descripcion>";
            // 
            // cmbLista1
            // 
            this.cmbLista1.FormattingEnabled = true;
            this.cmbLista1.Location = new System.Drawing.Point(99, 16);
            this.cmbLista1.Name = "cmbLista1";
            this.cmbLista1.Size = new System.Drawing.Size(175, 21);
            this.cmbLista1.TabIndex = 4;
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(7, 610);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(49, 13);
            this.lblEtiqueta1.TabIndex = 2;
            this.lblEtiqueta1.Text = "Cantidad";
            // 
            // grdGrillaEdit1
            // 
            this.grdGrillaEdit1.DataMember = "";
            this.grdGrillaEdit1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grdGrillaEdit1.Location = new System.Drawing.Point(10, 19);
            this.grdGrillaEdit1.Name = "grdGrillaEdit1";
            this.grdGrillaEdit1.Size = new System.Drawing.Size(516, 588);
            this.grdGrillaEdit1.TabIndex = 3;
            // 
            // frmCrudGrilla
            // 
            this.ClientSize = new System.Drawing.Size(559, 815);
            this.Controls.Add(this.gpbGrupo3);
            this.Controls.Add(this.gpbGrupo2);
            this.Controls.Add(this.gpbGrupo1);
            this.Name = "frmCrudGrilla";
            this.gpbGrupo1.ResumeLayout(false);
            this.gpbGrupo1.PerformLayout();
            this.gpbGrupo2.ResumeLayout(false);
            this.gpbGrupo2.PerformLayout();
            this.gpbGrupo3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaEdit1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
