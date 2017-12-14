namespace FormsAuxiliares
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
            this.gesGroup1 = new Controles.contenedores.gesGroup();
            this.btnGeneral1 = new Controles.buttons.btnGeneral();
            this.lblEtiqueta3 = new Controles.labels.lblEtiqueta();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.txtDetalle = new Controles.textBoxes.txtObservaciones();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar1 = new Controles.buttons.btnCancelar();
            this.btnAceptar1 = new Controles.buttons.btnAceptar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gesGroup1.SuspendLayout();
            this.gesGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup1
            // 
            this.gesGroup1.Controls.Add(this.btnGeneral1);
            this.gesGroup1.Controls.Add(this.lblEtiqueta3);
            this.gesGroup1.Controls.Add(this.dtpFecha);
            this.gesGroup1.Controls.Add(this.lblEtiqueta2);
            this.gesGroup1.Controls.Add(this.txtDetalle);
            this.gesGroup1.Controls.Add(this.lblEtiqueta1);
            this.gesGroup1.Location = new System.Drawing.Point(12, 12);
            this.gesGroup1.Name = "gesGroup1";
            this.gesGroup1.Size = new System.Drawing.Size(504, 254);
            this.gesGroup1.TabIndex = 0;
            this.gesGroup1.TabStop = false;
            this.gesGroup1.Text = "Datos";
            // 
            // btnGeneral1
            // 
            this.btnGeneral1.Location = new System.Drawing.Point(122, 206);
            this.btnGeneral1.Name = "btnGeneral1";
            this.btnGeneral1.Size = new System.Drawing.Size(37, 33);
            this.btnGeneral1.TabIndex = 11;
            this.btnGeneral1.Text = "...";
            this.btnGeneral1.UseVisualStyleBackColor = true;
            this.btnGeneral1.Click += new System.EventHandler(this.btnGeneral1_Click);
            // 
            // lblEtiqueta3
            // 
            this.lblEtiqueta3.AutoSize = true;
            this.lblEtiqueta3.Location = new System.Drawing.Point(39, 226);
            this.lblEtiqueta3.Name = "lblEtiqueta3";
            this.lblEtiqueta3.Size = new System.Drawing.Size(62, 13);
            this.lblEtiqueta3.TabIndex = 10;
            this.lblEtiqueta3.Text = "lblEtiqueta3";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(122, 27);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(96, 20);
            this.dtpFecha.TabIndex = 9;
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(39, 34);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(62, 13);
            this.lblEtiqueta2.TabIndex = 3;
            this.lblEtiqueta2.Text = "lblEtiqueta2";
            // 
            // txtDetalle
            // 
            this.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetalle.Location = new System.Drawing.Point(122, 63);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(364, 137);
            this.txtDetalle.TabIndex = 1;
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(39, 66);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(62, 13);
            this.lblEtiqueta1.TabIndex = 0;
            this.lblEtiqueta1.Text = "lblEtiqueta1";
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar1);
            this.gesGroup2.Controls.Add(this.btnAceptar1);
            this.gesGroup2.Location = new System.Drawing.Point(12, 272);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(504, 89);
            this.gesGroup2.TabIndex = 1;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar1.Image")));
            this.btnCancelar1.Location = new System.Drawing.Point(309, 14);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar1.TabIndex = 1;
            this.btnCancelar1.Text = "btnCancelar1";
            this.btnCancelar1.UseVisualStyleBackColor = true;
            // 
            // btnAceptar1
            // 
            this.btnAceptar1.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar1.Image")));
            this.btnAceptar1.Location = new System.Drawing.Point(418, 14);
            this.btnAceptar1.Name = "btnAceptar1";
            this.btnAceptar1.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar1.TabIndex = 0;
            this.btnAceptar1.Text = "btnAceptar1";
            this.btnAceptar1.UseVisualStyleBackColor = true;
            this.btnAceptar1.Click += new System.EventHandler(this.btnAceptar1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmObservacionesCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 373);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gesGroup1);
            this.Name = "frmObservacionesCrud";
            this.Text = "frmObservacionesCrud";
            this.Load += new System.EventHandler(this.frmObservacionesCrud_Load);
            this.gesGroup1.ResumeLayout(false);
            this.gesGroup1.PerformLayout();
            this.gesGroup2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gesGroup gesGroup1;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.textBoxes.txtObservaciones txtDetalle;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar1;
        private Controles.buttons.btnAceptar btnAceptar1;
        private Controles.labels.lblEtiqueta lblEtiqueta3;
        private Controles.buttons.btnGeneral btnGeneral1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}