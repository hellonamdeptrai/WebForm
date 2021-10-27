using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Search : System.Web.UI.Page
{
    public List<Product> listProducts = new List<Product>();

    protected void Page_Load(object sender, EventArgs e)
    {
        string name = Request.Form["name"];
        string nameQ = 12+"";
        if (Request.QueryString["name"] != null)
        {
            nameQ = Request.QueryString["name"];
        }
        txtTitleCategory.Text = nameQ;
        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "ProductsSearch";
            cmd.Parameters.Add(new SqlParameter("@Name", nameQ.ToString()));

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
            con.Close();
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}