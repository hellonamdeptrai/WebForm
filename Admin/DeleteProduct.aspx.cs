using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DeleteProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Int32.Parse(Request.QueryString["id"]);
        int page = Int32.Parse(Request.QueryString["page"]);
        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();

            SqlCommand cmdPr = new SqlCommand();
            cmdPr.Connection = con;
            cmdPr.CommandType = System.Data.CommandType.StoredProcedure;
            cmdPr.CommandText = "GetProductsID";
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

            SqlCommand cmdIm = new SqlCommand();
            cmdIm.Connection = con;
            cmdIm.CommandType = System.Data.CommandType.StoredProcedure;
            cmdIm.CommandText = "GetImagesProduct";
            cmdIm.Parameters.Add(new SqlParameter("@Id", id));

            cmdIm.ExecuteNonQuery();
            SqlDataReader dataIm = cmdIm.ExecuteReader();

            while (dataIm.Read())
            {
                string fileName = "../Images/" + dataIm["Path"].ToString();
                string filePath = MapPath(fileName);
                FileInfo fileP = new FileInfo(filePath);
                if (fileP.Exists)
                {
                    fileP.Delete();
                }
            }
            dataIm.Close();
            cmdIm.Clone();

            SqlCommand cmdA = new SqlCommand();
            cmdA.Connection = con;
            cmdA.CommandType = System.Data.CommandType.StoredProcedure;
            cmdA.CommandText = "DeleteImages";
            cmdA.Parameters.Add(new SqlParameter("@Id", id));

            cmdA.ExecuteNonQuery();
            cmdA.Clone();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "DeleteProducts";
            cmd.Parameters.Add(new SqlParameter("@Id", id));

            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Product.aspx?p=" + page);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}