﻿using AppProcesos.gesServicios.frmMedidoresCrud;
using Controles.datos;
using Controles.form;
using Service;
using System;
using System.Windows.Forms;

namespace GesServicios.controles.forms
{
    public partial class frmMedidoresCrud : gesForm, IVistaMedidoresCrud
    {

        #region << PROPIEDADES >>

        UIMedidoresCrud _oMedidoresCrud;
        Utility oUtil;

        long _MmoNumero;
        int _usrNumero;
        string _EstCodigo;

        #endregion
        #region Implementation of IVistaMedidoresCrud


        public long Numero
        {
            get { return _MmoNumero; }
            set { _MmoNumero = value; }
        }
        public string NumeroSerie
        {
            get { return this.txtNumeroSerie.Text; }
            set { this.txtNumeroSerie.Text = value; }
        }

        public cmbLista NumeroProv
        {
            get { return this.cmbNumeroProv; }
            set { this.cmbNumeroProv = value; }
        }
        public int Digitos
        {
            get { return int.Parse(gesTextBoxDigitos.Text); }
            set { gesTextBoxDigitos.Text = value.ToString(); }
        }
        public string EstCodigo
        {
            get { return this.chkEstado.Checked ? "H" : "I"; }
            set { this.chkEstado.Checked = (value == "H"); }
        }

        public double FactorCalib
        {
            get { return double.Parse(gesTextBoxDmeCodigo.Text); }
            set { gesTextBoxDmeCodigo.Text = value.ToString(); }
        }

        public decimal? GisX
        {
            get { return decimal.Parse(TextBoxGisX.Text); }
            set { TextBoxGisX.Text = value.ToString(); }
        }

        public decimal? GisY
        {
            get { return decimal.Parse(TextBoxGisY.Text); }
            set { TextBoxGisY.Text = value.ToString(); }
        }

        public string DmeCodigo
        {
            get { return this.gesTextBoxDmeCodigo.Text; }
            set { this.gesTextBoxDmeCodigo.Text = value; }
        }

        public int UsrNumero
        {
            get { return _usrNumero; }
            set { _usrNumero = value; }
        }

        public DateTime FechaCarga
        {
            get { return DateTime.Parse(dtpFechaCarga.Text); }
            set { dtpFechaCarga.Text = value.ToString(); }
        }
        public cmbLista MmoCodigo
        {
            get { return this.cmbMmoCodigo; }
            set { this.cmbMmoCodigo = value; }
        }

        public decimal Registrador { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        #endregion
        public frmMedidoresCrud(long NumeroMedidor, string Estado, int Usuario)
        //SRuta, Estado 
        {
            //try
            //{
            _MmoNumero = NumeroMedidor;
            _EstCodigo = Estado;
            _usrNumero = Usuario;
            _oMedidoresCrud = new UIMedidoresCrud(this);
            InitializeComponent();
            if (Estado == "B")
                if (MessageBox.Show("Desea eliminar el Numero de Medidor Código: " + NumeroMedidor + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    _oMedidoresCrud.EliminarModeloMedidor(NumeroMedidor);
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

        private void frmMedidoresCrud_Load(object sender, EventArgs e)
        {
            try
            {
                oUtil = new Utility();
                _oMedidoresCrud.Inicializar();
                this.cmbNumeroProv.REQUERIDO = "SI";
                this.dtpFechaCarga.REQUERIDO = "SI";
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
            if (!this.gbDatos.Enabled)
            {
                this.Close();
                return;
            }
            try
            {
                this.VALIDARFORM = true;
                oUtil.ValidarFormulario(this, this, 11);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oMedidoresCrud.Guardar();
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
