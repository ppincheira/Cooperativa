using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public partial class Dominios {
        public virtual string dmnCodigo { get; set; }
        public virtual string dmnValor { get; set; }
        public virtual string dmnDescripcion { get; set; }
        public virtual string dmnActivo { get; set; }
        public virtual string dmnDefault { get; set; }
 /*       #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as dominio;
			if (t == null) return false;
			if (dmnCodigo == t.dmnCodigo
			 && dmnValor == t.dmnValor)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ dmnCodigo.GetHashCode();
			hash = (hash * 397) ^ dmnValor.GetHashCode();

			return hash;
        }
        #endregion
   */
    }
}
