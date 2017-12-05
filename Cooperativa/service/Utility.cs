using System;
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


        private void borrarContenidoControles(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control.Controls.Count > 0) borrarContenidoControles(control);
                else
                {
                    if (control is TextBox) ((TextBox)control).Clear();
                    if (control is RadioButton) ((RadioButton)control).Checked = false;
                    if (control is CheckBox) ((CheckBox)control).Checked = false;
                }
            }
        }

        private void HabilitarControles(Control contenedor )
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control.Controls.Count > 0) borrarContenidoControles(control);
                else
                {
                    if (control is Controles.buttons.btnEditar) ((Controles.buttons.btnEditar)control).FUN_CODIGO 
                    if (control is RadioButton) ((RadioButton)control).Checked = false;
                    if (control is CheckBox) ((CheckBox)control).Checked = false;
                }
            }
        }

        ////public static List<T> GetControls<T>(this Control container) where T : Control
        ////{
        ////    List<T> controls = new List<T>();
        ////    foreach (Control c in container.Controls)
        ////    {
        ////        if (c is T)
        ////            controls.Add((T)c);
        ////        controls.AddRange(GetControls<T>(c));
        ////    }
        ////    return controls;
        ////}



    }
}
