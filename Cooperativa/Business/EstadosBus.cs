using System;
using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class EstadosBus
    {
        public int EstadosAdd(Estados oEstados)
        {
            EstadosImpl oEstadosImpl = new EstadosImpl();
            return oEstadosImpl.EstadosAdd(oEstados);
        }

        public bool EstadosUpdate(Estados oEstados)
        {
            EstadosImpl oEstadosImpl = new EstadosImpl();
            return oEstadosImpl.EstadosUpdate(oEstados);
        }

        public bool EstadosDelete(String Id)
        {
            EstadosImpl oEstadosImpl = new EstadosImpl();
            return oEstadosImpl.EstadosDelete(Id);
        }

        public Estados EstadosGetById(string Id)
        {
            EstadosImpl oEstadosImpl = new EstadosImpl();
            return oEstadosImpl.EstadosGetById(Id);
        }

        public List<Estados> EstadosGetAll()
        {
            EstadosImpl oEstadosImpl = new EstadosImpl();
            return oEstadosImpl.EstadosGetAll();
        }
    }
}
