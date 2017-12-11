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
            PermisosFoms oPermiso = new PermisosFoms("2", "3", "0", "4", "0"); 
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin("PERB", oPermiso);
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
            FormsAuxiliares.frmCrudGrilla frmbus = new FormsAuxiliares.frmCrudGrilla();
            frmbus.ShowDialog();

        }
    }
}
