namespace FormsAuxiliares
{
    partial class frmDomiciliosCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDomiciliosCrud));
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.lblEtiqueta11 = new Controles.labels.lblEtiqueta();
            this.cmbCalleHasta = new Controles.datos.cmbLista();
            this.cmbCalleDesde = new Controles.datos.cmbLista();
            this.lblEntre = new Controles.labels.lblEtiqueta();
            this.lblGisY = new Controles.labels.lblEtiqueta();
            this.txtGisY = new Controles.textBoxes.txtDescripcionCorta();
            this.lblGisX = new Controles.labels.lblEtiqueta();
            this.txtGisX = new Controles.textBoxes.txtDescripcionCorta();
            this.txtLote = new Controles.textBoxes.txtDescripcionCorta();
            this.lblLote = new Controles.labels.lblEtiqueta();
            this.txtCodigoPostal = new Controles.textBoxes.txtDescripcionCorta();
            this.lblCodigoPostal = new Controles.labels.lblEtiqueta();
            this.txtParcela = new Controles.textBoxes.txtDescripcionCorta();
            this.lblParcela = new Controles.labels.lblEtiqueta();
            this.lblDepartamento = new Controles.labels.lblEtiqueta();
            this.txtDepartamento = new Controles.textBoxes.txtDescripcionCorta();
            this.lblPiso = new Controles.labels.lblEtiqueta();
            this.txtPiso = new Controles.textBoxes.txtDescripcionCorta();
            this.lblBloque = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.txtBloque = new Controles.textBoxes.txtDescripcionCorta();
            this.txtNumero = new Controles.textBoxes.txtDescripcionCorta();
            this.cmbCalle = new Controles.datos.cmbLista();
            this.cmbLocalidad = new Controles.datos.cmbLista();
            this.lbLocalidad = new Controles.labels.lblEtiqueta();
            this.lbCalle = new Controles.labels.lblEtiqueta();
            this.gesGroup2.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(8, 272);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(548, 89);
            this.gesGroup2.TabIndex = 3;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(342, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(437, 16);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblEtiqueta11);
            this.gbDatos.Controls.Add(this.cmbCalleHasta);
            this.gbDatos.Controls.Add(this.cmbCalleDesde);
            this.gbDatos.Controls.Add(this.lblEntre);
            this.gbDatos.Controls.Add(this.lblGisY);
            this.gbDatos.Controls.Add(this.txtGisY);
            this.gbDatos.Controls.Add(this.lblGisX);
            this.gbDatos.Controls.Add(this.txtGisX);
            this.gbDatos.Controls.Add(this.txtLote);
            this.gbDatos.Controls.Add(this.lblLote);
            this.gbDatos.Controls.Add(this.txtCodigoPostal);
            this.gbDatos.Controls.Add(this.lblCodigoPostal);
            this.gbDatos.Controls.Add(this.txtParcela);
            this.gbDatos.Controls.Add(this.lblParcela);
            this.gbDatos.Controls.Add(this.lblDepartamento);
            this.gbDatos.Controls.Add(this.txtDepartamento);
            this.gbDatos.Controls.Add(this.lblPiso);
            this.gbDatos.Controls.Add(this.txtPiso);
            this.gbDatos.Controls.Add(this.lblBloque);
            this.gbDatos.Controls.Add(this.lblEtiqueta1);
            this.gbDatos.Controls.Add(this.txtBloque);
            this.gbDatos.Controls.Add(this.txtNumero);
            this.gbDatos.Controls.Add(this.cmbCalle);
            this.gbDatos.Controls.Add(this.cmbLocalidad);
            this.gbDatos.Controls.Add(this.lbLocalidad);
            this.gbDatos.Controls.Add(this.lbCalle);
            this.gbDatos.Location = new System.Drawing.Point(8, 3);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(548, 263);
            this.gbDatos.TabIndex = 2;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // lblEtiqueta11
            // 
            this.lblEtiqueta11.AutoSize = true;
            this.lblEtiqueta11.Location = new System.Drawing.Point(263, 143);
            this.lblEtiqueta11.Name = "lblEtiqueta11";
            this.lblEtiqueta11.Size = new System.Drawing.Size(12, 13);
            this.lblEtiqueta11.TabIndex = 35;
            this.lblEtiqueta11.Text = "y";
            // 
            // cmbCalleHasta
            // 
            this.cmbCalleHasta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCalleHasta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCalleHasta.FormattingEnabled = true;
            this.cmbCalleHasta.Location = new System.Drawing.Point(281, 135);
            this.cmbCalleHasta.Name = "cmbCalleHasta";
            this.cmbCalleHasta.Size = new System.Drawing.Size(165, 21);
            this.cmbCalleHasta.TabIndex = 34;
            // 
            // cmbCalleDesde
            // 
            this.cmbCalleDesde.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCalleDesde.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCalleDesde.FormattingEnabled = true;
            this.cmbCalleDesde.Location = new System.Drawing.Point(91, 135);
            this.cmbCalleDesde.Name = "cmbCalleDesde";
            this.cmbCalleDesde.Size = new System.Drawing.Size(165, 21);
            this.cmbCalleDesde.TabIndex = 33;
            // 
            // lblEntre
            // 
            this.lblEntre.AutoSize = true;
            this.lblEntre.Location = new System.Drawing.Point(4, 143);
            this.lblEntre.Name = "lblEntre";
            this.lblEntre.Size = new System.Drawing.Size(81, 13);
            this.lblEntre.TabIndex = 32;
            this.lblEntre.Text = "Entre las calles:";
            // 
            // lblGisY
            // 
            this.lblGisY.AutoSize = true;
            this.lblGisY.Location = new System.Drawing.Point(216, 237);
            this.lblGisY.Name = "lblGisY";
            this.lblGisY.Size = new System.Drawing.Size(38, 13);
            this.lblGisY.TabIndex = 31;
            this.lblGisY.Text = "GIS Y:";
            // 
            // txtGisY
            // 
            this.txtGisY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGisY.Location = new System.Drawing.Point(260, 230);
            this.txtGisY.MaxLength = 20;
            this.txtGisY.Name = "txtGisY";
            this.txtGisY.Size = new System.Drawing.Size(64, 20);
            this.txtGisY.TabIndex = 30;
            // 
            // lblGisX
            // 
            this.lblGisX.AutoSize = true;
            this.lblGisX.Location = new System.Drawing.Point(45, 237);
            this.lblGisX.Name = "lblGisX";
            this.lblGisX.Size = new System.Drawing.Size(38, 13);
            this.lblGisX.TabIndex = 29;
            this.lblGisX.Text = "GIS X:";
            // 
            // txtGisX
            // 
            this.txtGisX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGisX.Location = new System.Drawing.Point(91, 230);
            this.txtGisX.MaxLength = 20;
            this.txtGisX.Name = "txtGisX";
            this.txtGisX.Size = new System.Drawing.Size(64, 20);
            this.txtGisX.TabIndex = 28;
            // 
            // txtLote
            // 
            this.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLote.Location = new System.Drawing.Point(91, 199);
            this.txtLote.MaxLength = 20;
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(165, 20);
            this.txtLote.TabIndex = 27;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(52, 206);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(31, 13);
            this.lblLote.TabIndex = 26;
            this.lblLote.Text = "Lote:";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPostal.Location = new System.Drawing.Point(91, 169);
            this.txtCodigoPostal.MaxLength = 20;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(165, 20);
            this.txtCodigoPostal.TabIndex = 25;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(10, 176);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(75, 13);
            this.lblCodigoPostal.TabIndex = 24;
            this.lblCodigoPostal.Text = "Codigo Postal:";
            // 
            // txtParcela
            // 
            this.txtParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParcela.Location = new System.Drawing.Point(91, 103);
            this.txtParcela.MaxLength = 20;
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(355, 20);
            this.txtParcela.TabIndex = 23;
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(39, 110);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(46, 13);
            this.lblParcela.TabIndex = 22;
            this.lblParcela.Text = "Parcela:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(177, 81);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 21;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepartamento.Location = new System.Drawing.Point(260, 74);
            this.txtDepartamento.MaxLength = 20;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(64, 20);
            this.txtDepartamento.TabIndex = 20;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(346, 81);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 13);
            this.lblPiso.TabIndex = 19;
            this.lblPiso.Text = "Piso:";
            // 
            // txtPiso
            // 
            this.txtPiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPiso.Location = new System.Drawing.Point(382, 74);
            this.txtPiso.MaxLength = 20;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(64, 20);
            this.txtPiso.TabIndex = 18;
            // 
            // lblBloque
            // 
            this.lblBloque.AutoSize = true;
            this.lblBloque.Location = new System.Drawing.Point(42, 81);
            this.lblBloque.Name = "lblBloque";
            this.lblBloque.Size = new System.Drawing.Size(43, 13);
            this.lblBloque.TabIndex = 17;
            this.lblBloque.Text = "Bloque:";
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(330, 54);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(47, 13);
            this.lblEtiqueta1.TabIndex = 16;
            this.lblEtiqueta1.Text = "Numero:";
            // 
            // txtBloque
            // 
            this.txtBloque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBloque.Location = new System.Drawing.Point(91, 74);
            this.txtBloque.MaxLength = 20;
            this.txtBloque.Name = "txtBloque";
            this.txtBloque.Size = new System.Drawing.Size(64, 20);
            this.txtBloque.TabIndex = 14;
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(382, 46);
            this.txtNumero.MaxLength = 20;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(64, 20);
            this.txtNumero.TabIndex = 13;
            // 
            // cmbCalle
            // 
            this.cmbCalle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCalle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCalle.FormattingEnabled = true;
            this.cmbCalle.Location = new System.Drawing.Point(91, 46);
            this.cmbCalle.Name = "cmbCalle";
            this.cmbCalle.Size = new System.Drawing.Size(233, 21);
            this.cmbCalle.TabIndex = 12;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(91, 19);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(233, 21);
            this.cmbLocalidad.TabIndex = 11;
            this.cmbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidad_SelectedIndexChanged);
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Location = new System.Drawing.Point(29, 27);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lbLocalidad.TabIndex = 3;
            this.lbLocalidad.Text = "Localidad:";
            // 
            // lbCalle
            // 
            this.lbCalle.AutoSize = true;
            this.lbCalle.Location = new System.Drawing.Point(52, 54);
            this.lbCalle.Name = "lbCalle";
            this.lbCalle.Size = new System.Drawing.Size(33, 13);
            this.lbCalle.TabIndex = 0;
            this.lbCalle.Text = "Calle:";
            // 
            // frmDomiciliosCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 372);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmDomiciliosCrud";
            this.Text = "frmDomiciliosCrud";
            this.Load += new System.EventHandler(this.frmDomiciliosCrud_Load);
            this.gesGroup2.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        private Controles.contenedores.gesGroup gbDatos;
        private Controles.labels.lblEtiqueta lblGisY;
        private Controles.textBoxes.txtDescripcionCorta txtGisY;
        private Controles.labels.lblEtiqueta lblGisX;
        private Controles.textBoxes.txtDescripcionCorta txtGisX;
        private Controles.textBoxes.txtDescripcionCorta txtLote;
        private Controles.labels.lblEtiqueta lblLote;
        private Controles.textBoxes.txtDescripcionCorta txtCodigoPostal;
        private Controles.labels.lblEtiqueta lblCodigoPostal;
        private Controles.textBoxes.txtDescripcionCorta txtParcela;
        private Controles.labels.lblEtiqueta lblParcela;
        private Controles.labels.lblEtiqueta lblDepartamento;
        private Controles.textBoxes.txtDescripcionCorta txtDepartamento;
        private Controles.labels.lblEtiqueta lblPiso;
        private Controles.textBoxes.txtDescripcionCorta txtPiso;
        private Controles.labels.lblEtiqueta lblBloque;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private Controles.textBoxes.txtDescripcionCorta txtBloque;
        private Controles.textBoxes.txtDescripcionCorta txtNumero;
        private Controles.datos.cmbLista cmbCalle;
        private Controles.datos.cmbLista cmbLocalidad;
        private Controles.labels.lblEtiqueta lbLocalidad;
        private Controles.labels.lblEtiqueta lbCalle;
        private Controles.datos.cmbLista cmbCalleDesde;
        private Controles.labels.lblEtiqueta lblEntre;
        private Controles.datos.cmbLista cmbCalleHasta;
        private Controles.labels.lblEtiqueta lblEtiqueta11;
    }
}