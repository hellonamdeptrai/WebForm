using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Orders : System.Web.UI.Page
{
    public List<Order> listOrders = new List<Order>();
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
            cmdT.CommandText = "CountOrder";

            cmdT.ExecuteNonQuery();
            SqlDataReader dataT = cmdT.ExecuteReader();
            dataT.Read();
            totalPage = Int32.Parse(dataT[0].ToString());
            pageList = Packet.toPaging(totalPage, pageSize);
            dataT.Close();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "PageOrders";
            cmd.Parameters.Add(new SqlParameter("@PageNumber", page));
            cmd.Parameters.Add(new SqlParameter("@RowsOfPage", pageSize));

            cmd.ExecuteNonQuery();

            SqlDataReader data = cmd.ExecuteReader();

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            while (data.Read())
            {
                Order or = new Order();
                or.Id = data["Id"].ToString();
                or.NameProduct = data["Name"].ToString();
                or.Status = data["Status"].ToString();
                or.Quantity = data["Quantity"].ToString();
                or.SalePrice = double.Parse(data["Money"].ToString()).ToString("#,###", cul.NumberFormat);
                or.DateCreated = DateTime.Parse(data["Date_created"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                or.DateEdit = DateTime.Parse(data["Date_edit"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                listOrders.Add(or);
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