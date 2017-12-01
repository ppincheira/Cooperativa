﻿using System.Collections.Generic;
using Implement;
using Model;


namespace Business
{
    public class DomiciliosBus
    {

        public int DomiciliosAdd(Domicilios oDomicilios)
        {
            DomiciliosImpl oDomiciliosImpl = new DomiciliosImpl();
            return oDomiciliosImpl.DomiciliosAdd(oDomicilios);
        }

        public bool DomiciliosUpdate(Domicilios oDomicilios)
        {
            DomiciliosImpl oDomiciliosImpl = new DomiciliosImpl();
            return oDomiciliosImpl.DomiciliosUpdate(oDomicilios);
        }

        public bool DomiciliosDelete(long Id)
        {
            DomiciliosImpl oDomiciliosImpl = new DomiciliosImpl();
            return oDomiciliosImpl.DomiciliosDelete(Id);
        }

        public Domicilios DomiciliosGetById(long Id)
        {
            DomiciliosImpl oDomiciliosImpl = new DomiciliosImpl();
            return oDomiciliosImpl.DomiciliosGetById(Id);
        }

        public List<Domicilios> DomiciliosGetAll()
        {
            DomiciliosImpl oDomiciliosImpl = new DomiciliosImpl();
            return oDomiciliosImpl.DomiciliosGetAll();
        }
    }
}
