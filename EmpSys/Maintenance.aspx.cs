using EmpSysLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EmpSys
{
    public partial class Maintenance : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (Session["UserName"] != null)
                {
                    this.lblWelcomeMessage.Text = string.Format("Welcome, {0}", Session["UserName"].ToString());
                }
            }
            dataGrid.Visible = false;
        }

        protected void addUserButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Information.aspx");
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string type = searchTextBox.Text;
            string drop = searchDropDown.SelectedValue;
            try
            {
                Search search = new Search();
                DataTable dtbl = search.UserSearch(search.SearchQuery(drop, type));
                if (dtbl.Rows.Count > 0)
                {
                    dataGrid.DataSource = dtbl;
                    dataGrid.DataBind();
                    dataGrid.Visible = true;
                }
                else
                {
                    dtbl.Rows.Add(dtbl.NewRow());
                    dataGrid.DataSource = dtbl;
                    dataGrid.DataBind();
                    dataGrid.Rows[0].Cells.Clear();
                    dataGrid.Rows[0].Cells.Add(new TableCell());
                    dataGrid.Rows[0].Cells[0].ColumnSpan = dtbl.Columns.Count;
                    dataGrid.Rows[0].Cells[0].Text = "No Data Found ..!";
                    dataGrid.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
                    dataGrid.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Maintenance.aspx");
        }

        protected void dataGrid_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {

        }

        protected void dataGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void dataGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}