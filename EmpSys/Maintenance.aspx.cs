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

        private void BindGrid()
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

        protected void dataGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
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

        protected void dataGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //try
            //{
            //    string connectionString = @"Data Source = GXD8HY1; Initial Catalog = EIS; User ID = sa; Password=Password2";
            //    GridViewRow row = dataGrid.Rows[e.RowIndex];
            //    Int64 employeeId = Convert.ToInt64(dataGrid.DataKeys[e.RowIndex].Values[0]);
            //    string name = (row.FindControl("Name") as System.Web.UI.WebControls.TextBox).Text;
            //    string contact = (row.FindControl("Mobile Number") as System.Web.UI.WebControls.TextBox).Text;
            //    string email = (row.FindControl("E-Mail Address") as System.Web.UI.WebControls.TextBox).Text;
            //    string query = "UPDATE Employee SET Name=@lastName, emergencyContact=@emergencyContact, email=@email WHERE employeeId=@employeeId";
            //    using (SqlConnection con = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand cmd = new SqlCommand(query))
            //        {
            //            cmd.Parameters.AddWithValue("@lastName", name);
            //            cmd.Parameters.AddWithValue("@emergencyContact", contact);
            //            cmd.Parameters.AddWithValue("@email", email);
            //            cmd.Connection = con;
            //            con.Open();
            //            cmd.ExecuteNonQuery();
            //            con.Close();
            //        }
            //    }
            //    dataGrid.EditIndex = -1;
            //    this.BindGrid();
            //} catch (Exception ex)
            //{
            //    MessageBox.Show("An error has occured.\n" + ex.Message);
            //}
        }

        protected void dataGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dataGrid.PageIndex = e.NewPageIndex;
            this.BindGrid();
            dataGrid.Visible = true;
        }
    }
}