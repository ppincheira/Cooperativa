using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FuncionalidadesFoms
    {


        public FuncionalidadesFoms(string FNew, string FEdit, string FDel, string FExp, string FImp)
        {
            this.New = FNew;
            this.Edit = FEdit;
            this.Del = FDel;
            this.Exp = FExp;
            this.Imp = FImp;
        }
        public virtual string New { get; set; }
        public virtual string Edit { get; set; }
        public virtual string Del { get; set; }
        public virtual string Exp { get; set; }
        public virtual string Imp { get; set; }
    }


}
