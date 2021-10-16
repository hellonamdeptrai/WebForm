using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admin_Category : System.Web.UI.Page
{
    public List<Category> listCategories = new List<Category>();
    public List<int> pageList = new List<int>();
    int totalPage = 0;
    int pageSize = 10;
    public int page;
    public int cp = 1;

    protected void Page_Load(object sender, EventArgs e)
    {
        page = Int32.Parse(Request.QueryString["p"]);

        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();
            SqlCommand cmdT = new SqlCommand();
            cmdT.Connection = con;
            cmdT.CommandType = System.Data.CommandType.StoredProcedure;
            cmdT.CommandText = "CountCategory";

            cmdT.ExecuteNonQuery();
            SqlDataReader dataT = cmdT.ExecuteReader();
            dataT.Read();
            totalPage = Int32.Parse(dataT[0].ToString());
            pageList = Packet.toPaging(totalPage, pageSize);
            dataT.Close();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "PageCategory";
            cmd.Parameters.Add(new SqlParameter("@PageNumber", page));
            cmd.Parameters.Add(new SqlParameter("@RowsOfPage", pageSize));

            cmd.ExecuteNonQuery();

            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                Category ct = new Category();
                ct.Id = data["Id"].ToString();
                ct.Name = data["Name"].ToString();
                ct.Description = data["Description"].ToString();
                ct.DateCreated = DateTime.Parse(data["Date_created"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                ct.DateEdit = DateTime.Parse(data["Date_edit"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                listCategories.Add(ct);
            }
            data.Close();
            con.Close();
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}