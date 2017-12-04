﻿using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class EmpresasBus
    {
        public int EmpresasAdd(Empresas oEmpresas)
        {
            EmpresasImpl oEmpresasImpl = new EmpresasImpl();
            return oEmpresasImpl.EmpresasAdd(oEmpresas);
        }

        public bool EmpresasUpdate(Empresas oEmpresas)
        {
            EmpresasImpl oEmpresasImpl = new EmpresasImpl();
            return oEmpresasImpl.EmpresasUpdate(oEmpresas);
        }

        public bool EmpresasDelete(long Id)
        {
            EmpresasImpl oEmpresasImpl = new EmpresasImpl();
            return oEmpresasImpl.EmpresasDelete(Id);
        }

        public Empresas EmpresasGetById(long Id)
        {
            EmpresasImpl oEmpresasImpl = new EmpresasImpl();
            return oEmpresasImpl.EmpresasGetById(Id);
        }

        public List<Empresas> EmpresasGetAll()
        {
            EmpresasImpl oEmpresasImpl = new EmpresasImpl();
            return oEmpresasImpl.EmpresasGetAll();
        }
    }
}