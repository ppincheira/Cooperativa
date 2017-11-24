using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Domicilios {
        public Domicilios()
        {
        }
        public virtual long DomCodigo { get; set; }
        public virtual string TdoCodigo { get; set; }
        public virtual string PaiCodigo { get; set; }
        public virtual string PrvCodigo { get; set; }
        public virtual int LocNumero { get; set; }
        public virtual int CalNumero { get; set; }
        public virtual int CalNumeroDesde { get; set; }
        public virtual int CalNumeroHasta { get; set; }
        public virtual int DomNumero { get; set; }
        public virtual string DomBloque { get; set; }
        public virtual string DomPiso { get; set; }
        public virtual string DomDepartamento { get; set; }
        public virtual string DomParcela { get; set; }
        public virtual int CplNumero { get; set; }
        public virtual long EmpNumero { get; set; }
        public virtual int PrsNumero { get; set; }
        public virtual decimal? DomGisX { get; set; }
        public virtual decimal? DomGisY { get; set; }
        public virtual string DomLote { get; set; }
    }
}
