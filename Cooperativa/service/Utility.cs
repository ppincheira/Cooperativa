﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controles;
using System.Data;
using System.Windows.Forms;
using Model;
using Business;

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


        public void borrarContenidoControles(Control contenedor)
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

        public void HabilitarControles(Control contenedor, int usrNumero, string formulario, string sbsCodigo)
        {
            FuncionalidadesBus oFunBus = new FuncionalidadesBus();
            DataTable dt = oFunBus.FuncionalidadesPermisos(formulario, usrNumero, sbsCodigo);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; dt.Rows.Count > i; i++)
                {
                    DataRow dr = dt.Rows[i];
                    foreach (Control control in contenedor.Controls)

                        if (control.Controls.Count > 0) borrarContenidoControles(control);
                        else
                        {
                            if (control is Controles.buttons.btnEditar)
                                if (((Controles.buttons.btnEditar)control).FUN_CODIGO == dr["FUN_CODIGO"].ToString())
                                    ((Controles.buttons.btnEditar)control).Enabled = true;
                        }
                }
            }
        }





    }
}
