using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.textBoxes
{
    class txtDescripcionCorta:gesTextBox
    {
        public txtDescripcionCorta()
        {
            this.MaxLength = 20;
            this.Width = 210;
            this.Height= 20;
        }
    }
}
