using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        RegisterEntities Db = new RegisterEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            GridView1.DataSource = Db.Tableregs.ToList();
            GridView1.DataBind();

        




        }

        protected void guncelle_Click(object sender, EventArgs e)
        {
            
            var updateperson = Db.Tableregs.Where(r => r.Username == usertxt.Text && r.Email == mailtxt.Text).FirstOrDefault();
            
            if (updateperson!=null)
            {
              
                updateperson.password = passtxt.Text;
                Db.SaveChanges();

                GridView1.DataSource = Db.Tableregs.ToList();
                GridView1.DataBind();
                Label1.Text = "Parola değiştirme başarılı ";
            }
         else
            {
                Label1.Text = "Geçersiz Kullanıcı";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        protected void dellbuton_Click1(object sender, EventArgs e)
        {
            var updateperson = Db.Tableregs.Where(r => r.Username == usertxt.Text && r.Email == mailtxt.Text && r.password == passtxt.Text).FirstOrDefault();

            if (updateperson != null)
            {
                int num = updateperson.Id;



                var deleteAddresses = Db.Tableads.Where(a => a.UserId == num).ToList();
                foreach (var user in Db.Tableads.Where(u => u.UserId == num).ToList())
                {
                    Db.Tableads.Remove(user);
                }
            
                

                Db.Tableregs.Remove(updateperson);


                Db.SaveChanges();

                GridView1.DataSource = Db.Tableregs.ToList();
                GridView1.DataBind();
                Label1.Text = "kullanıcı silme başarılı ";
            }
            else
            {
                Label1.Text = "Geçersiz Kullanıcı";
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Buttonadres_Click(object sender, EventArgs e)
        {
            var query = (from reg in Db.Tableregs
                         join addres in Db.Tableads on reg.Id equals addres.UserId
                         select new
                         {
                             reg.Username,
                             reg.Name,

                             addres.adress

                         }).ToList();
            var list = query.Where(r => r.Username == usertxt.Text).ToList();
            GridView2.DataSource = list;
            GridView2.DataBind();
            Label6.Text = usertxt.Text+" nickli kullanıcının adresleri";
        }
    }
}