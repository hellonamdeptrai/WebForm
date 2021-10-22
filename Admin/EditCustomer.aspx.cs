using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

public partial class Admin_EditUser : System.Web.UI.Page
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
                cmd.CommandText = "GetUserID";
                cmd.Parameters.Add(new SqlParameter("@Id", id));

                cmd.ExecuteNonQuery();

                SqlDataReader data = cmd.ExecuteReader();
                data.Read();
                name.Text = data["Name"].ToString();
                Email.Text = data["Email"].ToString();
                Previewimage.ImageUrl = "../Images/" + data["Avatar"].ToString();
                Status.SelectedItem.Value = data["Status"].ToString();
                Phone.Text = data["Phone"].ToString();
                Address.Text = data["Address"].ToString();
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

            if (Page.IsValid && Avatar.HasFile && Packet.CheckFileType(Avatar.FileName))
            {
                string fileNameD = "../Images/" + nameAvatar;
                string filePathD = MapPath(fileNameD);
                FileInfo file = new FileInfo(filePathD);
                if (file.Exists)
                {
                    file.Delete();
                }

                nameAvatar = DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + Avatar.FileName;
                string fileName = "../Images/" + nameAvatar;
                string filePath = MapPath(fileName);
                Avatar.SaveAs(filePath);
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "UpdateUser";
            cmd.Parameters.Add(new SqlParameter("@Id", id));
            cmd.Parameters.Add(new SqlParameter("@Name", name.Text));
            cmd.Parameters.Add(new SqlParameter("@Email", Email.Text));
            cmd.Parameters.Add(new SqlParameter("@Avatar", nameAvatar));
            cmd.Parameters.Add(new SqlParameter("@Status", Status.SelectedItem.Value));
            cmd.Parameters.Add(new SqlParameter("@Position", 3));
            cmd.Parameters.Add(new SqlParameter("@Phone", Int32.Parse(Phone.Text)));
            cmd.Parameters.Add(new SqlParameter("@Password", Packet.MD5Hash(Pass.Text)));
            cmd.Parameters.Add(new SqlParameter("@Address", Address.Text));
            cmd.Parameters.Add(new SqlParameter("@Date_edit", DateTime.Now.Date.ToString("MM/dd/yyyy")));

            cmd.ExecuteNonQuery();

            Response.Redirect("Customer.aspx?p=" + page);
            con.Close();
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}