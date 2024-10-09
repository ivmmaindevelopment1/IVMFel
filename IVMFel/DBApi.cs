using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace IVMFel
{
    public class DBApi
    {
        public dynamic Post(string url, string json, string autorizacion = null, string NIT = null, string TIPO = null, string FORMAT = null, string USERNAME = null)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                if (autorizacion != null)
                {
                    request.AddHeader("Authorization", autorizacion);
                }
                if (NIT != null)
                {
                    request.AddParameter("NIT", NIT, ParameterType.QueryString);
                }
                if (TIPO != null)
                {
                    request.AddParameter("TIPO", TIPO, ParameterType.QueryString);
                }
                if (FORMAT != null)
                {
                    request.AddParameter("FORMAT", FORMAT, ParameterType.QueryString);
                }
                if (USERNAME != null)
                {
                    request.AddParameter("USERNAME", USERNAME, ParameterType.QueryString);
                }

                IRestResponse response = client.Execute(request);

                dynamic datos = JsonConvert.DeserializeObject(response.Content);

                return datos;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public dynamic PostNit(string url, string autorizacion, string NIT, string DATA1, string DATA2, string DATA3, string USERNAME)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.GET);
                request.AddHeader("content-type", "application/json");
                //request.AddParameter("application/json", json, ParameterType.RequestBody);

                if (autorizacion != null)
                {
                    request.AddHeader("Authorization", autorizacion);
                }
                if (NIT != null)
                {
                    request.AddParameter("NIT", NIT, ParameterType.QueryString);
                }
                if (DATA1 != null)
                {
                    request.AddParameter("DATA1", DATA1, ParameterType.QueryString);
                }
                if (DATA2 != null)
                {
                    request.AddParameter("DATA2", DATA2, ParameterType.QueryString);
                }
                if (USERNAME != null)
                {
                    request.AddParameter("USERNAME", USERNAME, ParameterType.QueryString);
                }

                IRestResponse response = client.Execute(request);

                dynamic datos = JsonConvert.DeserializeObject(response.Content);

                return datos;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public dynamic Get(string url)
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
            //myWebRequest.CookieContainer = myCookie;
            myWebRequest.Credentials = CredentialCache.DefaultCredentials;
            myWebRequest.Proxy = null;
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            Stream myStream = myHttpWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myStream);
            //Leemos los datos
            string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());

            dynamic data = JsonConvert.DeserializeObject(Datos);

            return data;
        }
    }
}