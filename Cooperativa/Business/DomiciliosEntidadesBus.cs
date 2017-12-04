﻿using System.Collections.Generic;
using Implement;
using Model;


namespace Business
{
    public class DomiciliosEntidadesBus
    {

        public int DomiciliosEntidadesAdd(DomiciliosEntidades oDomiciliosEntidades)
        {
            DomiciliosEntidadesImpl oDomiciliosEntidadesImpl = new DomiciliosEntidadesImpl();
            return oDomiciliosEntidadesImpl.DomiciliosEntidadesAdd(oDomiciliosEntidades);
        }

        public bool DomiciliosEntidadesUpdate(DomiciliosEntidades oDomiciliosEntidades)
        {
            DomiciliosEntidadesImpl oDomiciliosEntidadesImpl = new DomiciliosEntidadesImpl();
            return oDomiciliosEntidadesImpl.DomiciliosEntidadesUpdate(oDomiciliosEntidades);
        }

        public bool DomiciliosEntidadesDelete(long Id)
        {
            DomiciliosEntidadesImpl oDomiciliosEntidadesImpl = new DomiciliosEntidadesImpl();
            return oDomiciliosEntidadesImpl.DomiciliosEntidadesDelete(Id);
        }

        public DomiciliosEntidades DomiciliosEntidadesGetById(long Id)
        {
            DomiciliosEntidadesImpl oDomiciliosEntidadesImpl = new DomiciliosEntidadesImpl();
            return oDomiciliosEntidadesImpl.DomiciliosEntidadesGetById(Id);
        }

        public List<DomiciliosEntidades> DomiciliosEntidadesGetAll()
        {
            DomiciliosEntidadesImpl oDomiciliosEntidadesImpl = new DomiciliosEntidadesImpl();
            return oDomiciliosEntidadesImpl.DomiciliosEntidadesGetAll();
        }
    }
}
