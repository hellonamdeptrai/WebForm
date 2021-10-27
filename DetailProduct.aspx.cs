using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DetailProduct : System.Web.UI.Page
{
    public List<string> listImages = new List<string>();
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Int32.Parse(Request.QueryString["id"]);
        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();
            SqlCommand cmdI = new SqlCommand();
            cmdI.Connection = con;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.CommandText = "GetImagesProduct";
            cmdI.Parameters.Add(new SqlParameter("@Id", id));

            cmdI.ExecuteNonQuery();
            SqlDataReader dataI = cmdI.ExecuteReader();

            while (dataI.Read())
            {
                listImages.Add(dataI["Path"].ToString());
            }
            dataI.Close();
            cmdI.Clone();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "GetProductsID";
            cmd.Parameters.Add(new SqlParameter("@Id", id));

            cmd.ExecuteNonQuery();
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");

            SqlDataReader data = cmd.ExecuteReader();
            data.Read();
            name.Text = data["Name"].ToString();
            originPrice.Text = double.Parse(data["Origin_price"].ToString()).ToString("#,###", cul.NumberFormat)+"đ";
            salePrice.Text = double.Parse(data["Sale_Price"].ToString()).ToString("#,###", cul.NumberFormat) + "đ";
            discount.Text = data["Discount_percent"].ToString();
            promotion.Text = data["Promotion"].ToString();
            specifications.Text = data["Specifications"].ToString();
            content.Text = data["Content"].ToString();
            data.Close();
            con.Close();
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}