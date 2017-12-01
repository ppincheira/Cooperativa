using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class TelefonosBus
    {
        public int TelefonosAdd(Telefonos oTelefonos)
        {
            TelefonosImpl oTelefonosImpl = new TelefonosImpl();
            return oTelefonosImpl.TelefonosAdd(oTelefonos);
        }

        public bool TelefonosUpdate(Telefonos oTelefonos)
        {
            TelefonosImpl oTelefonosImpl = new TelefonosImpl();
            return oTelefonosImpl.TelefonosUpdate(oTelefonos);
        }

        public bool TelefonosDelete(long Id)
        {
            TelefonosImpl oTelefonosImpl = new TelefonosImpl();
            return oTelefonosImpl.TelefonosDelete(Id);
        }

        public Telefonos TelefonosGetById(long Id)
        {
            TelefonosImpl oTelefonosImpl = new TelefonosImpl();
            return oTelefonosImpl.TelefonosGetById(Id);
        }

        public List<Telefonos> TelefonosGetAll()
        {
            TelefonosImpl oTelefonosImpl = new TelefonosImpl();
            return oTelefonosImpl.TelefonosGetAll();
        }
    }
}
