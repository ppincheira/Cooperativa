using Implement;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class LecturasConceptosBus
    {
        public long LecturasConceptosAdd (LecturasConceptos oLC)
        {
            LecturasConceptosImpl auxImple = new LecturasConceptosImpl();
            return auxImple.LecturasConceptosAdd(oLC);
        }

        public bool LecturasConceptosUpdate(LecturasConceptos oLC)
        {
            LecturasConceptosImpl auxImple = new LecturasConceptosImpl();
            return auxImple.LecturasConceptosUpdate(oLC);
        }

        public bool LecturasConceptosDelete(string oLC)
        {
            LecturasConceptosImpl auxImple = new LecturasConceptosImpl();
            return auxImple.LecturasConceptosDelete(oLC);
        }

        public LecturasConceptos LecturasConceptosGetById(long oLC)
        {
            LecturasConceptosImpl auxImple = new LecturasConceptosImpl();
            return auxImple.LecturasConceptosGetById(oLC);
        }

        public DataTable LecturasConceptosGetAllDT()
        {
            LecturasConceptosImpl auxImple = new LecturasConceptosImpl();
            return auxImple.LecturasConceptosGetAllDT();
        }

        public List<LecturasConceptos> TiposMedidoresGetAll( )
        {
            LecturasConceptosImpl auxImple = new LecturasConceptosImpl();
            return auxImple.LecturasConceptosGetAll();
        }



    }
}
