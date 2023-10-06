using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {

        RegisterEntities db = new RegisterEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void resetbuton_Click(object sender, EventArgs e)
        {
            var model = db.Tableregs.FirstOrDefault(r => r.Email == mailtxt.Text);

            if (model != null)
            {

                Guid guid = Guid.NewGuid();
                model.password = guid.ToString().Substring(0, 8);
                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential("cagriberkantt@gmail.com", "tdlcrvonsstykxqo");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
     
                MailMessage mail = new MailMessage();
                mail.To.Add(mailtxt.Text);
                mail.From = new MailAddress("cagriberkantt@gmail.com", "sifre sıfırlama");
                mail.IsBodyHtml = true;
                mail.Subject = "parola yenileme isteginiz";
                mail.Body += " Merhaba Sayın " + model.Name + " " + model.Surname + " : " + "<br/> Kullanıcı Adınız = " + model.Username + "<br/> Sifreniz= " + model.password;

                try
                {
                    client.Send(mail);
                    db.SaveChanges();
                    Response.Redirect("WebForm5.aspx");

                   

                }
                 catch (Exception)
                {

                }

            }
        }

        protected void mailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected void mailtxt_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}