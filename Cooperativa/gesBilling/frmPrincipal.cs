using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controles;
namespace gesBilling
{
    class frmPrincipal:Controles.gesForm
    {
        public frmPrincipal()
        {
            frmBusqueda vtnBusqueda = new frmBusqueda();
            vtnBusqueda.Show();
        }
    }
}
