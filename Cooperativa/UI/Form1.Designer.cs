﻿namespace UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersonalizado1 = new Controles.lblPersonalizado();
            this.numericTextBox1 = new Controles.NumericTextBox();
            this.txtPersonalizado1 = new Controles.txtFiltro();
            this.btnPersonalizado1 = new Controles.btnPersonalizado();
            this.btnPersonalizado2 = new Controles.btnPersonalizado();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPersonalizado3 = new Controles.btnPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
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
            // btnPersonalizado1
            // 
            this.btnPersonalizado1.ForeColor = System.Drawing.Color.Green;
            this.btnPersonalizado1.Location = new System.Drawing.Point(274, 81);
            this.btnPersonalizado1.Name = "btnPersonalizado1";
            this.btnPersonalizado1.Size = new System.Drawing.Size(129, 23);
            this.btnPersonalizado1.TabIndex = 6;
            this.btnPersonalizado1.Text = "btnPersonalizado1";
            this.btnPersonalizado1.UseVisualStyleBackColor = true;
            this.btnPersonalizado1.Click += new System.EventHandler(this.btnPersonalizado1_Click);
            // 
            // btnPersonalizado2
            // 
            this.btnPersonalizado2.ForeColor = System.Drawing.Color.Green;
            this.btnPersonalizado2.Location = new System.Drawing.Point(345, 206);
            this.btnPersonalizado2.Name = "btnPersonalizado2";
            this.btnPersonalizado2.Size = new System.Drawing.Size(100, 23);
            this.btnPersonalizado2.TabIndex = 7;
            this.btnPersonalizado2.Text = "btnPersonalizado2";
            this.btnPersonalizado2.UseVisualStyleBackColor = true;
            this.btnPersonalizado2.Click += new System.EventHandler(this.btnPersonalizado2_Click);
            // 
            // dgvTest
            // 
            this.dgvTest.Location = new System.Drawing.Point(107, 279);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.Size = new System.Drawing.Size(240, 150);
            this.dgvTest.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPersonalizado3
            // 
            this.btnPersonalizado3.ForeColor = System.Drawing.Color.Green;
            this.btnPersonalizado3.Location = new System.Drawing.Point(47, 241);
            this.btnPersonalizado3.Name = "btnPersonalizado3";
            this.btnPersonalizado3.Size = new System.Drawing.Size(100, 23);
            this.btnPersonalizado3.TabIndex = 9;
            this.btnPersonalizado3.Text = "observaciones";
            this.btnPersonalizado3.UseVisualStyleBackColor = true;
            this.btnPersonalizado3.Click += new System.EventHandler(this.btnPersonalizado3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 468);
            this.Controls.Add(this.btnPersonalizado3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTest);
            this.Controls.Add(this.btnPersonalizado2);
            this.Controls.Add(this.btnPersonalizado1);
            this.Controls.Add(this.lblPersonalizado1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private Controles.lblPersonalizado lblPersonalizado1;
        private Controles.btnPersonalizado btnPersonalizado1;
        private Controles.btnPersonalizado btnPersonalizado2;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.Button button1;
        private Controles.btnPersonalizado btnPersonalizado3;
    }
}

