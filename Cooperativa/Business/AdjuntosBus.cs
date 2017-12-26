using Model;
using Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Business
{
    public class AdjuntosBus
    {
        public int AdjuntosAdd(Adjuntos oAdjunto)
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntosAdd(oAdjunto);
        }

        public bool AdjuntoUpdate(Adjuntos oAdjunto)
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntosUpdate(oAdjunto);
        }

        public bool AdjuntosDelete(long Id)
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntosDelete(Id);
        }

        public Adjuntos AdjuntosGetById(long Id)
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntosGetById(Id);
        }

        public Boolean AdjuntoExisteByCodigoRegistro(long Id) {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntoExisteByCodigoRegistro(Id);
        }
        public Adjuntos AdjuntosGetByCodigoRegistro(long Id)
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntosGetByCodigoRegistro(Id);
        }

        public DataTable AdjuntoGetAdjuntoById(long Id)
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntoGetAdjuntoById(Id);
        }
        public List<Adjuntos> AdjuntosGetAll()
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntosGetAll();
        }

    }
}
