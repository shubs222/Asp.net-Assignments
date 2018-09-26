using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Repository;
namespace _24th_Sep2018
{
    public partial class Update : System.Web.UI.Page
    {
        ProductRepository productRepository = new ProductRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                productRepository.getDetails();
                int qstr = Convert.ToInt32(Request.QueryString["id"]);
                ProductName.Text = productRepository.productslist[qstr].PName;
                ProductPrice.Text = productRepository.productslist[qstr].Price.ToString();
                ProductDescriprtion.Text = productRepository.productslist[qstr].Description;
                BrandName.SelectedValue = productRepository.productslist[qstr].BrandId.ToString();
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            int qstr = Convert.ToInt32(Request.QueryString["id"]);
            productRepository.Update(qstr,ProductName.Text, Convert.ToSingle(ProductPrice.Text), ProductDescriprtion.Text, ImageUpload.FileName, Convert.ToInt32(BrandName.SelectedValue));
            Response.Redirect("ProductManagement.aspx");
        }
    }
}