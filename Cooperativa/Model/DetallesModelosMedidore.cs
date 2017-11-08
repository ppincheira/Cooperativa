using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public partial class DetallesModelosMedidore {
        public DetallesModelosMedidore() {
//			medidores = new List<Medidore>();
        }
        public virtual string dmeCodigo { get; set; }
        public virtual string dmeDescripcion { get; set; }
        public virtual string dmeDescripcionCorta { get; set; }
        public virtual int? dmeDigitos { get; set; }
        public virtual int? dmeDecimales { get; set; }
        public virtual int? dmeCantHilos { get; set; }
        public virtual int? dmeKwVueltas { get; set; }
        public virtual string dmeAmperaje { get; set; }
        public virtual int? dmeClase { get; set; }
        public virtual decimal? dmeRegistrador { get; set; }
        public virtual string dmeTipoContador { get; set; }
        public virtual string dmeTipoConexion { get; set; }
        public virtual int fabNumero { get; set; }
        public virtual string tmeCodigo { get; set; }
        public virtual int usrNumero { get; set; }
        public virtual DateTime dmeFechaCarga { get; set; }
//        public virtual IList<Medidore> medidores { get; set; }
    }
}
