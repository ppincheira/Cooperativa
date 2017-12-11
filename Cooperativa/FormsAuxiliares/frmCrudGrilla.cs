using System;
<<<<<<< HEAD
<<<<<<< HEAD
using AppProcesos.formsAuxiliares.frmCrudGrilla;
using Controles.datos;


namespace FormsAuxiliares
{
    public partial class frmCrudGrilla : gesForm, IVistaCrudGrilla
    {

        private UICrudGrilla _oCrudGrilla;
        private Controles.contenedores.gpbGrupo gpbGrupo1;
        private Controles.txtFiltro txtFiltro1;
        private Controles.datos.cmbLista cmbLista1;
        private Controles.labels.lblEtiqueta lblEtiqueta3;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.contenedores.gpbGrupo gpbGrupo2;
        private Controles.datos.grdGrillaEdit grdGrillaEdit1;
        private Controles.contenedores.gpbGrupo gpbGrupo3;
        private Controles.buttons.btnCancelar btnCancelar1;
        private Controles.buttons.btnAceptar btnAceptar1;
        private Controles.labels.lblEtiqueta lblCantidad;
=======
=======
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsAuxiliares
{
    public partial class frmCrudGrilla:gesForm
    {
        private Controles.contenedores.gpbGrupo gpbGrupo2;
        private Controles.contenedores.gpbGrupo gpbGrupo3;
        private Controles.buttons.btnCancelar btnCancelar1;
        private Controles.buttons.btnAceptar btnAceptar1;
        private Controles.labels.lblEtiqueta lblEtiqueta3;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.txtFiltro txtFiltro1;
        private Controles.datos.cmbLista cmbLista1;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private Controles.datos.grdGrillaEdit grdGrillaEdit1;
<<<<<<< HEAD
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
        private Controles.contenedores.gpbGrupo gpbGrupoEstado;
        private Controles.datos.cmbLista cmbEstado;
        private Controles.labels.lblEtiqueta lblEEstado;
        private Controles.contenedores.gpbGrupo gpbGrupoFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private Controles.labels.lblEtiqueta lblEFechaHasta;
        private Controles.labels.lblEtiqueta lblEFechaDesde;
<<<<<<< HEAD
<<<<<<< HEAD
        #region << PROPIEDADES >>
        private string _Tabla;
        #endregion
        #region Implementation of IVistaCrudGrilla
        public Boolean grupoEstado
        {
            get { return this.gpbGrupoEstado.Visible; }
            set { this.gpbGrupoEstado.Visible = value; }
        }
        public Boolean grupoFecha
        {
            get { return this.gpbGrupoFecha.Visible; }
            set { this.gpbGrupoFecha.Visible = value; }
        }

        public grdGrillaEdit grilla
        {
            get { return this.grdGrillaEdit1; }
            set { this.grdGrillaEdit1 = value; }
        }
        public DateTime fechaDesde
        {
            get { return this.dtpFechaDesde.Value; }
            set { this.dtpFechaDesde.Value = value; }
        }
        public DateTime fechaHasta
        {
            get { return this.dtpFechaHasta.Value; }
            set { this.dtpFechaHasta.Value = value; }
        }
        public cmbLista comboBuscar
        {
            get { return this.cmbLista1; }
            set { this.cmbLista1 = value; }
        }
        public string filtro
        {
            get { return this.txtFiltro1.Text; }
            set { this.txtFiltro1.Text = value; }
        }
        public cmbLista comboEstado
        {
            get { return this.cmbEstado; }
            set { this.cmbEstado = value; }
        }
        public string cantidad
        {

            set { this.lblCantidad.Text = value; }
        }

        #endregion
        #region << EVENTOS >>

        public frmCrudGrilla(string tabla)
        {
            _Tabla = tabla;
            InitializeComponent();
            _oCrudGrilla = new UICrudGrilla(this);
        }
        private void txtFiltro1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _oCrudGrilla.CargarGrilla(_Tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        private void frmCrudGrilla_Load(object sender, EventArgs e)
        {
            try
            {

                _oCrudGrilla.Inicializar(_Tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
=======
=======
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
        private Controles.contenedores.gpbGrupo gpbGrupo1;

        public frmCrudGrilla() {

        }

<<<<<<< HEAD
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrudGrilla));
            this.gpbGrupo1 = new Controles.contenedores.gpbGrupo();
            this.lblEtiqueta3 = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.txtFiltro1 = new Controles.txtFiltro();
            this.cmbLista1 = new Controles.datos.cmbLista();
            this.gpbGrupo2 = new Controles.contenedores.gpbGrupo();
            this.grdGrillaEdit1 = new Controles.datos.grdGrillaEdit();
<<<<<<< HEAD
<<<<<<< HEAD
            this.lblCantidad = new Controles.labels.lblEtiqueta();
=======
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            this.gpbGrupo3 = new Controles.contenedores.gpbGrupo();
            this.btnCancelar1 = new Controles.buttons.btnCancelar();
            this.btnAceptar1 = new Controles.buttons.btnAceptar();
            this.gpbGrupoEstado = new Controles.contenedores.gpbGrupo();
            this.cmbEstado = new Controles.datos.cmbLista();
            this.lblEEstado = new Controles.labels.lblEtiqueta();
            this.gpbGrupoFecha = new Controles.contenedores.gpbGrupo();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblEFechaHasta = new Controles.labels.lblEtiqueta();
            this.lblEFechaDesde = new Controles.labels.lblEtiqueta();
            this.gpbGrupo1.SuspendLayout();
            this.gpbGrupo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaEdit1)).BeginInit();
            this.gpbGrupo3.SuspendLayout();
            this.gpbGrupoEstado.SuspendLayout();
            this.gpbGrupoFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbGrupo1
            // 
            this.gpbGrupo1.Controls.Add(this.lblEtiqueta3);
            this.gpbGrupo1.Controls.Add(this.lblEtiqueta2);
            this.gpbGrupo1.Controls.Add(this.txtFiltro1);
            this.gpbGrupo1.Controls.Add(this.cmbLista1);
            this.gpbGrupo1.Location = new System.Drawing.Point(12, 6);
            this.gpbGrupo1.Name = "gpbGrupo1";
            this.gpbGrupo1.Size = new System.Drawing.Size(334, 99);
            this.gpbGrupo1.TabIndex = 0;
            this.gpbGrupo1.TabStop = false;
<<<<<<< HEAD
<<<<<<< HEAD
            this.gpbGrupo1.Enter += new System.EventHandler(this.gpbGrupo1_Enter);
=======
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            // 
            // lblEtiqueta3
            // 
            this.lblEtiqueta3.AutoSize = true;
            this.lblEtiqueta3.Location = new System.Drawing.Point(7, 61);
            this.lblEtiqueta3.Name = "lblEtiqueta3";
<<<<<<< HEAD
<<<<<<< HEAD
            this.lblEtiqueta3.Size = new System.Drawing.Size(45, 13);
=======
            this.lblEtiqueta3.Size = new System.Drawing.Size(66, 20);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
            this.lblEtiqueta3.Size = new System.Drawing.Size(66, 20);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            this.lblEtiqueta3.TabIndex = 7;
            this.lblEtiqueta3.Text = "FILTRO";
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(6, 23);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
<<<<<<< HEAD
<<<<<<< HEAD
            this.lblEtiqueta2.Size = new System.Drawing.Size(78, 13);
=======
            this.lblEtiqueta2.Size = new System.Drawing.Size(115, 20);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
            this.lblEtiqueta2.Size = new System.Drawing.Size(115, 20);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            this.lblEtiqueta2.TabIndex = 6;
            this.lblEtiqueta2.Text = "FILTRAR POR";
            // 
            // txtFiltro1
            // 
            this.txtFiltro1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro1.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtFiltro1.Location = new System.Drawing.Point(127, 58);
            this.txtFiltro1.Name = "txtFiltro1";
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtFiltro1.Size = new System.Drawing.Size(175, 20);
=======
            this.txtFiltro1.Size = new System.Drawing.Size(175, 26);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
            this.txtFiltro1.Size = new System.Drawing.Size(175, 26);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            this.txtFiltro1.TabIndex = 5;
            this.txtFiltro1.TextoVacio = "<Descripcion>";
            // 
            // cmbLista1
            // 
            this.cmbLista1.FormattingEnabled = true;
            this.cmbLista1.Location = new System.Drawing.Point(127, 15);
            this.cmbLista1.Name = "cmbLista1";
<<<<<<< HEAD
<<<<<<< HEAD
            this.cmbLista1.Size = new System.Drawing.Size(175, 21);
=======
            this.cmbLista1.Size = new System.Drawing.Size(175, 28);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
            this.cmbLista1.Size = new System.Drawing.Size(175, 28);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            this.cmbLista1.TabIndex = 4;
            // 
            // gpbGrupo2
            // 
            this.gpbGrupo2.Controls.Add(this.grdGrillaEdit1);
<<<<<<< HEAD
<<<<<<< HEAD
            this.gpbGrupo2.Controls.Add(this.lblCantidad);
=======
            this.gpbGrupo2.Controls.Add(this.lblEtiqueta1);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
            this.gpbGrupo2.Controls.Add(this.lblEtiqueta1);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            this.gpbGrupo2.Location = new System.Drawing.Point(12, 111);
            this.gpbGrupo2.Name = "gpbGrupo2";
            this.gpbGrupo2.Size = new System.Drawing.Size(748, 831);
            this.gpbGrupo2.TabIndex = 1;
            this.gpbGrupo2.TabStop = false;
            // 
            // grdGrillaEdit1
            // 
            this.grdGrillaEdit1.DataMember = "";
            this.grdGrillaEdit1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grdGrillaEdit1.Location = new System.Drawing.Point(6, 25);
            this.grdGrillaEdit1.Name = "grdGrillaEdit1";
            this.grdGrillaEdit1.Size = new System.Drawing.Size(736, 763);
            this.grdGrillaEdit1.TabIndex = 3;
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(7, 791);
            this.lblCantidad.Name = "lblEtiqueta1";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
=======
=======
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(7, 791);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(73, 20);
            this.lblEtiqueta1.TabIndex = 2;
            this.lblEtiqueta1.Text = "Cantidad";
<<<<<<< HEAD
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            // 
            // gpbGrupo3
            // 
            this.gpbGrupo3.Controls.Add(this.btnCancelar1);
            this.gpbGrupo3.Controls.Add(this.btnAceptar1);
            this.gpbGrupo3.Location = new System.Drawing.Point(571, 948);
            this.gpbGrupo3.Name = "gpbGrupo3";
            this.gpbGrupo3.Size = new System.Drawing.Size(189, 84);
            this.gpbGrupo3.TabIndex = 1;
            this.gpbGrupo3.TabStop = false;
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar1.Image")));
            this.btnCancelar1.Location = new System.Drawing.Point(100, 14);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar1.TabIndex = 1;
            this.btnCancelar1.UseVisualStyleBackColor = true;
            // 
            // btnAceptar1
            // 
            this.btnAceptar1.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar1.Image")));
            this.btnAceptar1.Location = new System.Drawing.Point(9, 14);
            this.btnAceptar1.Name = "btnAceptar1";
            this.btnAceptar1.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar1.TabIndex = 0;
            this.btnAceptar1.UseVisualStyleBackColor = true;
            // 
            // gpbGrupoEstado
            // 
            this.gpbGrupoEstado.Controls.Add(this.cmbEstado);
            this.gpbGrupoEstado.Controls.Add(this.lblEEstado);
            this.gpbGrupoEstado.Location = new System.Drawing.Point(584, 7);
            this.gpbGrupoEstado.Name = "gpbGrupoEstado";
            this.gpbGrupoEstado.Size = new System.Drawing.Size(176, 98);
            this.gpbGrupoEstado.TabIndex = 9;
            this.gpbGrupoEstado.TabStop = false;
            this.gpbGrupoEstado.Visible = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(6, 54);
            this.cmbEstado.Name = "cmbEstado";
<<<<<<< HEAD
<<<<<<< HEAD
            this.cmbEstado.Size = new System.Drawing.Size(164, 21);
=======
            this.cmbEstado.Size = new System.Drawing.Size(164, 28);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
            this.cmbEstado.Size = new System.Drawing.Size(164, 28);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            this.cmbEstado.TabIndex = 8;
            // 
            // lblEEstado
            // 
            this.lblEEstado.AutoSize = true;
            this.lblEEstado.Location = new System.Drawing.Point(6, 16);
            this.lblEEstado.Name = "lblEEstado";
<<<<<<< HEAD
<<<<<<< HEAD
            this.lblEEstado.Size = new System.Drawing.Size(40, 13);
=======
            this.lblEEstado.Size = new System.Drawing.Size(60, 20);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
            this.lblEEstado.Size = new System.Drawing.Size(60, 20);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            this.lblEEstado.TabIndex = 8;
            this.lblEEstado.Text = "Estado";
            // 
            // gpbGrupoFecha
            // 
            this.gpbGrupoFecha.Controls.Add(this.dtpFechaHasta);
            this.gpbGrupoFecha.Controls.Add(this.dtpFechaDesde);
            this.gpbGrupoFecha.Controls.Add(this.lblEFechaHasta);
            this.gpbGrupoFecha.Controls.Add(this.lblEFechaDesde);
            this.gpbGrupoFecha.Location = new System.Drawing.Point(352, 7);
            this.gpbGrupoFecha.Name = "gpbGrupoFecha";
            this.gpbGrupoFecha.Size = new System.Drawing.Size(226, 98);
            this.gpbGrupoFecha.TabIndex = 8;
            this.gpbGrupoFecha.TabStop = false;
            this.gpbGrupoFecha.Visible = false;
<<<<<<< HEAD
<<<<<<< HEAD
            this.gpbGrupoFecha.Enter += new System.EventHandler(this.gpbGrupoFecha_Enter);
=======
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(117, 55);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
<<<<<<< HEAD
<<<<<<< HEAD
            this.dtpFechaHasta.Size = new System.Drawing.Size(96, 20);
=======
            this.dtpFechaHasta.Size = new System.Drawing.Size(96, 26);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
            this.dtpFechaHasta.Size = new System.Drawing.Size(96, 26);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            this.dtpFechaHasta.TabIndex = 9;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(6, 55);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
<<<<<<< HEAD
<<<<<<< HEAD
            this.dtpFechaDesde.Size = new System.Drawing.Size(96, 20);
=======
            this.dtpFechaDesde.Size = new System.Drawing.Size(96, 26);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
            this.dtpFechaDesde.Size = new System.Drawing.Size(96, 26);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            this.dtpFechaDesde.TabIndex = 8;
            // 
            // lblEFechaHasta
            // 
            this.lblEFechaHasta.AutoSize = true;
            this.lblEFechaHasta.Location = new System.Drawing.Point(114, 16);
            this.lblEFechaHasta.Name = "lblEFechaHasta";
<<<<<<< HEAD
<<<<<<< HEAD
            this.lblEFechaHasta.Size = new System.Drawing.Size(68, 13);
=======
            this.lblEFechaHasta.Size = new System.Drawing.Size(101, 20);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
            this.lblEFechaHasta.Size = new System.Drawing.Size(101, 20);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            this.lblEFechaHasta.TabIndex = 7;
            this.lblEFechaHasta.Text = "Fecha Hasta";
            // 
            // lblEFechaDesde
            // 
            this.lblEFechaDesde.AutoSize = true;
            this.lblEFechaDesde.Location = new System.Drawing.Point(6, 16);
            this.lblEFechaDesde.Name = "lblEFechaDesde";
<<<<<<< HEAD
<<<<<<< HEAD
            this.lblEFechaDesde.Size = new System.Drawing.Size(71, 13);
=======
            this.lblEFechaDesde.Size = new System.Drawing.Size(105, 20);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
            this.lblEFechaDesde.Size = new System.Drawing.Size(105, 20);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            this.lblEFechaDesde.TabIndex = 6;
            this.lblEFechaDesde.Text = "Fecha Desde";
            // 
            // frmCrudGrilla
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(776, 749);
=======
            this.ClientSize = new System.Drawing.Size(776, 1044);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
            this.ClientSize = new System.Drawing.Size(776, 1044);
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            this.Controls.Add(this.gpbGrupoEstado);
            this.Controls.Add(this.gpbGrupoFecha);
            this.Controls.Add(this.gpbGrupo3);
            this.Controls.Add(this.gpbGrupo2);
            this.Controls.Add(this.gpbGrupo1);
            this.Name = "frmCrudGrilla";
<<<<<<< HEAD
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.frmCrudGrilla_Load);
=======
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
            this.gpbGrupo1.ResumeLayout(false);
            this.gpbGrupo1.PerformLayout();
            this.gpbGrupo2.ResumeLayout(false);
            this.gpbGrupo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaEdit1)).EndInit();
            this.gpbGrupo3.ResumeLayout(false);
            this.gpbGrupoEstado.ResumeLayout(false);
            this.gpbGrupoEstado.PerformLayout();
            this.gpbGrupoFecha.ResumeLayout(false);
            this.gpbGrupoFecha.PerformLayout();
            this.ResumeLayout(false);

        }
<<<<<<< HEAD
<<<<<<< HEAD

        private void gpbGrupo1_Enter(object sender, EventArgs e)
        {

        }

        private void gpbGrupoFecha_Enter(object sender, EventArgs e)
        {

        }

=======
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
=======
>>>>>>> parent of 45d0aa8... Merge branch 'master' of https://github.com/ppincheira/Cooperativa
    }
}
