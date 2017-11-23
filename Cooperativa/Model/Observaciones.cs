using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Observaciones {
        public Observaciones()
        {
        }
        public virtual long? ObsNumero { get; set; }
        public virtual string CotClaveBusqueda { get; set; }
        public virtual string ObsDetalle { get; set; }
        public virtual DateTime? ObsFechaCarga { get; set; }
        public virtual string TabCodigo { get; set; }
        public virtual string TobCodigo { get; set; }
    }
}
