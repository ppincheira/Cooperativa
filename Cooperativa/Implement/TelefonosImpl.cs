
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;
namespace Implement
{
    public class TelefonosImpl
    {
        #region Telefonos methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int TelefonosAdd(Telefonos oTel)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia TEL_CODIGO
                ds = new DataSet();
                cmd = new OracleCommand("insert into Telefonos " +
                    "(TTE_CODIGO, TEL_NUMERO, EMP_NUMERO, PRS_NUMERO, " +
                    "TEL_CARGO, TEL_DEFECTO, TEL_EMAIL, TEL_NOMBRE_CONTACTO) " +
                    "values('" + oTel.TteCodigo + "', '" +oTel.TelNumero + "'," + oTel.EmpNumero + ", " +
                    oTel.PrsNumero + ", '" +oTel.TelCargo + "','" + oTel.TelDefecto + "','" +
                    oTel.TelDefecto + "','"+ oTel.TelEmail + "', '" +oTel.TelNombreContacto+"')", cn);
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

        public bool TelefonosUpdate(Telefonos oTel)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Telefonos " +
                    "SET TTE_CODIGO='" + oTel.TteCodigo + "'," +
                    "TEL_NUMERO='" + oTel.TelNumero + "', " +
                    "EMP_NUMERO=" + oTel.EmpNumero + ", " +
                    "PRS_NUMERO=" + oTel.PrsNumero + ", " +
                    "TEL_CARGO='" + oTel.TelCargo + "', " +
                    "TEL_DEFECTO='" + oTel.TelDefecto + "', " +
                    "TEL_EMAIL='" + oTel.TelEmail + "', " +
                    "TEL_NOMBRE_CONTACTO='" + oTel.TelNombreContacto + "' " +
                    "WHERE TEL_CODIGO=" + oTel.TelCodigo, cn);
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

        public bool TelefonosDelete(long Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Telefonos " +
                      "WHERE TEL_CODIGO=" + Id, cn);
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

        public Telefonos TelefonosGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Telefonos " +
                    "WHERE TEL_CODIGO=" + Id;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Telefonos NewEnt = new Telefonos();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarTelefonos(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Telefonos> TelefonosGetAll()
        {
            List<Telefonos> lstTelefonos = new List<Telefonos>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Telefonos ";
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
                        Telefonos NewEnt = new Telefonos();
                        NewEnt = CargarTelefonos(dr);
                        lstTelefonos.Add(NewEnt);
                    }
                }
                return lstTelefonos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Telefonos CargarTelefonos(DataRow dr)
        {
            try
            {
                Telefonos oObjeto = new Telefonos();
                oObjeto.TteCodigo =dr["TTE_CODIGO"].ToString();
                oObjeto.TelNumero = dr["TEL_NUMERO"].ToString();
                oObjeto.EmpNumero = long.Parse(dr["EMP_NUMERO"].ToString());
                oObjeto.PrsNumero = int.Parse(dr["PRS_NUMERO"].ToString());
                oObjeto.TelCodigo =long.Parse(dr["TEL_CODIGO"].ToString());
                oObjeto.TelCargo = dr["TEL_CARGO"].ToString();
                oObjeto.TelDefecto = dr["TEL_DEFECTO"].ToString();
                oObjeto.TelEmail = dr["TEL_EMAIL"].ToString();
                oObjeto.TelNombreContacto = dr["TEL_NOMBRE_CONTACTO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       //public DataTable TelefonosGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "TelefonosGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
