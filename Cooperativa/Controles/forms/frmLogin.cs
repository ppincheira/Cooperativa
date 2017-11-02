using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
namespace Controles
{
    public partial class frmLogin: gesForm
    {
        private contenedores.gpbGrupo gpbGrupo2;
        private buttons.btnCancelar btnCancelar;
        private buttons.btnAceptar btnAceptar;
        private textBoxes.txtDescripcionCorta txtUsuario;
        private textBoxes.txtPassword txtPassword;
        private labels.lblEtiqueta lblEtiqueta1;
        private labels.lblEtiqueta lblEtiqueta2;
        private contenedores.gpbGrupo gpbGrupo1;

        public frmLogin(string modulo)
        {
            this.Text = "LOGIN";
            InitializeComponent();
            

        }

        private void InitializeComponent()
        {
            this.gpbGrupo1 = new Controles.contenedores.gpbGrupo();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.txtPassword = new Controles.textBoxes.txtPassword();
            this.txtUsuario = new Controles.textBoxes.txtDescripcionCorta();
            this.gpbGrupo2 = new Controles.contenedores.gpbGrupo();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gpbGrupo1.SuspendLayout();
            this.gpbGrupo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbGrupo1
            // 
            this.gpbGrupo1.Controls.Add(this.lblEtiqueta2);
            this.gpbGrupo1.Controls.Add(this.lblEtiqueta1);
            this.gpbGrupo1.Controls.Add(this.txtPassword);
            this.gpbGrupo1.Controls.Add(this.txtUsuario);
            this.gpbGrupo1.Location = new System.Drawing.Point(12, 12);
            this.gpbGrupo1.Name = "gpbGrupo1";
            this.gpbGrupo1.Size = new System.Drawing.Size(319, 119);
            this.gpbGrupo1.TabIndex = 0;
            this.gpbGrupo1.TabStop = false;
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(21, 74);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(61, 13);
            this.lblEtiqueta2.TabIndex = 3;
            this.lblEtiqueta2.Text = "Contraseña";
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(21, 36);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(43, 13);
            this.lblEtiqueta1.TabIndex = 2;
            this.lblEtiqueta1.Text = "Usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(88, 71);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(210, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(88, 33);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(210, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // gpbGrupo2
            // 
            this.gpbGrupo2.Controls.Add(this.btnCancelar);
            this.gpbGrupo2.Controls.Add(this.btnAceptar);
            this.gpbGrupo2.Location = new System.Drawing.Point(12, 137);
            this.gpbGrupo2.Name = "gpbGrupo2";
            this.gpbGrupo2.Size = new System.Drawing.Size(319, 71);
            this.gpbGrupo2.TabIndex = 1;
            this.gpbGrupo2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(189, 28);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 23);
            this.btnCancelar.TabIndex = 1;
       
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(24, 28);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 23);
            this.btnAceptar.TabIndex = 0;
       
            //this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmLogin
            // 
            this.ClientSize = new System.Drawing.Size(343, 229);
            this.Controls.Add(this.gpbGrupo2);
            this.Controls.Add(this.gpbGrupo1);
            this.Name = "frmLogin";
            this.gpbGrupo1.ResumeLayout(false);
            this.gpbGrupo1.PerformLayout();
            this.gpbGrupo2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ValidarLogin valida = new ValidarLogin();
            if (valida.existeUsuario()){
                frmPrincipal vtnPrincipal = new frmPrincipal();
                this.Visible = false;
                vtnPrincipal.Show();

            }
            }
    }
}
