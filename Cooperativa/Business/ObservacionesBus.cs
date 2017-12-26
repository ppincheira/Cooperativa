using System.Collections.Generic;
using Implement;
using Model;
using System;
using System.Data;

namespace Business
{
    public class ObservacionesBus
    {
        public long ObservacionesAdd(Observaciones oObservaciones)
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

        public DataTable ObservacionesGetByFilter(string tabCodigo, int tobCodigo, string obsCodigoRegistro, DateTime fechaDesde, DateTime fechaHasta)
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesGetByFilter(tabCodigo, tobCodigo, obsCodigoRegistro, fechaDesde, fechaHasta);

        }

        public DataTable ObservacionesGetAdjuntoById(int Id)
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesGetAdjuntoById(Id);

        }
    }
}
