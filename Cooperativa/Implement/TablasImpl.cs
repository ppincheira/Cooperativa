
///////////////////////////////////////////////////////////////////////////
//
// Creado por: Pincheira Pablo
//
///////////////////////////////////////////////////////////////////////////

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Configuration;
using Model;

namespace Implement
{
	public class TablasImpl
    {
        #region Tablas methods
     
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int TablasAdd(Tablas oTablas)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                ds = new DataSet();
                cmd = new OracleCommand("insert into TABLAS(TAB_CODIGO, TAB_NOMBRE, TAB_DESCRIPCION) " +
                    "values('"+oTablas.TabCodigo+"', '"+oTablas.TabNombre+"', '"+oTablas.TabDescripcion+"')",cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                return response;
            }
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public bool TablasUpdate(Tablas oTablas)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update TABLAS " +
                    "SET TAB_CODIGO='" + oTablas.TabCodigo + "',"+
                    "TAB_NOMBRE='"+ oTablas.TabNombre + "'," +
                    "TAB_DESCRIPCION= '" + oTablas.TabDescripcion + "' " +
                    "WHERE TAB_CODIGO='" + oTablas.TabCodigo + "'", cn);
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
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public bool TablasDelete(String Id)
		{


                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE TABLAS" +
                        "WHERE TAB_CODIGO='" + Id + "'",cn);
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

        public Tablas TablasGetById(string Id)
		{
			try
			{
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                string sqlSelect = "select * from tablas " +
                    "where TAB_CODIGO='"+ Id+"'";

                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
           
               
                DataTable dt;
                dt = ds.Tables[0];
            
                Tablas NewEnt = new Tablas();

				if(dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
                    NewEnt = CargarTablas(dr);
				}
				return NewEnt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public List<Tablas> TablasGetAll()
		{
            List<Tablas> lstTablas = new List<Tablas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Tablas ";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt = new DataTable() ;
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                  for (int i = 0; dt.Rows.Count > i; i++)
                  {
                            DataRow dr = dt.Rows[i];
                            Tablas NewEnt = new Tablas();
                            NewEnt = CargarTablas(dr);
                            lstTablas.Add(NewEnt);
                  }
                }
                return lstTablas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        private Tablas CargarTablas(DataRow dr)
		{
			try
			{
                Tablas oObjeto = new Tablas();
                oObjeto.TabCodigo = dr["TAB_CODIGO"].ToString();
                oObjeto.TabNombre = dr["TAB_NOMBRE"].ToString();
                oObjeto.TabDescripcion = dr["TAB_DESCRIPCION"].ToString();
				return oObjeto;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public DataTable TablasBusquedaGetAllFilter(string Tabla, string Campos, string filterCampos, string filterValores)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                string[] filterCamp = System.Text.RegularExpressions.Regex.Split(filterCampos, "&");
                string[] filterV = System.Text.RegularExpressions.Regex.Split(filterValores, "&");
                
                cn.Open();

                string sqlSelect = "select "+Campos+" from " + Tabla;
                if (filterCampos != "") { 
                     sqlSelect=sqlSelect+" where ";

                    for (int i = 0; i < filterCamp.Length; i++)
                    {
                        sqlSelect += filterCamp[i] + " like '%" + filterV[i]+"%'";
                    }
                }
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);


                DataTable dt;
                return dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        #endregion

    }
}
