using System;


namespace Model
{

    public class Empresas {
        public Empresas() {
/*			Fabricantes = new List<Fabricante>();
			Telefonos = new List<Telefono>();
			Medidores = new List<Medidore>();
			Accionistas = new List<Accionista>();
*/
        }
        public virtual long EmpNumero { get; set; }
        public virtual string EmpRazonSocial { get; set; }
        public virtual string EmpDenominacionComercial { get; set; }
        public virtual string EmpCuit { get; set; }
        public virtual string TivCodigo { get; set; }
        public virtual DateTime EmpFechaAltaPro { get; set; }
        public virtual DateTime? EmpFechaBajaPro { get; set; }
        public virtual string EmpObservacion { get; set; }
        public virtual string EmpTitularCheques { get; set; }
        public virtual string EmpPropia { get; set; }
        public virtual string EmpProveedor { get; set; }
        public virtual string EmpCliente { get; set; }
        public virtual DateTime? EmpFechaAltaCli { get; set; }
        public virtual DateTime? EmpFechaBajaCli { get; set; }
        public virtual string EmpCategoriaMonotributo { get; set; }
        public virtual string EmpTipoDni { get; set; }
        public virtual string EmpDniNumero { get; set; }
        public virtual DateTime? EmpFechaAlta { get; set; }
        public virtual int UsrNumeroCarga { get; set; }
        public virtual string Apellidos { get; set; }
        public virtual string Nombres { get; set; }
        public virtual string EstCodigoPro { get; set; }
        public virtual string EstCodigoCli { get; set; }

        /*        public virtual IList<Fabricante> Fabricantes { get; set; }
                public virtual IList<Telefono> Telefonos { get; set; }
                public virtual IList<Medidore> Medidores { get; set; }
                public virtual IList<Accionista> Accionistas { get; set; }
        */
    }
}
