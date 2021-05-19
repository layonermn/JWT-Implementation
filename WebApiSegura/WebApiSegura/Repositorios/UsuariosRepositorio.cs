using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Text;

namespace WebApiSegura.Repositorios
{
    public class UsuariosRepositorio
    {
        public string get_UsuarioAutorizacionToken_POST(string Url, string bodyJSON, string metodoVerbo = "POST")
        {
            string AutToken = string.Empty;
            var url = Url;
            var request = (HttpWebRequest)WebRequest.Create(url);
            
            request.Method = metodoVerbo;
            request.ContentType = "application/json";
            request.Accept = "application/json";

            System.Threading.Thread.Sleep(1000);
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(bodyJSON);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null)
                        {
                            return "";
                        }
                        
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            Console.WriteLine(responseBody);

                            AutToken = responseBody;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                string msgWebExt = ex.Message;
            }

            return AutToken;
        }
    }
}