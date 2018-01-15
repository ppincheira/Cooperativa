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
<<<<<<< HEAD
            this.btnPersonalizado8 = new Controles.btnPersonalizado();
            this.btnPersonalizado9 = new Controles.btnPersonalizado();
=======
            this.btnPersonalizado5 = new Controles.btnPersonalizado();
            this.btnPersonalizado6 = new Controles.btnPersonalizado();
            this.btnPersonalizado7 = new Controles.btnPersonalizado();
            this.gesTextBox1 = new Controles.textBoxes.gesTextBox();
            this.gesTextBox2 = new Controles.textBoxes.gesTextBox();
            this.gesTextBox3 = new Controles.textBoxes.gesTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
>>>>>>> ace1f2deb870a45a5d8fbc87e8c570538f4ad4e8
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
<<<<<<< HEAD
            // gesTextBox3
            // 
            this.gesTextBox3.BackColor = System.Drawing.Color.Red;
            this.gesTextBox3.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBox3.Location = new System.Drawing.Point(164, 168);
            this.gesTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.gesTextBox3.Name = "gesTextBox3";
            this.gesTextBox3.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.gesTextBox3.Size = new System.Drawing.Size(76, 20);
            this.gesTextBox3.TabIndex = 18;
            this.gesTextBox3.TextoVacio = "<Descripcion>";
            this.gesTextBox3.TipoControl = Controles.util.Enumerados.enumTipos.Email;
            // 
            // gesTextBox2
            // 
            this.gesTextBox2.BackColor = System.Drawing.Color.Red;
            this.gesTextBox2.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBox2.Location = new System.Drawing.Point(164, 143);
            this.gesTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.gesTextBox2.Name = "gesTextBox2";
            this.gesTextBox2.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.gesTextBox2.Size = new System.Drawing.Size(76, 20);
            this.gesTextBox2.TabIndex = 17;
            this.gesTextBox2.TextoVacio = "<Descripcion>";
            this.gesTextBox2.TipoControl = Controles.util.Enumerados.enumTipos.TelefonoConArea;
            // 
            // gesTextBox1
            // 
            this.gesTextBox1.BackColor = System.Drawing.Color.Red;
            this.gesTextBox1.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBox1.Location = new System.Drawing.Point(147, 110);
            this.gesTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gesTextBox1.Name = "gesTextBox1";
            this.gesTextBox1.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.gesTextBox1.Size = new System.Drawing.Size(76, 20);
            this.gesTextBox1.TabIndex = 16;
            this.gesTextBox1.TextoVacio = "<Descripcion>";
            this.gesTextBox1.TipoControl = Controles.util.Enumerados.enumTipos.Fecha;
            // 
            // btnPersonalizado7
            // 
            this.btnPersonalizado7.ForeColor = System.Drawing.Color.Green;
            this.btnPersonalizado7.Location = new System.Drawing.Point(342, 22);
            this.btnPersonalizado7.Name = "btnPersonalizado7";
            this.btnPersonalizado7.Size = new System.Drawing.Size(125, 23);
            this.btnPersonalizado7.TabIndex = 15;
            this.btnPersonalizado7.Text = "CLIENTES";
            this.btnPersonalizado7.UseVisualStyleBackColor = true;
            this.btnPersonalizado7.Click += new System.EventHandler(this.btnPersonalizado7_Click);
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
            // btnPersonalizado5
            // 
            this.btnPersonalizado5.ForeColor = System.Drawing.Color.Green;
            this.btnPersonalizado5.Location = new System.Drawing.Point(342, 51);
            this.btnPersonalizado5.Name = "btnPersonalizado5";
            this.btnPersonalizado5.Size = new System.Drawing.Size(125, 23);
            this.btnPersonalizado5.TabIndex = 13;
            this.btnPersonalizado5.Text = "TELEFONOS";
            this.btnPersonalizado5.UseVisualStyleBackColor = true;
            this.btnPersonalizado5.Click += new System.EventHandler(this.btnPersonalizado5_Click);
            // 
=======
>>>>>>> ace1f2deb870a45a5d8fbc87e8c570538f4ad4e8
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
            // btnPersonalizado5
            // 
            this.btnPersonalizado5.ForeColor = System.Drawing.Color.Green;
            this.btnPersonalizado5.Location = new System.Drawing.Point(342, 51);
            this.btnPersonalizado5.Name = "btnPersonalizado5";
            this.btnPersonalizado5.Size = new System.Drawing.Size(125, 23);
            this.btnPersonalizado5.TabIndex = 13;
            this.btnPersonalizado5.Text = "TELEFONOS";
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
            this.btnPersonalizado7.Location = new System.Drawing.Point(342, 22);
            this.btnPersonalizado7.Name = "btnPersonalizado7";
            this.btnPersonalizado7.Size = new System.Drawing.Size(125, 23);
            this.btnPersonalizado7.TabIndex = 15;
            this.btnPersonalizado7.Text = "CLIENTES";
            this.btnPersonalizado7.UseVisualStyleBackColor = true;
            this.btnPersonalizado7.Click += new System.EventHandler(this.btnPersonalizado7_Click);
            // 
            // gesTextBox1
            // 
            this.gesTextBox1.BackColor = System.Drawing.Color.White;
            this.gesTextBox1.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBox1.Location = new System.Drawing.Point(147, 110);
            this.gesTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gesTextBox1.Name = "gesTextBox1";
            this.gesTextBox1.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.gesTextBox1.Size = new System.Drawing.Size(76, 20);
            this.gesTextBox1.TabIndex = 16;
            this.gesTextBox1.TextoVacio = "<Descripcion>";
            this.gesTextBox1.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            this.gesTextBox1.TextChanged += new System.EventHandler(this.gesTextBox1_TextChanged_1);
            // 
            // gesTextBox2
            // 
            this.gesTextBox2.BackColor = System.Drawing.Color.White;
            this.gesTextBox2.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBox2.Location = new System.Drawing.Point(164, 143);
            this.gesTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.gesTextBox2.Name = "gesTextBox2";
            this.gesTextBox2.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.gesTextBox2.Size = new System.Drawing.Size(76, 20);
            this.gesTextBox2.TabIndex = 17;
            this.gesTextBox2.TextoVacio = "<Descripcion>";
            this.gesTextBox2.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // gesTextBox3
            // 
            this.gesTextBox3.BackColor = System.Drawing.Color.White;
            this.gesTextBox3.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBox3.Location = new System.Drawing.Point(164, 168);
            this.gesTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.gesTextBox3.Name = "gesTextBox3";
            this.gesTextBox3.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.gesTextBox3.Size = new System.Drawing.Size(76, 20);
            this.gesTextBox3.TabIndex = 18;
            this.gesTextBox3.TextoVacio = "<Descripcion>";
            this.gesTextBox3.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(342, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 27);
            this.button4.TabIndex = 19;
            this.button4.Text = "Tipos de Medidores";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(342, 352);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 27);
            this.button5.TabIndex = 20;
            this.button5.Text = "Fabricantes";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPersonalizado9
            // 
            this.btnPersonalizado9.ForeColor = System.Drawing.Color.Green;
            this.btnPersonalizado9.Location = new System.Drawing.Point(342, 214);
            this.btnPersonalizado9.Name = "btnPersonalizado9";
            this.btnPersonalizado9.Size = new System.Drawing.Size(125, 23);
            this.btnPersonalizado9.TabIndex = 7;
            this.btnPersonalizado9.Text = "MEDIDORES";
            this.btnPersonalizado9.UseVisualStyleBackColor = true;
            this.btnPersonalizado9.Click += new System.EventHandler(this.btnPersonalizado8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 468);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.gesTextBox3);
            this.Controls.Add(this.gesTextBox2);
            this.Controls.Add(this.gesTextBox1);
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
<<<<<<< HEAD
            this.Controls.Add(this.btnPersonalizado9);
            this.Controls.Add(this.btnPersonalizado8);
=======
>>>>>>> ace1f2deb870a45a5d8fbc87e8c570538f4ad4e8
            this.Controls.Add(this.btnPersonalizado2);
            this.Controls.Add(this.btnPersonalizado1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Controles.textBoxes.gesTextBox gesTextBox1;
        private Controles.textBoxes.gesTextBox gesTextBox2;
        private Controles.textBoxes.gesTextBox gesTextBox3;
<<<<<<< HEAD
        private Controles.btnPersonalizado btnPersonalizado8;
        private Controles.btnPersonalizado btnPersonalizado9;
=======
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
>>>>>>> ace1f2deb870a45a5d8fbc87e8c570538f4ad4e8
    }
}

