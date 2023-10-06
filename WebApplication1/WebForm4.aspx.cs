using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] != null)
            {
                Label1.Text = "Welcome " + Session["KullaniciAdi"].ToString();


            }
            else
            {
               

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