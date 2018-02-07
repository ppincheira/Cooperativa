using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AdminObs
    {
        public enum enumTipoForm { Selector, Filtro, Ninguna };
        public AdminObs()
        {
        }
        public virtual string CodigoRegistro { get; set; }
        public virtual string TabCodigo { get; set; }
        public virtual int TobCodigo { get; set; }

        private enumTipoForm tipos = enumTipoForm.Ninguna;
        public virtual enumTipoForm Tipo
        {
            get { return tipos; }
            set { tipos = value; }
        }
    }
}
