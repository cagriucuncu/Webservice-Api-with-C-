using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void Button1_Click(object sender, EventArgs e)
        {

            string apiKey = "7vw1GSi8UV5MF5y2wh9Q";
            string supplierId = "2738";
            string apiSecret = "ziAoE6pBo1DS6yYaYYdW";
            string baseUrl = "https://stageapi.trendyol.com/stagesapigw/suppliers/";
            string endpoint = "products/price-and-inventory";

            string apiUrl = $"{baseUrl}{supplierId}/{endpoint}";
            Items items = new Items
            {
                Barcode = "86900003",
                Quantity = 100,
                SalePrice = 112.85,
                ListPrice = 113.89
            };

            using (HttpClient client = new HttpClient())
            {
                string jsonData = JsonConvert.SerializeObject(items);
                var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                string authHeaderValue = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{apiKey}:{apiSecret}"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
                client.DefaultRequestHeaders.Add("User-Agent", "2738 - Trendyolsoft");
                //  client.DefaultRequestHeaders.Add("Content-Type", "application/json");
                // content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    ResponseLabel.Text = "Response: " + responseContent;
                }
                else
                {
                    ResponseLabel.Text = "Error: " + response.StatusCode;
                }
            }
        }

      
    }
    }








/*
using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WebFormExample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void SendDataButton_Click(object sender, EventArgs e)
        {
            string apiKey = "your_api_key";
            string supplierId = "your_supplier_id";
            string apiSecret = "your_api_secret";
            string url = "https://api.trendyol.com/sapigw/suppliers/200300444/products/price-and-inventory"; 
            MyData data = new MyData
            {
                Name = "name",
                surname = "surname"
            };

            using (HttpClient client = new HttpClient())
            {
                string jsonData = JsonConvert.SerializeObject(data);
                var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                string authHeaderValue = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{apiKey}:{apiSecret}"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
                client.DefaultRequestHeaders.Add("User-Agent", "200300444 - Trendyolsoft");
                client.DefaultRequestHeaders.Add("Content-Type", "application/json");
        
                HttpResponseMessage response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    ResponseLabel.Text = "Response: " + responseContent;
                }
                else
                {
                    ResponseLabel.Text = "Error: " + response.StatusCode;
                }
            }
        }
    }
}
 */