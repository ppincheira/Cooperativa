using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implement;
using Model;

namespace Business
{
    public class DetallesModelosMedidoresBus
    {
        public int DetallesModelosMedidoresAdd(DetallesModelosMedidores oDetallesModelosMedidores)
        {
            DetallesModelosMedidoresImpl oDetallesModelosMedidoresImpl = new DetallesModelosMedidoresImpl();
            return oDetallesModelosMedidoresImpl.DetallesModelosMedidoresAdd(oDetallesModelosMedidores);
        }

        public bool DetallesModelosMedidoresUpdate(DetallesModelosMedidores oDetallesModelosMedidores)
        {
            DetallesModelosMedidoresImpl oDetallesModelosMedidoresImpl = new DetallesModelosMedidoresImpl();
            return oDetallesModelosMedidoresImpl.DetallesModelosMedidoresUpdate(oDetallesModelosMedidores);
        }

        public bool DetallesModelosMedidoresDelete(string Id)
        {
            DetallesModelosMedidoresImpl oDetallesModelosMedidoresImpl = new DetallesModelosMedidoresImpl();
            return oDetallesModelosMedidoresImpl.DetallesModelosMedidoresDelete(Id);
        }

        public DetallesModelosMedidores DetallesModelosMedidoresGetById(string Id)
        {
            DetallesModelosMedidoresImpl oDetallesModelosMedidoresImpl = new DetallesModelosMedidoresImpl();
            return oDetallesModelosMedidoresImpl.DetallesModelosMedidoresGetById(Id);
        }

        public List<DetallesModelosMedidores> DetallesModelosMedidoresGetAll()
        {
            DetallesModelosMedidoresImpl oDetallesModelosMedidoresImpl = new DetallesModelosMedidoresImpl();
            return oDetallesModelosMedidoresImpl.DetallesModelosMedidoresGetAll();
        }
    }
}
