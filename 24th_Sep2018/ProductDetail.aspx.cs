using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Repository;

namespace _24th_Sep2018
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductRepository ps = new ProductRepository();
            int str = Convert.ToInt32(Request.QueryString["id"]);
           
            ps.getDetails();
            Image1.ImageUrl = "~/"+ProductRepository.productslist[str].ProductUrl;
            Label1.Text= ProductRepository.productslist[str].PName;
            Label2.Text = ProductRepository.productslist[str].Price.ToString();
        }
    }
}