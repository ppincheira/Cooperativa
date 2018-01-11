﻿namespace GesServicios.controles.forms
{
    partial class frmModelosMedidoresCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModelosMedidoresCrud));
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.dtpFechaCarga = new Controles.Fecha.dtpFecha();
            this.TextBoxTipoConexion = new Controles.textBoxes.gesTextBox();
            this.TextBoxTipoContador = new Controles.textBoxes.gesTextBox();
            this.lblTipoMedidor = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.cmbTipoMedidor = new Controles.datos.cmbLista();
            this.TextBoxAmperaje = new Controles.textBoxes.gesTextBox();
            this.TextBoxRegistrador = new Controles.NumericTextBox();
            this.TextBoxKWVueltas = new Controles.NumericTextBox();
            this.numericTextBox1 = new Controles.NumericTextBox();
            this.TextBoxClase = new Controles.NumericTextBox();
            this.TextBoxCantHilos = new Controles.NumericTextBox();
            this.TextBoxDigitos = new Controles.NumericTextBox();
            this.lblRegistrador = new Controles.labels.lblEtiqueta();
            this.chkEstado = new Controles.datos.chkBox();
            this.lblKWVueltas = new Controles.labels.lblEtiqueta();
            this.cmbFabricante = new Controles.datos.cmbLista();
            this.lblTipoConexion = new Controles.labels.lblEtiqueta();
            this.lblDecimales = new Controles.labels.lblEtiqueta();
            this.lblTipoContador = new Controles.labels.lblEtiqueta();
            this.lblClase = new Controles.labels.lblEtiqueta();
            this.lblAmperaje = new Controles.labels.lblEtiqueta();
            this.lblCantHilos = new Controles.labels.lblEtiqueta();
            this.lblEstado = new Controles.labels.lblEtiqueta();
            this.lblDigitos = new Controles.labels.lblEtiqueta();
            this.lblParcela = new Controles.labels.lblEtiqueta();
            this.lblDescripcionCorta = new Controles.labels.lblEtiqueta();
            this.txtDescripcionCorta = new Controles.textBoxes.txtDescripcionCorta();
            this.txtDescripcion = new Controles.textBoxes.txtDescripcionCorta();
            this.lbDescripcion = new Controles.labels.lblEtiqueta();
            this.gesGroup2.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(8, 396);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(451, 89);
            this.gesGroup2.TabIndex = 3;
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
            this.gbDatos.Controls.Add(this.dtpFechaCarga);
            this.gbDatos.Controls.Add(this.TextBoxTipoConexion);
            this.gbDatos.Controls.Add(this.TextBoxTipoContador);
            this.gbDatos.Controls.Add(this.lblTipoMedidor);
            this.gbDatos.Controls.Add(this.lblEtiqueta1);
            this.gbDatos.Controls.Add(this.cmbTipoMedidor);
            this.gbDatos.Controls.Add(this.TextBoxAmperaje);
            this.gbDatos.Controls.Add(this.TextBoxRegistrador);
            this.gbDatos.Controls.Add(this.TextBoxKWVueltas);
            this.gbDatos.Controls.Add(this.numericTextBox1);
            this.gbDatos.Controls.Add(this.TextBoxClase);
            this.gbDatos.Controls.Add(this.TextBoxCantHilos);
            this.gbDatos.Controls.Add(this.TextBoxDigitos);
            this.gbDatos.Controls.Add(this.lblRegistrador);
            this.gbDatos.Controls.Add(this.chkEstado);
            this.gbDatos.Controls.Add(this.lblKWVueltas);
            this.gbDatos.Controls.Add(this.cmbFabricante);
            this.gbDatos.Controls.Add(this.lblTipoConexion);
            this.gbDatos.Controls.Add(this.lblDecimales);
            this.gbDatos.Controls.Add(this.lblTipoContador);
            this.gbDatos.Controls.Add(this.lblClase);
            this.gbDatos.Controls.Add(this.lblAmperaje);
            this.gbDatos.Controls.Add(this.lblCantHilos);
            this.gbDatos.Controls.Add(this.lblEstado);
            this.gbDatos.Controls.Add(this.lblDigitos);
            this.gbDatos.Controls.Add(this.lblParcela);
            this.gbDatos.Controls.Add(this.lblDescripcionCorta);
            this.gbDatos.Controls.Add(this.txtDescripcionCorta);
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Controls.Add(this.lbDescripcion);
            this.gbDatos.Location = new System.Drawing.Point(8, 3);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(598, 387);
            this.gbDatos.TabIndex = 2;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.Location = new System.Drawing.Point(110, 314);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCarga.TabIndex = 27;
            // 
            // TextBoxTipoConexion
            // 
            this.TextBoxTipoConexion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxTipoConexion.Location = new System.Drawing.Point(433, 200);
            this.TextBoxTipoConexion.MaxLength = 15;
            this.TextBoxTipoConexion.Name = "TextBoxTipoConexion";
            this.TextBoxTipoConexion.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTipoConexion.TabIndex = 26;
            this.TextBoxTipoConexion.TextChanged += new System.EventHandler(this.gesTextBox1_TextChanged);
            // 
            // TextBoxTipoContador
            // 
            this.TextBoxTipoContador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxTipoContador.Location = new System.Drawing.Point(110, 200);
            this.TextBoxTipoContador.MaxLength = 15;
            this.TextBoxTipoContador.Name = "TextBoxTipoContador";
            this.TextBoxTipoContador.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTipoContador.TabIndex = 26;
            this.TextBoxTipoContador.TextChanged += new System.EventHandler(this.gesTextBox1_TextChanged);
            // 
            // lblTipoMedidor
            // 
            this.lblTipoMedidor.AutoSize = true;
            this.lblTipoMedidor.Location = new System.Drawing.Point(336, 239);
            this.lblTipoMedidor.Name = "lblTipoMedidor";
            this.lblTipoMedidor.Size = new System.Drawing.Size(87, 13);
            this.lblTipoMedidor.TabIndex = 24;
            this.lblTipoMedidor.Text = "Tipo de Medidor:";
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(13, 314);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(86, 13);
            this.lblEtiqueta1.TabIndex = 24;
            this.lblEtiqueta1.Text = "Fecha de Carga:";
            // 
            // cmbTipoMedidor
            // 
            this.cmbTipoMedidor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTipoMedidor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoMedidor.FormattingEnabled = true;
            this.cmbTipoMedidor.Location = new System.Drawing.Point(433, 236);
            this.cmbTipoMedidor.Name = "cmbTipoMedidor";
            this.cmbTipoMedidor.Size = new System.Drawing.Size(165, 21);
            this.cmbTipoMedidor.TabIndex = 4;
            // 
            // TextBoxAmperaje
            // 
            this.TextBoxAmperaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxAmperaje.Location = new System.Drawing.Point(110, 130);
            this.TextBoxAmperaje.MaxLength = 15;
            this.TextBoxAmperaje.Name = "TextBoxAmperaje";
            this.TextBoxAmperaje.Size = new System.Drawing.Size(100, 20);
            this.TextBoxAmperaje.TabIndex = 26;
            // 
            // TextBoxRegistrador
            // 
            this.TextBoxRegistrador.AllowSpace = false;
            this.TextBoxRegistrador.Location = new System.Drawing.Point(433, 165);
            this.TextBoxRegistrador.Name = "TextBoxRegistrador";
            this.TextBoxRegistrador.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRegistrador.TabIndex = 25;
            this.TextBoxRegistrador.TextChanged += new System.EventHandler(this.numericTextBox3_TextChanged);
            // 
            // TextBoxKWVueltas
            // 
            this.TextBoxKWVueltas.AllowSpace = false;
            this.TextBoxKWVueltas.Location = new System.Drawing.Point(433, 97);
            this.TextBoxKWVueltas.Name = "TextBoxKWVueltas";
            this.TextBoxKWVueltas.Size = new System.Drawing.Size(100, 20);
            this.TextBoxKWVueltas.TabIndex = 25;
            this.TextBoxKWVueltas.TextChanged += new System.EventHandler(this.numericTextBox3_TextChanged);
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.AllowSpace = false;
            this.numericTextBox1.Location = new System.Drawing.Point(433, 61);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(100, 20);
            this.numericTextBox1.TabIndex = 25;
            // 
            // TextBoxClase
            // 
            this.TextBoxClase.AllowSpace = false;
            this.TextBoxClase.Location = new System.Drawing.Point(110, 165);
            this.TextBoxClase.Name = "TextBoxClase";
            this.TextBoxClase.Size = new System.Drawing.Size(100, 20);
            this.TextBoxClase.TabIndex = 25;
            this.TextBoxClase.TextChanged += new System.EventHandler(this.numericTextBox2_TextChanged);
            // 
            // TextBoxCantHilos
            // 
            this.TextBoxCantHilos.AllowSpace = false;
            this.TextBoxCantHilos.Location = new System.Drawing.Point(110, 97);
            this.TextBoxCantHilos.Name = "TextBoxCantHilos";
            this.TextBoxCantHilos.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCantHilos.TabIndex = 25;
            this.TextBoxCantHilos.TextChanged += new System.EventHandler(this.numericTextBox2_TextChanged);
            // 
            // TextBoxDigitos
            // 
            this.TextBoxDigitos.AllowSpace = false;
            this.TextBoxDigitos.Location = new System.Drawing.Point(110, 61);
            this.TextBoxDigitos.Name = "TextBoxDigitos";
            this.TextBoxDigitos.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDigitos.TabIndex = 25;
            // 
            // lblRegistrador
            // 
            this.lblRegistrador.AutoSize = true;
            this.lblRegistrador.Location = new System.Drawing.Point(336, 168);
            this.lblRegistrador.Name = "lblRegistrador";
            this.lblRegistrador.Size = new System.Drawing.Size(64, 13);
            this.lblRegistrador.TabIndex = 22;
            this.lblRegistrador.Text = "Registrador:";
            this.lblRegistrador.Click += new System.EventHandler(this.lblEtiqueta2_Click);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(113, 348);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(73, 17);
            this.chkEstado.TabIndex = 5;
            this.chkEstado.Text = "Habilitado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblKWVueltas
            // 
            this.lblKWVueltas.AutoSize = true;
            this.lblKWVueltas.Location = new System.Drawing.Point(336, 100);
            this.lblKWVueltas.Name = "lblKWVueltas";
            this.lblKWVueltas.Size = new System.Drawing.Size(79, 13);
            this.lblKWVueltas.TabIndex = 22;
            this.lblKWVueltas.Text = "KW por Vuelta:";
            this.lblKWVueltas.Click += new System.EventHandler(this.lblEtiqueta2_Click);
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFabricante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(110, 236);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(165, 21);
            this.cmbFabricante.TabIndex = 3;
            // 
            // lblTipoConexion
            // 
            this.lblTipoConexion.AutoSize = true;
            this.lblTipoConexion.Location = new System.Drawing.Point(336, 203);
            this.lblTipoConexion.Name = "lblTipoConexion";
            this.lblTipoConexion.Size = new System.Drawing.Size(93, 13);
            this.lblTipoConexion.TabIndex = 22;
            this.lblTipoConexion.Text = "Tipo de Conexión:";
            this.lblTipoConexion.Click += new System.EventHandler(this.lblEtiqueta1_Click);
            // 
            // lblDecimales
            // 
            this.lblDecimales.AutoSize = true;
            this.lblDecimales.Location = new System.Drawing.Point(336, 64);
            this.lblDecimales.Name = "lblDecimales";
            this.lblDecimales.Size = new System.Drawing.Size(59, 13);
            this.lblDecimales.TabIndex = 22;
            this.lblDecimales.Text = "Decimales:";
            // 
            // lblTipoContador
            // 
            this.lblTipoContador.AutoSize = true;
            this.lblTipoContador.Location = new System.Drawing.Point(13, 203);
            this.lblTipoContador.Name = "lblTipoContador";
            this.lblTipoContador.Size = new System.Drawing.Size(92, 13);
            this.lblTipoContador.TabIndex = 22;
            this.lblTipoContador.Text = "Tipo de Contador:";
            this.lblTipoContador.Click += new System.EventHandler(this.lblEtiqueta1_Click);
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(13, 168);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(36, 13);
            this.lblClase.TabIndex = 22;
            this.lblClase.Text = "Clase:";
            this.lblClase.Click += new System.EventHandler(this.lblEtiqueta1_Click);
            // 
            // lblAmperaje
            // 
            this.lblAmperaje.AutoSize = true;
            this.lblAmperaje.Location = new System.Drawing.Point(13, 133);
            this.lblAmperaje.Name = "lblAmperaje";
            this.lblAmperaje.Size = new System.Drawing.Size(54, 13);
            this.lblAmperaje.TabIndex = 22;
            this.lblAmperaje.Text = "Amperaje:";
            this.lblAmperaje.Click += new System.EventHandler(this.lblEtiqueta1_Click);
            // 
            // lblCantHilos
            // 
            this.lblCantHilos.AutoSize = true;
            this.lblCantHilos.Location = new System.Drawing.Point(13, 100);
            this.lblCantHilos.Name = "lblCantHilos";
            this.lblCantHilos.Size = new System.Drawing.Size(91, 13);
            this.lblCantHilos.TabIndex = 22;
            this.lblCantHilos.Text = "Cantidad de hilos:";
            this.lblCantHilos.Click += new System.EventHandler(this.lblEtiqueta1_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 348);
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
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(13, 244);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(60, 13);
            this.lblParcela.TabIndex = 22;
            this.lblParcela.Text = "Fabricante:";
            // 
            // lblDescripcionCorta
            // 
            this.lblDescripcionCorta.AutoSize = true;
            this.lblDescripcionCorta.Location = new System.Drawing.Point(336, 29);
            this.lblDescripcionCorta.Name = "lblDescripcionCorta";
            this.lblDescripcionCorta.Size = new System.Drawing.Size(91, 13);
            this.lblDescripcionCorta.TabIndex = 21;
            this.lblDescripcionCorta.Text = "Descripción Corta";
            // 
            // txtDescripcionCorta
            // 
            this.txtDescripcionCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionCorta.Location = new System.Drawing.Point(433, 22);
            this.txtDescripcionCorta.MaxLength = 10;
            this.txtDescripcionCorta.Name = "txtDescripcionCorta";
            this.txtDescripcionCorta.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionCorta.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(110, 25);
            this.txtDescripcion.MaxLength = 30;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(165, 20);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(13, 33);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbDescripcion.TabIndex = 0;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // frmModelosMedidoresCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 488);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmModelosMedidoresCrud";
            this.Text = "frmModelosMedidoresCrud";
            this.Load += new System.EventHandler(this.frmModelosMedidoresCrud_Load);
            this.gesGroup2.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        private Controles.labels.lblEtiqueta lblParcela;
        private Controles.labels.lblEtiqueta lblDescripcionCorta;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcionCorta;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcion;
        private Controles.labels.lblEtiqueta lbDescripcion;
        private Controles.datos.cmbLista cmbFabricante;
        public Controles.contenedores.gesGroup gbDatos;
        private Controles.datos.chkBox chkEstado;
        private Controles.labels.lblEtiqueta lblEstado;
        private Controles.NumericTextBox TextBoxKWVueltas;
        private Controles.NumericTextBox numericTextBox1;
        private Controles.NumericTextBox TextBoxCantHilos;
        private Controles.NumericTextBox TextBoxDigitos;
        private Controles.labels.lblEtiqueta lblKWVueltas;
        private Controles.labels.lblEtiqueta lblDecimales;
        private Controles.labels.lblEtiqueta lblCantHilos;
        private Controles.labels.lblEtiqueta lblDigitos;
        private Controles.textBoxes.gesTextBox TextBoxAmperaje;
        private Controles.NumericTextBox TextBoxRegistrador;
        private Controles.NumericTextBox TextBoxClase;
        private Controles.labels.lblEtiqueta lblRegistrador;
        private Controles.labels.lblEtiqueta lblClase;
        private Controles.labels.lblEtiqueta lblAmperaje;
        private Controles.textBoxes.gesTextBox TextBoxTipoContador;
        private Controles.labels.lblEtiqueta lblTipoContador;
        private Controles.textBoxes.gesTextBox TextBoxTipoConexion;
        private Controles.labels.lblEtiqueta lblTipoConexion;
        private Controles.labels.lblEtiqueta lblTipoMedidor;
        private Controles.datos.cmbLista cmbTipoMedidor;
        private Controles.Fecha.dtpFecha dtpFechaCarga;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
    }
}