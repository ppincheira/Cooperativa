using System.Collections.Generic;
using Implement;
using Model;


namespace Business
{
    public class BarriosLocalidadesBus
    {

        public int BarriosLocalidadesAdd(BarriosLocalidades oBarriosLocalidades)
        {
            BarriosLocalidadesImpl oBarriosLocalidadesImpl = new BarriosLocalidadesImpl();
            return oBarriosLocalidadesImpl.BarriosLocalidadesAdd(oBarriosLocalidades);
        }

        public bool BarriosLocalidadesUpdate(BarriosLocalidades oBarriosLocalidades)
        {
            BarriosLocalidadesImpl oBarriosLocalidadesImpl = new BarriosLocalidadesImpl();
            return oBarriosLocalidadesImpl.BarriosLocalidadesUpdate(oBarriosLocalidades);
        }

        public bool BarriosLocalidadesDelete(long Id)
        {
            BarriosLocalidadesImpl oBarriosLocalidadesImpl = new BarriosLocalidadesImpl();
            return oBarriosLocalidadesImpl.BarriosLocalidadesDelete(Id);
        }

        public BarriosLocalidades BarriosLocalidadesGetById(long Id)
        {
            BarriosLocalidadesImpl oBarriosLocalidadesImpl = new BarriosLocalidadesImpl();
            return oBarriosLocalidadesImpl.BarriosLocalidadesGetById(Id);
        }

        public List<BarriosLocalidades> BarriosLocalidadesGetAll()
        {
            BarriosLocalidadesImpl oBarriosLocalidadesImpl = new BarriosLocalidadesImpl();
            return oBarriosLocalidadesImpl.BarriosLocalidadesGetAll();
        }
    }
}
