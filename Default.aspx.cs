using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    public List<Product> listProducts = new List<Product>();
    public List<Product> listProducts2 = new List<Product>();
    public List<Product> listProducts3 = new List<Product>();
    public List<Product> listProducts4 = new List<Product>();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "ProductsDESC";
            cmd.Parameters.Add(new SqlParameter("@TOP", 3));

            cmd.ExecuteNonQuery();

            SqlDataReader data = cmd.ExecuteReader();

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            while (data.Read())
            {
                Product pr = new Product();
                pr.Id = data["Id"].ToString();
                pr.Name = data["Name"].ToString();
                pr.Slug = data["Slug"].ToString();
                pr.Brand = data["Brand"].ToString();
                pr.OriginPrice = double.Parse(data["Origin_price"].ToString()).ToString("#,###", cul.NumberFormat);
                pr.SalePrice = double.Parse(data["Sale_Price"].ToString()).ToString("#,###", cul.NumberFormat);
                pr.Discount = data["Discount_percent"].ToString();
                pr.Avatar = data["Avatar"].ToString();
                pr.Promotion = data["Promotion"].ToString();
                pr.Specifications = data["Specifications"].ToString();
                pr.Content = data["Content"].ToString();
                pr.DateCreated = DateTime.Parse(data["Date_created"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                pr.DateEdit = DateTime.Parse(data["Date_edit"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                listProducts.Add(pr);
            }
            data.Close();
            cmd.Clone();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandType = System.Data.CommandType.StoredProcedure;
            cmd2.CommandText = "ProductsSalePrice";

            cmd2.ExecuteNonQuery();

            SqlDataReader data2 = cmd2.ExecuteReader();
            while (data2.Read())
            {
                Product pr = new Product();
                pr.Id = data2["Id"].ToString();
                pr.Name = data2["Name"].ToString();
                pr.Slug = data2["Slug"].ToString();
                pr.Brand = data2["Brand"].ToString();
                pr.OriginPrice = double.Parse(data2["Origin_price"].ToString()).ToString("#,###", cul.NumberFormat);
                pr.SalePrice = double.Parse(data2["Sale_Price"].ToString()).ToString("#,###", cul.NumberFormat);
                pr.Discount = data2["Discount_percent"].ToString();
                pr.Avatar = data2["Avatar"].ToString();
                pr.Promotion = data2["Promotion"].ToString();
                pr.Specifications = data2["Specifications"].ToString();
                pr.Content = data2["Content"].ToString();
                pr.DateCreated = DateTime.Parse(data2["Date_created"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                pr.DateEdit = DateTime.Parse(data2["Date_edit"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                listProducts2.Add(pr);
            }
            data2.Close();
            cmd2.Clone();

            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = con;
            cmd3.CommandType = System.Data.CommandType.StoredProcedure;
            cmd3.CommandText = "ProductsDiscountPercent";

            cmd3.ExecuteNonQuery();

            SqlDataReader data3 = cmd3.ExecuteReader();
            while (data3.Read())
            {
                Product pr = new Product();
                pr.Id = data3["Id"].ToString();
                pr.Name = data3["Name"].ToString();
                pr.Slug = data3["Slug"].ToString();
                pr.Brand = data3["Brand"].ToString();
                pr.OriginPrice = double.Parse(data3["Origin_price"].ToString()).ToString("#,###", cul.NumberFormat);
                pr.SalePrice = double.Parse(data3["Sale_Price"].ToString()).ToString("#,###", cul.NumberFormat);
                pr.Discount = data3["Discount_percent"].ToString();
                pr.Avatar = data3["Avatar"].ToString();
                pr.Promotion = data3["Promotion"].ToString();
                pr.Specifications = data3["Specifications"].ToString();
                pr.Content = data3["Content"].ToString();
                pr.DateCreated = DateTime.Parse(data3["Date_created"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                pr.DateEdit = DateTime.Parse(data3["Date_edit"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                listProducts3.Add(pr);
            }
            data3.Close();
            cmd3.Clone();

            SqlCommand cmd4 = new SqlCommand();
            cmd4.Connection = con;
            cmd4.CommandType = System.Data.CommandType.StoredProcedure;
            cmd4.CommandText = "ProductsNew";

            cmd4.ExecuteNonQuery();

            SqlDataReader data4 = cmd4.ExecuteReader();
            while (data4.Read())
            {
                Product pr = new Product();
                pr.Id = data4["Id"].ToString();
                pr.Name = data4["Name"].ToString();
                pr.Slug = data4["Slug"].ToString();
                pr.Brand = data4["Brand"].ToString();
                pr.OriginPrice = double.Parse(data4["Origin_price"].ToString()).ToString("#,###", cul.NumberFormat);
                pr.SalePrice = double.Parse(data4["Sale_Price"].ToString()).ToString("#,###", cul.NumberFormat);
                pr.Discount = data4["Discount_percent"].ToString();
                pr.Avatar = data4["Avatar"].ToString();
                pr.Promotion = data4["Promotion"].ToString();
                pr.Specifications = data4["Specifications"].ToString();
                pr.Content = data4["Content"].ToString();
                pr.DateCreated = DateTime.Parse(data4["Date_created"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                pr.DateEdit = DateTime.Parse(data4["Date_edit"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                listProducts4.Add(pr);
            }
            data4.Close();
            cmd4.Clone();

            con.Close();
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}