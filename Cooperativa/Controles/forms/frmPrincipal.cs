using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controles;
namespace Controles
{
    public class frmPrincipal: gesForm
    {
        private contenedores.mnuMenuPrincipal mnuMenuPrincipal1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private datos.trvMenu trvMenu;

        public frmPrincipal()
        {
            this.IsMdiContainer = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
            //salirToolStripMenuItem.Click += ;

        }

 

        public void InitializeComponent() {
            this.trvMenu = new Controles.datos.trvMenu();
            this.mnuMenuPrincipal1 = new Controles.contenedores.mnuMenuPrincipal();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuPrincipal1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvMenu
            // 
            this.trvMenu.Location = new System.Drawing.Point(0, 24);
            this.trvMenu.Name = "trvMenu";
            this.trvMenu.Size = new System.Drawing.Size(400, 800);
            this.trvMenu.TabIndex = 0;
            // 
            // mnuMenuPrincipal1
            // 
            this.mnuMenuPrincipal1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.mnuMenuPrincipal1.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuPrincipal1.Name = "mnuMenuPrincipal1";
            this.mnuMenuPrincipal1.Size = new System.Drawing.Size(284, 24);
            this.mnuMenuPrincipal1.TabIndex = 1;
            this.mnuMenuPrincipal1.Text = "mnuMenuPrincipal1";
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
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cambiarClaveToolStripMenuItem.Text = "Cambiar clave";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.trvMenu);
            this.Controls.Add(this.mnuMenuPrincipal1);
            this.MainMenuStrip = this.mnuMenuPrincipal1;
            this.Name = "frmPrincipal";
            this.mnuMenuPrincipal1.ResumeLayout(false);
            this.mnuMenuPrincipal1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
