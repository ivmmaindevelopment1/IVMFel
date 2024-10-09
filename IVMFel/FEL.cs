using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace IVMFel
{
    public class FEL
    {
        public static string FacNit = "";
        public static string FacUsuario = "";
        public static string FacPass = "";
        public static string FacNombreEmisor = "";
        public static string FacDireccion = "";
        public static string FacDepartamento = "";
        public static string FacMunicipio = "";
        public static string FacNombreComercial = "";
        public static int FacCodigoEscenario = 0;
        public static int FacTipoFrase = 0;
        public static int FacCodigoEstablecimiento = 0;
        public static string FacCodigoPostal = "";
        public static bool Promo2doMitadPrecio = false;
        public static bool ActivaInventario = false;

        DBApi dBApi = new DBApi();

        public string Fac(string Cod)
        {
            StringBuilder Query = new StringBuilder();
            Query.AppendLine("SELECT VALOR FROM PROPIEDADVENDING WHERE CODIGOVENDING = '" + Cod + "' AND CODIGOPROPIEDAD = '45'");
            DataTable dtFacNit = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            foreach (DataRow dr in dtFacNit.Rows)
            {
                FacNit = dr["Valor"].ToString();
            }

            Query.Clear();

            Query.AppendLine("SELECT VALOR FROM PROPIEDADVENDING WHERE CODIGOVENDING = '" + Cod + "' AND CODIGOPROPIEDAD = '46'");
            DataTable dtFacUsuario = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            foreach (DataRow dr in dtFacUsuario.Rows)
            {
                FacUsuario = dr["Valor"].ToString();
            }

            Query.Clear();

            Query.AppendLine("SELECT VALOR FROM PROPIEDADVENDING WHERE CODIGOVENDING = '" + Cod + "' AND CODIGOPROPIEDAD = '47'");
            DataTable dtFacPass = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            foreach (DataRow dr in dtFacPass.Rows)
            {
                FacPass = dr["Valor"].ToString();
            }

            Query.Clear();

            Query.AppendLine("SELECT VALOR FROM PROPIEDADVENDING WHERE CODIGOVENDING = '" + Cod + "' AND CODIGOPROPIEDAD = '48'");
            DataTable dtFacNombreEmisor = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            foreach (DataRow dr in dtFacNombreEmisor.Rows)
            {
                FacNombreEmisor = dr["Valor"].ToString();
            }

            Query.Clear();

            Query.AppendLine("SELECT VALOR FROM PROPIEDADVENDING WHERE CODIGOVENDING = '" + Cod + "' AND CODIGOPROPIEDAD = '49'");
            DataTable dtFacDireccion = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            foreach (DataRow dr in dtFacDireccion.Rows)
            {
                FacDireccion = dr["Valor"].ToString();
            }

            Query.Clear();

            Query.AppendLine("SELECT VALOR FROM PROPIEDADVENDING WHERE CODIGOVENDING = '" + Cod + "' AND CODIGOPROPIEDAD = '50'");
            DataTable dtFacDepartamento = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            foreach (DataRow dr in dtFacDepartamento.Rows)
            {
                FacDepartamento = dr["Valor"].ToString();
            }

            Query.Clear();

            Query.AppendLine("SELECT VALOR FROM PROPIEDADVENDING WHERE CODIGOVENDING = '" + Cod + "' AND CODIGOPROPIEDAD = '51'");
            DataTable dtFacMunicipio = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            foreach (DataRow dr in dtFacMunicipio.Rows)
            {
                FacMunicipio = dr["Valor"].ToString();
            }

            Query.Clear();

            Query.AppendLine("SELECT VALOR FROM PROPIEDADVENDING WHERE CODIGOVENDING = '" + Cod + "' AND CODIGOPROPIEDAD = '52'");
            DataTable dtFacNombreComercial = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            foreach (DataRow dr in dtFacNombreComercial.Rows)
            {
                FacNombreComercial = dr["Valor"].ToString();
            }

            Query.Clear();

            Query.AppendLine("SELECT VALOR FROM PROPIEDADVENDING WHERE CODIGOVENDING = '" + Cod + "' AND CODIGOPROPIEDAD = '53'");
            DataTable dtFacCodigoEscenario = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            foreach (DataRow dr in dtFacCodigoEscenario.Rows)
            {
                FacCodigoEscenario = Convert.ToInt32(dr["Valor"].ToString());
            }

            Query.Clear();

            Query.AppendLine("SELECT VALOR FROM PROPIEDADVENDING WHERE CODIGOVENDING = '" + Cod + "' AND CODIGOPROPIEDAD = '54'");
            DataTable dtFacTipoFrase = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            foreach (DataRow dr in dtFacTipoFrase.Rows)
            {
                FacTipoFrase = Convert.ToInt32(dr["Valor"].ToString());
            }

            Query.Clear();

            Query.AppendLine("SELECT VALOR FROM PROPIEDADVENDING WHERE CODIGOVENDING = '" + Cod + "' AND CODIGOPROPIEDAD = '55'");
            DataTable dtFacCodigoEstablecimiento = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            foreach (DataRow dr in dtFacCodigoEstablecimiento.Rows)
            {
                FacCodigoEstablecimiento = Convert.ToInt32(dr["Valor"].ToString());
            }

            Query.Clear();

            Query.AppendLine("SELECT VALOR FROM PROPIEDADVENDING WHERE CODIGOVENDING = '" + Cod + "' AND CODIGOPROPIEDAD = '56'");
            DataTable dtFacCodigoPostal = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            foreach (DataRow dr in dtFacCodigoPostal.Rows)
            {
                FacCodigoPostal = dr["Valor"].ToString();
            }

            Query.Clear();

            Query.AppendLine("SELECT VALOR FROM PROPIEDADVENDING WHERE CODIGOVENDING = '" + Cod + "' AND CODIGOPROPIEDAD = '57'");
            DataTable dtPromo2doMitadPrecio = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            foreach (DataRow dr in dtPromo2doMitadPrecio.Rows)
            {
                Promo2doMitadPrecio = Convert.ToBoolean(dr["Valor"].ToString());
            }

            Query.Clear();

            Query.AppendLine("SELECT VALOR FROM PROPIEDADVENDING WHERE CODIGOVENDING = '" + Cod + "' AND CODIGOPROPIEDAD = '20'");
            DataTable dtActivaInventario = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            foreach (DataRow dr in dtActivaInventario.Rows)
            {
                ActivaInventario = Convert.ToBoolean(dr["Valor"].ToString());
            }

            return Cod;

        }

        public string GetToken()
        {
            getToken token = new getToken
            {
                UserName = "GT." + FacNit + "." + FacUsuario,//"GT." + "000112753175.112753175",
                Password = FacPass//"7m7yK2?+"
            };
            string json = JsonConvert.SerializeObject(token);
            dynamic respuesta = dBApi.Post("https://felgtaws.digifact.com.gt/gt.com.fel.api.v3/api/login/get_token", json);
            return respuesta.Token.ToString();
        }

        public resultadoFactura GetFactura(string stoken, string NIT, string Nombre, string Direccion, string Codigo)
        {
            StringBuilder Query = new StringBuilder();
            DataTable dtFactura = new DataTable();
            if (!Promo2doMitadPrecio)
            {
                Query.AppendLine("SELECT			PV.Numero, FD.PrecioUnitario, FD.Cantidad, F.CodigoVending");
                Query.AppendLine("FROM            Factura F");
                Query.AppendLine("LEFT JOIN       FacturaDetalle FD");
                Query.AppendLine("ON              F.CodigoFactura = FD.CodigoFactura");
                Query.AppendLine("LEFT JOIN       PosicionVending PV");
                Query.AppendLine("ON              FD.CodigoPosicion = PV.CodigoPosicion");
                Query.AppendLine("WHERE           F.CodigoInterno = '" + Codigo + "'");
            }
            else
            {
                Query.AppendLine("SELECT			CASE WHEN FD.PrecioUnitario < IV.Precio ");
                Query.AppendLine("				THEN ");
                Query.AppendLine("					'PROMO BLACK FRIDAY ' + CAST(PV.Numero AS VARCHAR(2)) ");
                Query.AppendLine("				ELSE ");
                Query.AppendLine("					CAST(PV.Numero AS VARCHAR(2)) ");
                Query.AppendLine("				END as Numero, ");
                Query.AppendLine("				FD.PrecioUnitario, FD.Cantidad, F.CodigoVending");
                Query.AppendLine("FROM            Factura F");
                Query.AppendLine("LEFT JOIN       FacturaDetalle FD");
                Query.AppendLine("ON              F.CodigoFactura = FD.CodigoFactura");
                Query.AppendLine("LEFT JOIN       PosicionVending PV");
                Query.AppendLine("ON              FD.CodigoPosicion = PV.CodigoPosicion");
                Query.AppendLine("LEFT JOIN		InventarioVending IV");
                Query.AppendLine("ON				PV.CodigoPosicion = IV.CodigoPosicion");
                Query.AppendLine("WHERE           F.CodigoInterno = '" + Codigo + "'");

            }
            dtFactura = Class1.DevolverTabla(Query.ToString(), "IVM12345");
            getToken token = new getToken
            {
                UserName = "GT." + FacNit + "." + FacUsuario,
                Password = FacPass //"7m7yK2?+"
            };
            //Fac(30)
            string fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");

            StringBuilder xmlFactura = new StringBuilder();
            xmlFactura.AppendLine("<?xml version='1.0' encoding='UTF-8'?>");
            xmlFactura.AppendLine("<dte:GTDocumento xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"");
            xmlFactura.AppendLine("    xmlns:dte=\"http://www.sat.gob.gt/dte/fel/0.2.0\" Version=\"0.1\">");
            xmlFactura.AppendLine("    <dte:SAT ClaseDocumento=\"dte\">");
            xmlFactura.AppendLine("        <dte:DTE ID=\"DatosCertificados\">");
            xmlFactura.AppendLine("            <dte:DatosEmision ID=\"DatosEmision\">");
            xmlFactura.AppendLine("                <dte:DatosGenerales Tipo=\"FACT\" FechaHoraEmision=\"" + fecha + "\"");
            xmlFactura.AppendLine("                    CodigoMoneda=\"GTQ\" />");
            xmlFactura.AppendLine("                <dte:Emisor NITEmisor=\"" + FacUsuario + "\" NombreEmisor=\"" + FacNombreEmisor + "\" CodigoEstablecimiento=\"" + FacCodigoEstablecimiento.ToString() + "\"");
            xmlFactura.AppendLine("                    NombreComercial=\"" + FacNombreComercial + "\" AfiliacionIVA=\"GEN\">");
            xmlFactura.AppendLine("                    <dte:DireccionEmisor>");
            xmlFactura.AppendLine("                        <dte:Direccion>" + FacDireccion + "</dte:Direccion>");
            xmlFactura.AppendLine("                        <dte:CodigoPostal>" + FacCodigoPostal + "</dte:CodigoPostal>");
            xmlFactura.AppendLine("                        <dte:Municipio>" + FacMunicipio + "</dte:Municipio>");
            xmlFactura.AppendLine("                        <dte:Departamento>" + FacDepartamento + "</dte:Departamento>");
            xmlFactura.AppendLine("                        <dte:Pais>GT</dte:Pais>");
            xmlFactura.AppendLine("                    </dte:DireccionEmisor>");
            xmlFactura.AppendLine("                </dte:Emisor>");
            xmlFactura.AppendLine("                <dte:Receptor NombreReceptor=\"" + Nombre + "\" IDReceptor=\"" + NIT + "\">");
            xmlFactura.AppendLine("                    <dte:DireccionReceptor>");
            xmlFactura.AppendLine("                        <dte:Direccion>" + Direccion + "</dte:Direccion>");
            xmlFactura.AppendLine("                        <dte:CodigoPostal>" + FacCodigoPostal + "</dte:CodigoPostal>");
            xmlFactura.AppendLine("                        <dte:Municipio>" + FacMunicipio + "</dte:Municipio>");
            xmlFactura.AppendLine("                        <dte:Departamento>" + FacDepartamento + "</dte:Departamento>");
            xmlFactura.AppendLine("                        <dte:Pais>GT</dte:Pais>");
            xmlFactura.AppendLine("                    </dte:DireccionReceptor>");
            xmlFactura.AppendLine("                </dte:Receptor>");
            xmlFactura.AppendLine("                <dte:Frases>");
            xmlFactura.AppendLine("                    <dte:Frase TipoFrase=\"" + FacTipoFrase.ToString() + "\" CodigoEscenario=\"" + FacCodigoEscenario.ToString() + "\"/>");

            xmlFactura.AppendLine("                </dte:Frases>");
            xmlFactura.AppendLine("                <dte:Items>");
            double impuesto = 0;
            double total = 0;
            foreach (DataRow dr in dtFactura.Rows)
            {
                double subtotal = Convert.ToDouble(dr["PrecioUnitario"].ToString()) * Convert.ToDouble(dr["Cantidad"].ToString());
                string articulo = "";
                if (ActivaInventario && dr["Numero"].ToString().Contains("PROMO"))
                {
                    articulo = dr["Numero"].ToString();
                }
                else
                {
                    articulo = "Articulo No." + dr["Numero"].ToString();
                }
                impuesto += (subtotal - (subtotal / 1.12));
                total += subtotal;
                xmlFactura.AppendLine("                    <dte:Item NumeroLinea=\"1\" BienOServicio=\"B\">");
                xmlFactura.AppendLine("                        <dte:Cantidad>" + dr["Cantidad"].ToString() + ".000</dte:Cantidad>");
                xmlFactura.AppendLine("                        <dte:UnidadMedida>CA</dte:UnidadMedida>");
                xmlFactura.AppendLine("                        <dte:Descripcion>" + articulo + "</dte:Descripcion>");
                xmlFactura.AppendLine("                        <dte:PrecioUnitario>" + dr["PrecioUnitario"].ToString() + "</dte:PrecioUnitario>");
                xmlFactura.AppendLine("                        <dte:Precio>" + subtotal.ToString() + "</dte:Precio>");
                xmlFactura.AppendLine("                        <dte:Descuento>0</dte:Descuento>");
                xmlFactura.AppendLine("                        <dte:Impuestos>");
                xmlFactura.AppendLine("                            <dte:Impuesto>");
                xmlFactura.AppendLine("                                <dte:NombreCorto>IVA</dte:NombreCorto>");
                xmlFactura.AppendLine("                                <dte:CodigoUnidadGravable>1</dte:CodigoUnidadGravable>");
                xmlFactura.AppendLine("                                <dte:MontoGravable>" + Math.Round((subtotal / 1.12), 3).ToString() + "</dte:MontoGravable>");
                xmlFactura.AppendLine("                                <dte:MontoImpuesto>" + Math.Round((subtotal - (subtotal / 1.12)), 3).ToString() + "</dte:MontoImpuesto>");
                xmlFactura.AppendLine("                            </dte:Impuesto>");
                xmlFactura.AppendLine("                        </dte:Impuestos>");
                xmlFactura.AppendLine("                        <dte:Total>" + subtotal.ToString() + "</dte:Total>");
                xmlFactura.AppendLine("                    </dte:Item>");
            }

            xmlFactura.AppendLine("                </dte:Items>");
            xmlFactura.AppendLine("                <dte:Totales>");
            xmlFactura.AppendLine("                    <dte:TotalImpuestos>");
            xmlFactura.AppendLine("                        <dte:TotalImpuesto NombreCorto=\"IVA\" TotalMontoImpuesto=\"" + Math.Round(impuesto, 3).ToString() + "\"/>");
            xmlFactura.AppendLine("                    </dte:TotalImpuestos>");
            xmlFactura.AppendLine("                    <dte:GranTotal>" + total.ToString() + "</dte:GranTotal>");
            xmlFactura.AppendLine("                </dte:Totales>");
            xmlFactura.AppendLine("            </dte:DatosEmision>");
            xmlFactura.AppendLine("        </dte:DTE>");
            xmlFactura.AppendLine("        <dte:Adenda>");
            xmlFactura.AppendLine("         <dtecomm:Informacion_COMERCIAL xmlns:dtecomm=\"https://www.digifact.com.gt/dtecomm\" xsi:schemaLocation=\"https://www.digifact.com.gt/dtecomm\">");
            xmlFactura.AppendLine("           <dtecomm:InformacionAdicional Version=\"7.1234654163\">");
            xmlFactura.AppendLine("               <dtecomm:REFERENCIA_INTERNA>" + Codigo + "</dtecomm:REFERENCIA_INTERNA>");//1B7IUMWYO3B2
            xmlFactura.AppendLine("               <dtecomm:FECHA_REFERENCIA>" + fecha + "</dtecomm:FECHA_REFERENCIA>");
            xmlFactura.AppendLine("               <dtecomm:VALIDAR_REFERENCIA_INTERNA>VALIDAR</dtecomm:VALIDAR_REFERENCIA_INTERNA>");
            xmlFactura.AppendLine("            </dtecomm:InformacionAdicional>");
            xmlFactura.AppendLine("            </dtecomm:Informacion_COMERCIAL>");
            xmlFactura.AppendLine("         </dte:Adenda>   ");
            xmlFactura.AppendLine("    </dte:SAT>");
            xmlFactura.AppendLine("</dte:GTDocumento>");

            string json = xmlFactura.ToString();
            dynamic respuesta = dBApi.Post("https://felgtaws.digifact.com.gt/gt.com.fel.api.v3/api/FelRequestV2", json, stoken, FacUsuario, "CERTIFICATE_DTE_XML_TOSIGN", "PDF", FacUsuario);
            //dynamic respuesta = dBApi.Post("https://felgtaws.digifact.com.gt/gt.com.fel.api.v3/api/FelRequestV2", json, stoken, "112753175", "CERTIFICATE_DTE_XML_TOSIGN", "PDF", "112753175");
            //dynamic respuesta = dBApi.Post("https://felgttestaws.digifact.com.gt/gt.com.fel.api.v3/api/FelRequestV2", json, stoken, "000044653948", "CERTIFICATE_DTE_XML_TOSIGN", "PDF", "PRUEBAS39");

            //byte[] bytes = Convert.FromBase64String(respuesta.ResponseDATA3.ToString());

            resultadoFactura respuestafac = new resultadoFactura();
            respuestafac.Autorizacion = respuesta.Autorizacion.ToString();
            respuestafac.Serie = respuesta.Serie.ToString();
            respuestafac.NUMERO = respuesta.NUMERO.ToString();
            respuestafac.Fecha_de_certificacion = respuesta.Fecha_de_certificacion.ToString();
            respuestafac.pdf = respuesta.ResponseDATA3.ToString();
            respuestafac.AcuseReciboSAT = respuesta.ResponseDATA1.ToString();
            respuestafac.jsonFactura = xmlFactura.ToString();
            return respuestafac;
        }

        public resultadoNit devolvernit(string nit, string stoken)
        {
            resultadoNit respuesta = new resultadoNit();
            getToken token = new getToken
            {
                UserName = "GT." + FacNit + "." + FacUsuario,
                Password = FacPass //"7m7yK2?+"
            };
            string json = JsonConvert.SerializeObject(token);

            //https://felgttestaws.digifact.com.gt/felapiv2/api/sharedInfo
            string nit2 = new string('0', 12);
            nit2 = nit2.Substring(0, 12 - nit.Length);
            nit2 = nit2 + nit;
            dynamic rdynamic = dBApi.PostNit("https://felgtaws.digifact.com.gt/gt.com.fel.api.v3/api/SHAREDINFO", stoken, "000112753175", "SHARED_GETINFONITCOM", "NIT|" + nit, "", "112753175");
            //dynamic respuesta = dBApi.PostNit("https://felgtaws.digifact.com.gt/gt.com.fel.api.v3/api/SHAREDINFO", stoken, "000071073027", "SHARED_GETINFONITCOM", "NIT|71073027", "", "PRUEBAS39");
            //MessageBox.Show(respuesta.Token.ToString());
            //txtRespuestaFactura.Text = rdynamic.
            try
            {
                respuesta.PAIS = rdynamic.RESPONSE[0].PAIS.ToString();
                respuesta.NOMBRE = rdynamic.RESPONSE[0].NOMBRE.ToString();
                respuesta.Direccion = rdynamic.RESPONSE[0].Direccion.ToString();
            }
            catch (Exception ex)
            {
                respuesta.PAIS = "";
                respuesta.NOMBRE = "";
                respuesta.Direccion = "";
            }
            return respuesta;
        }

    }
    public class resultadoFactura
    {
        public string Autorizacion { get; set; }
        public string Serie { get; set; }   
        public string NUMERO { get; set; }  
        public string Fecha_de_certificacion { get; set; }
        public string pdf { get; set; } 
        public string AcuseReciboSAT { get; set; }
        public string jsonFactura { get; set; }
    }

    public class getToken
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class resultadoNit
    {
        public string PAIS { get; set; }
        public string NOMBRE { get; set; }
        public string Direccion { get; set; }
        public string DEPARTAMENTO { get; set; }
        public string MUNICIPIO { get; set; }
    }

    public class facturafel
    {
        public string token { get; set; }
        public string nit { get; set; }
        public string tipo { get; set; }
        public string format { get; set; }
        public string user { get; set; }
    }
}