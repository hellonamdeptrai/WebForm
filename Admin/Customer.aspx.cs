using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admin_Customer : System.Web.UI.Page
{
    public List<Customer> listCustomer = new List<Customer>();
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
            cmdT.CommandText = "CountCustomer";

            cmdT.ExecuteNonQuery();
            SqlDataReader dataT = cmdT.ExecuteReader();
            dataT.Read();
            totalPage = Int32.Parse(dataT[0].ToString());
            pageList = Packet.toPaging(totalPage, pageSize);
            dataT.Close();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "PageCustomer";
            cmd.Parameters.Add(new SqlParameter("@PageNumber", page));
            cmd.Parameters.Add(new SqlParameter("@RowsOfPage", pageSize));

            cmd.ExecuteNonQuery();

            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                Customer ct = new Customer();
                ct.Id = data["Id"].ToString();
                ct.Name = data["Name"].ToString();
                ct.Email = data["Email"].ToString();
                ct.Avatar = data["Avatar"].ToString();
                ct.Status = data["Status"].ToString();
                ct.Phone = data["Phone"].ToString();
                ct.Address = data["Address"].ToString();
                ct.Date_created = DateTime.Parse(data["Date_created"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                ct.Date_edit = DateTime.Parse(data["Date_edit"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                listCustomer.Add(ct);
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