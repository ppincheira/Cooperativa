﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.datos
{
    public  class grdGrillaAdmin : gesGrid
    {

        public grdGrillaAdmin() {

            SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        }

    }
}
