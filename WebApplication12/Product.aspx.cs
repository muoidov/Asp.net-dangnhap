using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication12
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["ContentL"] == false)
            {
                Session["MaTB"] = 1;
                Response.Redirect("Thongbao.aspx");
            }
        }
    }
}