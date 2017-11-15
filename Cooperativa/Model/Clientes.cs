using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Clientes {

        #region Constructors
        public Clientes() { }
        #endregion


        #region Properties
        public virtual decimal Id { get; set; }
        public virtual string Nombres { get; set; }
        public virtual string Apellido { get; set; }
        public virtual decimal? Puntos { get; set; }
        public virtual DateTime? Miembrodesde { get; set; }
        public virtual string Credito { get; set; }
        public virtual decimal? Gastopromedio { get; set; }
        public virtual string Calle { get; set; }
        public virtual string Ciudad { get; set; }
        public virtual string Provincia { get; set; }
        public virtual string Pais { get; set; }
        #endregion  
    }
}
