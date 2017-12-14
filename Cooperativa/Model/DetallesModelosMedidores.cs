using System;


namespace Model
{

    public class DetallesModelosMedidores {
        public DetallesModelosMedidores() {
        }
        public virtual string DmeCodigo { get; set; }
        public virtual string DmeDescripcion { get; set; }
        public virtual string DmeDescripcionCorta { get; set; }
        public virtual int? DmeDigitos { get; set; }
        public virtual int? DmeDecimales { get; set; }
        public virtual int? DmeCantHilos { get; set; }
        public virtual int? DmeKwVueltas { get; set; }
        public virtual string DmeAmperaje { get; set; }
        public virtual int? DmeClase { get; set; }
        public virtual decimal? DmeRegistrador { get; set; }
        public virtual string DmeTipoContador { get; set; }
        public virtual string DmeTipoConexion { get; set; }
        public virtual int FabNumero { get; set; }
        public virtual string TmeCodigo { get; set; }
        public virtual int UsrNumero { get; set; }
        public virtual DateTime DmeFechaCarga { get; set; }
        //        public virtual IList<Medidore> medidores { get; set; }
    }
}
