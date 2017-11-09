using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public partial class Domicilios {
        public virtual long domCodigo { get; set; }
        public virtual string tdoCodigo { get; set; }
        public virtual string paiCodigo { get; set; }
        public virtual string prvCodigo { get; set; }
        public virtual int locNumero { get; set; }
        public virtual int calNumero { get; set; }
        public virtual int calNumeroDesde { get; set; }
        public virtual int calNumeroHasta { get; set; }
        public virtual int domNumero { get; set; }
        public virtual string domBloque { get; set; }
        public virtual string domPiso { get; set; }
        public virtual string domDepartamento { get; set; }
        public virtual string domParcela { get; set; }
        public virtual int cplNumero { get; set; }
        public virtual long empNumero { get; set; }
        public virtual int prsNumero { get; set; }
        public virtual decimal? domGisX { get; set; }
        public virtual decimal? domGisY { get; set; }
        public virtual string domLote { get; set; }
    }
}
