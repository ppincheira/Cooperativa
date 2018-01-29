using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmClientes
{
    public class UIClientesCrud
    {

        private IVistaClientesCrud _vista;
        Utility oUtil;


        public UIClientesCrud(IVistaClientesCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


    }
}
