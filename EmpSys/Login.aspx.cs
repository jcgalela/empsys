using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpSys.Model;
namespace EmpSys
{
    public partial class Login : System.Web.UI.Page
    {
        EISEntities db = new EISEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Start"] = 1;
            Session["Error"] = string.Empty;
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PassTextBox.Text;

            var details = db.Employees.Where(x => x.userName == username && x.password == password).FirstOrDefault();
            if (details == null)
            {
                Session["Error"] = 1;
            }
            else
            {
                Session["Start"] = 0;
                Session["username"] = details.userName;
                Session["UserName"] = this.UsernameTextBox.Text.Trim();
                Response.Redirect("/Maintenance.aspx");
            
            }
        }

    }
}