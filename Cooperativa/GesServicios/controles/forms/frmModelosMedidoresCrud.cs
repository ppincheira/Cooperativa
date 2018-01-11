﻿using AppProcesos.gesServicios.frmModelosMedidoresCrud;
using Controles.datos;
using Controles.form;
using Service;
using System;
using System.Windows.Forms;

namespace GesServicios.controles.forms
{
    public partial class frmModelosMedidoresCrud : gesForm, IVistaModelosMedidoresCrud
    {

        #region << PROPIEDADES >>

        UIModelosMedidoresCrud _oModelosMedidoresCrud;
        Utility oUtil;

        long _SruNumero;
        string _EstCodigo;
        long _GrdCodigo, _GrpCodigo;
        string _GrdCodigoRegistro;

        #endregion
        #region Implementation of IVistaModelosMedidoresCrud


        public long sruNumero
        {
            get { return _SruNumero; }
            set { _SruNumero = value; }
        }
        public string Descripcion
        {
            get { return this.txtDescripcion.Text; }
            set { this.txtDescripcion.Text = value; }
        }

        public string DescripcionCorta
        {
            get { return this.txtDescripcionCorta.Text; }
            set { this.txtDescripcionCorta.Text = value; }
        }

        public string estCodigo
        {
            get { return this.chkEstado.Checked?"H":"I"; }
            set { this.chkEstado.Checked= (value=="H"); }
        }

        public cmbLista srvCodigo
        {
            get { return this.cmbFabricante; }
            set { this.cmbFabricante = value; }
        }
        public long grdCodigo
        {
            get { return _GrdCodigo; }
            set { _GrdCodigo = value; }
        }
        public cmbLista grupo
        {
            get { return this.cmbUsuario; }
            set { this.cmbUsuario = value; }
        }
        public string grdCodigoRegistro
        {
            get { return _GrdCodigoRegistro; }
            set { _GrdCodigoRegistro = value; }
        }
        #endregion
        public frmModelosMedidoresCrud(long SRuta, string Estado)
            //SRuta, Estado 
        {
            //try
            //{
                _SruNumero=SRuta;
                _EstCodigo = Estado;
                _oModelosMedidoresCrud = new UIModelosMedidoresCrud(this);
                InitializeComponent();
            if (Estado == "B")
                if (MessageBox.Show("Desea eliminar La Ruta Código: " + SRuta + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    _oModelosMedidoresCrud.EliminarRuta(SRuta);
                    this.Close();
                }
            //}
            //catch (Exception ex)
            //{
            //    Cursor.Current = Cursors.Default;
            //    ManejarError Err = new ManejarError();
            //    Err.CargarError(ex,
            //                    e.ToString(),
            //                    ((Control)sender).Name,
            //                    this.FindForm().Name);
            //}
        }

        private void frmModelosMedidoresCrud_Load(object sender, EventArgs e)
        {
            try
            {
                oUtil = new Utility();
                _oModelosMedidoresCrud.Inicializar();
                this.txtDescripcion.REQUERIDO = "SI";
                this.txtDescripcionCorta.REQUERIDO = "SI";
                this.cmbFabricante.REQUERIDO = "SI";
                this.cmbUsuario.REQUERIDO = "SI";
                this.chkEstado.REQUERIDO = "NO";
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.VALIDARFORM = true;
                oUtil.ValidarFormulario(this, this, 4);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oModelosMedidoresCrud.Guardar();

                    this.Close();
                }
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

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEtiqueta1_Click(object sender, EventArgs e)
        {

        }

        private void numericTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEtiqueta2_Click(object sender, EventArgs e)
        {

        }

        private void numericTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gesTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
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

    }
}