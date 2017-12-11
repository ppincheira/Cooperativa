using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PermisosFoms
    {


        public PermisosFoms(string PNew, string PEdit, string PDel, string PExp, string PImp)
        {
            this.New = PNew;
            this.Edit = PEdit;
            this.Del = PDel;
            this.Exp = PExp;
            this.Imp = PImp;
        }
        public virtual string New { get; set; }
        public virtual string Edit { get; set; }
        public virtual string Del { get; set; }
        public virtual string Exp { get; set; }
        public virtual string Imp { get; set; }
    }


}
