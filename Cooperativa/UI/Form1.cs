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
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin("DOMB", oPermiso);
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
            //FormsAuxiliares.frmCrudGrillaN frmbus = new FormsAuxiliares.frmCrudGrillaN("PERC","NUMERO",true);
            FormsAuxiliares.frmCrudGrilla frmbus = new FormsAuxiliares.frmCrudGrilla("AREC", "CODIGO", false);
            frmbus.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormsAuxiliares.frmObservacionesAdmin frmobs = new FormsAuxiliares.frmObservacionesAdmin("PERS", 1, "1");
            frmobs.ShowDialog();
        }

        private void btnPersonalizado4_Click(object sender, EventArgs e)
        {

            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini("CALB", oPermiso);
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
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini("COPB", oPermiso);
            frmbus.ShowDialog();
        }

        private void btnPersonalizado7_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini("CLIB", oPermiso);
            frmbus.ShowDialog();
        }


        private void gesTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10100", "10101", "10102", "10104", "10105", "10103");
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin("MED", oPermiso);

        }

        private void btnMedidoresModelos_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10031", "10032", "10033", "10035", "10036", "10034");
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin("MEM", oPermiso);
            frmbus.ShowDialog();
        }

        private void btnMedidores_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10101", "10102", "10103", "10105", "10106", "10104");
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin("MED", oPermiso);
            frmbus.ShowDialog();

        }

        private void categorias_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini("SCAT", oPermiso);
            frmbus.ShowDialog();
        }

        private void btnTiposConexiones_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10111", "10112", "10113", "10115", "10116", "10114");
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini("TCS", oPermiso);
            frmbus.ShowDialog();

        }

        private void btnMedidoresMasivos_Click(object sender, EventArgs e)
        {
            frmMedidoresMasivosCrud oFrmMedCrud = new frmMedidoresMasivosCrud(0, "H", 1);
            oFrmMedCrud.ShowDialog();
        }

        private void buttonDeptos_Click(object sender, EventArgs e)
        {
            FormsAuxiliares.frmCrudGrilla frmbus = new FormsAuxiliares.frmCrudGrilla("DEPC", "DEP_NUMERO", false);
            frmbus.ShowDialog();
        }

        private void buttonLectura_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini("LEC", oPermiso);
            frmbus.Text = "Administrador Lecturas Conceptos";
            frmbus.ShowDialog();

        }

        private void buttonRutas_Click(object sender, EventArgs e)
        {
            //Aqui se utiliza una clase para asignar la funcionalidad a formularios admin cargados dinamicamente
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10001", "10002", "10003", "10005", "10006", "10004");
            //Se instancia un objeto de la clase formulario admin al cual se le pasa por parametro el COD_TABLA
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini("SRUT", oPermiso);
            frmbus.ShowDialog();
        }

        private void buttonTiposMedidores_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini("TME", oPermiso);
            frmbus.Text = "Administrador Tipos de Medidores";
            frmbus.ShowDialog();
        }

        private void buttonFabricantes_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini("FAB", oPermiso);
            frmbus.Text = "Administrador Fabricantes";
            frmbus.ShowDialog();

        }

    }
}
