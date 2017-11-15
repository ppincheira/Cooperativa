using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Implement;
namespace Business
{
    public class PersonasBus
    {
        public int PersonasAdd(Personas oPersonas)
        {
            PersonasImpl oPersonasImpl = new PersonasImpl();
            return oPersonasImpl.PersonasAdd(oPersonas);
        }

        public bool PersonasUpdate(Personas oPersonas)
        {
            PersonasImpl oPersonasImpl = new PersonasImpl();
            return oPersonasImpl.PersonasUpdate(oPersonas);
        }

        public bool PersonasDelete(String Id)
        {
            PersonasImpl oPersonasImpl = new PersonasImpl();
            return oPersonasImpl.PersonasDelete(Id);
        }

        public Personas PersonasGetById(int Id)
        {
            PersonasImpl oPersonasImpl = new PersonasImpl();
            return oPersonasImpl.PersonasGetById(Id);
        }

        public List<Personas> PersonasGetAll()
        {
            PersonasImpl oPersonasImpl = new PersonasImpl();
            return oPersonasImpl.PersonasGetAll();
        }
       
    }
}
