
///////////////////////////////////////////////////////////////////////////
//
// Creado por: Pincheira Pablo
//
///////////////////////////////////////////////////////////////////////////

using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class DetallesColumnasTablasImpl
    {
        #region DetallesColumnasTablas methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int DetallesColumnasTablasAdd(DetallesColumnasTablas oDetalle)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave TAB_CODIGO, DCT_CODIGO_TABLA Y DCT_COLUMNA
                ds = new DataSet();
                cmd = new OracleCommand("insert into Detalles_Columnas_Tablas(TAB_CODIGO, DCT_CODIGO_TABLA," +
                    "DCT_NRO_ORDEN, DCT_COLUMNA, DCT_HABILITADO, DCT_REQUERIDO, DCT_DESCRIPCION, " +
                    "DCT_ETIQUETA, DCT_TIPO_CONTROL, DCT_LISTA_VALORES) " +
                    "values('" + oDetalle.TabCodigo + "', '" + oDetalle.DctCodigoTabla + "'," + 
                    oDetalle.DctNroOrden + ",'"+oDetalle.DctColumna+"','"+ oDetalle.DctHabilitado+"','"+
                    oDetalle.DctRequerido+"','"+oDetalle.DctDescripcion+"','" + oDetalle.DctEtiqueta +"'"+
                    oDetalle.DctTipoControl+"','"+oDetalle.DctListaValores+"')", cn);
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

        public bool DetallesColumnasTablasUpdate(DetallesColumnasTablas oDetalle)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Detalles_Columnas_Tablas " +
                    "SET DCT_NRO_ORDEN=" + oDetalle.DctNroOrden + "," +
                    "DCT_HABILITADO='" + oDetalle.DctHabilitado + "'," +
                    "DCT_REQUERIDO='" + oDetalle.DctRequerido + "'," +
                    "DCT_DESCRIPCION='" + oDetalle.DctDescripcion + "'," +
                    "DCT_ETIQUETA='" + oDetalle.DctEtiqueta + "'," +
                    "DCT_TIPO_CONTROL='" + oDetalle.DctTipoControl + "'," +
                    "DCT_LISTA_VALORES='" + oDetalle.DctListaValores + "' " +
                    "WHERE TAB_CODIGO='" + oDetalle.TabCodigo+ "' and DCT_CODIGO_TABLA='" + 
                    oDetalle.DctCodigoTabla+ "' and DCT_COLUMNA='"+ oDetalle.DctColumna+ "'", cn);
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

        public bool DetallesColumnasTablasDelete(string Tab, string Tabla, string Columna)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Detalles_Columnas_Tablas " +
                    "WHERE TAB_CODIGO='" + Tab + "' and DCT_CODIGO_TABLA='" +
                    Tabla + "' and DCT_COLUMNA='" + Columna + "'", cn);
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

        public DetallesColumnasTablas DetallesColumnasTablasGetById(string TabCodigo, string DctCodigoTabla, string DctColumna)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Detalles_Columnas_Tablas " +
                    "WHERE TAB_CODIGO='" + TabCodigo + "' and DCT_CODIGO_TABLA='" +
                    DctCodigoTabla + "' and DCT_COLUMNA='" + DctColumna + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                DetallesColumnasTablas NewEnt = new DetallesColumnasTablas();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarDetallesColumnasTablas(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DetallesColumnasTablas> DetallesColumnasTablasGetAll()
        {
            List<DetallesColumnasTablas> lstDetallesColumnasTablas = new List<DetallesColumnasTablas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Detalles_Columnas_Tablas ";
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
                        DetallesColumnasTablas NewEnt = new DetallesColumnasTablas();
                        NewEnt = CargarDetallesColumnasTablas(dr);
                        lstDetallesColumnasTablas.Add(NewEnt);
                    }
                }
                return lstDetallesColumnasTablas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DetallesColumnasTablas> DetallesColumnasTablasGetByName(string name)
        {
            List<DetallesColumnasTablas> lstDetallesColumnasTablas = new List<DetallesColumnasTablas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Detalles_Columnas_Tablas DCT, Tablas T" +
                    " where DCT.TAB_CODIGO=T.TAB_CODIGO and T.nombre = '" + name + "'";
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
                        DetallesColumnasTablas NewEnt = new DetallesColumnasTablas();
                        NewEnt = CargarDetallesColumnasTablas(dr);
                        lstDetallesColumnasTablas.Add(NewEnt);
                    }
                }
                return lstDetallesColumnasTablas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DetallesColumnasTablas> DetallesColumnasTablasGetByCodigo(string codigo)
        {
            List<DetallesColumnasTablas> lstDetallesColumnasTablas = new List<DetallesColumnasTablas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Detalles_Columnas_Tablas" +
                    " where TAB_CODIGO= '" + codigo + "'";
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
                        DetallesColumnasTablas NewEnt = new DetallesColumnasTablas();
                        NewEnt = CargarDetallesColumnasTablas(dr);
                        lstDetallesColumnasTablas.Add(NewEnt);
                    }
                }
                return lstDetallesColumnasTablas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DetallesColumnasTablas CargarDetallesColumnasTablas(DataRow dr)
        {
            try
            {
                DetallesColumnasTablas oObjeto = new DetallesColumnasTablas();
                oObjeto.TabCodigo = dr["TAB_CODIGO"].ToString();
                oObjeto.DctCodigoTabla = dr["DCT_CODIGO_TABLA"].ToString();
                oObjeto.DctNroOrden = short.Parse(dr["DCT_NRO_ORDEN"].ToString());
                oObjeto.DctColumna = dr["DCT_COLUMNA"].ToString();
                oObjeto.DctHabilitado= dr["DCT_HABILITADO"].ToString();
                oObjeto.DctRequerido = dr["DCT_REQUERIDO"].ToString();
                oObjeto.DctDescripcion = dr["DCT_DESCRIPCION"].ToString();
                oObjeto.DctEtiqueta = dr["DCT_ETIQUETA"].ToString();
                oObjeto.DctTipoControl= dr["DCT_TIPO_CONTROL"].ToString();
                oObjeto.DctListaValores= dr["DCT_LISTA_VALORES"].ToString();

                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public DataTable DetallesColumnasTablasGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "DetallesColumnasTablasGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

