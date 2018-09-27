using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using DAL.Repository;

namespace _24th_Sep2018
{
    public partial class About : Page
    {
        ProductRepository productRepository = new ProductRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            
               
            if (!Page.IsPostBack)
            {
                Table tb = new Table();
                tb.ID = "1";
                PlaceHolder1.Controls.Add(tb);
               
                productRepository.getDetails();
                    for (int count = 0; count < productRepository.productslist.Count; count++)
                    {
                        TableRow tablerow = new TableRow();
                        tb.Rows.Add(tablerow);
                        TableCell tcell = new TableCell();
                        HyperLink hp = new HyperLink();
                        Image mg = new Image();
                        PlaceHolder1.Controls.Add(mg);
                        mg.ImageUrl = "~/Content/"+productRepository.productslist[count].ProductUrl;
                        mg.Height = 200;
                        mg.Width = 200;
                        PlaceHolder1.Controls.Add(hp);
                        hp.Text = "<br/>" + productRepository.productslist[count].PName;
                        hp.NavigateUrl = "ProductDetail?id=" + count;
                        Label lb = new Label();
                        PlaceHolder1.Controls.Add(lb);
                        lb.Text = "<br/>Price: " + Convert.ToString(productRepository.productslist[count].Price) + "<br/><br/>";
                        tablerow.Cells.Add(tcell);
                    } 
               
           }
          
          
        }

        

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            productRepository.SearchProduct(SearchBox.Text);
            Table tb = new Table();
            tb.ID = "1";
            PlaceHolder1.Controls.Add(tb); 

            for (int count = 0; count < productRepository.Searchproductslist.Count; count++)
            {
                TableRow tablerow = new TableRow();
                tb.Rows.Add(tablerow);
                TableCell tcell = new TableCell();
                HyperLink hp = new HyperLink();
                Image mg = new Image();
                PlaceHolder1.Controls.Add(mg);
                mg.ImageUrl = "~/Content/" + productRepository.Searchproductslist[count].ProductUrl;
                mg.Height = 200;
                mg.Width = 200;
                PlaceHolder1.Controls.Add(hp);
                hp.Text = "<br/>" + productRepository.Searchproductslist[count].PName;
                hp.NavigateUrl = "ProductDetail?id=" + count;
                Label lb = new Label();
                PlaceHolder1.Controls.Add(lb);
                lb.Text = "<br/>" + Convert.ToString(productRepository.Searchproductslist[count].Price) + "<br/>";
                tablerow.Cells.Add(tcell);
            }


        }
    }
}
