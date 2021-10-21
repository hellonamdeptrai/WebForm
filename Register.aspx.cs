using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Register : System.Web.UI.Page
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
            string nameAvatar = DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + avatar.FileName;
            if (Page.IsValid && avatar.HasFile && Packet.CheckFileType(avatar.FileName))
            {
                string fileName = "Images/" + nameAvatar;
                string filePath = MapPath(fileName);
                avatar.SaveAs(filePath);
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CreateUser";
            cmd.Parameters.Add(new SqlParameter("@Name", name.Text));
            cmd.Parameters.Add(new SqlParameter("@Email", email.Text));
            cmd.Parameters.Add(new SqlParameter("@Avatar", nameAvatar));
            cmd.Parameters.Add(new SqlParameter("@Status", 1));
            cmd.Parameters.Add(new SqlParameter("@Position", 3));
            cmd.Parameters.Add(new SqlParameter("@Phone", phoneNumber.Text));
            cmd.Parameters.Add(new SqlParameter("@Address", address.Text));
            cmd.Parameters.Add(new SqlParameter("@Password", Packet.MD5Hash(comfPassword.Text)));
            cmd.Parameters.Add(new SqlParameter("@Date_created", DateTime.Now.Date.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Date_edit", DateTime.Now.Date.ToString()));

            cmd.ExecuteNonQuery();
            cmd.Clone();
            con.Close();
            Response.Redirect("Login.aspx");
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}