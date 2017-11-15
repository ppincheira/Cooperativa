using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class CallesLocalidades {
        public CallesLocalidades() {
        }
        public virtual int CalNumero { get; set; }
        public virtual string CalDescripcion { get; set; }
        public virtual string PaiCodigo { get; set; }
        public virtual string PrvCodigo { get; set; }
        public virtual int LocNumero { get; set; }
    }
}
