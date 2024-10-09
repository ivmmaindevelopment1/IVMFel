using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IVMFel
{
    public partial class factura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            //FEL fel = new FEL();
            //string token = fel.GetToken();
            if (Request.QueryString["Codigo"] == "" || Request.QueryString["Codigo"] == null)
                return;
            string Codigo = Security.Decrypt(Request.QueryString["Codigo"], "IVM12345");
            string NIT = Security.Decrypt(Request.QueryString["Nit"], "IVM12345");
            if (Codigo == "")
                return;
            
            StringBuilder Query = new StringBuilder();
            Query.AppendLine("SELECT pdfFactura FROM FACTURA WHERE CODIGOINTERNO = '" + Codigo + "'");
            DataTable dt = Class1.DevolverTabla(Query.ToString(), "IVM12345");  
            if(dt.Rows[0][0].ToString() != "")
            {
                Response.AddHeader("Content-Disposition", "attachment;filename=FacturaElectronica.pdf");
                Response.ContentType = "application/pdf";
                Response.BinaryWrite((byte[])(dt.Rows[0][0]));
                return;
            }               

        }
    }
}