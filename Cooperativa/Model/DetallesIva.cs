using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class DetallesIva {

        public DetallesIva()
        {

        }
        public virtual string tivCodigo { get; set; }
        public virtual float divPorcentaje { get; set; }
        public virtual DateTime divVigenciaDesde { get; set; }
        public virtual DateTime? divVigenciaHasta { get; set; }
    }
}
