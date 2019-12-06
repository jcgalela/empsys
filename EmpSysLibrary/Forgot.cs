using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpSysLibrary
{
    public class Forgot
    {
        public string checkPassIfNull(string email, string username, string password)
        {
            SqlConnection con = new SqlConnection("Data Source = GXD8HY1; Initial Catalog = EIS; User ID = sa; Password=Password2");
            SqlCommand cmmd = new SqlCommand("SELECT userName,password from Employee where email = @email");
            cmmd.Parameters.AddWithValue("@email", email.Trim());
            cmmd.Connection = con;
            con.Open();
            SqlDataReader sdr = cmmd.ExecuteReader();
            if (sdr.Read())
            {
                username = sdr["userName"].ToString();
                password = sdr["password"].ToString();
            }
            con.Close();

            if (!string.IsNullOrEmpty(password))
            {
                string fromaddr = "galelajohnchristian@gmail.com";
                string toaddr = email;
                string Password = "FUNDAMENTAL$1010";
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromaddr);
                mail.Subject = "Password Recovery";
                mail.Body = string.Format("HI {0}, Your Password is {1}. <br /><br /> Please click here to " +
                    "<a href = http://localhost:52842/Login.aspx > LOGIN </a>  <br /> <br /> Thank You!!", username, password);
                mail.IsBodyHtml = true;
                mail.To.Add(new MailAddress(toaddr));
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                NetworkCredential NetworkCred = new NetworkCredential(fromaddr, password);
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mail);
                MessageBox.Show("Password has been sent to your email address.");
                
                return password;
            }
            else
            {
                MessageBox.Show("This email address does not match our records.");
            }
            return password;
            
        }
        
    }
}
