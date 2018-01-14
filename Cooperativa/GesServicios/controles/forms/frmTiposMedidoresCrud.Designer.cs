namespace GesServicios.controles.forms
{
    partial class frmTiposMedidoresCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposMedidoresCrud));
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.chkEstado = new Controles.datos.chkBox();
            this.lblServicios = new Controles.labels.lblEtiqueta();
            this.cmbSRVCodigo = new Controles.datos.cmbLista();
            this.txtTMEDescripcionCorta = new Controles.textBoxes.txtDescripcionCorta();
            this.lblFechaCarga = new Controles.labels.lblEtiqueta();
            this.lblDescripcionCorta = new Controles.labels.lblTitulo();
            this.dtpFechaCarga = new Controles.Fecha.dtpFecha();
            this.txtTMEDescripcion = new Controles.textBoxes.txtDescripcion();
            this.lblDescripcion = new Controles.labels.lblEtiqueta();
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos.SuspendLayout();
            this.gesGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.chkEstado);
            this.gbDatos.Controls.Add(this.lblServicios);
            this.gbDatos.Controls.Add(this.cmbSRVCodigo);
            this.gbDatos.Controls.Add(this.txtTMEDescripcionCorta);
            this.gbDatos.Controls.Add(this.lblFechaCarga);
            this.gbDatos.Controls.Add(this.lblDescripcionCorta);
            this.gbDatos.Controls.Add(this.dtpFechaCarga);
            this.gbDatos.Controls.Add(this.txtTMEDescripcion);
            this.gbDatos.Controls.Add(this.lblDescripcion);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(243, 241);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(6, 218);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(73, 17);
            this.chkEstado.TabIndex = 39;
            this.chkEstado.Text = "Habilitado";
            this.chkEstado.UseVisualStyleBackColor = true;
            this.chkEstado.CheckedChanged += new System.EventHandler(this.chkEstado_CheckedChanged);
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Location = new System.Drawing.Point(9, 101);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(48, 13);
            this.lblServicios.TabIndex = 35;
            this.lblServicios.Text = "Servicio:";
            // 
            // cmbSRVCodigo
            // 
            this.cmbSRVCodigo.FormattingEnabled = true;
            this.cmbSRVCodigo.Items.AddRange(new object[] {
            "Energia Electrica",
            "Agua"});
            this.cmbSRVCodigo.Location = new System.Drawing.Point(12, 117);
            this.cmbSRVCodigo.Name = "cmbSRVCodigo";
            this.cmbSRVCodigo.Size = new System.Drawing.Size(224, 21);
            this.cmbSRVCodigo.TabIndex = 3;
            // 
            // txtTMEDescripcionCorta
            // 
            this.txtTMEDescripcionCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTMEDescripcionCorta.Location = new System.Drawing.Point(12, 38);
            this.txtTMEDescripcionCorta.MaxLength = 5;
            this.txtTMEDescripcionCorta.Name = "txtTMEDescripcionCorta";
            this.txtTMEDescripcionCorta.Size = new System.Drawing.Size(224, 20);
            this.txtTMEDescripcionCorta.TabIndex = 1;
            // 
            // lblFechaCarga
            // 
            this.lblFechaCarga.AutoSize = true;
            this.lblFechaCarga.Location = new System.Drawing.Point(9, 141);
            this.lblFechaCarga.Name = "lblFechaCarga";
            this.lblFechaCarga.Size = new System.Drawing.Size(86, 13);
            this.lblFechaCarga.TabIndex = 32;
            this.lblFechaCarga.Text = "Fecha de Carga:";
            // 
            // lblDescripcionCorta
            // 
            this.lblDescripcionCorta.AutoSize = true;
            this.lblDescripcionCorta.Location = new System.Drawing.Point(9, 22);
            this.lblDescripcionCorta.Name = "lblDescripcionCorta";
            this.lblDescripcionCorta.Size = new System.Drawing.Size(94, 13);
            this.lblDescripcionCorta.TabIndex = 31;
            this.lblDescripcionCorta.Text = "Descripcion Corta:";
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.Location = new System.Drawing.Point(12, 157);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Size = new System.Drawing.Size(224, 20);
            this.dtpFechaCarga.TabIndex = 30;
            // 
            // txtTMEDescripcion
            // 
            this.txtTMEDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTMEDescripcion.Location = new System.Drawing.Point(12, 77);
            this.txtTMEDescripcion.MaxLength = 50;
            this.txtTMEDescripcion.Multiline = true;
            this.txtTMEDescripcion.Name = "txtTMEDescripcion";
            this.txtTMEDescripcion.Size = new System.Drawing.Size(224, 21);
            this.txtTMEDescripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(9, 61);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 27;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(12, 259);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(243, 89);
            this.gesGroup2.TabIndex = 4;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(12, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 77;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(156, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmTiposMedidoresCrud
            // 
            this.ClientSize = new System.Drawing.Size(260, 358);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmTiposMedidoresCrud";
            this.Text = "Tipos de Medidores";
            this.Load += new System.EventHandler(this.frmTiposMedidoresCrud_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gesGroup2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Controles.contenedores.gesGroup gbDatos;
        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        private Controles.textBoxes.txtDescripcion txtTMEDescripcion;
        private Controles.labels.lblEtiqueta lblDescripcion;
        private Controles.labels.lblTitulo lblDescripcionCorta;
        private Controles.Fecha.dtpFecha dtpFechaCarga;
        private Controles.textBoxes.txtDescripcionCorta txtTMEDescripcionCorta;
        private Controles.labels.lblEtiqueta lblFechaCarga;
        private Controles.labels.lblEtiqueta lblServicios;
        private Controles.datos.cmbLista cmbSRVCodigo;
        private Controles.datos.chkBox chkEstado;
    }
}