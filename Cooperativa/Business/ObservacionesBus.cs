using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class ObservacionesBus
    {
        public int ObservacionesAdd(Observaciones oObservaciones)
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesAdd(oObservaciones);
        }

        public bool ObservacionesUpdate(Observaciones oObservaciones)
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesUpdate(oObservaciones);
        }

        public bool ObservacionesDelete(long Id)
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesDelete(Id);
        }

        public Observaciones ObservacionesGetById(long Id)
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesGetById(Id);
        }

        public List<Observaciones> ObservacionesGetAll()
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesGetAll();
        }
    }
}
