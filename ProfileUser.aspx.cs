using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProfileUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LoginSession"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        if (!IsPostBack)
        {
            foreach (Personnel item in (List<Personnel>)Session["LoginSession"])
            {
                previewAvatar.ImageUrl = "../Images/" + item.Avatar.ToString();
                name.Text = item.Name;
                email.Text = item.Email;
                phoneNumber.Text = item.Phone;
                address.Text = item.Address;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();
            foreach (Personnel item in (List<Personnel>)Session["LoginSession"])
            {
                SqlCommand cmdPr = new SqlCommand();
                cmdPr.Connection = con;
                cmdPr.CommandType = System.Data.CommandType.StoredProcedure;
                cmdPr.CommandText = "GetUserID";
                cmdPr.Parameters.Add(new SqlParameter("@Id", item.Id));

                cmdPr.ExecuteNonQuery();

                SqlDataReader dataPr = cmdPr.ExecuteReader();
                dataPr.Read();
                string nameAvatar = dataPr["Avatar"].ToString();
                dataPr.Close();
                cmdPr.Clone();

                if (Page.IsValid && avatar.HasFile && Packet.CheckFileType(avatar.FileName))
                {
                    string fileNameD = "../Images/" + nameAvatar;
                    string filePathD = MapPath(fileNameD);
                    FileInfo file = new FileInfo(filePathD);
                    if (file.Exists)
                    {
                        file.Delete();
                    }

                    nameAvatar = DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + avatar.FileName;
                    string fileName = "../Images/" + nameAvatar;
                    string filePath = MapPath(fileName);
                    avatar.SaveAs(filePath);
                }
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "UpdateUser";
                cmd.Parameters.Add(new SqlParameter("@Id", item.Id));
                cmd.Parameters.Add(new SqlParameter("@Name", name.Text));
                cmd.Parameters.Add(new SqlParameter("@Email", email.Text));
                cmd.Parameters.Add(new SqlParameter("@Avatar", nameAvatar));
                cmd.Parameters.Add(new SqlParameter("@Status", 1));
                cmd.Parameters.Add(new SqlParameter("@Position", 3));
                cmd.Parameters.Add(new SqlParameter("@Phone", Int32.Parse(phoneNumber.Text)));
                cmd.Parameters.Add(new SqlParameter("@Password", Packet.MD5Hash(password.Text)));
                cmd.Parameters.Add(new SqlParameter("@Address", address.Text));
                cmd.Parameters.Add(new SqlParameter("@Date_edit", DateTime.Now.Date.ToString("MM/dd/yyyy")));

                cmd.ExecuteNonQuery();

                Response.Redirect("Default.aspx");
            }
            
            con.Close();
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}