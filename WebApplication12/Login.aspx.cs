using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication12
{
    public partial class Login : System.Web.UI.Page
    {
        Xulydata DB = new Xulydata();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           bool ok= DB.KTDangNhap(TextBox1.Text, TextBox2.Text);
            if (ok == true)
            {
                
                Session["Login"] = true;
                Session["ContentL"] = TextBox1.Text;
                Session["HoTen"] = DB.LayHoTen(TextBox1.Text);
                Response.Redirect("Home.aspx");
            }
            else
            {
                Label3.Visible = true;
            }
        }
    }
}