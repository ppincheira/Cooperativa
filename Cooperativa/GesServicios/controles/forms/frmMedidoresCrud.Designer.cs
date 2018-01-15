namespace GesServicios.controles.forms
{
    partial class frmMedidoresCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedidoresCrud));
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.gesTextBoxDmeCodigo = new Controles.textBoxes.gesTextBox();
            this.gesTextBoxFactorCalib = new Controles.textBoxes.gesTextBox();
            this.gesTextBoxDigitos = new Controles.textBoxes.gesTextBox();
            this.dtpFechaCarga = new Controles.Fecha.dtpFecha();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.cmbMmoCodigo = new Controles.datos.cmbLista();
            this.TextBoxGisY = new Controles.NumericTextBox();
            this.TextBoxGisX = new Controles.NumericTextBox();
            this.chkEstado = new Controles.datos.chkBox();
            this.lblGisY = new Controles.labels.lblEtiqueta();
            this.cmbNumeroProv = new Controles.datos.cmbLista();
            this.lblMmoCodigo = new Controles.labels.lblEtiqueta();
            this.lblDecimales = new Controles.labels.lblEtiqueta();
            this.lblNumeroProv = new Controles.labels.lblEtiqueta();
            this.lblClase = new Controles.labels.lblEtiqueta();
            this.lblGisX = new Controles.labels.lblEtiqueta();
            this.lblEstado = new Controles.labels.lblEtiqueta();
            this.lblDigitos = new Controles.labels.lblEtiqueta();
            this.txtNumeroSerie = new Controles.textBoxes.txtDescripcionCorta();
            this.lbDescripcion = new Controles.labels.lblEtiqueta();
            this.gesGroup2.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(159, 324);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(451, 89);
            this.gesGroup2.TabIndex = 5;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(234, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(329, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.gesTextBoxDmeCodigo);
            this.gbDatos.Controls.Add(this.gesTextBoxFactorCalib);
            this.gbDatos.Controls.Add(this.gesTextBoxDigitos);
            this.gbDatos.Controls.Add(this.dtpFechaCarga);
            this.gbDatos.Controls.Add(this.lblEtiqueta1);
            this.gbDatos.Controls.Add(this.cmbMmoCodigo);
            this.gbDatos.Controls.Add(this.TextBoxGisY);
            this.gbDatos.Controls.Add(this.TextBoxGisX);
            this.gbDatos.Controls.Add(this.chkEstado);
            this.gbDatos.Controls.Add(this.lblGisY);
            this.gbDatos.Controls.Add(this.cmbNumeroProv);
            this.gbDatos.Controls.Add(this.lblMmoCodigo);
            this.gbDatos.Controls.Add(this.lblDecimales);
            this.gbDatos.Controls.Add(this.lblNumeroProv);
            this.gbDatos.Controls.Add(this.lblClase);
            this.gbDatos.Controls.Add(this.lblGisX);
            this.gbDatos.Controls.Add(this.lblEstado);
            this.gbDatos.Controls.Add(this.lblDigitos);
            this.gbDatos.Controls.Add(this.txtNumeroSerie);
            this.gbDatos.Controls.Add(this.lbDescripcion);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(598, 288);
            this.gbDatos.TabIndex = 4;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // gesTextBoxDmeCodigo
            // 
            this.gesTextBoxDmeCodigo.BackColor = System.Drawing.Color.White;
            this.gesTextBoxDmeCodigo.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBoxDmeCodigo.Location = new System.Drawing.Point(110, 133);
            this.gesTextBoxDmeCodigo.Name = "gesTextBoxDmeCodigo";
            this.gesTextBoxDmeCodigo.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.gesTextBoxDmeCodigo.Size = new System.Drawing.Size(100, 20);
            this.gesTextBoxDmeCodigo.TabIndex = 7;
            this.gesTextBoxDmeCodigo.TextoVacio = "<Descripcion>";
            this.gesTextBoxDmeCodigo.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // gesTextBoxFactorCalib
            // 
            this.gesTextBoxFactorCalib.BackColor = System.Drawing.Color.Red;
            this.gesTextBoxFactorCalib.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBoxFactorCalib.Location = new System.Drawing.Point(427, 61);
            this.gesTextBoxFactorCalib.Name = "gesTextBoxFactorCalib";
            this.gesTextBoxFactorCalib.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.gesTextBoxFactorCalib.Size = new System.Drawing.Size(100, 20);
            this.gesTextBoxFactorCalib.TabIndex = 4;
            this.gesTextBoxFactorCalib.TextoVacio = "<Descripcion>";
            this.gesTextBoxFactorCalib.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // gesTextBoxDigitos
            // 
            this.gesTextBoxDigitos.BackColor = System.Drawing.Color.Red;
            this.gesTextBoxDigitos.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBoxDigitos.Location = new System.Drawing.Point(110, 57);
            this.gesTextBoxDigitos.Name = "gesTextBoxDigitos";
            this.gesTextBoxDigitos.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.gesTextBoxDigitos.Size = new System.Drawing.Size(100, 20);
            this.gesTextBoxDigitos.TabIndex = 3;
            this.gesTextBoxDigitos.TextoVacio = "<Descripcion>";
            this.gesTextBoxDigitos.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCarga.Location = new System.Drawing.Point(110, 171);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Size = new System.Drawing.Size(165, 20);
            this.dtpFechaCarga.TabIndex = 9;
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(13, 171);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(86, 13);
            this.lblEtiqueta1.TabIndex = 24;
            this.lblEtiqueta1.Text = "Fecha de Carga:";
            // 
            // cmbMmoCodigo
            // 
            this.cmbMmoCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMmoCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMmoCodigo.FormattingEnabled = true;
            this.cmbMmoCodigo.Location = new System.Drawing.Point(427, 136);
            this.cmbMmoCodigo.Name = "cmbMmoCodigo";
            this.cmbMmoCodigo.Size = new System.Drawing.Size(165, 21);
            this.cmbMmoCodigo.TabIndex = 8;
            // 
            // TextBoxGisY
            // 
            this.TextBoxGisY.AllowSpace = false;
            this.TextBoxGisY.Location = new System.Drawing.Point(427, 97);
            this.TextBoxGisY.Name = "TextBoxGisY";
            this.TextBoxGisY.Size = new System.Drawing.Size(100, 20);
            this.TextBoxGisY.TabIndex = 6;
            // 
            // TextBoxGisX
            // 
            this.TextBoxGisX.AllowSpace = false;
            this.TextBoxGisX.Location = new System.Drawing.Point(110, 97);
            this.TextBoxGisX.Name = "TextBoxGisX";
            this.TextBoxGisX.Size = new System.Drawing.Size(100, 20);
            this.TextBoxGisX.TabIndex = 5;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(110, 207);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(73, 17);
            this.chkEstado.TabIndex = 10;
            this.chkEstado.Text = "Habilitado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblGisY
            // 
            this.lblGisY.AutoSize = true;
            this.lblGisY.Location = new System.Drawing.Point(336, 100);
            this.lblGisY.Name = "lblGisY";
            this.lblGisY.Size = new System.Drawing.Size(35, 13);
            this.lblGisY.TabIndex = 22;
            this.lblGisY.Text = "GIS Y";
            // 
            // cmbNumeroProv
            // 
            this.cmbNumeroProv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNumeroProv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNumeroProv.FormattingEnabled = true;
            this.cmbNumeroProv.Location = new System.Drawing.Point(427, 25);
            this.cmbNumeroProv.Name = "cmbNumeroProv";
            this.cmbNumeroProv.Size = new System.Drawing.Size(165, 21);
            this.cmbNumeroProv.TabIndex = 2;
            // 
            // lblMmoCodigo
            // 
            this.lblMmoCodigo.AutoSize = true;
            this.lblMmoCodigo.Location = new System.Drawing.Point(323, 140);
            this.lblMmoCodigo.Name = "lblMmoCodigo";
            this.lblMmoCodigo.Size = new System.Drawing.Size(98, 13);
            this.lblMmoCodigo.TabIndex = 22;
            this.lblMmoCodigo.Text = "Modelo de Medidor";
            // 
            // lblDecimales
            // 
            this.lblDecimales.AutoSize = true;
            this.lblDecimales.Location = new System.Drawing.Point(314, 64);
            this.lblDecimales.Name = "lblDecimales";
            this.lblDecimales.Size = new System.Drawing.Size(110, 13);
            this.lblDecimales.TabIndex = 22;
            this.lblDecimales.Text = "Factor de Calibración:";
            // 
            // lblNumeroProv
            // 
            this.lblNumeroProv.AutoSize = true;
            this.lblNumeroProv.Location = new System.Drawing.Point(312, 28);
            this.lblNumeroProv.Name = "lblNumeroProv";
            this.lblNumeroProv.Size = new System.Drawing.Size(109, 13);
            this.lblNumeroProv.TabIndex = 22;
            this.lblNumeroProv.Text = "Empresa Proveedora;";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(13, 136);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(70, 13);
            this.lblClase.TabIndex = 22;
            this.lblClase.Text = "Codigo DME:";
            // 
            // lblGisX
            // 
            this.lblGisX.AutoSize = true;
            this.lblGisX.Location = new System.Drawing.Point(13, 100);
            this.lblGisX.Name = "lblGisX";
            this.lblGisX.Size = new System.Drawing.Size(38, 13);
            this.lblGisX.TabIndex = 22;
            this.lblGisX.Text = "GIS X:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(13, 207);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 22;
            this.lblEstado.Text = "Estado:";
            // 
            // lblDigitos
            // 
            this.lblDigitos.AutoSize = true;
            this.lblDigitos.Location = new System.Drawing.Point(13, 64);
            this.lblDigitos.Name = "lblDigitos";
            this.lblDigitos.Size = new System.Drawing.Size(44, 13);
            this.lblDigitos.TabIndex = 22;
            this.lblDigitos.Text = "Dígitos:";
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.BackColor = System.Drawing.Color.White;
            this.txtNumeroSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroSerie.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtNumeroSerie.Location = new System.Drawing.Point(110, 25);
            this.txtNumeroSerie.MaxLength = 30;
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtNumeroSerie.Size = new System.Drawing.Size(165, 20);
            this.txtNumeroSerie.TabIndex = 1;
            this.txtNumeroSerie.TextoVacio = "<Descripcion>";
            this.txtNumeroSerie.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(13, 33);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(89, 13);
            this.lbDescripcion.TabIndex = 0;
            this.lbDescripcion.Text = "Numero de Serie:";
            // 
            // frmMedidoresCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 436);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmMedidoresCrud";
            this.Text = "frmMedidoresCrud";
            this.Load += new System.EventHandler(this.frmMedidoresCrud_Load);
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
        private Controles.Fecha.dtpFecha dtpFechaCarga;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private Controles.datos.cmbLista cmbMmoCodigo;
        private Controles.NumericTextBox TextBoxGisY;
        private Controles.NumericTextBox TextBoxGisX;
        private Controles.datos.chkBox chkEstado;
        private Controles.labels.lblEtiqueta lblGisY;
        private Controles.datos.cmbLista cmbNumeroProv;
        private Controles.labels.lblEtiqueta lblMmoCodigo;
        private Controles.labels.lblEtiqueta lblDecimales;
        private Controles.labels.lblEtiqueta lblNumeroProv;
        private Controles.labels.lblEtiqueta lblClase;
        private Controles.labels.lblEtiqueta lblGisX;
        private Controles.labels.lblEtiqueta lblEstado;
        private Controles.labels.lblEtiqueta lblDigitos;
        private Controles.textBoxes.txtDescripcionCorta txtNumeroSerie;
        private Controles.labels.lblEtiqueta lbDescripcion;
        private Controles.textBoxes.gesTextBox gesTextBoxDmeCodigo;
        private Controles.textBoxes.gesTextBox gesTextBoxFactorCalib;
        private Controles.textBoxes.gesTextBox gesTextBoxDigitos;
    }
}