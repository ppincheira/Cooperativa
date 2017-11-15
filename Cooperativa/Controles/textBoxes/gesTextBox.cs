using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.textBoxes 
{
    public class gesTextBox : System.Windows.Forms.TextBox
    {
        public gesTextBox(){
            this.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        }
    }
    
}
