using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _24th_Sep2018
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Context.User.IsInRole("OrderManager"))
            {
                //Response.Redirect("~/Contact");
            }
            else
            {
                Response.Redirect("~/");
            }
            
        }
    }
}