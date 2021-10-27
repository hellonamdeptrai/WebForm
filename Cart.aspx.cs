using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cart : System.Web.UI.Page
{
    public List<Carts> listCarts = new List<Carts>();
    private Int64 TotalCart;
    protected void Page_Load(object sender, EventArgs e)
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        if (Session["LoginSession"] != null)
        {

            foreach (Personnel item in (List<Personnel>)Session["LoginSession"])
            {
                address.Text = item.Address;
            }

        }
        if (Session["CartsSession"] != null)
        {
            
            foreach (Carts item in (List<Carts>)Session["CartsSession"])
            {
                Carts ct = new Carts();
                Int64 total = Int64.Parse(item.SalePrice.ToString()) * item.Quantity;
                ct.IdProduct = item.IdProduct;
                ct.Name = item.Name;
                ct.SalePrice = double.Parse(item.SalePrice.ToString()).ToString("#,###", cul.NumberFormat);
                ct.Avatar = item.Avatar;
                ct.Quantity = item.Quantity;
                ct.TotalPrice = total.ToString("#,###", cul.NumberFormat);
                TotalCart += total;
                TotalPriceCart.Text = TotalCart.ToString("#,###", cul.NumberFormat)+"đ";
                listCarts.Add(ct);
            }

        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["LoginSession"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();
            if (Session["CartsSession"] != null)
            {
                foreach (Carts item in (List<Carts>)Session["CartsSession"])
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "CreateOrders";
                    cmd.Parameters.Add(new SqlParameter("@Status", 1));
                    cmd.Parameters.Add(new SqlParameter("@Money", item.SalePrice));
                    cmd.Parameters.Add(new SqlParameter("@Date_created", DateTime.Now.Date.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@Date_edit", DateTime.Now.Date.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@Quantity", item.Quantity));
                    cmd.Parameters.Add(new SqlParameter("@Product_id", item.IdProduct));
                    foreach (Personnel itemUser in (List<Personnel>)Session["LoginSession"])
                    {
                        cmd.Parameters.Add(new SqlParameter("@User_id", itemUser.Id));
                    }

                    cmd.ExecuteNonQuery();
                    cmd.Clone();

                }

                con.Close();
                Session["CartsSession"] = null;
                Response.Redirect("Default.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Không có sản phẩm trong giỏ hàng');", true);
            }
            
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}