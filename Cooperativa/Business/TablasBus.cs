using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Implement;
using Model;

namespace Business
{
    public class TablasBus
    {
        public int TablasAdd(Tablas oTablas)
        {
            TablasImpl oTablasImpl = new TablasImpl();
            return oTablasImpl.TablasAdd(oTablas);
        }

        public bool TablasUpdate(Tablas oTablas)
        {
            TablasImpl oTablasImpl = new TablasImpl();
            return oTablasImpl.TablasUpdate(oTablas);
        }

        public bool TablasDelete(String Id)
        {
            TablasImpl oTablasImpl = new TablasImpl();
            return oTablasImpl.TablasDelete(Id);
        }

        public Tablas TablasGetById(string Id)
        {
            TablasImpl oTablasImpl = new TablasImpl();
            return oTablasImpl.TablasGetById(Id);
        }

        public List<Tablas> TablasGetAll()
        {
            TablasImpl oTablasImpl = new TablasImpl();
            return oTablasImpl.TablasGetAll();
        }

        public DataTable TablasBusquedaGetAllFilter(string Codigo, string Campos ,string filterCampos, string filterValores) {

            Tablas oTabla = new Tablas();
            oTabla = TablasGetById(Codigo);
            TablasImpl oTablasImpl = new TablasImpl();
            return oTablasImpl.TablasBusquedaGetAllFilter(oTabla.TabNombre, Campos, filterCampos, filterValores);

        }

    }
}
