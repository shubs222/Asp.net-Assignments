using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Repository;
namespace _24th_Sep2018
{
    public partial class Delete : System.Web.UI.Page
    {
        ProductRepository productRepository = new ProductRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            productRepository.getDetails();
            int qstr = Convert.ToInt32(Request.QueryString["id"]);
            ProductName.Text = productRepository.productslist[qstr].PName;
            ProductPrice.Text = productRepository.productslist[qstr].Price.ToString();
            ProductDescription.Text = productRepository.productslist[qstr].Description;
            BrandList.SelectedValue= productRepository.productslist[qstr].BrandId.ToString();
            ProductimageUrl.ImageUrl = "~/Content/" + productRepository.productslist[qstr].ProductUrl;
        }

        protected void DeleteProduct_Click(object sender, EventArgs e)
        {
            
            int qstr = Convert.ToInt32(Request.QueryString["id"]);
            productRepository.DeleteProduct(ProductName.Text);
            Response.Redirect("ProductManagement.aspx");
        }

        
    }
}