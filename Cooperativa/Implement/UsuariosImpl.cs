﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Configuration;
using Model;
namespace Implement
{
    public class UsuariosImpl
    {
        #region Usuarios methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int UsuariosAdd(Usuarios oUsuarios)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                ds = new DataSet();
                cmd = new OracleCommand("insert into Usuarios(USR_NUMERO, PRS_NUMERO, USR_NOMBRE, USR_BLOQUEADO, USR_CLAVE, USR_FECHA_ALTA,  USR_PERFIL " +
                    "values('" + oUsuarios.UsrNumero + "', '" + oUsuarios.PrsNumero + "', '" + oUsuarios.UsrNombre + "', '" + oUsuarios.UsrClave + "', TO_DATE('" + oUsuarios.UsrFechaAlta + "', 'YYYY-MM-DD HH24:MI:SS'), '" + oUsuarios.UsrPerfil + "')", cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UsuariosUpdate(Usuarios oUsuarios)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Usuarios " +
                    "SET USR_NUMERO='" + oUsuarios.UsrNumero + "'," +
                    "PRS_NUMERO='" + oUsuarios.PrsNumero + "'," +
                    "USR_NOMRE='" + oUsuarios.UsrNombre + "'," +
                    "USR_BLOQUEADO='" + oUsuarios.UsrBloqueado + "'," +
                    "USR_CLAVE='" + oUsuarios.UsrClave + "'," +
                    "USR_FECHA_ALTA='" + oUsuarios.UsrFechaAlta + "'," +
                    "USR_FECHA_BAJA='" + oUsuarios.UsrFechaBaja + "'," +
                    "WHERE USR_NUMERO='" + oUsuarios.UsrNumero + "'", cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UsuariosDelete(String Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Usuarios " +
                      "WHERE USR_NUMERO='" + Id + "'", cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public Usuarios UsuariosGetById(string Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Usuarios " +
                    "where USR_NUMERO='" + Id + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Usuarios NewEnt = new Usuarios();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarUsuarios(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuarios UsuariosLogin(string user, string password) {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Usuarios " +
                    "where USR_NOMBRE='" + user + "'" +
                    " and USR_CLAVE = '"+ password +"'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Usuarios NewEnt = new Usuarios();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarUsuarios(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuarios> UsuariosGetAll()
        {
            List<Usuarios> lstUsuarios = new List<Usuarios>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Usuarios ";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; dt.Rows.Count > i; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        Usuarios NewEnt = new Usuarios();
                        NewEnt = CargarUsuarios(dr);
                        lstUsuarios.Add(NewEnt);
                    }
                }
                return lstUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Usuarios CargarUsuarios(DataRow dr)
        {
            try
            {
                Usuarios oObjeto = new Usuarios();
                oObjeto.UsrNumero = int.Parse(dr["USR_NUMERO"].ToString());
                oObjeto.PrsNumero = int.Parse(dr["PRS_NUMERO"].ToString());
                oObjeto.UsrBloqueado = dr["USR_BLOQUEADO"].ToString();
                oObjeto.UsrNombre = dr["USR_NOMBRE"].ToString();
                oObjeto.UsrClave = dr["USR_CLAVE"].ToString();
                if (dr["USR_FECHA_ALTA"].ToString() != "")
                    oObjeto.UsrFechaAlta = DateTime.Parse(dr["USR_FECHA_ALTA"].ToString());
                
                if (dr["USR_FECHA_BAJA"].ToString() != "") 
                    oObjeto.UsrFechaBaja = DateTime.Parse(dr["USR_FECHA_BAJA"].ToString());
                
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    #endregion
    }

}