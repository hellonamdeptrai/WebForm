using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        List<Carts> listCarts = (List<Carts>)Session["CartsSession"];
        int index = isExist(id);
        listCarts.RemoveAt(index);
        Session["CartsSession"] = listCarts;
        Response.Redirect("Cart.aspx");
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