using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    public class Barrios {
        public Barrios(){
        }
        public virtual int BarNumero { get; set; }
        public virtual string PaiCodigo { get; set; }
        public virtual string PrvCodigo { get; set; }
        public virtual int LocNumero { get; set; }
        public virtual string BarDescripcion { get; set; }
    }
}
