using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DAL.Repository;
namespace _24th_Sep2018
{
    public partial class ProductManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!(Context.User.IsInRole("ProductsManager")))
            {
                Response.Redirect("Default.aspx");
            }
            if (!Page.IsPostBack)
            {
                Table tb = new Table();
                tb.ID = "1";
                PlaceHolder1.Controls.Add(tb);
                ProductRepository ps = new ProductRepository();
                ps.getDetails();
                for (int count = 0; count < ProductRepository.productslist.Count; count++)
                {
                    TableRow tablerow = new TableRow();
                    tb.Rows.Add(tablerow);
                    TableCell tcell = new TableCell();
                    Label lb = new Label();
                    HyperLink preview = new HyperLink();
                    HyperLink delete = new HyperLink();
                    HyperLink update = new HyperLink();
                    PlaceHolder1.Controls.Add(lb);
                    lb.Text = ProductRepository.productslist[count].PName;
                    lb.Width = 100;
                    PlaceHolder1.Controls.Add(preview);
                    preview.Text = "Preview";
                    preview.NavigateUrl = "ProductDetail?id="+ProductRepository.productslist[count].ProductId;
                    preview.Width = 100;
                    //PlaceHolder1.Controls.Add(update);
                    //update.Text = "Update";
                    //update.NavigateUrl = "ProductManagement?id="+ ProductRepository.productslist[count].ProductId;
                    //update.Width = 100;
                    PlaceHolder1.Controls.Add(delete);
                    delete.Text = "Delete?id="+ ProductRepository.productslist[count].ProductId + "<br/>";
                    delete.NavigateUrl = "ProductManagent";
                }
                int id = Convert.ToInt32(Request.QueryString["id"]);
                ps.DeleteProduct(id);
            }
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert.aspx");
        }
    }
}