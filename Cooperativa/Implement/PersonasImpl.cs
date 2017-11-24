using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Configuration;
using Model;
namespace Implement
{
    public class PersonasImpl
    {
        #region Personas methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int PersonasAdd(Personas oPersonas)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                ds = new DataSet();
                cmd = new OracleCommand("insert into PERSONAS(PRS_NUMERO, PRS_APELLIDO,PRS_NOMBRE,PRS_TIPO_DOC, PRS_NUMERO_DOC, PRS_FECHA_NACIMIENTO, PRS_LEGAJO, LOC_NUMERO_NACIMIENTO, EST_CODIGO, PRS_FECHA_INGRESO, PRS_MOTIVO_BAJA, PRS_SEXO, PRS_ESTADO_CIVIL, PRS_CUIL, PAI_CODIGO_NACIMIENTO, PRS_CARGO, PRV_CODIGO_NACIMIENTO) " +
                                      " values('" + oPersonas.PrsNumero + "','"+   oPersonas.PrsApellido + "','"+ oPersonas.PrsNombre +"','"+ oPersonas.PrsTipoDoc +"','"+ oPersonas.PrsNumeroDoc +", TO_DATE('" + oPersonas.PrsFechaNacimiento + "','YYYY-MM-DD HH24:MI:SS'), " + oPersonas.PrsLegajo + "," + oPersonas.LocNumeroNacimiento + "," + oPersonas.EstCodigo + ", TO_DATE('" + oPersonas.PrsFechaIngreso + "', 'YYYY-MM-DD HH24:MI:SS'), '" + oPersonas.PrsMotivoBaja + "','" + oPersonas.PrsSexo + "','"+oPersonas.PrsEstadoCivil +"','" +oPersonas.PrsCuil+"','"+oPersonas.PaiCodigoNacimiento +"','"+oPersonas.PrsCargo+"','"+oPersonas.PrvCodigoNacimiento+"')", cn);
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

        public bool PersonasUpdate(Personas oPersonas)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Personas " +
                    "SET PRS_APELLIDO='" + oPersonas.PrsApellido + "'," +
                    "PRS_NOMBRE='" + oPersonas.PrsNombre + "'," +
                    "PRS_TIPO_DOC='" + oPersonas.PrsTipoDoc + "'," +
                    "PRS_NUMERO_DOC ='" + oPersonas.PrsTipoDoc + "'," +
                    "PRS_FECHA_NACIMIENTO, ='" + oPersonas.PrsFechaNacimiento + "'," +
                    "PRS_LEGAJO, ='" + oPersonas.PrsLegajo + "'," +
                    "LOC_NUMERO_NACIMIENTO ='" + oPersonas.LocNumeroNacimiento + "'," +
                    "EST_CODIGO ='" + oPersonas.EstCodigo + "'," +
                    "PRS_FECHA_INGRESO ='" + oPersonas.PrsFechaIngreso + "'," +
                    "PRS_MOTIVO_BAJA ='" + oPersonas.PrsMotivoBaja + "'," +
                    "PRS_SEXO ='" + oPersonas.PrsSexo + "'," +
                    "PRS_ESTADO_CIVIL ='" + oPersonas.PrsEstadoCivil + "'," +
                    "PRS_CUIL ='" + oPersonas.PrsCuil + "'," +
                    "PAI_CODIGO_NACIMIENTO ='" + oPersonas.PaiCodigoNacimiento + "'," +
                    "PRS_CARGO ='" + oPersonas.PrsCargo + "'," +
                    "PRV_CODIGO_NACIMIENTO ='" + oPersonas.PrvCodigoNacimiento + "'," +
                    "PRS_FECHA_BAJA ='" + oPersonas.PrsFechaBaja + "'," +
                    "WHERE PRS_NUMERO='" + oPersonas.PrsNumero + "'", cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PersonasDelete(String Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Personas " +
                      "WHERE PRS_NUMERO='" + Id + "'", cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public Personas PersonasGetById(int Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Personas " +
                    "where PRS_NUMERO=" + Id ;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Personas NewEnt = new Personas();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarPersonas(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       
        public List<Personas> PersonasGetAll()
        {
            List<Personas> lstPersonas = new List<Personas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Personas ";
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
                        Personas NewEnt = new Personas();
                        NewEnt = CargarPersonas(dr);
                        lstPersonas.Add(NewEnt);
                    }
                }
                return lstPersonas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Personas CargarPersonas(DataRow dr)
        {
            try
            {
                Personas oObjeto = new Personas();
                oObjeto.PrsNumero = int.Parse(dr["PRS_NUMERO"].ToString());
                oObjeto.PrsApellido = dr["PRS_APELLIDO"].ToString();
                oObjeto.PrsNombre = dr["PRS_NOMBRE"].ToString();
                oObjeto.PrsTipoDoc = dr["PRS_TIPO_DOC"].ToString();
                oObjeto.PrsNumeroDoc = dr["PRS_NUMERO_DOC"].ToString();
                if (dr["PRS_FECHA_NACIMIENTO"].ToString() != "")
                    oObjeto.PrsFechaNacimiento = DateTime.Parse(dr["PRS_FECHA_NACIMIENTO"].ToString());
                oObjeto.PrsLegajo = int.Parse(dr["PRS_LEGAJO"].ToString());
                oObjeto.LocNumeroNacimiento = int.Parse(dr["LOC_NUMERO_NACIMIENTO"].ToString());
                oObjeto.EstCodigo = dr["EST_CODIGO"].ToString();
                if (dr["PRS_FECHA_INGRESO"].ToString() != "")
                    oObjeto.PrsFechaIngreso = DateTime.Parse(dr["PRS_FECHA_INGRESO"].ToString());
                oObjeto.PrsMotivoBaja = dr["PRS_MOTIVO_BAJA"].ToString();
                oObjeto.PrsSexo = dr["PRS_SEXO"].ToString();
                oObjeto.PrsEstadoCivil = dr["PRS_ESTADO_CIVIL"].ToString();
                oObjeto.PrsCuil = dr["PRS_CUIL"].ToString();
                oObjeto.PaiCodigoNacimiento= dr["PAI_CODIGO_NACIMIENTO"].ToString();
                oObjeto.PrsCargo = dr["PRS_CARGO"].ToString();
                oObjeto.PrvCodigoNacimiento = dr["PRV_CODIGO_NACIMIENTO"].ToString();
                if (dr["PRS_FECHA_BAJA"].ToString() != "")
                    oObjeto.PrsFechaBaja = DateTime.Parse(dr["PRS_FECHA_BAJA"].ToString());
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

