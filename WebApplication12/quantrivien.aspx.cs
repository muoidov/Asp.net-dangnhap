using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication12
{
    public partial class quantrivien : System.Web.UI.Page
    {
        Xulydata Db = new Xulydata();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["ContentL"] == false)
            {
                Session["MaTB"] = 1;
                Response.Redirect("Thongbao.aspx");
            }
            int maquyen = Db.LayMaQuyen(Session["Login"].ToString());
            if (maquyen != 1)
            {
                Session["MaTB"] = 2;
                Response.Redirect("Thongbao.aspx");
            }
        }
    }
}