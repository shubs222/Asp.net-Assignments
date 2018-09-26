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
            ProductRepository productRepository = new ProductRepository();
            int str = Convert.ToInt32(Request.QueryString["id"]);
            productRepository.getDetails();
            ProductImage.ImageUrl = "~/Content/"+productRepository.productslist[str].ProductUrl;
            ProductName.Text= productRepository.productslist[str].PName;
            ProductPrice.Text = productRepository.productslist[str].Price.ToString();
            ProductDesription.Text = productRepository.productslist[str].Description;
        }
    }
}