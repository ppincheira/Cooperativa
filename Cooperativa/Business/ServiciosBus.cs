﻿using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class ServiciosBus
    {
        public int ServiciosAdd(Servicios oServicios)
        {
            ServiciosImpl oServiciosImpl = new ServiciosImpl();
            return oServiciosImpl.ServiciosAdd(oServicios);
        }

        public bool ServiciosUpdate(Servicios oServicios)
        {
            ServiciosImpl oServiciosImpl = new ServiciosImpl();
            return oServiciosImpl.ServiciosUpdate(oServicios);
        }

        public bool ServiciosDelete(string Id)
        {
            ServiciosImpl oServiciosImpl = new ServiciosImpl();
            return oServiciosImpl.ServiciosDelete(Id);
        }

        public Servicios ServiciosGetById(string Id)
        {
            ServiciosImpl oServiciosImpl = new ServiciosImpl();
            return oServiciosImpl.ServiciosGetById(Id);
        }

        public List<Servicios> ServiciosGetAll()
        {
            ServiciosImpl oServiciosImpl = new ServiciosImpl();
            return oServiciosImpl.ServiciosGetAll();
        }
    }
}
