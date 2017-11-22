using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.buttons
{
    public partial class btnEditar: gesButton
    {
        public btnEditar() {
            //Image = Resources.Iconos.nuevo;
            Size = new System.Drawing.Size(50, 50);
            BackgroundImage = Resources.Iconos.editar;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //Text = "N";
            //Size = this.BackgroundImage.Size;
        }
    }
}
