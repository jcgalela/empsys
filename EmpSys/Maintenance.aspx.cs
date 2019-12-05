using EmpSysLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpSys
{
    public partial class Maintenance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dataGrid.Visible = false;
        }

        protected void addUserButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Information.aspx");
        }

        protected void dataGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string drop = searchDropDown.SelectedValue.ToString();
            string type = searchTextBox.Text;
            Search search = new Search();
            search.Drop(drop);
            search.SearchUser(drop, type);
            dataGrid.Visible = true;
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Maintenance.aspx");
        }

    }
}