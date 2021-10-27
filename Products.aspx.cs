using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Products : System.Web.UI.Page
{
    public List<Product> listProducts = new List<Product>();
    public List<int> pageList = new List<int>();
    int totalPage = 0;
    int pageSize = 8;
    public int page;
    public int cp = 1;
    public int checkPage = 0;
    int id = 0;
    public string slug = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Request.QueryString["id"] != null) 
        {
            id = Int32.Parse(Request.QueryString["id"]);
        }
        if (Request.QueryString["slug"] != null)
        {
            slug = Request.QueryString["slug"];
        }

        if (Request.QueryString["p"] != null)
        {
            page = Int32.Parse(Request.QueryString["p"]);
        }
        
        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();
            if (slug == "old" && id == 0)
            {
                checkPage = 1;
                txtTitleCategory.Text = "Cũ";
                txtTitleCategory2.Text = "Điện thoại cũ";

                SqlCommand cmdT = new SqlCommand();
                cmdT.Connection = con;
                cmdT.CommandType = System.Data.CommandType.StoredProcedure;
                cmdT.CommandText = "CountProductStatus";
                cmdT.Parameters.Add(new SqlParameter("@Status", 3));

                cmdT.ExecuteNonQuery();
                SqlDataReader dataT = cmdT.ExecuteReader();
                dataT.Read();
                totalPage = Int32.Parse(dataT[0].ToString());
                pageList = Packet.toPaging(totalPage, pageSize);
                dataT.Close();
                cmdT.Clone();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ProductsStatus";
                cmd.Parameters.Add(new SqlParameter("@PageNumber", page));
                cmd.Parameters.Add(new SqlParameter("@RowsOfPage", pageSize));
                cmd.Parameters.Add(new SqlParameter("@Status", 3));

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
            }
            else
            {
                if (id != 0 && slug != null)
                {
                    checkPage = 2;
                    SqlCommand cmdC = new SqlCommand();
                    cmdC.Connection = con;
                    cmdC.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdC.CommandText = "GetCategoryID";
                    cmdC.Parameters.Add(new SqlParameter("@Id", id));

                    cmdC.ExecuteNonQuery();
                    SqlDataReader dataC = cmdC.ExecuteReader();

                    dataC.Read();
                    txtTitleCategory.Text = dataC["Name"].ToString();
                    txtTitleCategory2.Text = dataC["Name"].ToString();
                    dataC.Close();
                    cmdC.Clone();

                    SqlCommand cmdT = new SqlCommand();
                    cmdT.Connection = con;
                    cmdT.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdT.CommandText = "CountProductCategory";
                    cmdT.Parameters.Add(new SqlParameter("@CategoryId", id));

                    cmdT.ExecuteNonQuery();
                    SqlDataReader dataT = cmdT.ExecuteReader();
                    dataT.Read();
                    totalPage = Int32.Parse(dataT[0].ToString());
                    pageList = Packet.toPaging(totalPage, pageSize);
                    dataT.Close();
                    cmdT.Clone();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "ProductsCategory";
                    cmd.Parameters.Add(new SqlParameter("@PageNumber", page));
                    cmd.Parameters.Add(new SqlParameter("@RowsOfPage", pageSize));
                    cmd.Parameters.Add(new SqlParameter("@CategoryId", id));

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
                }
                else
                {
                    checkPage = 3;
                    txtTitleCategory2.Text = "Tất cả điện thoại";

                    SqlCommand cmdT = new SqlCommand();
                    cmdT.Connection = con;
                    cmdT.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdT.CommandText = "CountProduct";

                    cmdT.ExecuteNonQuery();
                    SqlDataReader dataT = cmdT.ExecuteReader();
                    dataT.Read();
                    totalPage = Int32.Parse(dataT[0].ToString());
                    pageList = Packet.toPaging(totalPage, pageSize);
                    dataT.Close();
                    cmdT.Clone();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "PageProducts";
                    cmd.Parameters.Add(new SqlParameter("@PageNumber", page));
                    cmd.Parameters.Add(new SqlParameter("@RowsOfPage", pageSize));

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
                }
            }
            con.Close();
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}