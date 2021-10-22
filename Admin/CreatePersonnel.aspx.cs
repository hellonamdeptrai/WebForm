using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admin_CreatePersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = Connection.SqlConnectServer();

        try
        {
            string nameAvatar = DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + Avatar.FileName;
            if (Page.IsValid && Avatar.HasFile && Packet.CheckFileType(Avatar.FileName))
            {
                string fileName = "../Images/" + nameAvatar;
                string filePath = MapPath(fileName);
                Avatar.SaveAs(filePath);
                Previewimage.ImageUrl = fileName;
            }
            string position1 = "";
            string status = "";
            con.Open();
            if (Position.SelectedItem.Selected)
            {
                position1 = Position.SelectedItem.Value;
            }
            if (Status.SelectedItem.Selected)
            {
                status = Position.SelectedItem.Value;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CreateUser";
            cmd.Parameters.Add(new SqlParameter("@Name", name.Text));
            cmd.Parameters.Add(new SqlParameter("@Email", Email.Text));
            cmd.Parameters.Add(new SqlParameter("@Avatar", nameAvatar));
            cmd.Parameters.Add(new SqlParameter("@Status", status));
            cmd.Parameters.Add(new SqlParameter("@Position", position1));
            cmd.Parameters.Add(new SqlParameter("@Phone", Int32.Parse(Phone.Text)));
            cmd.Parameters.Add(new SqlParameter("@Password", Packet.MD5Hash(Pass.Text)));
            cmd.Parameters.Add(new SqlParameter("@Address", Address.Text));
            cmd.Parameters.Add(new SqlParameter("@Date_created", DateTime.Now.Date.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Date_edit", DateTime.Now.Date.ToString()));

            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Personnel.aspx?p=1");
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}