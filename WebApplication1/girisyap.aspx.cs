using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class girisyap : System.Web.UI.Page
    {
        RegisterEntities dbcontext = new RegisterEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

            

           


        
        }

        protected void Login_Click(object sender, EventArgs e)
        {

            if (dbcontext.Tableregs.Where(r => r.Username == usertxt.Text && r.password == passtxt.Text).Count() > 0)
            {
                Session["KullaniciAdi"] = usertxt.Text;
                Response.Redirect("WebForm5.aspx");
            }
            else
            {
                Label4.Text = "your username or password invalid";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}