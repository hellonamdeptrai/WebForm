using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admin_DeleteCategory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Int32.Parse(Request.QueryString["id"]);
        int page = Int32.Parse(Request.QueryString["page"]);
        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "DeleteCategories";
            cmd.Parameters.Add(new SqlParameter("@Id", id));

            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Category.aspx?p="+page);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}