
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class MedidoresImpl
        {
        #region Medidores methods

        private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int MedidoresAdd(Medidores oMed)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    // Clave MED_NUMERO
                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Medidores" +
                        "(MED_NUMEROSERIE, EMP_NUMERO_PROVEEDOR, MED_REGISTRADOR, MED_DIGITOS, MED_ESTADO, " +
                        "MED_FACTOR_CALIB, GIS_X, GIS_Y, DME_CODIGO, USR_NUMERO, MED_FECHA_CARGA) " +
                        "values('" + oMed.MedNumeroserie + "',"+ oMed.EmpNumeroProveedor + ","+ 
                        oMed.MedRegistrador + "," +  oMed.MedDigitos + ",'" + oMed.MedEstado + "'," + 
                        oMed.MedFactorCalib + "," + oMed.GisX + "," + oMed.GisY + ",'" + 
                        oMed.DmeCodigo + "'," + oMed.UsrNumero + "," + oMed.MedFechaCarga + ")", cn);
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

            public bool MedidoresUpdate(Medidores oMed)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Medidores " +
                        "SET MED_NUMEROSERIE='" + oMed.MedNumeroserie +
                        "', EMP_NUMERO_PROVEEDOR=" + oMed.EmpNumeroProveedor +
                        ", MED_REGISTRADOR=" + oMed.MedRegistrador +
                        ", MED_DIGITOS=" + oMed.MedDigitos +
                        ", MED_ESTADO='" + oMed.MedEstado +
                        "', MED_FACTOR_CALIB=" + oMed.MedFactorCalib +
                        ", GIS_X=" + oMed.GisX +
                        ", GIS_Y=" + oMed.GisY +
                        ", DME_CODIGO=" + oMed.DmeCodigo +
                        ", USR_NUMERO=" + oMed.UsrNumero +
                        ", MED_FECHA_CARGA=" + oMed.MedFechaCarga +
                        " WHERE MED_NUMERO=" + oMed.DmeCodigo.ToString(), cn);
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
            public bool MedidoresDelete(long Id)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Medidores " +
                        "WHERE MED_NUMERO=" + Id.ToString(), cn);
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

            public Medidores MedidoresGetById(long Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Medidores " +
                         "WHERE MED_NUMERO=" + Id.ToString();
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    Medidores NewEnt = new Medidores();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarMedidores(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<Medidores> MedidoresGetAll()
            {
                List<Medidores> lstMedidores = new List<Medidores>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Medidores ";
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
                            Medidores NewEnt = new Medidores();
                            NewEnt = CargarMedidores(dr);
                            lstMedidores.Add(NewEnt);
                        }
                    }
                    return lstMedidores;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        private Medidores CargarMedidores(DataRow dr)
        {
            try
            {
                Medidores oObjeto = new Medidores();
                oObjeto.MedNumero = long.Parse(dr["MED_NUMERO"].ToString());
                oObjeto.MedNumeroserie = dr["MED_NUMEROSERIE"].ToString();
                oObjeto.EmpNumeroProveedor = long.Parse(dr["EMP_NUMERO_PROVEEDOR"].ToString());
                oObjeto.MedRegistrador = decimal.Parse(dr["MED_REGISTRADOR"].ToString());
                oObjeto.MedDigitos = int.Parse(dr["MED_DIGITOS"].ToString());
                oObjeto.MedEstado = dr["MED_ESTADO"].ToString();
                oObjeto.MedFactorCalib = double.Parse(dr["MED_FACTOR_CALIB"].ToString());
                oObjeto.GisX = decimal.Parse(dr["GIS_X"].ToString());
                oObjeto.GisY = decimal.Parse(dr["GIS_Y"].ToString());
                oObjeto.DmeCodigo = dr["DME_CODIGO"].ToString();
                oObjeto.UsrNumero = int.Parse(dr["USR_NUMERO"].ToString());
                if (dr["MED_FECHA_CARGA"].ToString() != "")
                    oObjeto.MedFechaCarga = DateTime.Parse(dr["MED_FECHA_CARGA"].ToString());
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

            //public DataTable MedidoresGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "MedidoresGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

