using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Localidades {
        public Localidades() {
/*			barrios = new List<Barrio>();
			barrios = new List<Barrio>();
			barrios = new List<Barrio>();
			callesLocalidades = new List<CallesLocalidade>();
			callesLocalidades = new List<CallesLocalidade>();
			callesLocalidades = new List<CallesLocalidade>();
			codigosPostalesLocalidades = new List<CodigosPostalesLocalidade>();
			codigosPostalesLocalidades = new List<CodigosPostalesLocalidade>();
			codigosPostalesLocalidades = new List<CodigosPostalesLocalidade>();
*/
        }
        public virtual string PaiCodigo { get; set; }
        public virtual string PrvCodigo { get; set; }
        public virtual int LocNumero { get; set; }
        public virtual string LocDescripcion { get; set; }
        public virtual string TloCodigo { get; set; }
        /*        public virtual IList<Barrio> barrios { get; set; }
                public virtual IList<Barrio> barrios { get; set; }
                public virtual IList<Barrio> barrios { get; set; }
                public virtual IList<CallesLocalidade> callesLocalidades { get; set; }
                public virtual IList<CallesLocalidade> callesLocalidades { get; set; }
                public virtual IList<CallesLocalidade> callesLocalidades { get; set; }
                public virtual IList<CodigosPostalesLocalidade> codigosPostalesLocalidades { get; set; }
                public virtual IList<CodigosPostalesLocalidade> codigosPostalesLocalidades { get; set; }
                public virtual IList<CodigosPostalesLocalidade> codigosPostalesLocalidades { get; set; }
                #region NHibernate Composite Key Requirements
                public override bool Equals(object obj) {
                    if (obj == null) return false;
                    var t = obj as localidade;
                    if (t == null) return false;
                    if (paiCodigo == t.paiCodigo
                     && prvCodigo == t.prvCodigo
                     && locNumero == t.locNumero)
                        return true;

                    return false;
                }
                public override int GetHashCode() {
                    int hash = GetType().GetHashCode();
                    hash = (hash * 397) ^ paiCodigo.GetHashCode();
                    hash = (hash * 397) ^ prvCodigo.GetHashCode();
                    hash = (hash * 397) ^ locNumero.GetHashCode();

                    return hash;
                }
                #endregion
        */
    }
}
