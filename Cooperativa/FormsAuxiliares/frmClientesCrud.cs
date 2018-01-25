using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAuxiliares
{
    public partial class frmClientesCrud : Form
    {
        public frmClientesCrud()
        {
            InitializeComponent();
        }

        private void frmClientesCrud_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
                FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
                FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin("DOMB", oPermiso);
                frmbus.ShowDialog();
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin("TETE", oPermiso);
            frmbus.ShowDialog();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin("TEEM", oPermiso);
            frmbus.ShowDialog();

        }
    }
}
