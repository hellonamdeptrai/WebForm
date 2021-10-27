using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Globalization;

public partial class Admin_Product : System.Web.UI.Page
{
    public List<Product> listProducts = new List<Product>();
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
            foreach (Personnel item in (List<Personnel>)Session["LoginSession"])
            {
                SqlDataReader dataT = null;
                if (item.Id.Equals("1"))
                {
                    SqlCommand cmdT = new SqlCommand();
                    cmdT.Connection = con;
                    cmdT.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdT.CommandText = "CountProduct";

                    cmdT.ExecuteNonQuery();
                    dataT = cmdT.ExecuteReader();
                }
                else
                {
                    SqlCommand cmdT = new SqlCommand();
                    cmdT.Connection = con;
                    cmdT.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdT.CommandText = "CountProductUser";
                    cmdT.Parameters.Add(new SqlParameter("@UserId", item.Id));

                    cmdT.ExecuteNonQuery();
                    dataT = cmdT.ExecuteReader();
                }
                
                dataT.Read();
                totalPage = Int32.Parse(dataT[0].ToString());
                pageList = Packet.toPaging(totalPage, pageSize);
                dataT.Close();
                SqlDataReader data = null;

                if (item.Id.Equals("1"))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "PageProducts";
                    cmd.Parameters.Add(new SqlParameter("@PageNumber", page));
                    cmd.Parameters.Add(new SqlParameter("@RowsOfPage", pageSize));

                    cmd.ExecuteNonQuery();

                    data = cmd.ExecuteReader();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "ProductsUser";
                    cmd.Parameters.Add(new SqlParameter("@PageNumber", page));
                    cmd.Parameters.Add(new SqlParameter("@RowsOfPage", pageSize));
                    cmd.Parameters.Add(new SqlParameter("@UserId", item.Id));

                    cmd.ExecuteNonQuery();

                    data = cmd.ExecuteReader();
                }


                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                while (data.Read())
                {
                    Product pr = new Product();
                    pr.Id = data["Id"].ToString();
                    pr.Name = data["Name"].ToString();
                    pr.Slug = data["Slug"].ToString();
                    pr.Brand = data["Brand"].ToString();
                    pr.SalePrice = double.Parse(data["Sale_Price"].ToString()).ToString("#,###", cul.NumberFormat);
                    pr.Avatar = data["Avatar"].ToString();
                    pr.DateCreated = DateTime.Parse(data["Date_created"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                    pr.DateEdit = DateTime.Parse(data["Date_edit"].ToString()).GetDateTimeFormats(new System.Globalization.CultureInfo("fr-FR", true))[0];
                    listProducts.Add(pr);
                }
                data.Close();
            }
            con.Close();
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}