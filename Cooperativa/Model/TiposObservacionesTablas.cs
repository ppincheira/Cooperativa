using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class TiposObservacionesTablas {
        public TiposObservacionesTablas() {
/*			Observaciones = new List<Observacione>();
			Observaciones = new List<Observacione>();
*/        }
        public virtual string TabCodigo { get; set; }
        public virtual string TobCodigo { get; set; }
        public virtual string TobDescripcion { get; set; }
/*        public virtual IList<Observacione> Observaciones { get; set; }
        public virtual IList<Observacione> Observaciones { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as TiposObservacionesTabla;
			if (t == null) return false;
			if (TabCodigo == t.TabCodigo
			 && TobCodigo == t.TobCodigo)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ TabCodigo.GetHashCode();
			hash = (hash * 397) ^ TobCodigo.GetHashCode();

			return hash;
        }
        #endregion
*/
    }
}
