using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using DAL.Repository;

namespace _24th_Sep2018
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Context.User.IsInRole("ProductsManager"))
            {
                //Response.Redirect("About.aspx");
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
            Table tb = new Table();
            tb.ID = "1";
            PlaceHolder1.Controls.Add(tb);
            ProductRepository ps = new ProductRepository();
            ps.getDetails();
            int count1 = 0;
            for (int count = 0; count < 6; count++)
            {
                TableRow tablerow = new TableRow();
                tb.Rows.Add(tablerow);
                    TableCell tcell = new TableCell();
                    HyperLink hp = new HyperLink();
                    Image mg = new Image();
                    PlaceHolder1.Controls.Add(mg);
                    mg.ImageUrl=ProductRepository.productslist[count].ProductUrl;
                Console.ReadLine();
                       PlaceHolder1.Controls.Add(hp);
                    hp.Text= ProductRepository.productslist[count].PName;
                    hp.NavigateUrl ="ProductDetail";
                    Label lb = new Label();
                    PlaceHolder1.Controls.Add(lb);
                    lb.Text = Convert.ToString(ProductRepository.productslist[count].Price);
                    tablerow.Cells.Add(tcell);
                   
                
               
            }

         
        }
    }
}
