
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Configuration;
using Model;

namespace Implement
{
	public class BarriosImpl
    {
        #region Barrios methods
     
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int BarriosAdd(Barrios oBarrio)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                ds = new DataSet();
                cmd = new OracleCommand("insert into Barrios(BAR_NUMERO, PAI_CODIGO, PRV_CODIGO, " +
                    "LOC_NUMERO, BAR_DESCRIPCION) " +
                    "values("+oBarrio.BarNumero + ", '"+oBarrio.PaiCodigo + "', '"+oBarrio.PrvCodigo + "', '" + 
                    oBarrio.LocNumero + "', '" + oBarrio.BarDescripcion + "')", cn);
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

        public bool BarriosUpdate(Barrios oBarrio)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Barrios " +
                    "SET PAI_CODIGO='" + oBarrio.PaiCodigo + "'," +
                    "PRV_CODIGO='" + oBarrio.PrvCodigo + "'," +
                    "LOC_NUMERO='" + oBarrio.LocNumero + "'," +
                    "BAR_DESCRIPCION='" + oBarrio.BarDescripcion + 
                    "WHERE BAR_NUMERO=" + oBarrio.BarNumero, cn);
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

        public bool BarriosDelete(Barrios oBarrio)
		{

                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Barrios " +
                         "WHERE BAR_NUMERO=" + oBarrio.BarNumero.ToString(),cn);
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

        public Barrios BarriosGetById(int Id)
		{
			try
			{
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Barrios " +
                    "WHERE BAR_NUMERO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Barrios NewEnt = new Barrios();
				if(dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
                    NewEnt = CargarBarrios(dr);
				}
				return NewEnt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public List<Barrios> BarriosGetAll()
		{
            List<Barrios> lstBarrios = new List<Barrios>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Barrios ";
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
                            Barrios NewEnt = new Barrios();
                            NewEnt = CargarBarrios(dr);
                            lstBarrios.Add(NewEnt);
                  }
                }
                return lstBarrios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        private Barrios CargarBarrios(DataRow dr)
		{
			try
			{
                Barrios oObjeto = new Barrios();
                oObjeto.BarNumero = int.Parse(dr["BAR_NUMERO"].ToString());
                oObjeto.PaiCodigo = dr["PAI_CODIGO"].ToString();
                oObjeto.PrvCodigo = dr["PRV_CODIGO"].ToString();
                oObjeto.LocNumero = int.Parse(dr["LOC_NUMERO"].ToString());
                oObjeto.BarDescripcion = dr["BAR_DESCRIPCION"].ToString();
                return oObjeto;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

		#endregion

	}
}
