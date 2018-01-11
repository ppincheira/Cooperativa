namespace UI
{
    partial class Form1
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
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCrudGrilla = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPersonalizado4 = new Controles.btnPersonalizado();
            this.btnPersonalizado3 = new Controles.btnPersonalizado();
            this.btnPersonalizado2 = new Controles.btnPersonalizado();
            this.btnPersonalizado1 = new Controles.btnPersonalizado();
            this.lblPersonalizado1 = new Controles.lblPersonalizado();
            this.numericTextBox1 = new Controles.NumericTextBox();
            this.txtPersonalizado1 = new Controles.txtFiltro();
            this.btnPersonalizado5 = new Controles.btnPersonalizado();
            this.btnPersonalizado6 = new Controles.btnPersonalizado();
            this.btnPersonalizado7 = new Controles.btnPersonalizado();
            this.btnPersonalizado8 = new Controles.btnPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTest
            // 
            this.dgvTest.Location = new System.Drawing.Point(12, 306);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.Size = new System.Drawing.Size(240, 150);
            this.dgvTest.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = " BUSCADOR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCrudGrilla
            // 
            this.buttonCrudGrilla.Location = new System.Drawing.Point(342, 248);
            this.buttonCrudGrilla.Name = "buttonCrudGrilla";
            this.buttonCrudGrilla.Size = new System.Drawing.Size(125, 32);
            this.buttonCrudGrilla.TabIndex = 8;
            this.buttonCrudGrilla.Text = "CrudGrilla";
            this.buttonCrudGrilla.UseVisualStyleBackColor = true;
            this.buttonCrudGrilla.Click += new System.EventHandler(this.buttonCrudGrilla_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "OBSERVACIONES";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(342, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 27);
            this.button3.TabIndex = 11;
            this.button3.Text = "RUTAS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPersonalizado4
            // 
            this.btnPersonalizado4.ForeColor = System.Drawing.Color.Green;
            this.btnPersonalizado4.Location = new System.Drawing.Point(342, 139);
            this.btnPersonalizado4.Name = "btnPersonalizado4";
            this.btnPersonalizado4.Size = new System.Drawing.Size(125, 23);
            this.btnPersonalizado4.TabIndex = 12;
            this.btnPersonalizado4.Text = "CALLES";
            this.btnPersonalizado4.UseVisualStyleBackColor = true;
            this.btnPersonalizado4.Click += new System.EventHandler(this.btnPersonalizado4_Click);
            // 
            // btnPersonalizado3
            // 
            this.btnPersonalizado3.ForeColor = System.Drawing.Color.Green;
            this.btnPersonalizado3.Location = new System.Drawing.Point(12, 263);
            this.btnPersonalizado3.Name = "btnPersonalizado3";
            this.btnPersonalizado3.Size = new System.Drawing.Size(100, 37);
            this.btnPersonalizado3.TabIndex = 9;
            this.btnPersonalizado3.Text = "observaciones";
            this.btnPersonalizado3.UseVisualStyleBackColor = true;
            this.btnPersonalizado3.Click += new System.EventHandler(this.btnPersonalizado3_Click);
            // 
            // btnPersonalizado2
            // 
            this.btnPersonalizado2.ForeColor = System.Drawing.Color.Green;
            this.btnPersonalizado2.Location = new System.Drawing.Point(342, 110);
            this.btnPersonalizado2.Name = "btnPersonalizado2";
            this.btnPersonalizado2.Size = new System.Drawing.Size(125, 23);
            this.btnPersonalizado2.TabIndex = 7;
            this.btnPersonalizado2.Text = "DOMICILIOS";
            this.btnPersonalizado2.UseVisualStyleBackColor = true;
            this.btnPersonalizado2.Click += new System.EventHandler(this.btnPersonalizado2_Click);
            // 
            // btnPersonalizado1
            // 
            this.btnPersonalizado1.ForeColor = System.Drawing.Color.Green;
            this.btnPersonalizado1.Location = new System.Drawing.Point(12, 86);
            this.btnPersonalizado1.Name = "btnPersonalizado1";
            this.btnPersonalizado1.Size = new System.Drawing.Size(129, 23);
            this.btnPersonalizado1.TabIndex = 6;
            this.btnPersonalizado1.Text = "btnPersonalizado1";
            this.btnPersonalizado1.UseVisualStyleBackColor = true;
            this.btnPersonalizado1.Click += new System.EventHandler(this.btnPersonalizado1_Click);
            // 
            // lblPersonalizado1
            // 
            this.lblPersonalizado1.AutoSize = true;
            this.lblPersonalizado1.ForeColor = System.Drawing.Color.Red;
            this.lblPersonalizado1.Location = new System.Drawing.Point(89, 195);
            this.lblPersonalizado1.Name = "lblPersonalizado1";
            this.lblPersonalizado1.Size = new System.Drawing.Size(89, 13);
            this.lblPersonalizado1.TabIndex = 5;
            this.lblPersonalizado1.Text = "lblPersonalizado1";
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.AllowSpace = false;
            this.numericTextBox1.Location = new System.Drawing.Point(107, 137);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(100, 20);
            this.numericTextBox1.TabIndex = 1;
            // 
            // txtPersonalizado1
            // 
            this.txtPersonalizado1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPersonalizado1.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtPersonalizado1.Location = new System.Drawing.Point(62, 44);
            this.txtPersonalizado1.Name = "txtPersonalizado1";
            this.txtPersonalizado1.Size = new System.Drawing.Size(146, 20);
            this.txtPersonalizado1.TabIndex = 0;
            this.txtPersonalizado1.TextoVacio = "<Descripcion>";
            // 
            // btnPersonalizado5
            // 
            this.btnPersonalizado5.ForeColor = System.Drawing.Color.Green;
            this.btnPersonalizado5.Location = new System.Drawing.Point(342, 44);
            this.btnPersonalizado5.Name = "btnPersonalizado5";
            this.btnPersonalizado5.Size = new System.Drawing.Size(125, 23);
            this.btnPersonalizado5.TabIndex = 13;
            this.btnPersonalizado5.Text = "Telefonos";
            this.btnPersonalizado5.UseVisualStyleBackColor = true;
            this.btnPersonalizado5.Click += new System.EventHandler(this.btnPersonalizado5_Click);
            // 
            // btnPersonalizado6
            // 
            this.btnPersonalizado6.ForeColor = System.Drawing.Color.Green;
            this.btnPersonalizado6.Location = new System.Drawing.Point(342, 80);
            this.btnPersonalizado6.Name = "btnPersonalizado6";
            this.btnPersonalizado6.Size = new System.Drawing.Size(125, 23);
            this.btnPersonalizado6.TabIndex = 14;
            this.btnPersonalizado6.Text = "CODIGO POSTAL";
            this.btnPersonalizado6.UseVisualStyleBackColor = true;
            this.btnPersonalizado6.Click += new System.EventHandler(this.btnPersonalizado6_Click);
            // 
            // btnPersonalizado7
            // 
            this.btnPersonalizado7.ForeColor = System.Drawing.Color.Green;
            this.btnPersonalizado7.Location = new System.Drawing.Point(342, 319);
            this.btnPersonalizado7.Name = "btnPersonalizado7";
            this.btnPersonalizado7.Size = new System.Drawing.Size(125, 23);
            this.btnPersonalizado7.TabIndex = 15;
            this.btnPersonalizado7.Text = "Tipos Medidores";
            this.btnPersonalizado7.UseVisualStyleBackColor = true;
            this.btnPersonalizado7.Click += new System.EventHandler(this.btnPersonalizado7_Click);
            // 
            // btnPersonalizado8
            // 
            this.btnPersonalizado8.ForeColor = System.Drawing.Color.Green;
            this.btnPersonalizado8.Location = new System.Drawing.Point(342, 348);
            this.btnPersonalizado8.Name = "btnPersonalizado8";
            this.btnPersonalizado8.Size = new System.Drawing.Size(125, 23);
            this.btnPersonalizado8.TabIndex = 16;
            this.btnPersonalizado8.Text = "Distritos";
            this.btnPersonalizado8.UseVisualStyleBackColor = true;
            this.btnPersonalizado8.Click += new System.EventHandler(this.btnPersonalizado8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 468);
            this.Controls.Add(this.btnPersonalizado8);
            this.Controls.Add(this.btnPersonalizado7);
            this.Controls.Add(this.btnPersonalizado6);
            this.Controls.Add(this.btnPersonalizado5);
            this.Controls.Add(this.btnPersonalizado4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPersonalizado3);
            this.Controls.Add(this.buttonCrudGrilla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTest);
            this.Controls.Add(this.btnPersonalizado2);
            this.Controls.Add(this.btnPersonalizado1);
            this.Controls.Add(this.lblPersonalizado1);
            this.Controls.Add(this.numericTextBox1);
            this.Controls.Add(this.txtPersonalizado1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.txtFiltro txtPersonalizado1;
        private Controles.NumericTextBox numericTextBox1;
        private Controles.lblPersonalizado lblPersonalizado1;
        private Controles.btnPersonalizado btnPersonalizado1;
        private Controles.btnPersonalizado btnPersonalizado2;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.Button button1;
        private Controles.btnPersonalizado btnPersonalizado3;
        private System.Windows.Forms.Button buttonCrudGrilla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Controles.btnPersonalizado btnPersonalizado4;
        private Controles.btnPersonalizado btnPersonalizado5;
        private Controles.btnPersonalizado btnPersonalizado6;
        private Controles.btnPersonalizado btnPersonalizado7;
        private Controles.btnPersonalizado btnPersonalizado8;
    }
}

