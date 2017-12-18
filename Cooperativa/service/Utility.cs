﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controles;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Model;
using Business;
using Controles.form;

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

        public void HabilitarControles(Control contenedor, int usrNumero, string formulario, string sbsCodigo, DataTable dt)
        {
            if (dt == null) { 
            FuncionalidadesBus oFunBus = new FuncionalidadesBus();
            dt = oFunBus.FuncionalidadesPermisos(formulario, usrNumero, sbsCodigo);
            }
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; dt.Rows.Count > i; i++)
                { 
                    DataRow dr = dt.Rows[i];
                    foreach (Control control in contenedor.Controls)

                        if (control.Controls.Count > 0) HabilitarControles(control,usrNumero,formulario,sbsCodigo,dt);
                        else
                        {
                            if (control is Controles.buttons.btnEditar)
                                if (((Controles.buttons.btnEditar)control).FUN_CODIGO == dr["FUN_CODIGO"].ToString())
                                    ((Controles.buttons.btnEditar)control).Enabled = true;
                            if (control is Controles.buttons.btnNuevo)
                                if (((Controles.buttons.btnNuevo)control).FUN_CODIGO == dr["FUN_CODIGO"].ToString())
                                    ((Controles.buttons.btnNuevo)control).Enabled = true;
                            if (control is Controles.buttons.btnEliminar)
                                if (((Controles.buttons.btnEliminar)control).FUN_CODIGO == dr["FUN_CODIGO"].ToString())
                                    ((Controles.buttons.btnEliminar)control).Enabled = true;
                            if (control is Controles.buttons.btnExportar)
                                if (((Controles.buttons.btnExportar)control).FUN_CODIGO == dr["FUN_CODIGO"].ToString())
                                    ((Controles.buttons.btnExportar)control).Enabled = true;
                            if (control is Controles.buttons.btnGeneral)
                                if (((Controles.buttons.btnGeneral)control).FUN_CODIGO == dr["FUN_CODIGO"].ToString())
                                    ((Controles.buttons.btnGeneral)control).Enabled = true;
                        }
                }
            }
        }

   
        public void ValidarFormulario( gesForm formInicial, Control contenedor, int index)
        {
            
            
                    foreach (Control control in contenedor.Controls) { 

                        if (control.Controls.Count > 0)
                             ValidarFormulario(formInicial, control, index);
                        else
                        {
                    if (control is Controles.textBoxes.txtDescripcionCorta)
                        if (((Controles.textBoxes.txtDescripcionCorta)control).REQUERIDO == "SI" && ((Controles.textBoxes.txtDescripcionCorta)control).Text == "" && ((Controles.textBoxes.txtDescripcionCorta)control).TabIndex <= index)
                        {
                            ((Controles.textBoxes.txtDescripcionCorta)control).BackColor = System.Drawing.Color.Red;
                            formInicial.VALIDARFORM = true;
                        }
          
                        if (control is Controles.textBoxes.txtObservaciones)
                            if (((Controles.textBoxes.txtObservaciones)control).REQUERIDO == "SI" && ((Controles.textBoxes.txtObservaciones)control).Text == "" && ((Controles.textBoxes.txtObservaciones)control).TabIndex <= index)
                            { 
                                ((Controles.textBoxes.txtObservaciones)control).BackColor = System.Drawing.Color.Red;
                                formInicial.VALIDARFORM = true;
                        }
                    if (control is Controles.textBoxes.txtPassword)
                            if (((Controles.textBoxes.txtPassword)control).REQUERIDO == "SI" && ((Controles.textBoxes.txtPassword)control).Text == "" && ((Controles.textBoxes.txtPassword)control).TabIndex <= index)
                            {
                                ((Controles.textBoxes.txtPassword)control).BackColor = System.Drawing.Color.Red;
                                formInicial.VALIDARFORM = true;
                        }
                    if (control is Controles.Fecha.dtpFecha)
                            if (((Controles.Fecha.dtpFecha)control).REQUERIDO == "SI" && ((Controles.Fecha.dtpFecha)control).Text == "" && ((Controles.Fecha.dtpFecha)control).TabIndex <= index)
                            {
                             ((Controles.textBoxes.txtPassword)control).BackColor = System.Drawing.Color.Red;
                             formInicial.VALIDARFORM = true;
                        }
                    if (control is Controles.datos.chkBox)
                        if (((Controles.datos.chkBox)control).REQUERIDO == "SI" && ((Controles.datos.chkBox)control).Text == "" && ((Controles.datos.chkBox)control).TabIndex <= index)
                        {
                            ((Controles.textBoxes.txtPassword)control).BackColor = System.Drawing.Color.Red;
                            formInicial.VALIDARFORM = true;
                        }
                }

            }
          
        }
     





    }
}
