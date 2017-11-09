using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public partial class Empresas {
        public Empresas() {
/*			fabricantes = new List<Fabricante>();
			telefonos = new List<Telefono>();
			domicilios = new List<Domicilio>();
			medidores = new List<Medidore>();
  */
        }
        public virtual long empNumero { get; set; }
        public virtual string empRazonSocial { get; set; }
        public virtual string empDenominacionComercial { get; set; }
        public virtual string empCuit { get; set; }
        public virtual string tivCodigo { get; set; }
        public virtual DateTime empFechaAltaPro { get; set; }
        public virtual DateTime? empFechaBajaPro { get; set; }
        public virtual string empObservacion { get; set; }
        public virtual string empTitularCheques { get; set; }
        public virtual string empPropia { get; set; }
        public virtual string empProveedor { get; set; }
        public virtual string empCliente { get; set; }
        public virtual DateTime? empFechaAltaCli { get; set; }
        public virtual DateTime? empFechaBajaCli { get; set; }
        public virtual string empCategoriaMonotributo { get; set; }
        public virtual string empTipoDni { get; set; }
        public virtual string empDniNumero { get; set; }
        public virtual DateTime? empFechaAlta { get; set; }
        public virtual int usrNumeroCarga { get; set; }
        public virtual string apellidos { get; set; }
        public virtual string nombres { get; set; }
/*        public virtual IList<Fabricante> fabricantes { get; set; }
        public virtual IList<Telefono> telefonos { get; set; }
        public virtual IList<Domicilio> domicilios { get; set; }
        public virtual IList<Medidore> medidores { get; set; }
  */
    }
}
