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
                //if (string.IsNullOrEmpty(type))
                //{
                //    DataTable dtbl = search.UserSearch(search.SearchQuery(drop, type));

                //}
                //else
                //{

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
                //}
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

        protected void dataGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)dataGrid.Rows[e.RowIndex];
            SqlCommand cmd = new SqlCommand("Delete From Employee where userName = '" + row + "'");
            dataGrid.DataBind();
            //try
            //{
            //    string connectionString = @"Data Source = GXD8HY1; Initial Catalog = EIS; User ID = sa; Password=Password2";

            //    using (SqlConnection con = new SqlConnection(connectionString))
            //    {
            //        con.Open();
            //        using (SqlCommand command = new SqlCommand("DELETE FROM Employee WHERE userName = userName", con))
            //        {
            //            dataGrid.Rows[e.RowIndex].FindControl("lblstId");
            //            command.ExecuteNonQuery();
            //        }
            //        con.Close();
            //    }
            //}
            //catch (SystemException ex)
            //{
            //    MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            //}
            //dataGrid.Visible = true;

        }
        
        
    }
}