using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication12
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Application["View"].ToString();
            if ((bool)Session["Login"] == false)
            {
                Label lbChao = new Label();
                lbChao.Text = "Chao cu";
                HyperLink hp = new HyperLink();
                hp.Text = "Login";
                hp.NavigateUrl = "Login.aspx";
                tbChao.Controls.Add(lbChao);
                tbChao.Controls.Add(hp);
            }
            else
            {
                Label lbChao = new Label(); 
                lbChao.Text = "Chao"+Session["HoTen"];
                LinkButton lbThoat = new LinkButton();
                lbThoat.Text = "Exit";
                lbThoat.Click += LbThoat_Click;
                tbChao.Controls.Add(lbChao);
                tbChao.Controls.Add(lbThoat);

                
            }
        }

        private void LbThoat_Click(object sender, EventArgs e)
        {
            Session["Login"] = false;
            Response.Redirect(Request.RawUrl);
        }
    }
}