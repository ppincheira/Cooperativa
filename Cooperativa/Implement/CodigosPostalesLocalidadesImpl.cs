
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Configuration;
using Model;

namespace Implement
{
	public class CodigosPostalesLocalidadesImpl
    {
        #region CodigosPostalesLocalidades methods
     
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int CodigosPostalesLocalidadesAdd(CodigosPostalesLocalidades oCalleLocalidad)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia CPL_NUMERO
                ds = new DataSet();
                cmd = new OracleCommand("insert into Codigos_Postales_Localidades(CPL_DESCRIPCION, " +
                    "CPL_CODIGO_POSTAL, LOC_NUMERO) " +
                    "values('"+oCalleLocalidad.CplDescripcion + "', '"+
                    oCalleLocalidad.CplCodigoPostal + "', " + oCalleLocalidad.LocNumero + "')", cn);
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

        public bool CodigosPostalesLocalidadesUpdate(CodigosPostalesLocalidades oCPL)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Codigos_Postales_Localidades " +
                    "SET CAL_DESCRIPCION='" + oCPL.CplDescripcion + 
                    "', CPL_CODIGO_POSTAL='" + oCPL.CplCodigoPostal + "' " + 
                    ", LOC_NUMERO=" + oCPL.LocNumero + 
                    " WHERE CPL_NUMERO=" + oCPL.CplNumero.ToString(), cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
				return (response > 0);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public bool CodigosPostalesLocalidadesDelete(int Id)
		{

                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Codigos_Postales_Localidades " +
                        "WHERE CPL_NUMERO=" + Id.ToString(), cn);
                    adapter = new OracleDataAdapter(cmd);
                    response = cmd.ExecuteNonQuery();
                    cn.Close();
                    return (response > 0);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
		}

        public CodigosPostalesLocalidades CodigosPostalesLocalidadesGetById(int Id)
		{
			try
			{
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Codigos_Postales_Localidades " +
                    "WHERE CPL_NUMERO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                CodigosPostalesLocalidades NewEnt = new CodigosPostalesLocalidades();
				if(dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
                    NewEnt = CargarCodigosPostalesLocalidades(dr);
				}
				return NewEnt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public List<CodigosPostalesLocalidades> CodigosPostalesLocalidadesGetAll()
		{
            List<CodigosPostalesLocalidades> lstCodigosPostalesLocalidades = new List<CodigosPostalesLocalidades>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Codigos_Postales_Localidades ";
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
                            CodigosPostalesLocalidades NewEnt = new CodigosPostalesLocalidades();
                            NewEnt = CargarCodigosPostalesLocalidades(dr);
                            lstCodigosPostalesLocalidades.Add(NewEnt);
                  }
                }
                return lstCodigosPostalesLocalidades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        private CodigosPostalesLocalidades CargarCodigosPostalesLocalidades(DataRow dr)
		{
			try
			{
                CodigosPostalesLocalidades oObjeto = new CodigosPostalesLocalidades();
                oObjeto.CplNumero = int.Parse(dr["CPL_NUMERO"].ToString());
                oObjeto.CplDescripcion = dr["CAL_DESCRIPCION"].ToString();
                oObjeto.CplCodigoPostal = dr["CPL_CODIGO_POSTAL"].ToString();
                oObjeto.LocNumero = int.Parse(dr["LOC_NUMERO"].ToString());
                return oObjeto;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}



        public DataTable CodigosPostalesLocalidadesGetByLocalidad(int IdLocalidad)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Codigos_Postales_Localidades " +
                    "WHERE LOC_NUMERO=" + IdLocalidad.ToString();
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
