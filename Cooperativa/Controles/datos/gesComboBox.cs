using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Controles.util.Enumerados;

namespace Controles.datos
{

    public class gesComboBox: System.Windows.Forms.ComboBox
    {
        public string REQUERIDO = "NO";

        private IContainer components;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private enumRequerido requerido = enumRequerido.NO;
        public enumRequerido Requerido
        {
            get { return requerido; }
            set
            {
                requerido = value;
                if (value == enumRequerido.SI)
                {
                    errorProvider2.SetError(this, "Campo Requerido");
                    errorProvider2.SetIconPadding(this, 5);
                }
            }

        }

        public gesComboBox()
        {//Iniciamos los valores por defecto
            InitializeComponent();

        }



        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gesComboBox));

            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();

            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.GesComboBox_Layout);
            this.Leave += new EventHandler(GesComboBox_Leave);
            this.SuspendLayout();
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ResumeLayout(false);

        }

        private void GesComboBox_Layout(object sender, LayoutEventArgs e)
        {
          //if (this.SelectedIndex >= 0)
              errorProvider2.Clear();


        }
        private void GesComboBox_Leave(object sender, EventArgs e)
        {
            if (this.SelectedIndex > 0) {
                errorProvider2.Clear();
                this.BackColor = System.Drawing.Color.White;
            }

            Boolean estaCodigo= false;
            for (int i = 0; i <= this.Items.Count-1; i++)
            {
                if (((System.Data.DataRowView)this.Items[i]).Row.ItemArray[1].ToString() == this.Text)
                {
                    estaCodigo = true;
                    break;
                }

            }

      

            if (!estaCodigo)
            {
                this.BackColor = System.Drawing.Color.Red;
                errorProvider2.SetError(this, "El valor seleccionado no existe");
                this.SelectAll();
                this.Focus();
            }
            else
            {
                this.BackColor = System.Drawing.Color.White;
                errorProvider2.Clear();
            }

            if ((this.Requerido == enumRequerido.SI) && (this.SelectedIndex == 0))
            {
                this.BackColor = System.Drawing.Color.Red;
                errorProvider2.SetError(this, "El campo es Requerido");
                this.SelectAll();
                this.Focus();


            }


        }
    }
}
