﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.buttons
{
    public partial class btnVer : gesButton
    {
        public btnVer()
        {
            //Image = Resources.Iconos.nuevo;
            Size = new System.Drawing.Size(40, 40);
            BackgroundImage = Resources.Iconos.ver;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //Text = "N";
            //Size = this.BackgroundImage.Size;
        }
    }
}
