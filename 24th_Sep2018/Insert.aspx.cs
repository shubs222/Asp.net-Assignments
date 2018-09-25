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
            ps.InsertAuto(TextBox1.Text,Convert.ToSingle(TextBox2.Text),TextBox3.Text,TextBox4.Text,Convert.ToInt32(DropDownList1.SelectedValue));
            Response.Redirect("ProductManagement.aspx");
        }
    }
}