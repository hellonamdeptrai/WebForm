using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

public partial class Admin_DeletePersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Int32.Parse(Request.QueryString["id"]);
        int page = Int32.Parse(Request.QueryString["page"]);
        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();

            //xóa file ảnh
            SqlCommand cmdPr = new SqlCommand();
            cmdPr.Connection = con;
            cmdPr.CommandType = System.Data.CommandType.StoredProcedure;
            cmdPr.CommandText = "GetUserID";
            cmdPr.Parameters.Add(new SqlParameter("@Id", id));

            cmdPr.ExecuteNonQuery();

            SqlDataReader dataPr = cmdPr.ExecuteReader();
            dataPr.Read();
            string nameAvatar = dataPr["Avatar"].ToString();
            dataPr.Close();
            cmdPr.Clone();
            string fileNameD = "../Images/" + nameAvatar;
            string filePathD = MapPath(fileNameD);
            FileInfo file = new FileInfo(filePathD);
            if (file.Exists)
            {
                file.Delete();
            }

            //xóa bản ghi
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "DeleteUser";
            cmd.Parameters.Add(new SqlParameter("@Id", id));

            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Personnel.aspx?p=" + page);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}