using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class ServiciosCategoriasBus
    {
        public int ServiciosCategoriasAdd(ServiciosCategorias oServiciosCategorias)
        {
            ServiciosCategoriasImpl oServiciosCategoriasImpl = new ServiciosCategoriasImpl();
            return oServiciosCategoriasImpl.ServiciosCategoriasAdd(oServiciosCategorias);
        }

        public bool ServiciosCategoriasUpdate(ServiciosCategorias oServiciosCategorias)
        {
            ServiciosCategoriasImpl oServiciosCategoriasImpl = new ServiciosCategoriasImpl();
            return oServiciosCategoriasImpl.ServiciosCategoriasUpdate(oServiciosCategorias);
        }

        public bool ServiciosCategoriasDelete(long Id)
        {
            ServiciosCategoriasImpl oServiciosCategoriasImpl = new ServiciosCategoriasImpl();
            return oServiciosCategoriasImpl.ServiciosCategoriasDelete(Id);
        }

        public ServiciosCategorias ServiciosCategoriasGetById(long Id)
        {
            ServiciosCategoriasImpl oServiciosCategoriasImpl = new ServiciosCategoriasImpl();
            return oServiciosCategoriasImpl.ServiciosCategoriasGetById(Id);
        }

        public List<ServiciosCategorias> ServiciosCategoriasGetAll()
        {
            ServiciosCategoriasImpl oServiciosCategoriasImpl = new ServiciosCategoriasImpl();
            return oServiciosCategoriasImpl.ServiciosCategoriasGetAll();
        }
    }
}
