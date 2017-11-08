using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public partial class Fabricantes {
        public Fabricantes() {
/*			tmeFabs = new List<TmeFab>();
			detallesModelosMedidores = new List<DetallesModelosMedidore>();
  */      }
        public virtual int fabNumero { get; set; }
        public virtual string fabDescripcion { get; set; }
        public virtual string fabHabilitado { get; set; }
        public virtual long empNumero { get; set; }
        public virtual int usrNumero { get; set; }
        public virtual DateTime fabFechaCarga { get; set; }
//        public virtual IList<TmeFab> tmeFabs { get; set; }
//        public virtual IList<DetallesModelosMedidore> detallesModelosMedidores { get; set; }
    }
}
