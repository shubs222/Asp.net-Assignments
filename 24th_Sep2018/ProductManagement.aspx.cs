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

                Table tb = new Table();
                tb.ID = "1";
                PlaceHolder1.Controls.Add(tb);
                TableRow tablerow;
                TableCell tcell;
                HyperLink preview;
                HyperLink delete;
                HyperLink update;
                ProductRepository productRepository = new ProductRepository();
                productRepository.getDetails();
                for (int count = 0; count < productRepository.productslist.Count; count++)
                {
                   
                     tablerow = new TableRow();
                    tb.Rows.Add(tablerow);
                     tcell = new TableCell();
                    Label lb = new Label();
                    preview = new HyperLink();
                    delete = new HyperLink();
                     update = new HyperLink();
                    PlaceHolder1.Controls.Add(lb);
                    lb.Text = productRepository.productslist[count].PName;
                    lb.Width = 100;
                    PlaceHolder1.Controls.Add(preview);
                    preview.Text = "Preview";
                    preview.NavigateUrl = "ProductDetail?id=" +count ;
                    preview.Width = 100;
                    PlaceHolder1.Controls.Add(update);
                    update.Text = "Update";
                 update.NavigateUrl = "Update?id=" + count;
                    update.Width = 100;
                    PlaceHolder1.Controls.Add(delete);
                    delete.Text = "Delete" + "<br/>";
                delete.NavigateUrl = "Delete?id=" +count;
                }   

        }

       
    }
}