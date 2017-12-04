using System;
using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class FuncionalidadesBus
    {
        public int FuncionalidadesAdd(Funcionalidades oFuncionalidades)
        {
            FuncionalidadesImpl oFuncionalidadesImpl = new FuncionalidadesImpl();
            return oFuncionalidadesImpl.FuncionalidadesAdd(oFuncionalidades);
        }

        public bool FuncionalidadesUpdate(Funcionalidades oFuncionalidades)
        {
            FuncionalidadesImpl oFuncionalidadesImpl = new FuncionalidadesImpl();
            return oFuncionalidadesImpl.FuncionalidadesUpdate(oFuncionalidades);
        }

        public bool FuncionalidadesDelete(String Id)
        {
            FuncionalidadesImpl oFuncionalidadesImpl = new FuncionalidadesImpl();
            return oFuncionalidadesImpl.FuncionalidadesDelete(Id);
        }

        public Funcionalidades FuncionalidadesGetById(string Id)
        {
            FuncionalidadesImpl oFuncionalidadesImpl = new FuncionalidadesImpl();
            return oFuncionalidadesImpl.FuncionalidadesGetById(Id);
        }

        public List<Funcionalidades> FuncionalidadesGetAll()
        {
            FuncionalidadesImpl oFuncionalidadesImpl = new FuncionalidadesImpl();
            return oFuncionalidadesImpl.FuncionalidadesGetAll();
        }
    }
}
