using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using System.Data;
using System.Web;
using System.Collections;

namespace Services
{


        public partial class Utilidades
        {
            //public void CargarComboEquipos(DropDownList cboEquipos, int tipo, string Distritos)
            //{
            //    EquipoImpl oEquipo = new EquipoImpl();
            //    IList lstEquipos = oEquipo.GetEquiposPorTipoPorDistritos(tipo, Distritos);
            //    CargarCombo(cboEquipos, lstEquipos, "IdEquipo", "Nombre");
            //}

            public void CargarCombo(DropDownList combo, IList Lista, string Value, string Text, string InsertaFila)
            {
                combo.DataSource = Lista;
                combo.DataTextField = Text;
                combo.DataValueField = Value;
                combo.DataBind();
                if (InsertaFila != "")
                    combo.Items.Insert(0, new ListItem(InsertaFila, "0"));
            }

            public void Log(Exception ex)
            {
                string idUsuario = "-1";
                string ip = "";
                string host = "";
                if (HttpContext.Current.Session["idUser"] != null)
                    idUsuario = HttpContext.Current.Session["idUser"].ToString();
                if (HttpContext.Current.Session["ip"] != null)
                    ip = HttpContext.Current.Session["ip"].ToString();
                if (HttpContext.Current.Session["host"] != null)
                    host = HttpContext.Current.Session["host"].ToString();

                //NHibernate.Cfg.Configuration oConf = new NHibernate.Cfg.Configuration();
                //String strconn = oConf.GetProperty("hibernate.connection.connection_string");
                //SqlConnection conn = null;
                //conn = new SqlConnection(strconn);
                //conn.Open();
                //SqlCommand cmd = new SqlCommand();

                //SqlParameter[] param = new SqlParameter[7];
                //param[0] = new SqlParameter("@ip", SqlDbType.VarChar);
                //param[0].Value = ip;
                //param[1] = new SqlParameter("@host", SqlDbType.VarChar);
                //param[1].Value = host;
                //param[2] = new SqlParameter("@idUsuario", SqlDbType.Int);
                //param[2].Value = idUsuario;
                //param[3] = new SqlParameter("@descripcion", SqlDbType.VarChar);
                //param[3].Value = ex.Message;
                //param[4] = new SqlParameter("@InnerException", SqlDbType.VarChar);
                //if (ex.InnerException != null)
                //    param[4].Value = ex.InnerException.ToString();
                //else
                //    param[4].Value = "";
                //param[5] = new SqlParameter("@StackTrace", SqlDbType.VarChar);
                //param[5].Value = ex.StackTrace;
                //param[6] = new SqlParameter("@TargetSite", SqlDbType.VarChar);
                //param[6].Value = ex.TargetSite.ToString(); ;

                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.CommandText = "LogAdd";
                //cmd.Connection = conn;
                //cmd.Parameters.AddRange(param);
                //cmd.ExecuteNonQuery();
                //conn.Close();


            }




            public void CargarCombo(DropDownList combo, DataTable Tabla, string Value, string Text, string InsertaFila)
            {
                combo.DataSource = Tabla;
                combo.DataTextField = Text;
                combo.DataValueField = Value;
                combo.DataBind();
                if (InsertaFila != "")
                    combo.Items.Insert(0, new ListItem(InsertaFila, "0"));
            }

            public void CargarCombo(DropDownList combo, int numero, DataTable Tabla, string Value, string Text, string InsertaFila)
            {

                combo.DataSource = Tabla;
                combo.DataTextField = Text;
                combo.DataValueField = Value;
                combo.DataBind();
                if (InsertaFila != "")
                    combo.Items.Insert(0, new ListItem(InsertaFila, "0"));
            }

            public void CargarCombo(DropDownList combo, DataTable Tabla, string Value, string Text, string InsertaFila1, string InsertaFila2)
            {
                combo.DataSource = Tabla;
                combo.DataTextField = Text;
                combo.DataValueField = Value;
                combo.DataBind();
                if (InsertaFila1 != "")
                {

                    combo.Items.Insert(0, new ListItem(InsertaFila1, "-1"));
                    combo.Items.Insert(1, new ListItem(InsertaFila2, "0"));
                }
            }
        }
    
}
