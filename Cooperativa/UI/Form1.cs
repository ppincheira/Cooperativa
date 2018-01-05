using System;
using System.Windows.Forms;
using Business;
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
                this.lblPersonalizado1.Text=oPrueba.GetAllDT().Rows.Count.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnPersonalizado2_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0","0"); 
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
            FormsAuxiliares.frmCrudGrillaN frmbus = new FormsAuxiliares.frmCrudGrillaN("AREC", "CODIGO", false);
            frmbus.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormsAuxiliares.frmObservacionesAdmin frmobs = new FormsAuxiliares.frmObservacionesAdmin("PERS",1,"1");
            frmobs.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Aqui se utiliza una clase para asignar la funcionalidad a formularios admin cargados dinamicamente
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0","0");
            //Se instancia un objeto de la clase formulario admin al cual se le pasa por parametro el COD_TABLA
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin("SRUT",oPermiso);
            frmbus.ShowDialog();
        }

        private void btnPersonalizado4_Click(object sender, EventArgs e)
        {

            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini("CALB", oPermiso);
            frmbus.ShowDialog();
        }

        private void btnPersonalizado5_Click(object sender, EventArgs e)
        {
            FormsAuxiliares.frmTelefonosAdmin frmobs = new FormsAuxiliares.frmTelefonosAdmin("PERS", "1");
            frmobs.ShowDialog();
        }

        private void btnPersonalizado6_Click(object sender, EventArgs e)
        {

            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini("COPB", oPermiso);
            frmbus.ShowDialog();
        }
    }
}
