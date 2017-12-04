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

<<<<<<< HEAD
        

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

        public static List<T> GetControls<T>(this Control container) where T : Control
        {
            List<T> controls = new List<T>();
            foreach (Control c in container.Controls)
            {
                if (c is T)
                    controls.Add((T)c);
                controls.AddRange(GetControls<T>(c));
            }
            return controls;
        }

        //public bool DatosFaltantes(Form clase, ref string falta)
        //{
        //    GroupBox {
        //        Dim grupo;
        //        Control contrl;

        //        DatosFaltantes = false;
        //        foreach (Dim /*TODO: cambiar el nombre de la variable*/ grupo in clase.Controls)
        //        {
        //            foreach (Control /*TODO: cambiar el nombre de la variable*/ contrl in grupo.Controls)
        //            {

        //                if ((contrl is TextBox) | (TypeOf contrl is ComboBox) | (TypeOf contrl is RichTextBox) | (TypeOf contrl is MaskedTextBox) ){

        //                    if (contrl.Text == "" & contrl.Tag == "n")
        //                    {
        //                        DatosFaltantes = true;

        //                        falta = contrl.Name;

        //                        return;
        //                    }

        //                }


        //            }

=======
>>>>>>> c69271fd8ee4341398eaf0fb659efda4263333b9
    }
}
