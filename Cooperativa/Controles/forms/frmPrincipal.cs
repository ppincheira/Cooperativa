using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controles;
using System.Data;
using System.Windows.Forms;
using Business;
using Business.Presentacion;

namespace Controles.forms
{
    public class frmPrincipal: gesForm, IVistaPrincipal
    {

        private  UIPrincipal _oPrincipal;
        private contenedores.mnuMenuPrincipal mnuMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        public contenedores.sstBarraEstado sstBarraEstado;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private datos.trvMenu trvMenu;

        #region Implementation of IVistaPrincipal
        public datos.trvMenu otrvMenu
        {
            get { return this.trvMenu; }
            set { this.trvMenu = value; }
        }
        
        #endregion
        public frmPrincipal(string subsistema)
        {
            this.IsMdiContainer = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
        }

 

        public void InitializeComponent() {
            this.trvMenu = new Controles.datos.trvMenu();
            this.mnuMenuPrincipal = new Controles.contenedores.mnuMenuPrincipal();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sstBarraEstado = new Controles.contenedores.sstBarraEstado();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMenuPrincipal.SuspendLayout();
            this.sstBarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvMenu
            // 
            this.trvMenu.Location = new System.Drawing.Point(0, 24);
            this.trvMenu.Name = "trvMenu";
            this.trvMenu.Size = new System.Drawing.Size(400, 800);
            this.trvMenu.TabIndex = 0;
             
            // mnuMenuPrincipal
            // 
            this.mnuMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.mnuMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuPrincipal.Name = "mnuMenuPrincipal";
            this.mnuMenuPrincipal.Size = new System.Drawing.Size(284, 24);
            this.mnuMenuPrincipal.TabIndex = 1;
            this.mnuMenuPrincipal.Text = "mnuMenuPrincipal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarClaveToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cambiarClaveToolStripMenuItem
            // 
            this.cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cambiarClaveToolStripMenuItem.Text = "Cambiar clave";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // sstBarraEstado
            // 
            this.sstBarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.sstBarraEstado.Location = new System.Drawing.Point(0, 239);
            this.sstBarraEstado.Name = "sstBarraEstado";
            this.sstBarraEstado.Size = new System.Drawing.Size(284, 22);
            this.sstBarraEstado.TabIndex = 2;
            this.sstBarraEstado.Text = "sstBarraEstado";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sstBarraEstado);
            this.Controls.Add(this.trvMenu);
            this.Controls.Add(this.mnuMenuPrincipal);
            this.MainMenuStrip = this.mnuMenuPrincipal;
            this.Name = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnuMenuPrincipal.ResumeLayout(false);
            this.mnuMenuPrincipal.PerformLayout();
            this.sstBarraEstado.ResumeLayout(false);
            this.sstBarraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #region << EVENTOS >>


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            _oPrincipal.InicializarArbol();
        }
        #endregion




    }
}
