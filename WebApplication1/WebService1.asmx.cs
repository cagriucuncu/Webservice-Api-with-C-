using System.Collections.Specialized;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Services;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web;
using Newtonsoft.Json.Linq;

namespace WebApplication1
{
    /// <summary>
    /// WebService1 için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]



    // [System.Web.Script.Services.ScriptService]

    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetDepoListesi()
        {
            string username = "CAMLICA";
            string password = "123456**";

            string tokenUrl = "http://185.124.86.45:8899/token";

            var postData = new NameValueCollection
        {
            { "grant_type", "password" },
            { "username", username },
            { "password", password }
        };

            using (WebClient client = new WebClient())
            {
                try
                {
                    byte[] responseBytes = client.UploadValues(tokenUrl, postData);


                    string response = System.Text.Encoding.UTF8.GetString(responseBytes);
                    Console.WriteLine("Sunucu Yanıtı: " + response);

                    JObject parsedData = JObject.Parse(response);
                    string token = (string)parsedData["access_token"]; ;

                    string apiUrl = "http://185.124.86.45:8899/api/Integration//EticaretStokListesi?tarih=1900-01-01&depoid=1&miktarsifirdanbuyukstoklarlistelensin=false";

                    client.Headers.Add("Authorization", "Bearer " + token);

                    byte[] responseBytess = client.DownloadData(apiUrl);
                    string apiResponse = Encoding.UTF8.GetString(responseBytess);
                    string s = apiResponse.Replace(@"\", string.Empty);
                    string final = s.Trim().Substring(1, (s.Length) - 2);
                    return final;
                }
                catch (WebException ex)
                {

                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }


        [WebMethod]
        public string HelloWorld(string myUserName)
        {
            return "hello" + myUserName;
        }

    }
}
