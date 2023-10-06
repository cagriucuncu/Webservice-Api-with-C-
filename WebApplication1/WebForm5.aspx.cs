using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] != null)
            {
                Label1.Text = "Hoşgeldin " + Session["KullaniciAdi"].ToString();


            }
            else
            {
                Label1.Text = "STOK LİSTESİNİ GÖRMEK İÇİN GİRİŞ YAPINIZ" ;


            }
        }
    }
}