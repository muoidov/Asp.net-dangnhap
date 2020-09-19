using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication12
{
    public partial class Thongbao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch ((int)Session["MaTB"])
            {
                case 1:Label2.Text = "Ban can dang nhap";
                    break;
                case 2:Label2.Text = "Khong du quyen";
                    break;
            }
        }
    }
}