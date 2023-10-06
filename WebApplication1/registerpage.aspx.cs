using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;

namespace WebApplication1
{
    public partial class registerpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
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
            else {
                // SQL veritabanı bağlantısını kurduk
                SqlConnection con = DatabaseHelper.Connection;

                {
                    try
                    {
                        // Create a new Tablereg object with the provided data
                        Tablereg newTablereg = new Tablereg
                        {
                            Name = nametxt.Text,
                            Surname = surnametxt.Text,
                            Username = usertxt.Text,
                            Email = mailtxt.Text,
                            password = passtxt.Text
                        };

                        int userId; // To store the generated UserID

                        // Using statement ensures the disposal of DbContext after use
                        using (var context = new RegisterEntities())
                        {
                            // Add the new Tablereg object to the context
                            context.Tableregs.Add(newTablereg);

                            // Save the changes to the database
                            context.SaveChanges();

                            // Now the newTablereg object will have the generated UserID after saving changes
                            userId = newTablereg.Id; // Replace "Id" with the actual name of the primary key property

                            // Continue using the userId as needed

                            List<string> addressesList = new List<string>();

                            // (addresstxt.Text) alınan adresi listeye ekledik
                            addressesList.Add(addresstxt.Text);

                            // Dinamik olarak eklenen adres alanlarını aldık
                            var addressInputs = Request.Form.GetValues("address[]");
                            if (addressInputs != null)
                            {
                                // eklenen adresleri liste ekledik
                                addressesList.AddRange(addressInputs);
                            }

                            // listedeki adresleri veritabanına ekledik
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
                        // Handle the exception (log, display, etc.)
                        // For example:
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    con.Close();

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
