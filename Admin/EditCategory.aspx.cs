using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admin_EditCategory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            SqlConnection con = Connection.SqlConnectServer();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "GetCategoryID";
                cmd.Parameters.Add(new SqlParameter("@Id", id));

                cmd.ExecuteNonQuery();

                SqlDataReader data = cmd.ExecuteReader();
                data.Read();
                name.Text = data["Name"].ToString();
                description.Text = data["Description"].ToString();
                data.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
            } 
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
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
            cmd.CommandText = "UpdateCategories";
            cmd.Parameters.Add(new SqlParameter("@Id", id));
            cmd.Parameters.Add(new SqlParameter("@Name", name.Text));
            cmd.Parameters.Add(new SqlParameter("@Slug", Packet.GenerateSlug(name.Text)));
            cmd.Parameters.Add(new SqlParameter("@Description", description.Text));
            cmd.Parameters.Add(new SqlParameter("@Date_edit", DateTime.Now.Date.ToString()));

            cmd.ExecuteNonQuery();

            Response.Redirect("Category.aspx?p="+page);
            con.Close();
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}