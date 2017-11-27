﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controles;
using System.Data;
using System.Windows.Forms;

namespace Service
{
    public class Utility
    {
        public int CargarGrilla(Controles.datos.grdGrillaAdmin grilla, DataTable dt) {
            grilla.DataSource = dt;
      
            return dt.Rows.Count;
        }

        public int CargarGrilla(Controles.datos.grdGrillaEdit grilla, DataTable dt)
        {
            grilla.DataSource = dt;

            return dt.Rows.Count;
        }


        public void CargarCombo(Controles.datos.cmbLista combo, DataTable dt, string Value, string Text)
        {
            combo.DataSource = dt;
            combo.ValueMember = Value;
            combo.DisplayMember = Text;
        }

    }
}
