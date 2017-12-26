
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;
using System.IO;

namespace Implement
{
    public class ObservacionesImpl
    {
        #region Observaciones methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        public long ObservacionesAdd(Observaciones oObs)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                //MemoryStream ms = new MemoryStream();
                //FileStream fs = new FileStream(oObs.ObsDatoAdjunto, FileMode.Open, FileAccess.Read);
                //byte[] blob = new byte[fs.Length];
                //fs.Read(blob, 0, System.Convert.ToInt32(fs.Length));
                //fs.Close();
                cn.Open();

                string query =


                    " insert into Observaciones( OBS_CODIGO_REGISTRO, OBS_DETALLE, OBS_FECHA_ALTA, TOB_CODIGO) " +
                    " values('" + oObs.ObsCodigoRegistro + "'," +
                    "'" + oObs.ObsDetalle + "'," +
                    "'" + oObs.ObsFechaAlta.ToString("dd/MM/yyyy") + "'," +
                    " " + oObs.TobCodigo + ") RETURNING OBS_CODIGO INTO :id";

                cmd = new OracleCommand(query, cn);
                cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = ":id",
                    OracleDbType = OracleDbType.Int64,
                    Direction = ParameterDirection.Output
                });




                cmd.ExecuteNonQuery();
                response = long.Parse(cmd.Parameters[":id"].Value.ToString());
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
                string query = "update Observaciones " +
                    " SET OBS_CODIGO_REGISTRO='" + oObs.ObsCodigoRegistro + "'," +
                    " OBS_DETALLE='" + oObs.ObsDetalle + "', " +
                    " OBS_FECHA_ALTA='" + oObs.ObsFechaAlta.ToString("dd/MM/yyyy") + "', " +
                    " TOB_CODIGO='" + oObs.TobCodigo + "'" +
                    " WHERE OBS_CODIGO=" + oObs.ObsCodigo;

                cmd = new OracleCommand(query, cn);
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
                      "WHERE OBS_CODIGO=" + Id, cn);
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
                    "WHERE OBS_CODIGO=" + Id;
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


        public DataTable ObservacionesGetAdjuntoById(int Id)
        {

            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT O.OBS_DATO_ADJUNTO " +
                " FROM OBSERVACIONES O " +
                " INNER JOIN TIPOS_OBSERVACIONES_TABLAS TOT ON O.TOB_CODIGO = TOT.TOB_CODIGO " +
                " WHERE  " +
                "  O.OBS_CODIGO=" + Id;
                
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

        public DataTable ObservacionesGetByFilter(string tabCodigo, int tobCodigo, string obsCodigoRegistro, DateTime fechaDesde, DateTime fechaHasta)
        {

            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT  O.OBS_CODIGO, O.OBS_CODIGO_REGISTRO, O.TOB_CODIGO,O.OBS_DETALLE DETALLE,O.OBS_FECHA_ALTA FECHA, " +
                " CASE WHEN A.ADJ_ADJUNTO IS NULL then 'NO' else  'SI' end ADJUNTO" +
                " FROM OBSERVACIONES O " +
                " INNER JOIN TIPOS_OBSERVACIONES_TABLAS TOT ON O.TOB_CODIGO = TOT.TOB_CODIGO " +
                " LEFT JOIN ADJUNTOS A ON O.OBS_CODIGO=A.ADJ_CODIGO_REGISTRO " +
                " WHERE TOT.TAB_CODIGO='" + tabCodigo + "' " +
                " AND O.TOB_CODIGO=" + tobCodigo.ToString() +
                " AND O.OBS_CODIGO_REGISTRO='" + obsCodigoRegistro + "'" +
                " AND O.OBS_FECHA_ALTA>='" + fechaDesde.ToString("dd/MM/yyyy") + "' AND O.OBS_FECHA_ALTA <='" + fechaHasta.ToString("dd/MM/yyyy") + "'";

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

        private Observaciones CargarObservaciones(DataRow dr)
        {
            try
            {
                Observaciones oObjeto = new Observaciones();
                oObjeto.ObsCodigo = long.Parse(dr["OBS_CODIGO"].ToString());
                oObjeto.ObsCodigoRegistro = dr["OBS_CODIGO_REGISTRO"].ToString();
                oObjeto.ObsDetalle = dr["OBS_DETALLE"].ToString();
                if (dr["OBS_FECHA_ALTA"].ToString() != "")
                    oObjeto.ObsFechaAlta = DateTime.Parse(dr["OBS_FECHA_ALTA"].ToString());
                oObjeto.TobCodigo = int.Parse(dr["TOB_CODIGO"].ToString());
                
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

