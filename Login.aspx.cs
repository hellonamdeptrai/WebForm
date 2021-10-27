using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    List<Personnel> listUser = new List<Personnel>();
    List<string> listCookieEmail = new List<string>();
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
            cmd.CommandText = "LoginUser";
            cmd.Parameters.Add(new SqlParameter("@Email", email.Text));
            cmd.Parameters.Add(new SqlParameter("@Password", Packet.MD5Hash(password.Text)));

            cmd.ExecuteNonQuery();

            SqlDataReader data = cmd.ExecuteReader();
            if (data.Read())
            {
                if (data["Status"].ToString().Equals("1"))
                {
                    Personnel us = new Personnel();
                    us.Id = data["Id"].ToString();
                    us.Name = data["Name"].ToString();
                    us.Email = data["Email"].ToString();
                    us.Avatar = data["Avatar"].ToString();
                    us.Status = data["Status"].ToString();
                    us.Position = data["Position"].ToString();
                    us.Phone = data["Phone"].ToString();
                    us.Address = data["Address"].ToString();
                    listUser.Add(us);

                    Session["LoginSession"] = listUser;

                    if (saveLogin.Checked)
                    {
                        HttpCookie ck = Request.Cookies["LoginCookie"];
                        if (ck == null)
                            ck = new HttpCookie("LoginCookie");
                        ck["email"] = data["Email"].ToString();
                        Response.Cookies.Add(ck);
                    }
                    if (data["Position"].ToString().Equals("3"))
                    {
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {
                        Response.Redirect("Admin/Default.aspx");
                    }

                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Tài khoản này đã bị khóa');", true);
                }
            }
            else
                errLogin.Text = "Sai tên email hoặc mật khẩu, vui lòng kiểm tra lại";

            cmd.Clone();
            con.Close();
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}