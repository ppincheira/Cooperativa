using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Globalization;

namespace Services
{
    public class Commons
    {

        public static object GetNullIfEmpty(string sValue)
        {
            if (sValue == null || sValue.Trim().Length == 0)
            {
                return null;
            }

            return sValue;
        }

        public static object GetMinValueIfEmpty(string sValue)
        {
            if (sValue == null || sValue.Trim().Length == 0)
            {
                return DateTime.MinValue;
            }

            return sValue;
        }

        public static bool EquipoPermitido(int idEquipo)
        {
            string[] Equipos = HttpContext.Current.Session["EquiposUsuario"].ToString().Split(',');
            bool Permitido = false;

            for (int i = 0; i < Equipos.Length; i++)
            {
                if (idEquipo == int.Parse(Equipos[i].ToString()))
                    Permitido = true;
            }

            return Permitido;
        }

        public static string GetNadaIfNull(string value)
        {
            if (value == null || value == "" || value == string.Empty)
                return "-";
            else
                return value.ToString();
        }
        public enum TypeFecha
        {
            Min, Max
        }

        public static DateTime obtenerFechaCultura(string fecha, CultureInfo oCultura, TypeFecha tipo)
        {
            DateTime Fecha;
            if (tipo== TypeFecha.Min)
                Fecha = DateTime.Parse("1/1/1753");
            else
                Fecha = DateTime.Parse("1/1/3000");

            if (fecha.Length > 0)
            {
                Fecha = DateTime.Parse(fecha, oCultura);
            }
            return Fecha;
        }
    }
}
