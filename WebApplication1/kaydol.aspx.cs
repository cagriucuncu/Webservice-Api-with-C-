using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class kaydol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void butonregister_Click(object sender, EventArgs e)
        {
            string email = mailtxt.Text.Trim();
            string pass = passtxt.Text.Trim();



            if (!IsValidEmail(email))
            {

                lblMessage.Text = "unvalid e mail!";
                return;
            }
            if (!IsValidPass(pass))
            {

                lblMessage.Text = "Unvalid password! min 8 character one uppercase one lowercase and one digit";
                return;
            }

            if (string.IsNullOrEmpty(nametxt.Text) || string.IsNullOrEmpty(surnametxt.Text) || string.IsNullOrEmpty(usertxt.Text) ||
     string.IsNullOrEmpty(mailtxt.Text) || string.IsNullOrEmpty(passtxt.Text))
            {
                lblMessage.Text = "fill the empty places";
            }
            else
            {
               

                {
                    try
                    {
                        
                        Tablereg newTablereg = new Tablereg
                        {
                            Name = nametxt.Text,
                            Surname = surnametxt.Text,
                            Username = usertxt.Text,
                            Email = mailtxt.Text,
                            password = passtxt.Text
                        };

                        int userId; 

                        
                        using (var context = new RegisterEntities())
                        {
                           
                            context.Tableregs.Add(newTablereg);

                           
                            context.SaveChanges();

                            
                            userId = newTablereg.Id; 

                         

                            List<string> addressesList = new List<string>();

                            
                            addressesList.Add(addresstxt.Text);

                           
                            var addressInputs = Request.Form.GetValues("address[]");
                            if (addressInputs != null)
                            {
                               
                                addressesList.AddRange(addressInputs);
                            }

                           
                            foreach (string address in addressesList)
                            {
                                var newAddress = new Tablead
                                {
                                    adress = address,
                                    UserId = userId
                                };
                                context.Tableads.Add(newAddress);
                            }
                            context.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        
                        Console.WriteLine("Error: " + ex.Message);
                    }
                   

                    lblMessage.Text = "register successful!";
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";


            return Regex.IsMatch(email, pattern);
        }
        private bool IsValidPass(string pass)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";


            return Regex.IsMatch(pass, pattern);
        }
    }
}