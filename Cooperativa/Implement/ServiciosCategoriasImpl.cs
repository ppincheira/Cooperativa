
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;
namespace Implement
{
    public class ServiciosCategoriasImpl
    {
        #region ServiciosCategorias methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int ServiciosCategoriasAdd(ServiciosCategorias oSCa)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia SCA_NUMERO
                ds = new DataSet();
                cmd = new OracleCommand("insert into Servicios_Categorias " +
                    "(SCA_DESCRIPCION, SCA_DESCRIPCION_CORTA, SRV_CODIGO, EST_CODIGO) " +
                    "values('" + oSCa.ScaDescripcion + "', '" +oSCa.ScaDescripcionCorta + "', '" +
                    oSCa.SrvCodigo + "', '" + oSCa.EstCodigo + "')", cn);
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

        public bool ServiciosCategoriasUpdate(ServiciosCategorias oSCa)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Servicios_Categorias " +
                    "SET SCA_DESCRIPCION='" + oSCa.ScaDescripcion + "', " +
                    "SCA_DESCRIPCION_CORTA='" + oSCa.ScaDescripcionCorta + "', " +
                    "SRV_CODIGO='" + oSCa.SrvCodigo + "', '" +
                    "EST_CODIGO='" + oSCa.EstCodigo + "' " +
                    "WHERE SCA_NUMERO=" + oSCa.SrvCodigo, cn);
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

        public bool ServiciosCategoriasDelete(long Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Servicios_Categorias " +
                      "WHERE SCA_NUMERO=" + Id, cn);
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

        public ServiciosCategorias ServiciosCategoriasGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Servicios_Categorias " +
                    "WHERE SCA_NUMERO=" + Id;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                ServiciosCategorias NewEnt = new ServiciosCategorias();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarServiciosCategorias(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ServiciosCategorias> ServiciosCategoriasGetAll()
        {
            List<ServiciosCategorias> lstServiciosCategorias = new List<ServiciosCategorias>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Servicios_Categorias ";
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
                        ServiciosCategorias NewEnt = new ServiciosCategorias();
                        NewEnt = CargarServiciosCategorias(dr);
                        lstServiciosCategorias.Add(NewEnt);
                    }
                }
                return lstServiciosCategorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private ServiciosCategorias CargarServiciosCategorias(DataRow dr)
        {
            try
            {
                ServiciosCategorias oObjeto = new ServiciosCategorias();
                oObjeto.ScaNumero = long.Parse(dr["SCA_NUMERO"].ToString());
                oObjeto.ScaDescripcion = dr["SCA_DESCRIPCION"].ToString();
                oObjeto.ScaDescripcionCorta = dr["SCA_DESCRIPCION_CORTA"].ToString();
                oObjeto.SrvCodigo =dr["SRV_CODIGO"].ToString();
                oObjeto.EstCodigo =dr["EST_CODIGO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataTable ServiciosCategoriasGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "ServiciosCategoriasGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
