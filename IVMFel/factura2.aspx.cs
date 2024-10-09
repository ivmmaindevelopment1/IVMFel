using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IVMFel
{
    public partial class factura2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CodigoInterno = Security.Decrypt(Request.QueryString["Codigo"], "IVM12345");
            string Nit = Security.Decrypt(Request.QueryString["Nit"], "IVM12345");

            string cod = CodigoInterno.Substring(4, 1) + CodigoInterno.Substring(5, 1);

            FEL fel = new FEL();

            fel.Fac(cod);

            string token = fel.GetToken();

            resultadoNit rNit = fel.devolvernit(Nit, token);

            resultadoFactura respuesta = fel.GetFactura(token, Nit, rNit.NOMBRE, rNit.Direccion, CodigoInterno);

            StringBuilder Query = new StringBuilder();
            Query.AppendLine("SELECT AUTORIZACION FROM FACTURA WHERE CODIGOINTERNO = '" + CodigoInterno + "'");
            DataTable dt = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            if (dt.Rows[0][0].ToString() != "")
            {
                return;
            }

            Query.Clear();

            Query.AppendLine("UPDATE Factura");
            Query.AppendLine("SET");
            Query.AppendLine("Autorizacion = '" + respuesta.Autorizacion + "', ");
            Query.AppendLine("AcuseRecibidoSAT = '" + respuesta.AcuseReciboSAT + "', ");
            Query.AppendLine("Numero = '" + respuesta.NUMERO + "', ");
            Query.AppendLine("Serie = '" + respuesta.Serie + "', ");
            Query.AppendLine("Nit = '" + Nit + "', ");
            Query.AppendLine("pdfFactura = @PDF, ");
            Query.AppendLine("pdf = '" + respuesta.jsonFactura.Replace("'","''") + "',");
            Query.AppendLine("FechaHoraCertificacion = '" + Convert.ToDateTime(respuesta.Fecha_de_certificacion).ToString("yyyy/MM/dd HH:mm:ss") + "'");
            Query.AppendLine("WHERE CodigoInterno = '" + CodigoInterno + "'");
            Query.AppendLine("SELECT SCOPE_IDENTITY()");
            SqlCommand cmd = new SqlCommand();
            SqlConnection cnn = new SqlConnection(Security.Decrypt("fpq3SXZZvo7j9Ou3xbqtNcnRrxo3uLEKY0PQRNn7E6taQxJPXQw2KN/jrrBh9hnPOYAVnZvolBFZyWVBFIzf1OIVDP9c73Am/qK1umwjK3YYIkMeUWwKEPMH4ceFokNt8rE0K/hdLCr8TNhYRykM311YcIgTtZ09zdYBkpoDZrXDYqDsr/24uf8qkG8iBid4", "IVM12345"));
            cmd.Connection = cnn;
            cmd.CommandText = Query.ToString();
            cmd.Parameters.Add("@PDF", SqlDbType.VarBinary).Value = Convert.FromBase64String(respuesta.pdf);
            //Class1.InsertarModificarEliminar(Query.ToString(), Properties.Settings.Default.Conexion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            Query.Clear();
            Query.AppendLine("SELECT PDFFACTURA FROM FACTURA WHERE CODIGOINTERNO = '" + CodigoInterno + "'");
            DataTable dt1 = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            if (dt1.Rows[0][0].ToString() != "")
            {
                Response.AddHeader("Content-Disposition", "attachment;filename=FacturaElectronica.pdf");
                Response.ContentType = "application/pdf";
                Response.BinaryWrite((byte[])(dt1.Rows[0][0]));
            }
        }
    }
}