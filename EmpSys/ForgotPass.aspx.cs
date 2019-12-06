using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;

namespace EmpSys
{
    public partial class ForgotPass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void sendButton_Click(object sender, EventArgs e)
        {
            string username = string.Empty;
            string Password = string.Empty;
            //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection("Data Source = GXD8HY1; Initial Catalog = EIS; User ID = sa; Password=Password2"))
            {
                SqlCommand cmmd = new SqlCommand("SELECT userName, [password] from Employee where email = @email");
                {
                    cmmd.Parameters.AddWithValue("@email", emailText.Text.Trim());
                    cmmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmmd.ExecuteReader())
                    {

                        if (sdr.Read())
                        {
                            username = sdr["userName"].ToString();
                            Password = sdr["password"].ToString();
                        
                        }
                    
                    }
                    con.Close();
                }
            }

            if (!string.IsNullOrEmpty(Password))
            {
                string fromaddr = "publicoian@gmail.com";
                string toaddr = emailText.Text;
                string password = "Kupalkanaman24";
                MailMessage mail = new MailMessage(); 
                mail.From = new MailAddress(fromaddr);
                mail.Subject = "Password Recovery";
                mail.Body = string.Format("HI {0}, Your Password is {1}. <br /><br /> Please click here to <a href = http://localhost:52842/Login.aspx > LOGIN </a>  <br /> <br /> Thank You!!", username, Password);
                mail.IsBodyHtml = true;
                mail.To.Add(new MailAddress(toaddr));
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                NetworkCredential NetworkCred = new NetworkCredential(fromaddr,password);  
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mail);
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "Recovery Password link has been sent to your email address.";
            }

            else
            {

                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "This email address does not match our records.";
            }
        }
               
    }
}