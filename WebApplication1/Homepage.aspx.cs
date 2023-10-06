using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        private const string Token = "BA_KkhxFrnsuu6F4TFmnMzS7lWYI27fUbw0Jzt-hH-hohCx1X0W5eCN2rwDenybngFbljHiS2NVB-g_IqQnvKu0ut8pIn-A7A6q2HwHKSLwPBViKOR6d9ZIi4aA8tw2knHULV51meTKIkAIahRkcaK2EvQIEzPDXnIni8NwR1D1ScwFV5ZXwZcZI5s028WN2JGyJy_JLNAXS7luBDdLrTUtIVn4qLel-tNrcvvBGCjRJhxLZoGDbo9tnPVzDu6CTu7oL2MhAenQzP4fBYHOLpw";
        private const string WebServiceUrl = "http://185.124.86.45:8899/api/Integration//EticaretStokListesi?tarih=1900-01-01&depoid=1&miktarsifirdanbuyukstoklarlistelensin=false"; // 
        protected async void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                await FetchDataAndBindGridViewAsync();
            }

            if (Session["KullaniciAdi"] != null)
            {
                Label1.Text = "Welcome " + Session["KullaniciAdi"].ToString();


            }

        }
        private async Task FetchDataAndBindGridViewAsync()
        {
            using (var httpClient = new HttpClient())
            {
                
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);

                try
                {
                    
                    var response = await httpClient.GetAsync(WebServiceUrl);

                    
                    response.EnsureSuccessStatusCode();

                
                    string jsonString = await response.Content.ReadAsStringAsync();
                    

                    
                    string s = jsonString.Replace(@"\", string.Empty);
                    string final = s.Trim().Substring(1, (s.Length) - 2);
                    try
                    {

                        

                        var data = JsonConvert.DeserializeObject<List<MyDataModel>>(final);
                        var data2 = JsonConvert.DeserializeObject<List<Class1>>(final);

                        GridView1.DataSource = data;
                        GridView1.DataBind();
                       
                    }
                    catch (JsonException ex)
                    {
                        
                        Response.Write("JSON hata: " + ex.Message);
                        throw; 
                    }




                }
                catch (HttpRequestException ex)
                {
                   
                    lblMessage.Text = $"Web servis isteği başarısız: {ex.Message}";
                }
                catch (Exception ex)
                {
                    lblMessage.Text = $"Hata oluştu: {ex.Message}";
                    
                }
            }
        }
        

        protected void logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Label1.Text = "logout succesfull";
            Response.Redirect("WebForm1.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}