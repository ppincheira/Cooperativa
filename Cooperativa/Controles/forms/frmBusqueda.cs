﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
using Business;
namespace Controles.forms
{
    public partial class frmBusqueda :Form
    {
        private contenedores.gesGroup gbData;
        internal System.Windows.Forms.GroupBox gbBusqueda;
        internal System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.ComboBox cmbBuscar;
        internal System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCantidad;
        public  datos.gesGrid dgBusqueda;

        private void InitializeComponent()
        {
            this.gbData = new Controles.contenedores.gesGroup();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgBusqueda = new Controles.datos.gesGrid();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).BeginInit();
            this.gbBusqueda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.lblCantidad);
            this.gbData.Controls.Add(this.dgBusqueda);
            this.gbData.Location = new System.Drawing.Point(12, 146);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(581, 307);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(9, 288);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(125, 13);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Se econtraron 0 registros";
            // 
            // dgBusqueda
            // 
            this.dgBusqueda.DataMember = "";
            this.dgBusqueda.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgBusqueda.Location = new System.Drawing.Point(6, 19);
            this.dgBusqueda.Name = "dgBusqueda";
            this.dgBusqueda.Size = new System.Drawing.Size(569, 261);
            this.dgBusqueda.TabIndex = 0;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.lblTitulo);
            this.gbBusqueda.Controls.Add(this.cmbBuscar);
            this.gbBusqueda.Controls.Add(this.txtFiltro);
            this.gbBusqueda.Location = new System.Drawing.Point(12, 12);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(581, 112);
            this.gbBusqueda.TabIndex = 4;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(6, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(61, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Buscar por:";
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(49, 36);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(176, 21);
            this.cmbBuscar.TabIndex = 2;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(49, 74);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(176, 20);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(310, 14);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 31);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(464, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 31);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Location = new System.Drawing.Point(12, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 51);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmBusqueda
            // 
            this.ClientSize = new System.Drawing.Size(605, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.gbData);
            this.Name = "frmBusqueda";
            this.Load += new System.EventHandler(this.frmBusqueda_Load);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).EndInit();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #region << PROPIEDADES >>
        public String _Tabla;
        
        #endregion
        #region << EVENTOS >>


        private void frmBusqueda_Load(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion
        #region << METODOS >>
        private void Buscar() {

            try
            {
                DetallesColumnasTablasBus oDetalleBus= new DetallesColumnasTablasBus();
                List<DetallesColumnasTablas> ListDetalle = oDetalleBus.DetallesColumnasTablasGetByName(_Tabla);
                foreach (DetallesColumnasTablas oDetalle in ListDetalle)
                {
                    if (oDetalle.DctFiltroBusqueda == "S")
                        this.cmbBuscar.Items.Add(oDetalle.DctDescripcion);

                }
                
            }
            catch {

            }


        }

     



        #endregion


    }
}
