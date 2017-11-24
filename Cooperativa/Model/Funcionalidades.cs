using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Funcionalidades {
        public Funcionalidades() {
//			RolesFuncionalidades = new List<RolesFuncionalidade>();
        }
        public virtual string FunCodigo { get; set; }
        public virtual string FunDescripcion { get; set; }
        public virtual string FunFuncionalidad { get; set; }
        public virtual string SbsCodigo { get; set; }
//        public virtual IList<RolesFuncionalidade> RolesFuncionalidades { get; set; }
    }
}
