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
            this.cmbCodigoPostal = new Controles.datos.cmbLista();
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
            this.gesGroup2.Location = new System.Drawing.Point(11, 335);
            this.gesGroup2.Margin = new System.Windows.Forms.Padding(4);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Padding = new System.Windows.Forms.Padding(4);
            this.gesGroup2.Size = new System.Drawing.Size(731, 110);
            this.gesGroup2.TabIndex = 3;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(456, 20);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 74);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(583, 20);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 74);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cmbCodigoPostal);
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
            this.gbDatos.Location = new System.Drawing.Point(11, 4);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatos.Size = new System.Drawing.Size(731, 324);
            this.gbDatos.TabIndex = 2;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // cmbCodigoPostal
            // 
            this.cmbCodigoPostal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCodigoPostal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCodigoPostal.FormattingEnabled = true;
            this.cmbCodigoPostal.Location = new System.Drawing.Point(121, 210);
            this.cmbCodigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCodigoPostal.Name = "cmbCodigoPostal";
            this.cmbCodigoPostal.Size = new System.Drawing.Size(309, 24);
            this.cmbCodigoPostal.TabIndex = 10;
            // 
            // lblEtiqueta11
            // 
            this.lblEtiqueta11.AutoSize = true;
            this.lblEtiqueta11.Location = new System.Drawing.Point(351, 176);
            this.lblEtiqueta11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtiqueta11.Name = "lblEtiqueta11";
            this.lblEtiqueta11.Size = new System.Drawing.Size(15, 17);
            this.lblEtiqueta11.TabIndex = 35;
            this.lblEtiqueta11.Text = "y";
            // 
            // cmbCalleHasta
            // 
            this.cmbCalleHasta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCalleHasta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCalleHasta.FormattingEnabled = true;
            this.cmbCalleHasta.Location = new System.Drawing.Point(375, 166);
            this.cmbCalleHasta.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCalleHasta.Name = "cmbCalleHasta";
            this.cmbCalleHasta.Size = new System.Drawing.Size(219, 24);
            this.cmbCalleHasta.TabIndex = 9;
            // 
            // cmbCalleDesde
            // 
            this.cmbCalleDesde.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCalleDesde.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCalleDesde.FormattingEnabled = true;
            this.cmbCalleDesde.Location = new System.Drawing.Point(121, 166);
            this.cmbCalleDesde.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCalleDesde.Name = "cmbCalleDesde";
            this.cmbCalleDesde.Size = new System.Drawing.Size(219, 24);
            this.cmbCalleDesde.TabIndex = 8;
            // 
            // lblEntre
            // 
            this.lblEntre.AutoSize = true;
            this.lblEntre.Location = new System.Drawing.Point(5, 176);
            this.lblEntre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntre.Name = "lblEntre";
            this.lblEntre.Size = new System.Drawing.Size(108, 17);
            this.lblEntre.TabIndex = 32;
            this.lblEntre.Text = "Entre las calles:";
            // 
            // lblGisY
            // 
            this.lblGisY.AutoSize = true;
            this.lblGisY.Location = new System.Drawing.Point(288, 292);
            this.lblGisY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGisY.Name = "lblGisY";
            this.lblGisY.Size = new System.Drawing.Size(48, 17);
            this.lblGisY.TabIndex = 31;
            this.lblGisY.Text = "GIS Y:";
            // 
            // txtGisY
            // 
            this.txtGisY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGisY.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtGisY.Location = new System.Drawing.Point(347, 283);
            this.txtGisY.Margin = new System.Windows.Forms.Padding(4);
            this.txtGisY.MaxLength = 20;
            this.txtGisY.Name = "txtGisY";
            this.txtGisY.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtGisY.Size = new System.Drawing.Size(141, 22);
            this.txtGisY.TabIndex = 13;
            this.txtGisY.TextoVacio = "<Descripcion>";
            this.txtGisY.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lblGisX
            // 
            this.lblGisX.AutoSize = true;
            this.lblGisX.Location = new System.Drawing.Point(60, 292);
            this.lblGisX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGisX.Name = "lblGisX";
            this.lblGisX.Size = new System.Drawing.Size(48, 17);
            this.lblGisX.TabIndex = 29;
            this.lblGisX.Text = "GIS X:";
            // 
            // txtGisX
            // 
            this.txtGisX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGisX.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtGisX.Location = new System.Drawing.Point(121, 283);
            this.txtGisX.Margin = new System.Windows.Forms.Padding(4);
            this.txtGisX.MaxLength = 20;
            this.txtGisX.Name = "txtGisX";
            this.txtGisX.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtGisX.Size = new System.Drawing.Size(159, 22);
            this.txtGisX.TabIndex = 12;
            this.txtGisX.TextoVacio = "<Descripcion>";
            this.txtGisX.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtLote
            // 
            this.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLote.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtLote.Location = new System.Drawing.Point(121, 245);
            this.txtLote.Margin = new System.Windows.Forms.Padding(4);
            this.txtLote.MaxLength = 15;
            this.txtLote.Name = "txtLote";
            this.txtLote.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtLote.Size = new System.Drawing.Size(219, 22);
            this.txtLote.TabIndex = 11;
            this.txtLote.TextoVacio = "<Descripcion>";
            this.txtLote.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(69, 254);
            this.lblLote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(40, 17);
            this.lblLote.TabIndex = 26;
            this.lblLote.Text = "Lote:";
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(13, 217);
            this.lblCodigoPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(99, 17);
            this.lblCodigoPostal.TabIndex = 24;
            this.lblCodigoPostal.Text = "Codigo Postal:";
            // 
            // txtParcela
            // 
            this.txtParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParcela.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtParcela.Location = new System.Drawing.Point(121, 127);
            this.txtParcela.Margin = new System.Windows.Forms.Padding(4);
            this.txtParcela.MaxLength = 15;
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtParcela.Size = new System.Drawing.Size(472, 22);
            this.txtParcela.TabIndex = 7;
            this.txtParcela.TextoVacio = "<Descripcion>";
            this.txtParcela.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(52, 135);
            this.lblParcela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(60, 17);
            this.lblParcela.TabIndex = 22;
            this.lblParcela.Text = "Parcela:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(236, 100);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(102, 17);
            this.lblDepartamento.TabIndex = 21;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepartamento.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtDepartamento.Location = new System.Drawing.Point(347, 91);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartamento.MaxLength = 4;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtDepartamento.Size = new System.Drawing.Size(84, 22);
            this.txtDepartamento.TabIndex = 5;
            this.txtDepartamento.TextoVacio = "<Descripcion>";
            this.txtDepartamento.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(461, 100);
            this.lblPiso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(39, 17);
            this.lblPiso.TabIndex = 19;
            this.lblPiso.Text = "Piso:";
            // 
            // txtPiso
            // 
            this.txtPiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPiso.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtPiso.Location = new System.Drawing.Point(509, 91);
            this.txtPiso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPiso.MaxLength = 4;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtPiso.Size = new System.Drawing.Size(84, 22);
            this.txtPiso.TabIndex = 6;
            this.txtPiso.TextoVacio = "<Descripcion>";
            this.txtPiso.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lblBloque
            // 
            this.lblBloque.AutoSize = true;
            this.lblBloque.Location = new System.Drawing.Point(56, 100);
            this.lblBloque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBloque.Name = "lblBloque";
            this.lblBloque.Size = new System.Drawing.Size(56, 17);
            this.lblBloque.TabIndex = 17;
            this.lblBloque.Text = "Bloque:";
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(440, 66);
            this.lblEtiqueta1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(62, 17);
            this.lblEtiqueta1.TabIndex = 16;
            this.lblEtiqueta1.Text = "Numero:";
            // 
            // txtBloque
            // 
            this.txtBloque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBloque.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtBloque.Location = new System.Drawing.Point(121, 91);
            this.txtBloque.Margin = new System.Windows.Forms.Padding(4);
            this.txtBloque.MaxLength = 4;
            this.txtBloque.Name = "txtBloque";
            this.txtBloque.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtBloque.Size = new System.Drawing.Size(84, 22);
            this.txtBloque.TabIndex = 4;
            this.txtBloque.TextoVacio = "<Bloque>";
            this.txtBloque.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtNumero.Location = new System.Drawing.Point(509, 57);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.MaxLength = 8;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtNumero.Size = new System.Drawing.Size(84, 22);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.TextoVacio = "<Numero>";
            this.txtNumero.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // cmbCalle
            // 
            this.cmbCalle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCalle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCalle.FormattingEnabled = true;
            this.cmbCalle.Location = new System.Drawing.Point(121, 57);
            this.cmbCalle.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCalle.Name = "cmbCalle";
            this.cmbCalle.Size = new System.Drawing.Size(309, 24);
            this.cmbCalle.TabIndex = 2;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(121, 23);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(309, 24);
            this.cmbLocalidad.TabIndex = 1;
            this.cmbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidad_SelectedIndexChanged);
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Location = new System.Drawing.Point(39, 33);
            this.lbLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(73, 17);
            this.lbLocalidad.TabIndex = 3;
            this.lbLocalidad.Text = "Localidad:";
            // 
            // lbCalle
            // 
            this.lbCalle.AutoSize = true;
            this.lbCalle.Location = new System.Drawing.Point(69, 66);
            this.lbCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCalle.Name = "lbCalle";
            this.lbCalle.Size = new System.Drawing.Size(43, 17);
            this.lbCalle.TabIndex = 0;
            this.lbCalle.Text = "Calle:";
            // 
            // frmDomiciliosCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 458);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        public Controles.contenedores.gesGroup gbDatos;
        private Controles.labels.lblEtiqueta lblGisY;
        private Controles.textBoxes.txtDescripcionCorta txtGisY;
        private Controles.labels.lblEtiqueta lblGisX;
        private Controles.textBoxes.txtDescripcionCorta txtGisX;
        private Controles.textBoxes.txtDescripcionCorta txtLote;
        private Controles.labels.lblEtiqueta lblLote;
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
        private Controles.datos.cmbLista cmbCodigoPostal;
    }
}