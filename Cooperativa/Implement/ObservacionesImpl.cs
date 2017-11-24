
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class ObservacionesImpl
        {
            #region Observaciones methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int ObservacionesAdd(Observaciones oObs)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    // Clave Secuencia OBS_NUMERO
                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Observaciones(COT_CLAVE_BUSQUEDA, " +
                        "OBS_DETALLE, OBS_FECHA_CARGA, TAB_CODIGO, TOB_CODIGO) " +
                        "values('" + oObs.CotClaveBusqueda + "', '" + oObs.ObsDetalle + "', " + 
                        oObs.ObsFechaCarga + ",'"+ oObs.TabCodigo + "','"+ oObs.TobCodigo +"')", cn);
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

            public bool ObservacionesUpdate(Observaciones oObs)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Observaciones " +
                        "SET COT_CLAVE_BUSQUEDA='" + oObs.CotClaveBusqueda + "'," +
                        "OBS_DETALLE='" + oObs.ObsDetalle +"', "+
                        "OBS_FECHA_CARGA=" + oObs.ObsFechaCarga +", "+
                        "TAB_CODIGO='" + oObs.TabCodigo +"', "+
                        "TOB_CODIGO='" + oObs.TobCodigo +"' "+
                        "WHERE OBS_NUMERO=" + oObs.ObsNumero, cn);
                    adapter = new OracleDataAdapter(cmd);
                    response = cmd.ExecuteNonQuery();
                    cn.Close();
                    return response > 0;
            }
            catch (Exception ex)
                {
                    throw ex;
                }
            }

            public bool ObservacionesDelete(long Id)
            {


                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Observaciones " +
                          "WHERE OBS_NUMERO=" + Id, cn);
                    adapter = new OracleDataAdapter(cmd);
                    response = cmd.ExecuteNonQuery();
                    cn.Close();
                    return response > 0;
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }

            public Observaciones ObservacionesGetById(long Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Observaciones " +
                        "WHERE OBS_NUMERO=" + Id;
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    Observaciones NewEnt = new Observaciones();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarObservaciones(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<Observaciones> ObservacionesGetAll()
            {
                List<Observaciones> lstObservaciones = new List<Observaciones>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Observaciones ";
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
                            Observaciones NewEnt = new Observaciones();
                            NewEnt = CargarObservaciones(dr);
                            lstObservaciones.Add(NewEnt);
                        }
                    }
                    return lstObservaciones;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private Observaciones CargarObservaciones(DataRow dr)
            {
                try
                {
                    Observaciones oObjeto = new Observaciones();
                    oObjeto.ObsNumero = long.Parse(dr["OBS_NUMERO"].ToString());
                    oObjeto.CotClaveBusqueda = dr["COT_CLAVE_BUSQUEDA"].ToString();
                    oObjeto.ObsDetalle = dr["OBS_DETALLE"].ToString();
                    oObjeto.ObsFechaCarga = DateTime.Parse(dr["OBS_FECHA_CARGA"].ToString());
                    oObjeto.TabCodigo = dr["TAB_CODIGO"].ToString();
                    oObjeto.TobCodigo = dr["TOB_CODIGO"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            //public DataTable ObservacionesGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "ObservacionesGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
            //        DTPartes = DSPartes.Tables[0];
            //        DSPartes.Tables.RemoveAt(0);
            //        return DTPartes;
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //}
            #endregion

        }
}

