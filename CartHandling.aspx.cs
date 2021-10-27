using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CartHandling : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Int32.Parse(Request.QueryString["id"]);
        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "GetProductsID";
            cmd.Parameters.Add(new SqlParameter("@Id", id));

            cmd.ExecuteNonQuery();

            SqlDataReader data = cmd.ExecuteReader();
            data.Read();

            if (Session["CartsSession"] == null)
            {
                List<Carts> listCarts = new List<Carts>();
                Carts ct = new Carts();
                ct.IdProduct = data["Id"].ToString();
                ct.Name = data["Name"].ToString();
                ct.SalePrice = Math.Round((double)(Double.Parse(data["Sale_price"].ToString()))).ToString();
                ct.Avatar = data["Avatar"].ToString();
                ct.Quantity = 1;
                listCarts.Add(ct);

                HttpContext.Current.Session["CartsSession"] = listCarts;
            }
            else
            {
                List<Carts> listCarts = (List<Carts>)Session["CartsSession"];
                
                int index = isExist(data["Id"].ToString());
                if (index != -1)
                {
                    listCarts[index].Quantity++;
                }
                else
                {
                    Carts ct = new Carts();
                    ct.IdProduct = data["Id"].ToString();
                    ct.Name = data["Name"].ToString();
                    ct.SalePrice = Math.Round((double)(Double.Parse(data["Sale_price"].ToString()))).ToString();
                    ct.Avatar = data["Avatar"].ToString();
                    ct.Quantity = 1;
                    listCarts.Add(ct);
                }

                HttpContext.Current.Session["CartsSession"] = listCarts;
            }
            

            data.Close();
            con.Close();
            Response.Redirect("Cart.aspx");
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }

    private int isExist(string id)
    {
        List<Carts> listCarts = (List<Carts>)Session["CartsSession"];
        for (int i = 0; i < listCarts.Count; i++)
            if (listCarts[i].IdProduct.Equals(id))
                return i;
        return -1;
    }
}