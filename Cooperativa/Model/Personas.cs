using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Personas {
        public Personas() {
/*			Usuarios = new List<Usuario>();
			PrsSecs = new List<PrsSec>();
			Telefonos = new List<Telefono>();
			Domicilios = new List<Domicilio>();
*/
        }
        public virtual int PrsNumero { get; set; }
        public virtual string PrsApellido { get; set; }
        public virtual string PrsNombre { get; set; }
        public virtual string PrsEstadoCivil { get; set; }
        public virtual string PrsTipoDoc { get; set; }
        public virtual string PrsNumeroDoc { get; set; }
        public virtual string PrsSexo { get; set; }
        public virtual DateTime PrsFechaNacimiento { get; set; }
        public virtual string PaiCodigoNacimiento { get; set; }
        public virtual string PrvCodigoNacimiento { get; set; }
        public virtual int LocNumeroNacimiento { get; set; }
        public virtual DateTime PrsFechaIngreso { get; set; }
        public virtual DateTime PrsFechaBaja { get; set; }
        public virtual string EstCodigo { get; set; }
        public virtual string PrsMotivoBaja { get; set; }
        public virtual int PrsLegajo { get; set; }
        public virtual string PrsCuil { get; set; }
        public virtual string PrsCargo { get; set; }
/*        public virtual IList<Usuario> Usuarios { get; set; }
        public virtual IList<PrsSec> PrsSecs { get; set; }
        public virtual IList<Telefono> Telefonos { get; set; }
        public virtual IList<Domicilio> Domicilios { get; set; }
*/
    }
}
