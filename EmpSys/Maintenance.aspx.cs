using EmpSysLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        public void Page_Load(object sender, EventArgs e)
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

        public void addUserButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Information.aspx");
        }

        public void searchButton_Click(object sender, EventArgs e)
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
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clearButton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("/Maintenance.aspx");
        }

        public void BindGrid()
        {
            string connectionString = @"Data Source = GXD8HY1; Initial Catalog = EIS; User ID = sa; Password=Password2";
            string query = "SELECT * FROM Employee";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon))
                {
                    using (DataTable dt = new DataTable())
                    {
                        adapter.Fill(dt);
                        dataGrid.DataSource = dt;
                        dataGrid.DataBind();
                    }
                }
            }
        }

        public void dataGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                string connectionString = @"Data Source = GXD8HY1; Initial Catalog = EIS; User ID = sa; Password=Password2";
                Int64 employeeId = Convert.ToInt64(dataGrid.DataKeys[e.RowIndex].Values[0]);
                string query = "DELETE FROM Employee WHERE employeeId=@employeeId";
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query))
                    {
                        command.Parameters.AddWithValue("@employeeId", employeeId);
                        command.Connection = sqlCon;
                        sqlCon.Open();
                        command.ExecuteNonQuery();
                        sqlCon.Close();
                    }
                }
                this.BindGrid();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Deleted Successfully')", true);
        }

        protected void dataGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Session["selected"] = dataGrid.SelectedRow;
        }

        public void dataGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = dataGrid.Rows[e.RowIndex];
            Int64 employeeId = Convert.ToInt64(dataGrid.DataKeys[e.RowIndex].Values[0]);
            //Session["employeeId"] = employeeId;
            //Response.Redirect("/Edit.aspx");
            Response.Redirect("Edit.aspx?employeeId=" + employeeId);
        }

        public void dataGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dataGrid.PageIndex = e.NewPageIndex;
            this.BindGrid();
            dataGrid.Visible = true;
        }

        protected void dataGrid_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            var employeeId = Convert.ToInt64(dataGrid.DataKeys[e.NewSelectedIndex].Value);
            
        }
    }
}