﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.datos
{

    public class gesComboBox: System.Windows.Forms.ComboBox
    {
        public string REQUERIDO = "NO";

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
