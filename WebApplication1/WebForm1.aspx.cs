using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        RegisterEntities dbcontext = new RegisterEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             
          

            if (dbcontext.Tableregs.Where(r => r.Username == usertxt.Text && r.password == passtxt.Text).Count() > 0)
            {
                Session["KullaniciAdi"] = usertxt.Text;
                Response.Redirect("WebForm5.aspx");
            }
            else {
                Label4.Text = "your username or password invalid";
            }
        }
    }
}