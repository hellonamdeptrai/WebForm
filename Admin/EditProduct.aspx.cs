using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

public partial class Admin_EditProduct : System.Web.UI.Page
{
    public List<string> listImages = new List<string>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            SqlConnection con = Connection.SqlConnectServer();
            try
            {
                con.Open();
                SqlCommand cmdC = new SqlCommand();
                cmdC.Connection = con;
                cmdC.CommandType = System.Data.CommandType.StoredProcedure;
                cmdC.CommandText = "GetCategories";

                cmdC.ExecuteNonQuery();
                SqlDataReader dataC = cmdC.ExecuteReader();

                while (dataC.Read())
                {
                    ListItem item = new ListItem(dataC["Name"].ToString(), dataC["Id"].ToString());
                    listcategory.Items.Add(item);
                }
                dataC.Close();
                cmdC.Clone();

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

                SqlDataReader data = cmd.ExecuteReader();
                data.Read();
                name.Text = data["Name"].ToString();
                brand.Text = data["Brand"].ToString();
                listcategory.Text = data["Category_id"].ToString();
                originprice.Text = Math.Round((double)(Double.Parse(data["Origin_price"].ToString()))).ToString();
                saleprice.Text = Math.Round((double)(Double.Parse(data["Sale_price"].ToString()))).ToString();
                avtarpreview.ImageUrl = "../Images/" + data["Avatar"].ToString();
                status.Text = data["Status"].ToString();
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        int id = Int32.Parse(Request.QueryString["id"]);
        int page = Int32.Parse(Request.QueryString["page"]);

        SqlConnection con = Connection.SqlConnectServer();
        try
        {
            con.Open();
            SqlCommand cmdPr = new SqlCommand();
            cmdPr.Connection = con;
            cmdPr.CommandType = System.Data.CommandType.StoredProcedure;
            cmdPr.CommandText = "GetProductsID";
            cmdPr.Parameters.Add(new SqlParameter("@Id", id));

            cmdPr.ExecuteNonQuery();

            SqlDataReader dataPr = cmdPr.ExecuteReader();
            dataPr.Read();
            string nameAvatar = dataPr["Avatar"].ToString();
            dataPr.Close();
            cmdPr.Clone();

            if (Page.IsValid && avatar.HasFile && Packet.CheckFileType(avatar.FileName))
            {
                string fileNameD = "../Images/" + nameAvatar;
                string filePathD = MapPath(fileNameD);
                FileInfo file = new FileInfo(filePathD);
                if (file.Exists)
                {
                    file.Delete();
                }

                nameAvatar = DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + avatar.FileName;
                string fileName = "../Images/" + nameAvatar;
                string filePath = MapPath(fileName);
                avatar.SaveAs(filePath);
            }
            int origin = Int32.Parse(originprice.Text);
            int salep = Int32.Parse(saleprice.Text);
            float discount1 = origin - salep;
            float discount2 = discount1 / salep;
            double discount = Math.Round((double)(discount2 * 100));

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "UpdateProducts";
            cmd.Parameters.Add(new SqlParameter("@Id", id));
            cmd.Parameters.Add(new SqlParameter("@Name", name.Text));
            cmd.Parameters.Add(new SqlParameter("@Slug", Packet.GenerateSlug(name.Text)));
            cmd.Parameters.Add(new SqlParameter("@Brand", brand.Text));
            cmd.Parameters.Add(new SqlParameter("@Origin_price", origin));
            cmd.Parameters.Add(new SqlParameter("@Sale_price", salep));
            cmd.Parameters.Add(new SqlParameter("@Discount_percent", discount));
            cmd.Parameters.Add(new SqlParameter("@Avatar", nameAvatar));
            cmd.Parameters.Add(new SqlParameter("@Promotion", promotion.Text));
            cmd.Parameters.Add(new SqlParameter("@Specifications", specifications.Text));
            cmd.Parameters.Add(new SqlParameter("@Content", content.Text));
            foreach (Personnel item in (List<Personnel>)Session["LoginSession"])
            {
                cmd.Parameters.Add(new SqlParameter("@User_id", item.Id));
            }
            cmd.Parameters.Add(new SqlParameter("@Category_id", listcategory.SelectedItem.Value));
            cmd.Parameters.Add(new SqlParameter("@Status", status.SelectedItem.Value));
            cmd.Parameters.Add(new SqlParameter("@Date_edit", DateTime.Now.Date.ToString()));

            cmd.ExecuteNonQuery();
            cmd.Clone();

            if (Page.IsValid && images.HasFile && Packet.CheckFileType(images.FileName))
            {
                SqlCommand cmdIm = new SqlCommand();
                cmdIm.Connection = con;
                cmdIm.CommandType = System.Data.CommandType.StoredProcedure;
                cmdIm.CommandText = "GetImagesProduct";
                cmdIm.Parameters.Add(new SqlParameter("@Id", id));

                cmdIm.ExecuteNonQuery();
                SqlDataReader dataIm = cmdIm.ExecuteReader();

                while (dataIm.Read())
                {
                    string fileName = "../Images/" + dataIm["Path"].ToString();
                    string filePath = MapPath(fileName);
                    FileInfo file = new FileInfo(filePath);
                    if (file.Exists)
                    {
                        file.Delete();
                    }
                }
                dataIm.Close();
                cmdIm.Clone();

                SqlCommand cmdA = new SqlCommand();
                cmdA.Connection = con;
                cmdA.CommandType = System.Data.CommandType.StoredProcedure;
                cmdA.CommandText = "DeleteImages";
                cmdA.Parameters.Add(new SqlParameter("@Id", id));

                cmdA.ExecuteNonQuery();
                cmdA.Clone();

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
                    cmdI.Parameters.Add(new SqlParameter("@Product_id", id));
                    cmdI.Parameters.Add(new SqlParameter("@Date_created", DateTime.Now.Date.ToString()));
                    cmdI.Parameters.Add(new SqlParameter("@Date_edit", DateTime.Now.Date.ToString()));

                    cmdI.ExecuteNonQuery();
                    cmdI.Clone();
                }

            }
            con.Close();
            Response.Redirect("Product.aspx?p=" + page);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}