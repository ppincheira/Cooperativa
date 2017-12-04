
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
	public class DomiciliosEntidadesImpl
    {
        #region DomiciliosEntidades methods
     
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int DomiciliosEntidadesAdd(DomiciliosEntidades oDEn)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia DEN_NUMERO
                ds = new DataSet();
                cmd = new OracleCommand("insert into Domicilios_Entidades(" +
                    "TDO_CODIGO, DEN_ID_ORIGEN, TAB_CODIGO) " +
                    "values('"+oDEn.TdoCodigo + "', "+oDEn.DenIdOrigen + ", '"+oDEn.TabCodigo + "')", cn);
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

        public bool DomiciliosEntidadesUpdate(DomiciliosEntidades oDEn)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Domicilios_Entidades " +
                    "SET TDO_CODIGO='" + oDEn.TdoCodigo + "'," +
                    "DEN_ID_ORIGEN=" + oDEn.DenNumero + "," +
                    "TAB_CODIGO='" + oDEn.TabCodigo + "'" +
                    " WHERE DEN_NUMERO=" + oDEn.DenNumero, cn);
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

        public bool DomiciliosEntidadesDelete(long Id)
		{

                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Domicilios_Entidades " +
                         "WHERE DEN_NUMERO=" + Id.ToString(),cn);
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

        public DomiciliosEntidades DomiciliosEntidadesGetById(long Id)
		{
			try
			{
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Domicilios_Entidades " +
                    "WHERE DEN_NUMERO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                DomiciliosEntidades NewEnt = new DomiciliosEntidades();
				if(dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
                    NewEnt = CargarDomiciliosEntidades(dr);
				}
				return NewEnt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public List<DomiciliosEntidades> DomiciliosEntidadesGetAll()
		{
            List<DomiciliosEntidades> lstDomiciliosEntidades = new List<DomiciliosEntidades>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Domicilios_Entidades ";
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
                            DomiciliosEntidades NewEnt = new DomiciliosEntidades();
                            NewEnt = CargarDomiciliosEntidades(dr);
                            lstDomiciliosEntidades.Add(NewEnt);
                  }
                }
                return lstDomiciliosEntidades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        private DomiciliosEntidades CargarDomiciliosEntidades(DataRow dr)
		{
			try
			{
                DomiciliosEntidades oObjeto = new DomiciliosEntidades();
                oObjeto.DenNumero = long.Parse(dr["DEN_NUMERO"].ToString());
                oObjeto.TdoCodigo = dr["TDO_CODIGO"].ToString();
                oObjeto.DenIdOrigen = long.Parse(dr["DEN_ID_ORIGEN"].ToString());
                oObjeto.TabCodigo = dr["TAB_CODIGO"].ToString();
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
