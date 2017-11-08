using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public partial class Estados {
        public virtual string estCodigo { get; set; }
        public virtual string estDescripcion { get; set; }
        public virtual string estDescripcionCorta { get; set; }
        public virtual string estEntidad { get; set; }
        public virtual string estTipoDato { get; set; }
    }
}
