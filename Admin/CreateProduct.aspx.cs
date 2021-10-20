using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admin_CreateProduct : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "GetCategories";

            cmd.ExecuteNonQuery();
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                ListItem item = new ListItem(data["Name"].ToString(), data["Id"].ToString());
                listcategory.Items.Add(item);
            }
            data.Close();
            cmd.Clone();
            con.Close();
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            string nameAvatar = DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + avatar.FileName;
            if (Page.IsValid && avatar.HasFile && Packet.CheckFileType(avatar.FileName))
            {
                string fileName = "../Images/" + nameAvatar;
                string filePath = MapPath(fileName);
                avatar.SaveAs(filePath);
            }
            int origin = Int32.Parse(originprice.Text);
            int salep = Int32.Parse(saleprice.Text);
            float discount1 = origin - salep;
            float discount2 = discount1 / salep;
            double discount = Math.Round((double)(discount2 * 100));

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CreateProducts";
            cmd.Parameters.Add(new SqlParameter("@Name", name.Text));
            cmd.Parameters.Add(new SqlParameter("@Slug", Packet.GenerateSlug(name.Text)));
            cmd.Parameters.Add(new SqlParameter("@Brand", brand.Text));
            cmd.Parameters.Add(new SqlParameter("@Origin_price", origin));
            cmd.Parameters.Add(new SqlParameter("@Sale_price", salep));
            cmd.Parameters.Add(new SqlParameter("@Discount_percent", discount));
            cmd.Parameters.Add(new SqlParameter("@Avatar", nameAvatar));
            cmd.Parameters.Add(new SqlParameter("@Promotion", promotion.Text.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Specifications", specifications.Text.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Content", content.Text.ToString()));
            cmd.Parameters.Add(new SqlParameter("@User_id", 1));
            cmd.Parameters.Add(new SqlParameter("@Category_id", listcategory.SelectedItem.Value));
            cmd.Parameters.Add(new SqlParameter("@Status", status.SelectedItem.Value));
            cmd.Parameters.Add(new SqlParameter("@Date_created", DateTime.Now.Date.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Date_edit", DateTime.Now.Date.ToString()));

            cmd.ExecuteNonQuery();
            cmd.Clone();

            SqlCommand cmdP = new SqlCommand();
            cmdP.Connection = con;
            cmdP.CommandType = System.Data.CommandType.StoredProcedure;
            cmdP.CommandText = "NewIdProduct";
            cmdP.ExecuteNonQuery();
            int idProduct;
            SqlDataReader data = cmdP.ExecuteReader();
            data.Read();
            idProduct = Int32.Parse(data["Id"].ToString());
            data.Close();
            cmdP.Clone();

            if (Page.IsValid && images.HasFile && Packet.CheckFileType(images.FileName))
            {

                foreach (HttpPostedFile uploadedFile in images.PostedFiles)
                {
                    string nameImage = DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + uploadedFile.FileName;
                    string fileName = "../Images/" + nameImage;
                    string filePath = MapPath(fileName);
                    uploadedFile.SaveAs(filePath);
                    SqlCommand cmdI = new SqlCommand();
                    cmdI.Connection = con;
                    cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdI.CommandText = "CreateImages";
                    cmdI.Parameters.Add(new SqlParameter("@Name", nameImage));
                    cmdI.Parameters.Add(new SqlParameter("@Path", nameImage));
                    cmdI.Parameters.Add(new SqlParameter("@Product_id", idProduct));
                    cmdI.Parameters.Add(new SqlParameter("@Date_created", DateTime.Now.Date.ToString()));
                    cmdI.Parameters.Add(new SqlParameter("@Date_edit", DateTime.Now.Date.ToString()));

                    cmdI.ExecuteNonQuery();
                    cmdI.Clone();
                }

            }
            con.Close();
            Response.Redirect("Product.aspx?p=1");
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}