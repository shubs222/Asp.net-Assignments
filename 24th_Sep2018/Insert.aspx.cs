using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Repository;

namespace _24th_Sep2018
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void AddProduct_Click(object sender, EventArgs e)
        {
            ProductRepository ps = new ProductRepository();
            ps.Insert(ProductName.Text,Convert.ToSingle(ProductPrice.Text),ProductDescription.Text,ImageFileUpload.FileName,Convert.ToInt32(BrandList.SelectedValue));
            Response.Redirect("ProductManagement.aspx");
        }

        
    }
}