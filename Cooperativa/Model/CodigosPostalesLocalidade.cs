using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class CodigosPostalesLocalidade {
        public CodigosPostalesLocalidade() {
        }
        public virtual int CplNumero { get; set; }
        public virtual int LocNumero { get; set; }
        public virtual string CplDescripcion { get; set; }
        public virtual string PaiCodigo { get; set; }
        public virtual string PrvCodigo { get; set; }
        public virtual string CplCodigoPostal { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as CodigosPostalesLocalidade;
			if (t == null) return false;
			if (CplNumero == t.CplNumero
			 && PaiCodigo == t.PaiCodigo
			 && PrvCodigo == t.PrvCodigo
			 && LocNumero == t.LocNumero)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ CplNumero.GetHashCode();
			hash = (hash * 397) ^ PaiCodigo.GetHashCode();
			hash = (hash * 397) ^ PrvCodigo.GetHashCode();
			hash = (hash * 397) ^ LocNumero.GetHashCode();

			return hash;
        }
        #endregion
    }
}
