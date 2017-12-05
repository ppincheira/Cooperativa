
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class DetallesModelosMedidoresImpl
        {
            #region Departamento methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int DetallesModelosMedidoresAdd(DetallesModelosMedidores oDMM)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    // Clave DME_CODIGO
                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Detalles_Modelos_Medidores" +
                        "(DME_CODIGO, DME_DESCRIPCION, DME_DESCRIPCION_CORTA, DME_DIGITOS, " +
                        "DME_DECIMALES, DME_CANT_HILOS, DME_KW_VUELTAS, DME_AMPERAJE, " +
                        "DME_CLASE, DME_REGISTRADOR, DME_TIPO_CONTADOR, DME_TIPO_CONEXION, " +
                        "FAB_NUMERO, TME_CODIGO, USR_NUMERO, DME_FECHA_CARGA) " +
                        "values('" + oDMM.DmeCodigo + "','"+ oDMM.DmeDescripcion + "','"+ 
                        oDMM.DmeDescripcionCorta + "'," +  oDMM.DmeDigitos + "," + 
                        oDMM.DmeDecimales + "," + oDMM.DmeCantHilos + "," + oDMM.DmeKwVueltas + ",'" + 
                        oDMM.DmeAmperaje + "'," + oDMM.DmeClase + "," + oDMM.DmeRegistrador + ",'" + 
                        oDMM.DmeTipoContador + "','" + oDMM.DmeTipoConexion + "'," + 
                        oDMM.FabNumero + ",'" + oDMM.TmeCodigo + "'," + oDMM.UsrNumero + "," + 
                        oDMM.DmeFechaCarga+ ")", cn);
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

            public bool DetallesModelosMedidoresUpdate(DetallesModelosMedidores oDMM)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Detalles_Modelos_Medidores " +
                        "SET DME_DESCRIPCION='" + oDMM.DmeDescripcion +
                        "', DME_DESCRIPCION_CORTA='" + oDMM.DmeDescripcionCorta +
                        ", DME_DIGITOS=" + oDMM.DmeDigitos +
                        ", DME_DECIMALES=" + oDMM.DmeDecimales +
                        ", DME_CANT_HILOS=" + oDMM.DmeCantHilos +
                        ", DME_KW_VUELTAS=" + oDMM.DmeKwVueltas +
                        ", DME_AMPERAJE='" + oDMM.DmeAmperaje +
                        "', DME_CLASE=" + oDMM.DmeClase +
                        ", DME_REGISTRADOR=" + oDMM.DmeRegistrador +
                        ", DME_TIPO_CONTADOR='" + oDMM.DmeTipoContador +
                        "', DME_TIPO_CONEXION='" + oDMM.DmeTipoConexion +
                        "', FAB_NUMERO=" + oDMM.FabNumero +
                        ", TME_CODIGO='" + oDMM.TmeCodigo +
                        "', USR_NUMERO=" + oDMM.UsrNumero +
                        ", DME_FECHA_CARGA=" + oDMM.DmeFechaCarga +
                        " WHERE DME_CODIGO='" + oDMM.DmeCodigo.ToString()+ "'", cn);
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

            public bool DetallesModelosMedidoresDelete(string Id)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Detalles_Modelos_Medidores " +
                        "WHERE DME_CODIGO='" +Id + "'", cn);
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

            public DetallesModelosMedidores DetallesModelosMedidoresGetById(string Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Detalles_Modelos_Medidores " +
                         "WHERE DME_CODIGO = '" +Id + "'";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    DetallesModelosMedidores NewEnt = new DetallesModelosMedidores();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarDetallesModelosMedidores(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<DetallesModelosMedidores> DetallesModelosMedidoresGetAll()
            {
                List<DetallesModelosMedidores> lstDetallesModelosMedidores = new List<DetallesModelosMedidores>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Detalles_Modelos_Medidores ";
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
                            DetallesModelosMedidores NewEnt = new DetallesModelosMedidores();
                            NewEnt = CargarDetallesModelosMedidores(dr);
                            lstDetallesModelosMedidores.Add(NewEnt);
                        }
                    }
                    return lstDetallesModelosMedidores;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        private DetallesModelosMedidores CargarDetallesModelosMedidores(DataRow dr)
            {
                try
                {
                    DetallesModelosMedidores oObjeto = new DetallesModelosMedidores();
                    oObjeto.DmeCodigo = dr["DME_CODIGO"].ToString();
                    oObjeto.DmeDescripcion = dr["DME_DESCRIPCION"].ToString();
                    oObjeto.DmeDescripcionCorta = dr["DME_DESCRIPCION_CORTA"].ToString();
                    if (dr["DME_DIGITOS"].ToString() != "")
                        oObjeto.DmeDigitos = int.Parse(dr["DME_DIGITOS"].ToString());
                    if (dr["DME_DECIMALES"].ToString() != "")
                        oObjeto.DmeDecimales = int.Parse(dr[""].ToString());
                    if (dr["DME_CANT_HILOS"].ToString() != "")
                        oObjeto.DmeCantHilos = int.Parse(dr["DME_CANT_HILOS"].ToString());
                    if (dr["DME_KW_VUELTAS"].ToString() != "")
                        oObjeto.DmeKwVueltas = int.Parse(dr[""].ToString());
                    oObjeto.DmeAmperaje = dr["DME_AMPERAJE"].ToString();
                    if (dr["DME_CLASE"].ToString() != "")
                        oObjeto.DmeClase = int.Parse(dr["DME_CLASE"].ToString());
                    if (dr["DME_REGISTRADOR"].ToString() != "")
                        oObjeto.DmeRegistrador = decimal.Parse(dr["DME_REGISTRADOR"].ToString());
                    oObjeto.DmeTipoContador = dr["DME_TIPO_CONTADOR"].ToString();
                    oObjeto.DmeTipoConexion = dr["DME_TIPO_CONEXION"].ToString();
                    oObjeto.FabNumero = int.Parse(dr["FAB_NUMERO"].ToString());
                    oObjeto.TmeCodigo = dr["TME_CODIGO"].ToString();
                    oObjeto.UsrNumero = int.Parse(dr["USR_NUMERO"].ToString());
                    if (dr["DME_FECHA_CARGA"].ToString() != "")
                        oObjeto.DmeFechaCarga = DateTime.Parse(dr["DME_FECHA_CARGA"].ToString());
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable DetallesModelosMedidoresGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "DetallesModelosMedidoresGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

