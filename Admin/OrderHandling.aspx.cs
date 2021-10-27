using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_OrderHandling : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Int32.Parse(Request.QueryString["id"]);
        int status = Int32.Parse(Request.QueryString["status"]);
        int page = Int32.Parse(Request.QueryString["p"]);

        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "UpdateOrders";
            cmd.Parameters.Add(new SqlParameter("@Id", id));
            if (status == 1)
            {
                cmd.Parameters.Add(new SqlParameter("@Status", 2));
            }
            else if (status == 0)
            {
                cmd.Parameters.Add(new SqlParameter("@Status", 1));
            }
            else if (status == 3)
            {
                cmd.Parameters.Add(new SqlParameter("@Status", 3));
            }
            
            cmd.Parameters.Add(new SqlParameter("@Date_edit", DateTime.Now.Date.ToString()));

            cmd.ExecuteNonQuery();

            Response.Redirect("Orders.aspx?p=" + page);
            con.Close();
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        } 
    }
}