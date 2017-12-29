﻿namespace FormsAuxiliares
{
    partial class frmCallesCrud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCallesCrud));
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.cmbLista = new Controles.datos.cmbLista();
            this.txtDescripcionCorta = new Controles.textBoxes.txtDescripcionCorta();
            this.lbDescripcion = new Controles.labels.lblEtiqueta();
            this.lbLocalidad = new Controles.labels.lblEtiqueta();
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos.SuspendLayout();
            this.gesGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cmbLista);
            this.gbDatos.Controls.Add(this.txtDescripcionCorta);
            this.gbDatos.Controls.Add(this.lbDescripcion);
            this.gbDatos.Controls.Add(this.lbLocalidad);
            this.gbDatos.Location = new System.Drawing.Point(16, 9);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatos.Size = new System.Drawing.Size(672, 161);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // cmbLista
            // 
            this.cmbLista.FormattingEnabled = true;
            this.cmbLista.Location = new System.Drawing.Point(148, 81);
            this.cmbLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLista.Name = "cmbLista";
            this.cmbLista.Size = new System.Drawing.Size(311, 24);
            this.cmbLista.TabIndex = 5;
            // 
            // txtDescripcionCorta
            // 
            this.txtDescripcionCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionCorta.Location = new System.Drawing.Point(148, 42);
            this.txtDescripcionCorta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionCorta.MaxLength = 20;
            this.txtDescripcionCorta.Name = "txtDescripcionCorta";
            this.txtDescripcionCorta.Size = new System.Drawing.Size(311, 22);
            this.txtDescripcionCorta.TabIndex = 4;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(52, 42);
            this.lbDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lbDescripcion.TabIndex = 3;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Location = new System.Drawing.Point(65, 91);
            this.lbLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(73, 17);
            this.lbLocalidad.TabIndex = 0;
            this.lbLocalidad.Text = "Localidad:";
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(16, 177);
            this.gesGroup2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gesGroup2.Size = new System.Drawing.Size(672, 110);
            this.gesGroup2.TabIndex = 5;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(412, 17);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 74);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(557, 17);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 74);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmCallesCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 298);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCallesCrud";
            this.Text = "frmCallesCrud";
            this.Load += new System.EventHandler(this.frmCallesCrud_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gesGroup2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gesGroup gbDatos;
        private Controles.labels.lblEtiqueta lbDescripcion;
        private Controles.labels.lblEtiqueta lbLocalidad;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcionCorta;
        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        private Controles.datos.cmbLista cmbLista;
    }
}