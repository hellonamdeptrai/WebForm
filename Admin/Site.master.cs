using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Site : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LoginSession"] == null)
        {
            Response.Redirect("../Default.aspx");
        }
        foreach (Personnel item in (List<Personnel>)Session["LoginSession"])
        {
            if (!item.Position.Equals("1") 
                && HttpContext.Current.Request.Url.AbsolutePath.ToLower() == "/Admin/Personnel.aspx".ToLower()
                && HttpContext.Current.Request.Url.AbsolutePath.ToLower() == "/Admin/Category.aspx".ToLower())
            {
                Response.Redirect("../403.aspx");
            }
            if (item.Position.Equals("3"))
            {
                Response.Redirect("../403.aspx");
            }
        }
    }
}
