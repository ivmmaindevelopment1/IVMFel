using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace IVMFel
{
    class Class1
    {
        static bool _continue;

        public static DataTable DevolverTabla(string Query, string conexion)
        {
            conexion = Security.Decrypt("fpq3SXZZvo7j9Ou3xbqtNcnRrxo3uLEKY0PQRNn7E6taQxJPXQw2KN/jrrBh9hnPOYAVnZvolBFZyWVBFIzf1OIVDP9c73Am/qK1umwjK3YYIkMeUWwKEPMH4ceFokNt8rE0K/hdLCr8TNhYRykM311YcIgTtZ09zdYBkpoDZrXDYqDsr/24uf8qkG8iBid4", conexion);
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cnn = new SqlConnection(conexion);
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                SqlCommand cmd = new SqlCommand(Query, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cnn.Close();
            }
            catch
            {

            }
            return dt;
        }

        public static String DevolverPosicion(DataTable dt, string posicion)
        {
            string resultado = "";
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Numero"].ToString().ToString() == posicion)
                {
                    resultado = dr["NumeroMotor"].ToString().Trim();
                }
            }
            return resultado;
        }

        public static bool InsertarModificarEliminar(string Query, string conexion)
        {
            bool resultado = true;
            conexion = Security.Decrypt("fpq3SXZZvo7j9Ou3xbqtNcnRrxo3uLEKY0PQRNn7E6taQxJPXQw2KN/jrrBh9hnPOYAVnZvolBFZyWVBFIzf1OIVDP9c73Am/qK1umwjK3YYIkMeUWwKEPMH4ceFokNt8rE0K/hdLCr8TNhYRykM311YcIgTtZ09zdYBkpoDZrXDYqDsr/24uf8qkG8iBid4", "IVM12345");
            SqlConnection cnn = new SqlConnection(conexion);
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                SqlCommand cmd = new SqlCommand(Query, cnn);
                int registros = cmd.ExecuteNonQuery();
                if (registros <= 0)
                    resultado = false;
            }
            catch (Exception ex)
            {
                GuardarLog(ex.ToString(), "Insertar Modificar Eliminar");
                resultado = false;
            }

            return resultado;
        }

        public static void GuardarLog(string Texto, string Evento)
        {
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamWriter sr = new StreamWriter("C:\\IVM\\log.txt");
                //Read the first line of text
                sr.WriteLine("-------------------------------Inicio Evento: " + Evento + "-------------------------------");
                sr.WriteLine("Fecha y Hora: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                sr.WriteLine(Texto);
                sr.WriteLine("-------------------------------Fin: " + Evento + "-------------------------------");
                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                //Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                //Console.WriteLine("Executing finally block.");
            }
        }

        public static byte stringToByte(string posicion)
        {
            int x = int.Parse(posicion);
            string hexa = x.ToString("x");
            if (hexa.Length == 1)
            {
                hexa = "0" + hexa;
            }
            return Convert.ToByte(hexa, 16);
        }
    }
}