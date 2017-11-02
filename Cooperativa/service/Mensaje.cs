using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;

namespace Services
{
    public class Mensaje
    {
        public enum TypeMessage
        {
            error,
            success,
            warning,
            notice
        }

        //private const string _NOTICE = "notice";
        //private const string _SUCCESS = "success";
        //private const string _WARNING = "warning";
        //private const string _ERROR = "error";

        /// <summary>
        ///     <para>Muestra un mensaje por pantalla</para>
        ///     <para>param 1|"form"(Page) = Formulario en el que se va a mostrar el mensaje</para>
        ///     <para>param 2|"message"(string) = Mensaje a mostrar</para>
        ///     <para>param 3|"sticky"(bool) = Indica si el mensaje desaparece solo(false) o no(true)</para>
        ///     <para>param 4|"typemessage"(string) = Indica tipo de mensaje mostrar (_ERROR, _NOTICE, _WARNING, _SUCCESS)</para>
        /// </summary>
        /// <param name="form">Formulario en el que se va a mostrar el mensaje</param>
        /// <param name="message">Mensaje a mostrar</param>
        /// <param name="sticky">Indica si el mensaje desaparece solo(false) o no(true)</param>
        /// <param name="typemessage">Indica tipo de mensaje mostrar (_ERROR, _NOTICE, _WARNING, _SUCCESS)</param>
        public static void MostrarMensaje(Page form, string message, bool sticky, TypeMessage typemessage)
        {
            string toasttypemessage;
            switch (typemessage)
            {
                case TypeMessage.notice:
                    if (sticky)
                        toasttypemessage = "showStickyNoticeToast";
                    else
                        toasttypemessage = "showNoticeToast";
                    break;
                case TypeMessage.success:
                    if (sticky)
                        toasttypemessage = "showStickySuccessToast";
                    else
                        toasttypemessage = "showSuccessToast";
                    break;
                case TypeMessage.warning:
                    if (sticky)
                        toasttypemessage = "showStickyWarningToast";
                    else
                        toasttypemessage = "showWarningToast";
                    break;
                case TypeMessage.error:
                    if (sticky)
                        toasttypemessage = "showStickyErrorToast";
                    else
                        toasttypemessage = "showErrorToast";
                    break;
                default:
                    toasttypemessage = string.Empty;
                    break;
            }

            if (toasttypemessage != string.Empty)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script language=Javascript>");

                message = message.Replace("'", "#");
                message = message.Replace('"', '#');
                message = message.Replace("\r", "<br>");
                message = message.Replace("\n", "<br>");
                sb.Append("javascript:" + toasttypemessage + "('" + message + "');");
                sb.Append("</script>");

                form.ClientScript.RegisterStartupScript(form.GetType(), "JSScript", sb.ToString());
            }
        }

        /// <summary>        
        ///     <para>Este método nos sirve para generar la pregunta de jQuery desde código, en el caso de que se necesite.</para>
        ///     <para>Se debe crear la función Pregunta(boton, eventTarget) en el CodeBehind de la pagina en que se use este método.</para>
        ///     <para>param 1|"form"(Page) = Formulario en el que se va a mostrar el mensaje</para>
        ///     <para>param 2|"IDELEMENTOSERVICIOJERARQUIA"(int) Es el id del Elemento que se obtiene desde el código.</para>
        /// </summary>
        /// <param name="form">Formulario en el que se va a mostrar el mensaje.</param>
        /// <param name="IDELEMENTOSERVICIOJERARQUIA">Es el ID del elemento que se obtiene desde el código.</param>
        public static void Pregunta(Page form, int IDELEMENTOSERVICIOJERARQUIA)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script language=Javascript>");
            sb.Append("javascript:Pregunta(" + IDELEMENTOSERVICIOJERARQUIA + ", \"MODIFICAR\");");
            sb.Append("</script>");

            form.ClientScript.RegisterStartupScript(form.GetType(), "JSScript", sb.ToString());

        }

        public static void PreguntaCodigoPedido(Page form, string estado, string cant)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script language=Javascript>");
            // + ", " + cant.ToString()
            sb.Append("javascript:PreguntaCodigoPedido('<BR>" + estado + "', '" + cant + "');");

            sb.Append("</script>");

            form.ClientScript.RegisterStartupScript(form.GetType(), "JSScript", sb.ToString());

        }

        public static void PreguntaCodigoPedido(Page form, string estado)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script language=Javascript>");
            // + ", " + cant.ToString()
            sb.Append("javascript:PreguntaCodigoPedido('<BR>" + estado + "');");
            sb.Append("</script>");

            form.ClientScript.RegisterStartupScript(form.GetType(), "JSScript", sb.ToString());

        }
    }
}
