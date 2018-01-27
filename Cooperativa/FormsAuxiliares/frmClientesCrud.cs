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
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "DOMB";
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
            frmbus.ShowDialog();
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "TETE";
            oAdmin.Tipo = Admin.enumTipoForm.Selector;
            FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            if (frmbus.ShowDialog() == DialogResult.OK)
            {
                string nombre = frmbus.striRdoCodigo;
            }
            frmbus.ShowDialog();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "TEEM";
            FormsAuxiliares.frmFormAdmin frmbus = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
            frmbus.ShowDialog();

        }
    }
}
