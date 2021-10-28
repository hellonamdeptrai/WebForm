using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Default : System.Web.UI.Page
{
    //public Int64 TotalMoney = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();
            SqlCommand cmdT = new SqlCommand();
            cmdT.Connection = con;
            cmdT.CommandType = System.Data.CommandType.StoredProcedure;
            cmdT.CommandText = "CountOrderSell";

            cmdT.ExecuteNonQuery();
            SqlDataReader dataT = cmdT.ExecuteReader();
            dataT.Read();
            orderCount.Text = dataT[0].ToString();
            dataT.Close();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "GetOrders";

            cmd.ExecuteNonQuery();

            SqlDataReader data = cmd.ExecuteReader();

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            double TotalMoney = 0;
            while (data.Read())
            {
                TotalMoney += Math.Round((double)(Double.Parse(data["Money"].ToString())));
            }
            txtTotalMoney.Text = TotalMoney.ToString("#,###", cul.NumberFormat)+"đ";
            data.Close();
            con.Close();
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}