using System;
using System.Drawing;
using System.Windows.Forms;
using AppProcesos.formsAuxiliares.frmCrudGrilla;
using Controles.datos;
using Controles.form;
using Service;

namespace FormsAuxiliares
{
    public partial class frmCrudGrillaN : gesForm, IVistaCrudGrilla
    {

        private UICrudGrilla _oCrudGrilla;
        private Controles.contenedores.gpbGrupo gpbGrupo1;
        private Controles.txtFiltro txtFiltro1;
        private cmbLista cmbLista1;
        private Controles.labels.lblEtiqueta lblEtiqueta3;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.contenedores.gpbGrupo gpbGrupo2;
        private grdGrillaEdit grdGrillaEdit1;
        private Controles.contenedores.gpbGrupo gpbGrupo3;
        private Controles.buttons.btnCancelar btnCancelar1;
        private Controles.buttons.btnAceptar btnAceptar1;
        private Controles.labels.lblEtiqueta lblCantidad;
        private Controles.contenedores.gpbGrupo gpbGrupoEstado;
        private cmbLista cmbEstado;
        private Controles.labels.lblEtiqueta lblEEstado;
        private Controles.contenedores.gpbGrupo gpbGrupoFecha;
        private DateTimePicker dtpFechaHasta;
        private DateTimePicker dtpFechaDesde;
        private Controles.labels.lblEtiqueta lblEFechaHasta;
        private Controles.labels.lblEtiqueta lblEFechaDesde;
        #region << PROPIEDADES >>
        private string _Tabla, _campoClave;
        private bool _claveSecuencia;
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

        public frmCrudGrillaN(string tabla, string campoClave, bool claveSecuencia)
        {
            _Tabla = tabla;
            _campoClave = campoClave;
            _claveSecuencia = claveSecuencia;
            InitializeComponent();
            _oCrudGrilla = new UICrudGrilla(this);
        }
        private void txtFiltro1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _oCrudGrilla.CargarGrilla(_Tabla, _campoClave, _claveSecuencia);
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

                _oCrudGrilla.Inicializar(_Tabla, _campoClave, _claveSecuencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrudGrillaN));
            this.gpbGrupoEstado = new Controles.contenedores.gpbGrupo();
            this.cmbEstado = new cmbLista();
            this.lblEEstado = new Controles.labels.lblEtiqueta();
            this.gpbGrupoFecha = new Controles.contenedores.gpbGrupo();
            this.dtpFechaHasta = new DateTimePicker();
            this.dtpFechaDesde = new DateTimePicker();
            this.lblEFechaHasta = new Controles.labels.lblEtiqueta();
            this.lblEFechaDesde = new Controles.labels.lblEtiqueta();
            this.gpbGrupo2 = new Controles.contenedores.gpbGrupo();
            this.grdGrillaEdit1 = new grdGrillaEdit();
            this.lblCantidad = new Controles.labels.lblEtiqueta();
            this.gpbGrupo3 = new Controles.contenedores.gpbGrupo();
            this.btnCancelar1 = new Controles.buttons.btnCancelar();
            this.btnAceptar1 = new Controles.buttons.btnAceptar();
            this.gpbGrupo1 = new Controles.contenedores.gpbGrupo();
            this.lblEtiqueta3 = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.txtFiltro1 = new Controles.txtFiltro();
            this.cmbLista1 = new cmbLista();
            this.gpbGrupoEstado.SuspendLayout();
            this.gpbGrupoFecha.SuspendLayout();
            this.gpbGrupo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaEdit1)).BeginInit();
            this.gpbGrupo3.SuspendLayout();
            this.gpbGrupo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbGrupoEstado
            // 
            this.gpbGrupoEstado.Controls.Add(this.cmbEstado);
            this.gpbGrupoEstado.Controls.Add(this.lblEEstado);
            this.gpbGrupoEstado.Location = new Point(584, 7);
            this.gpbGrupoEstado.Name = "gpbGrupoEstado";
            this.gpbGrupoEstado.Size = new Size(176, 98);
            this.gpbGrupoEstado.TabIndex = 9;
            this.gpbGrupoEstado.TabStop = false;
            this.gpbGrupoEstado.Visible = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new Point(6, 54);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new Size(164, 21);
            this.cmbEstado.TabIndex = 8;
            // 
            // lblEEstado
            // 
            this.lblEEstado.AutoSize = true;
            this.lblEEstado.Location = new Point(6, 16);
            this.lblEEstado.Name = "lblEEstado";
            this.lblEEstado.Size = new Size(40, 13);
            this.lblEEstado.TabIndex = 8;
            this.lblEEstado.Text = "Estado";
            // 
            // gpbGrupoFecha
            // 
            this.gpbGrupoFecha.Controls.Add(this.dtpFechaHasta);
            this.gpbGrupoFecha.Controls.Add(this.dtpFechaDesde);
            this.gpbGrupoFecha.Controls.Add(this.lblEFechaHasta);
            this.gpbGrupoFecha.Controls.Add(this.lblEFechaDesde);
            this.gpbGrupoFecha.Location = new Point(352, 7);
            this.gpbGrupoFecha.Name = "gpbGrupoFecha";
            this.gpbGrupoFecha.Size = new Size(226, 98);
            this.gpbGrupoFecha.TabIndex = 8;
            this.gpbGrupoFecha.TabStop = false;
            this.gpbGrupoFecha.Visible = false;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new Point(117, 55);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new Size(96, 20);
            this.dtpFechaHasta.TabIndex = 9;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new Point(6, 55);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new Size(96, 20);
            this.dtpFechaDesde.TabIndex = 8;
            // 
            // lblEFechaHasta
            // 
            this.lblEFechaHasta.AutoSize = true;
            this.lblEFechaHasta.Location = new Point(114, 16);
            this.lblEFechaHasta.Name = "lblEFechaHasta";
            this.lblEFechaHasta.Size = new Size(68, 13);
            this.lblEFechaHasta.TabIndex = 7;
            this.lblEFechaHasta.Text = "Fecha Hasta";
            // 
            // lblEFechaDesde
            // 
            this.lblEFechaDesde.AutoSize = true;
            this.lblEFechaDesde.Location = new Point(6, 16);
            this.lblEFechaDesde.Name = "lblEFechaDesde";
            this.lblEFechaDesde.Size = new Size(71, 13);
            this.lblEFechaDesde.TabIndex = 6;
            this.lblEFechaDesde.Text = "Fecha Desde";
            // 
            // gpbGrupo2
            // 
            this.gpbGrupo2.Controls.Add(this.grdGrillaEdit1);
            this.gpbGrupo2.Controls.Add(this.lblCantidad);
            this.gpbGrupo2.Controls.Add(this.gpbGrupo3);
            this.gpbGrupo2.Location = new Point(12, 111);
            this.gpbGrupo2.Name = "gpbGrupo2";
            this.gpbGrupo2.Size = new Size(748, 831);
            this.gpbGrupo2.TabIndex = 1;
            this.gpbGrupo2.TabStop = false;
            // 
            // grdGrillaEdit1
            // 
            this.grdGrillaEdit1.Location = new Point(6, 25);
            this.grdGrillaEdit1.Name = "grdGrillaEdit1";
            this.grdGrillaEdit1.Size = new Size(650, 500);
            this.grdGrillaEdit1.TabIndex = 3;
            this.grdGrillaEdit1.CellBeginEdit += new DataGridViewCellCancelEventHandler(this.grdGrillaEdit1_CellBeginEdit);
            this.grdGrillaEdit1.CellEndEdit += new DataGridViewCellEventHandler(this.grdGrillaEdit1_CellEndEdit);
            this.grdGrillaEdit1.UserAddedRow += new DataGridViewRowEventHandler(this.grdGrillaEdit1_UserAddedRow);
            this.grdGrillaEdit1.UserDeletingRow += new DataGridViewRowCancelEventHandler(this.grdGrillaEdit1_UserDeletingRow);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new Point(7, 791);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new Size(49, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // gpbGrupo3
            // 
            this.gpbGrupo3.Controls.Add(this.btnCancelar1);
            this.gpbGrupo3.Controls.Add(this.btnAceptar1);
            this.gpbGrupo3.Location = new Point(288, 531);
            this.gpbGrupo3.Name = "gpbGrupo3";
            this.gpbGrupo3.Size = new Size(189, 84);
            this.gpbGrupo3.TabIndex = 1;
            this.gpbGrupo3.TabStop = false;
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar1.Image")));
            this.btnCancelar1.Location = new Point(100, 14);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new Size(80, 60);
            this.btnCancelar1.TabIndex = 1;
            this.btnCancelar1.UseVisualStyleBackColor = true;
            // 
            // btnAceptar1
            // 
            this.btnAceptar1.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar1.Image")));
            this.btnAceptar1.Location = new Point(9, 14);
            this.btnAceptar1.Name = "btnAceptar1";
            this.btnAceptar1.Size = new Size(80, 60);
            this.btnAceptar1.TabIndex = 0;
            this.btnAceptar1.UseVisualStyleBackColor = true;
            this.btnAceptar1.Click += new EventHandler(this.btnAceptar1_Click);
            // 
            // gpbGrupo1
            // 
            this.gpbGrupo1.Controls.Add(this.lblEtiqueta3);
            this.gpbGrupo1.Controls.Add(this.lblEtiqueta2);
            this.gpbGrupo1.Controls.Add(this.txtFiltro1);
            this.gpbGrupo1.Controls.Add(this.cmbLista1);
            this.gpbGrupo1.Location = new Point(12, 6);
            this.gpbGrupo1.Name = "gpbGrupo1";
            this.gpbGrupo1.Size = new Size(334, 99);
            this.gpbGrupo1.TabIndex = 0;
            this.gpbGrupo1.TabStop = false;
            // 
            // lblEtiqueta3
            // 
            this.lblEtiqueta3.AutoSize = true;
            this.lblEtiqueta3.Location = new Point(7, 61);
            this.lblEtiqueta3.Name = "lblEtiqueta3";
            this.lblEtiqueta3.Size = new Size(45, 13);
            this.lblEtiqueta3.TabIndex = 7;
            this.lblEtiqueta3.Text = "FILTRO";
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new Point(6, 23);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new Size(78, 13);
            this.lblEtiqueta2.TabIndex = 6;
            this.lblEtiqueta2.Text = "FILTRAR POR";
            // 
            // txtFiltro1
            // 
            this.txtFiltro1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro1.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtFiltro1.Location = new Point(127, 58);
            this.txtFiltro1.Name = "txtFiltro1";
            this.txtFiltro1.Size = new Size(175, 20);
            this.txtFiltro1.TabIndex = 5;
            this.txtFiltro1.TextoVacio = "<Descripcion>";
            this.txtFiltro1.TextChanged += new EventHandler(this.txtFiltro1_TextChanged_1);
            // 
            // cmbLista1
            // 
            this.cmbLista1.FormattingEnabled = true;
            this.cmbLista1.Location = new Point(127, 15);
            this.cmbLista1.Name = "cmbLista1";
            this.cmbLista1.Size = new Size(175, 21);
            this.cmbLista1.TabIndex = 4;
            // 
            // frmCrudGrillaN
            // 
            this.ClientSize = new Size(776, 749);
            this.Controls.Add(this.gpbGrupoEstado);
            this.Controls.Add(this.gpbGrupoFecha);
            this.Controls.Add(this.gpbGrupo2);
            this.Controls.Add(this.gpbGrupo1);
            this.Name = "frmCrudGrillaN";
            this.Load += new EventHandler(this.frmCrudGrilla_Load);
            this.gpbGrupoEstado.ResumeLayout(false);
            this.gpbGrupoEstado.PerformLayout();
            this.gpbGrupoFecha.ResumeLayout(false);
            this.gpbGrupoFecha.PerformLayout();
            this.gpbGrupo2.ResumeLayout(false);
            this.gpbGrupo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaEdit1)).EndInit();
            this.gpbGrupo3.ResumeLayout(false);
            this.gpbGrupo1.ResumeLayout(false);
            this.gpbGrupo1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btnAceptar1_Click(object sender, EventArgs e)
        {
            _oCrudGrilla.ActualizaTabla(_Tabla, _campoClave, _claveSecuencia);
            foreach (DataGridViewRow row in grdGrillaEdit1.Rows)
            {
                if (!row.IsNewRow && row.Cells[grdGrillaEdit1.ColumnCount - 1].Value == "0")
                    row.DefaultCellStyle.BackColor = Color.White;
                if (!row.IsNewRow && row.DefaultCellStyle.BackColor == Color.Red && row.Cells[grdGrillaEdit1.ColumnCount - 1].Value == "0")
                    row.Visible = false;
            }
            // obtener el objeto en cuestion para cada elemento modificado usando el id , por ej AreasGetById(columnaClave)
            // Hacer un porje Areas Update(area obtenida en el paso anterior)

        }

        private void txtFiltro1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _oCrudGrilla.CargarGrilla(_Tabla, _campoClave, _claveSecuencia);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }

        }
        String temp = "";
        private void grdGrillaEdit1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            temp = grdGrillaEdit1.CurrentCell.Value.ToString();
        }

        private void grdGrillaEdit1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            grdGrillaEdit1.CurrentRow.Cells[grdGrillaEdit1.ColumnCount - 1].Value = "2";
            grdGrillaEdit1.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
            e.Cancel = true;

        }

        private void grdGrillaEdit1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (!grdGrillaEdit1.CurrentRow.IsNewRow)
            {
                grdGrillaEdit1.CurrentRow.Cells[grdGrillaEdit1.ColumnCount - 1].Value = "3";
                grdGrillaEdit1.CurrentRow.DefaultCellStyle.BackColor = Color.Blue;
                if (!_claveSecuencia) // Permito editar la clave si no es secuencia
                    grdGrillaEdit1.CurrentRow.Cells[0].ReadOnly = false;
                grdGrillaEdit1.CurrentRow.Cells[0].Selected = true;
            }
        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            _oCrudGrilla.MostrarTabla(_Tabla);
        }

        private void grdGrillaEdit1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (grdGrillaEdit1.CurrentCell.Value.ToString() != temp && grdGrillaEdit1.CurrentRow.Cells[grdGrillaEdit1.ColumnCount - 1].Value == "0")
            {
                // se realizo algun cambio y la celda esta sin editar (no esta borrada ni nueva)
                grdGrillaEdit1.CurrentRow.Cells[grdGrillaEdit1.ColumnCount - 1].Value = "1";
                grdGrillaEdit1.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
            }

        }
    }
}

