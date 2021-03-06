﻿namespace FormsAuxiliares
{
    partial class frmObservacionesCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObservacionesCrud));
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.btnVer = new Controles.buttons.btnGeneral();
            this.txtDescripcionPath = new Controles.textBoxes.txtDescripcionCorta();
            this.dtpFecha = new Controles.Fecha.dtpFecha();
            this.btnAgregar = new Controles.buttons.btnGeneral();
            this.lbAdjunto = new Controles.labels.lblEtiqueta();
            this.lbFecha = new Controles.labels.lblEtiqueta();
            this.txtDetalle = new Controles.textBoxes.txtObservaciones();
            this.lbDetalle = new Controles.labels.lblEtiqueta();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.txtObservaciones1 = new Controles.textBoxes.txtObservaciones();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.btnGeneral1 = new Controles.buttons.btnGeneral();
            this.dtpFecha1 = new Controles.Fecha.dtpFecha();
            this.txtDescripcionCorta1 = new Controles.textBoxes.txtDescripcionCorta();
            this.btnGeneral2 = new Controles.buttons.btnGeneral();
            this.gbDatos.SuspendLayout();
            this.gesGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnGeneral2);
            this.gbDatos.Controls.Add(this.btnVer);
            this.gbDatos.Controls.Add(this.txtDescripcionCorta1);
            this.gbDatos.Controls.Add(this.txtDescripcionPath);
            this.gbDatos.Controls.Add(this.dtpFecha1);
            this.gbDatos.Controls.Add(this.btnGeneral1);
            this.gbDatos.Controls.Add(this.dtpFecha);
            this.gbDatos.Controls.Add(this.lblEtiqueta2);
            this.gbDatos.Controls.Add(this.btnAgregar);
            this.gbDatos.Controls.Add(this.lbAdjunto);
            this.gbDatos.Controls.Add(this.txtObservaciones1);
            this.gbDatos.Controls.Add(this.lbFecha);
            this.gbDatos.Controls.Add(this.lblEtiqueta1);
            this.gbDatos.Controls.Add(this.txtDetalle);
            this.gbDatos.Controls.Add(this.lbDetalle);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(504, 254);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(449, 205);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(37, 33);
            this.btnVer.TabIndex = 13;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // txtDescripcionPath
            // 
            this.txtDescripcionPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionPath.Location = new System.Drawing.Point(174, 218);
            this.txtDescripcionPath.MaxLength = 20;
            this.txtDescripcionPath.Name = "txtDescripcionPath";
            this.txtDescripcionPath.ReadOnly = true;
            this.txtDescripcionPath.Size = new System.Drawing.Size(269, 20);
            this.txtDescripcionPath.TabIndex = 12;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(122, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(105, 20);
            this.dtpFecha.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(122, 206);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(37, 33);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "...";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbAdjunto
            // 
            this.lbAdjunto.AutoSize = true;
            this.lbAdjunto.Location = new System.Drawing.Point(39, 225);
            this.lbAdjunto.Name = "lbAdjunto";
            this.lbAdjunto.Size = new System.Drawing.Size(49, 13);
            this.lbAdjunto.TabIndex = 10;
            this.lbAdjunto.Text = "Adjuntar:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(39, 34);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(40, 13);
            this.lbFecha.TabIndex = 3;
            this.lbFecha.Text = "Fecha:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetalle.Location = new System.Drawing.Point(122, 63);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(364, 137);
            this.txtDetalle.TabIndex = 2;
            // 
            // lbDetalle
            // 
            this.lbDetalle.AutoSize = true;
            this.lbDetalle.Location = new System.Drawing.Point(39, 66);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(43, 13);
            this.lbDetalle.TabIndex = 0;
            this.lbDetalle.Text = "Detalle:";
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(12, 272);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(504, 89);
            this.gesGroup2.TabIndex = 1;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(309, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(418, 14);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(39, 65);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(43, 13);
            this.lblEtiqueta1.TabIndex = 0;
            this.lblEtiqueta1.Text = "Detalle:";
            // 
            // txtObservaciones1
            // 
            this.txtObservaciones1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones1.Location = new System.Drawing.Point(122, 62);
            this.txtObservaciones1.Multiline = true;
            this.txtObservaciones1.Name = "txtObservaciones1";
            this.txtObservaciones1.Size = new System.Drawing.Size(364, 137);
            this.txtObservaciones1.TabIndex = 2;
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(39, 224);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(49, 13);
            this.lblEtiqueta2.TabIndex = 10;
            this.lblEtiqueta2.Text = "Adjuntar:";
            // 
            // btnGeneral1
            // 
            this.btnGeneral1.Location = new System.Drawing.Point(122, 205);
            this.btnGeneral1.Name = "btnGeneral1";
            this.btnGeneral1.Size = new System.Drawing.Size(37, 33);
            this.btnGeneral1.TabIndex = 3;
            this.btnGeneral1.Text = "...";
            this.btnGeneral1.UseVisualStyleBackColor = true;
            this.btnGeneral1.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(122, 27);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(105, 20);
            this.dtpFecha1.TabIndex = 11;
            // 
            // txtDescripcionCorta1
            // 
            this.txtDescripcionCorta1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionCorta1.Location = new System.Drawing.Point(174, 217);
            this.txtDescripcionCorta1.MaxLength = 20;
            this.txtDescripcionCorta1.Name = "txtDescripcionCorta1";
            this.txtDescripcionCorta1.ReadOnly = true;
            this.txtDescripcionCorta1.Size = new System.Drawing.Size(269, 20);
            this.txtDescripcionCorta1.TabIndex = 12;
            // 
            // btnGeneral2
            // 
            this.btnGeneral2.Location = new System.Drawing.Point(449, 204);
            this.btnGeneral2.Name = "btnGeneral2";
            this.btnGeneral2.Size = new System.Drawing.Size(37, 33);
            this.btnGeneral2.TabIndex = 13;
            this.btnGeneral2.Text = "Ver";
            this.btnGeneral2.UseVisualStyleBackColor = true;
            this.btnGeneral2.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // frmObservacionesCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 373);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmObservacionesCrud";
            this.Text = "frmObservacionesCrud";
            this.Load += new System.EventHandler(this.frmObservacionesCrud_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gesGroup2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gesGroup gbDatos;
        private Controles.labels.lblEtiqueta lbFecha;
        private Controles.textBoxes.txtObservaciones txtDetalle;
        private Controles.labels.lblEtiqueta lbDetalle;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        private Controles.labels.lblEtiqueta lbAdjunto;
        private Controles.buttons.btnGeneral btnAgregar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Controles.Fecha.dtpFecha dtpFecha;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcionPath;
        private Controles.buttons.btnGeneral btnVer;
        private Controles.buttons.btnGeneral btnGeneral2;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcionCorta1;
        private Controles.Fecha.dtpFecha dtpFecha1;
        private Controles.buttons.btnGeneral btnGeneral1;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.textBoxes.txtObservaciones txtObservaciones1;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
    }
}