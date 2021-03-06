﻿using System;
using System.Windows.Forms;
using Business;
using GesServicios.controles.forms;
using Model;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonalizado1_Click(object sender, EventArgs e)
        {
            string username = "sys";
            string password = "SaPass1?";
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("El usuario y el password son datos requeridos");
            }
            else { Validar(username, password); }
        }

        private void Validar(string username, string password)
        {
            try
            {
                PruebaBus oPrueba = new PruebaBus();
              
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnPersonalizado2_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0","0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "DOMB";

            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
            frmbus.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Areas oArea = new Areas();
            //oArea.AreCodigo = "BBB";
            //oArea.AreDescripcion = "BBBBBBBB";
            //AreasBus oAreaBus = new AreasBus();
            //oAreaBus.AreasAdd(oArea);
            //Controles.forms.frmBuscador frmbus = new Controles.forms.frmBuscador("AREB");
           FormsAuxiliares.frmBuscador frmbus = new FormsAuxiliares.frmBuscador("PERB");
            frmbus.ShowDialog();
        }

        private void btnPersonalizado3_Click(object sender, EventArgs e)
        {
            //FormsAuxiliares.frmObservacionesAdmin frmObs = new FormsAuxiliares.frmObservacionesAdmin();
            //frmObs.Show();
        }

        private void buttonCrudGrilla_Click(object sender, EventArgs e)
        {

            FormsAuxiliares.frmCrudGrilla frmbus = new FormsAuxiliares.frmCrudGrilla("AREC", "CODIGO", false);
            frmbus.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormsAuxiliares.frmObservacionesAdmin frmobs = new FormsAuxiliares.frmObservacionesAdmin("PERS",1,"1");
            frmobs.ShowDialog();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            //Aqui se utiliza una clase para asignar la funcionalidad a formularios admin cargados dinamicamente
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10001", "10002", "10003", "10005", "10006","10004");
            //Se instancia un objeto de la clase formulario admin al cual se le pasa por parametro el COD_TABLA
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "SRUT";
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            frmbus.ShowDialog();
        }

        private void btnPersonalizado4_Click(object sender, EventArgs e)
        {

            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "CALB";
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            frmbus.ShowDialog();
        }

        private void btnPersonalizado5_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            FormsAuxiliares.frmTelefonosAdmin frmobs = new FormsAuxiliares.frmTelefonosAdmin("PERB", "1", oPermiso);
            frmobs.ShowDialog();
        }

        private void btnPersonalizado6_Click(object sender, EventArgs e)
        {

            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "COPB";
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            frmbus.ShowDialog();
        }

        private void btnPersonalizado7_Click(object sender, EventArgs e)
        {
            //FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            //FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini("CLIB", oPermiso);
            //frmbus.ShowDialog();

            FormsAuxiliares.frmClientesCrud frmCliente = new FormsAuxiliares.frmClientesCrud(0);
            frmCliente.Show();
        }


        private void gesTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10100", "10101", "10102", "10104", "10105", "10103");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "MED";
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);

        }

        private void btnTiposMedidores_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "TME";
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            frmbus.Text = "Administrador Tipos de Medidores";
            frmbus.ShowDialog();
        }

        private void btnFabricantes_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "FAB";
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            frmbus.Text = "Administrador Fabricantes";
            frmbus.ShowDialog();
        }

        private void btnMedidoresModelos_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10031", "10032", "10033", "10035", "10036", "10034");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "MEM";
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
            frmbus.ShowDialog();
        }

        private void btnMedidores_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10101", "10102", "10103", "10105", "10106", "10104");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "MED";
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
            frmbus.ShowDialog();

        }

        private void categorias_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "SCAT";
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            frmbus.ShowDialog();
        }

        private void btnTiposConexiones_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10111", "10112", "10113", "10115", "10116", "10114");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "TCS";
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            frmbus.ShowDialog();

        }

        private void btnMedidoresMasivos_Click(object sender, EventArgs e)
        {
            frmMedidoresMasivosCrud oFrmMedCrud = new frmMedidoresMasivosCrud(0, "H", 1);
            oFrmMedCrud.ShowDialog();
        }

        private void btnDeptos_Click(object sender, EventArgs e)
        {
            FormsAuxiliares.frmCrudGrilla frmbus = new FormsAuxiliares.frmCrudGrilla("DEPC", "DEP_NUMERO", false);
            frmbus.ShowDialog();
        }

        private void btnLectura_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "LEC";
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            frmbus.Text = "Administrador Lecturas Conceptos";
            frmbus.ShowDialog();
        }


        private void btnTiposIva_Click(object sender, EventArgs e)
        {
            FormsAuxiliares.frmCrudGrilla frmbus = new FormsAuxiliares.frmCrudGrilla("TIV", "TIV_CODIGO", false);
            frmbus.ShowDialog();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            FormsAuxiliares.frmCrudGrilla frmbus = new FormsAuxiliares.frmCrudGrilla("SRV", "SRV_CODIGO", false);
            frmbus.ShowDialog();
        }

        private void btnSuministros_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10001", "10002", "10003", "10005", "10006", "10004");
            //Se instancia un objeto de la clase formulario admin al cual se le pasa por parametro el COD_TABLA
            frmSuministrosAdmin frmbus = new frmSuministrosAdmin("SUM", oPermiso);
            frmbus.ShowDialog();

        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10031", "10032", "10033", "10035", "10036", "10034");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "PERB";
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
            frmbus.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "USUS";
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            frmbus.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "LEM";
           
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            frmbus.Text = "Administrador de Modos Lecturas";
            frmbus.ShowDialog();
        }
    }
}
