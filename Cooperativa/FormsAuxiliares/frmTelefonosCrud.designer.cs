﻿namespace FormsAuxiliares
{
    partial class frmTelefonosCrud
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelefonosCrud));
            this.gesControles = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gesDatos = new Controles.contenedores.gesGroup();
            this.txtEmail = new Controles.textBoxes.txtEmail();
            this.cmbCargo = new Controles.datos.cmbLista();
            this.lblEtiqueta4 = new Controles.labels.lblEtiqueta();
            this.cmbTipo = new Controles.datos.cmbLista();
            this.chkPorDefecto = new Controles.datos.chkBox();
            this.txtNombreContacto = new Controles.textBoxes.txtDescripcion();
            this.lblEtiqueta3 = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.txtNumeroTelefono = new Controles.textBoxes.txtDescripcionCorta();
            this.lblNumeroTelefono = new Controles.labels.lblEtiqueta();
            this.tttEtiqueta = new Controles.objects.tttEtiqueta();
            this.gesControles.SuspendLayout();
            this.gesDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesControles
            // 
            this.gesControles.Controls.Add(this.btnCancelar);
            this.gesControles.Controls.Add(this.btnAceptar);
            this.gesControles.Location = new System.Drawing.Point(8, 190);
            this.gesControles.Name = "gesControles";
            this.gesControles.Size = new System.Drawing.Size(504, 89);
            this.gesControles.TabIndex = 3;
            this.gesControles.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(309, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(418, 14);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gesDatos
            // 
            this.gesDatos.Controls.Add(this.txtEmail);
            this.gesDatos.Controls.Add(this.cmbCargo);
            this.gesDatos.Controls.Add(this.lblEtiqueta4);
            this.gesDatos.Controls.Add(this.cmbTipo);
            this.gesDatos.Controls.Add(this.chkPorDefecto);
            this.gesDatos.Controls.Add(this.txtNombreContacto);
            this.gesDatos.Controls.Add(this.lblEtiqueta3);
            this.gesDatos.Controls.Add(this.lblEtiqueta2);
            this.gesDatos.Controls.Add(this.lblEtiqueta1);
            this.gesDatos.Controls.Add(this.txtNumeroTelefono);
            this.gesDatos.Controls.Add(this.lblNumeroTelefono);
            this.gesDatos.Location = new System.Drawing.Point(8, 5);
            this.gesDatos.Name = "gesDatos";
            this.gesDatos.Size = new System.Drawing.Size(504, 175);
            this.gesDatos.TabIndex = 2;
            this.gesDatos.TabStop = false;
            this.gesDatos.Text = "Datos";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 95);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(100, 52);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(167, 21);
            this.cmbCargo.TabIndex = 2;
            // 
            // lblEtiqueta4
            // 
            this.lblEtiqueta4.AutoSize = true;
            this.lblEtiqueta4.Location = new System.Drawing.Point(297, 64);
            this.lblEtiqueta4.Name = "lblEtiqueta4";
            this.lblEtiqueta4.Size = new System.Drawing.Size(28, 13);
            this.lblEtiqueta4.TabIndex = 13;
            this.lblEtiqueta4.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(360, 56);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 6;
            // 
            // chkPorDefecto
            // 
            this.chkPorDefecto.AutoSize = true;
            this.chkPorDefecto.Location = new System.Drawing.Point(300, 21);
            this.chkPorDefecto.Name = "chkPorDefecto";
            this.chkPorDefecto.Size = new System.Drawing.Size(83, 17);
            this.chkPorDefecto.TabIndex = 5;
            this.chkPorDefecto.Text = "Por Defecto";
            this.chkPorDefecto.UseVisualStyleBackColor = true;
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreContacto.Location = new System.Drawing.Point(100, 133);
            this.txtNombreContacto.MaxLength = 50;
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(167, 20);
            this.txtNombreContacto.TabIndex = 4;
            // 
            // lblEtiqueta3
            // 
            this.lblEtiqueta3.AutoSize = true;
            this.lblEtiqueta3.Location = new System.Drawing.Point(4, 136);
            this.lblEtiqueta3.Name = "lblEtiqueta3";
            this.lblEtiqueta3.Size = new System.Drawing.Size(90, 13);
            this.lblEtiqueta3.TabIndex = 11;
            this.lblEtiqueta3.Text = "Nombre Contacto";
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(4, 98);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(32, 13);
            this.lblEtiqueta2.TabIndex = 10;
            this.lblEtiqueta2.Text = "Email";
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(4, 60);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(35, 13);
            this.lblEtiqueta1.TabIndex = 9;
            this.lblEtiqueta1.Text = "Cargo";
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroTelefono.Location = new System.Drawing.Point(100, 19);
            this.txtNumeroTelefono.MaxLength = 20;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(167, 20);
            this.txtNumeroTelefono.TabIndex = 1;
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Location = new System.Drawing.Point(4, 22);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(72, 13);
            this.lblNumeroTelefono.TabIndex = 8;
            this.lblNumeroTelefono.Text = "Nro. Telefono";
            // 
            // frmTelefonosCrud
            // 
            this.ClientSize = new System.Drawing.Size(519, 288);
            this.Controls.Add(this.gesControles);
            this.Controls.Add(this.gesDatos);
            this.Name = "frmTelefonosCrud";
            this.Load += new System.EventHandler(this.frmTelefonosCrud_Load);
            this.gesControles.ResumeLayout(false);
            this.gesDatos.ResumeLayout(false);
            this.gesDatos.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private Controles.contenedores.gesGroup gesControles;
        private Controles.contenedores.gesGroup gesDatos;

        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;

        private Controles.labels.lblEtiqueta lblNumeroTelefono;               
        private Controles.labels.lblEtiqueta lblEtiqueta3;        
        private Controles.labels.lblEtiqueta lblEtiqueta2;        
        private Controles.labels.lblEtiqueta lblEtiqueta1;

        private Controles.datos.chkBox chkPorDefecto;
        private Controles.textBoxes.txtDescripcionCorta txtNumeroTelefono;
        private Controles.textBoxes.txtDescripcion txtNombreContacto;
        private Controles.datos.cmbLista cmbTipo;
        private Controles.labels.lblEtiqueta lblEtiqueta4;
        private Controles.datos.cmbLista cmbCargo;
        private Controles.textBoxes.txtEmail txtEmail;
        private Controles.objects.tttEtiqueta tttEtiqueta;
    }
}