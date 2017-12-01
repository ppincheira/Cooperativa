namespace Model
{

    public class Localidades {
        public Localidades() {
/*			CallesLocalidades = new List<CallesLocalidade>();
			CodigosPostalesLocalidades = new List<CodigosPostalesLocalidade>();
			BarriosLocalidades = new List<BarriosLocalidade>();
*/        }
        public virtual int LocNumero { get; set; }
        public virtual string PrvCodigo { get; set; }
        public virtual string LocDescripcion { get; set; }
        public virtual string TloCodigo { get; set; }
/*        public virtual IList<CallesLocalidade> CallesLocalidades { get; set; }
        public virtual IList<CodigosPostalesLocalidade> CodigosPostalesLocalidades { get; set; }
        public virtual IList<BarriosLocalidade> BarriosLocalidades { get; set; }
*/    }
}
