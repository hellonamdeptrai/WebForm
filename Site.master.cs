using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : MasterPage
{
    public List<Category> listCategories = new List<Category>();

    protected void Page_Init(object sender, EventArgs e)
    {
        
    }

    void master_Page_PreLoad(object sender, EventArgs e)
    {
        
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();
            SqlCommand cmdC = new SqlCommand();
            cmdC.Connection = con;
            cmdC.CommandType = System.Data.CommandType.StoredProcedure;
            cmdC.CommandText = "GetCategories";

            cmdC.ExecuteNonQuery();
            SqlDataReader dataC = cmdC.ExecuteReader();

            while (dataC.Read())
            {
                Category ct = new Category();
                ct.Id = dataC["Id"].ToString();
                ct.Name = dataC["Name"].ToString();
                ct.Slug = dataC["Slug"].ToString();
                ct.Description = dataC["Description"].ToString();
                ct.DateCreated = DateTime.Parse(dataC["Date_created"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                ct.DateEdit = DateTime.Parse(dataC["Date_edit"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                listCategories.Add(ct);
            }
            dataC.Close();
            cmdC.Clone();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}