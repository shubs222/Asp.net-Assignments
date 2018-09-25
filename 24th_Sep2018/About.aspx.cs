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
            
                if (Context.User.IsInRole("User"))
                {
                    //Response.Redirect("About.aspx");
                }
                else
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
                        HyperLink hp = new HyperLink();
                        Image mg = new Image();
                        PlaceHolder1.Controls.Add(mg);
                        mg.ImageUrl = "~/"+ProductRepository.productslist[count].ProductUrl;
                        PlaceHolder1.Controls.Add(hp);
                        hp.Text = "<br/>" + ProductRepository.productslist[count].PName;
                        hp.NavigateUrl = "ProductDetail?id=" + ProductRepository.productslist[count].ProductId.ToString();
                        Label lb = new Label();
                        PlaceHolder1.Controls.Add(lb);
                        lb.Text = "<br/>" + Convert.ToString(ProductRepository.productslist[count].Price) + "<br/>";
                        tablerow.Cells.Add(tcell);
                    } 
               
           }
          
          else
            {
                string s = TextBox1.Text;
                string q = "select * from Products where Name LIKE '%" + s + "%'";
                SqlConnection con = new SqlConnection("Data Source=ACUPC_113;Initial Catalog=AcuData;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(q, con);
                con.Open();
                Table tb = new Table();
                tb.ID = "1";
                PlaceHolder1.Controls.Add(tb);  
                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    int count=0;
                    while (sqlDataReader.Read())
                    {
                        TableRow tablerow = new TableRow();
                        tb.Rows.Add(tablerow);
                        TableCell tcell = new TableCell();
                        HyperLink hp = new HyperLink();
                        Image mg = new Image();
                        PlaceHolder1.Controls.Add(mg);
                        mg.ImageUrl = "~/"+ProductRepository.productslist[count].ProductUrl;
                        PlaceHolder1.Controls.Add(hp);
                        hp.Text = "<br/>" + ProductRepository.productslist[count].PName;
                        hp.NavigateUrl = "ProductDetail?id="+ ProductRepository.productslist[count].ProductId.ToString();
                        Label lb = new Label();
                        PlaceHolder1.Controls.Add(lb);
                        lb.Text = "<br/>" + Convert.ToString(ProductRepository.productslist[count].Price) + "<br/>";
                        tablerow.Cells.Add(tcell);
                        count++;
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
          
        }
    }
}
