using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class CodigosPostalesLocalidades {
        public CodigosPostalesLocalidades() {
//			Domicilios = new List<Domicilio>();
        }
        public virtual int CplNumero { get; set; }
        public virtual string CplDescripcion { get; set; }
        public virtual string CplCodigoPostal { get; set; }
        public virtual int LocNumero { get; set; }
//        public virtual IList<Domicilio> Domicilios { get; set; }
    }
}
