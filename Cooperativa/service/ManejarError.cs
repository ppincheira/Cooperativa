using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Model;
using Service;

namespace Service
{
    public class ManejarError
    {
        public void CargarError(Exception sException,
                                string sNombreEvento,
                                string sNombreControl,
                                string sNombreFormulario
                                )
        {
            ////genera el registros para la base de datos                        
            Excepciones oExcepciones = new Excepciones();
            oExcepciones.ExcFecha = DateTime.Now;
            oExcepciones.ExcNombreExcepcion = sException.TargetSite.Name;
            oExcepciones.ExcNombreEvento = sNombreEvento;
            oExcepciones.ExcNombreControl = sNombreControl;
            oExcepciones.ExcNombreFormulario = sNombreFormulario;
            oExcepciones.UsrNumero = 1;//falta definir variable global
            oExcepciones.SbsCodigo = "BILL";//falta definir variable global
            oExcepciones.TerNumero = 1;//falta definir variable global
            oExcepciones.ExcDescripcion = sException.Message;
            ExcepcionesBus oExcepcionesBus = new ExcepcionesBus();
            oExcepcionesBus.ExcepcionesAdd(oExcepciones);
            ////sale el mensaje de error hacia el formulario
            MessageBox.Show("Error: " + sException.Message, "Cooperativa", MessageBoxButtons.OK);
        }
    }
}