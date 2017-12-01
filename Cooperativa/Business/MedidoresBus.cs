﻿using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class MedidoresBus
    {
        public int MedidoresAdd(Medidores oMedidores)
        {
            MedidoresImpl oMedidoresImpl = new MedidoresImpl();
            return oMedidoresImpl.MedidoresAdd(oMedidores);
        }

        public bool MedidoresUpdate(Medidores oMedidores)
        {
            MedidoresImpl oMedidoresImpl = new MedidoresImpl();
            return oMedidoresImpl.MedidoresUpdate(oMedidores);
        }

        public bool MedidoresDelete(long Id)
        {
            MedidoresImpl oMedidoresImpl = new MedidoresImpl();
            return oMedidoresImpl.MedidoresDelete(Id);
        }

        public Medidores MedidoresGetById(long Id)
        {
            MedidoresImpl oMedidoresImpl = new MedidoresImpl();
            return oMedidoresImpl.MedidoresGetById(Id);
        }

        public List<Medidores> MedidoresGetAll()
        {
            MedidoresImpl oMedidoresImpl = new MedidoresImpl();
            return oMedidoresImpl.MedidoresGetAll();
        }
    }
}
