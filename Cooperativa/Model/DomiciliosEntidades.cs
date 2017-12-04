using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class DomiciliosEntidades {
        public DomiciliosEntidades() { 
        }
        public virtual long DenNumero { get; set; }
        public virtual string TdoCodigo { get; set; }
        public virtual long? DenIdOrigen { get; set; }
        public virtual string TabCodigo { get; set; }
    }
}
