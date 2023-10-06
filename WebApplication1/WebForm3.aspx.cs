using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using Newtonsoft.Json;


namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private const string Token = "-gWnh54VYUj1uX8E6lR3yufR7yOOX7PPN4dQD5P9d513_Ctv516VdQL3d0Sb1gW6XqwRKX5JEN4YSD_eYHuDJBVaLO3W-fiCZYiq21H91gdx1MvOo09S_nWvClxL05ErzrCZ5WmugV3meBdgZPsMN0EhYOjFWTe_3DTDB4iJnpVBJrLhWzIouADF0sd5E5bMlGLKcntuvmR71sbZSGP9xZrbMS_CBTFTKt_6AK5AaBqIVtWvqV1xEN90DdYryFTNE8L_6XboBXKvI6AGW3busQ";
        private const string WebServiceUrl = "http://185.124.86.45:8899/api/Integration//EticaretStokListesi?tarih=1900-01-01&depoid=1&miktarsifirdanbuyukstoklarlistelensin=False"; // Web servisinizin URL'sini buraya yazın

        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                await FetchDataAndBindGridViewAsync();
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
                   

                    Response.Write("<pre>" + jsonString + "</pre>");
                    string s = jsonString.Replace(@"\", string.Empty);
                    string final = s.Trim().Substring(1, (s.Length) - 2);
                    try
                    {
                       


                        var data = JsonConvert.DeserializeObject<List<MyDataModel>>(final);

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
    }
}