using System.Collections.Generic;
using Implement;
using Model;


namespace Business
{
    public class CodigosPostalesLocalidadesBus
    {

        public int CodigosPostalesLocalidadesAdd(CodigosPostalesLocalidades oCodigosPostalesLocalidades)
        {
            CodigosPostalesLocalidadesImpl oCodigosPostalesLocalidadesImpl = new CodigosPostalesLocalidadesImpl();
            return oCodigosPostalesLocalidadesImpl.CodigosPostalesLocalidadesAdd(oCodigosPostalesLocalidades);
        }

        public bool CodigosPostalesLocalidadesUpdate(CodigosPostalesLocalidades oCodigosPostalesLocalidades)
        {
            CodigosPostalesLocalidadesImpl oCodigosPostalesLocalidadesImpl = new CodigosPostalesLocalidadesImpl();
            return oCodigosPostalesLocalidadesImpl.CodigosPostalesLocalidadesUpdate(oCodigosPostalesLocalidades);
        }

        public bool CodigosPostalesLocalidadesDelete(int Id)
        {
            CodigosPostalesLocalidadesImpl oCodigosPostalesLocalidadesImpl = new CodigosPostalesLocalidadesImpl();
            return oCodigosPostalesLocalidadesImpl.CodigosPostalesLocalidadesDelete(Id);
        }

        public CodigosPostalesLocalidades CodigosPostalesLocalidadesGetById(int Id)
        {
            CodigosPostalesLocalidadesImpl oCodigosPostalesLocalidadesImpl = new CodigosPostalesLocalidadesImpl();
            return oCodigosPostalesLocalidadesImpl.CodigosPostalesLocalidadesGetById(Id);
        }

        public List<CodigosPostalesLocalidades> CodigosPostalesLocalidadesGetAll()
        {
            CodigosPostalesLocalidadesImpl oCodigosPostalesLocalidadesImpl = new CodigosPostalesLocalidadesImpl();
            return oCodigosPostalesLocalidadesImpl.CodigosPostalesLocalidadesGetAll();
        }
    }
}
