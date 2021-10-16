﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admin_CreateCategory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CreateCategories";
            cmd.Parameters.Add(new SqlParameter("@Name", name.Text));
            cmd.Parameters.Add(new SqlParameter("@Slug", Packet.GenerateSlug(name.Text)));
            cmd.Parameters.Add(new SqlParameter("@Description", description.Text));
            cmd.Parameters.Add(new SqlParameter("@Date_created", DateTime.Now.Date.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Date_edit", DateTime.Now.Date.ToString()));

            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Category.aspx?p=1");
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }

    }
}