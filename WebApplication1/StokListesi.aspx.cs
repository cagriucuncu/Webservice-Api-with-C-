using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class StokListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["KullaniciAdi"] != null)
            {
                Label1.Text = "Welcome " + Session["KullaniciAdi"].ToString();


            }
            else
            {
                Response.Redirect("WebForm5.aspx");

            }
           
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            
                Session.Clear();
                Label1.Text = "logout succesfull";
                Response.Redirect("WebForm5.aspx");
            
        }
    }
}