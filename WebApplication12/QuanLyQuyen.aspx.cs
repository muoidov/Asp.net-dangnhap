using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication12
{
    public partial class QuanLyQuyen : System.Web.UI.Page
    {
        Xulydata Db = new Xulydata();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Capnhatluoi();
            }
        }

        private void Capnhatluoi()
        {
            Db.LayDsQuyen();
            GridView1.DataSource = Db.LayDsQuyen();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          bool kq=  Db.ThemQuyen(int.Parse(TextBox1.Text), TextBox2.Text);
            if (kq == true)
            {
                Label4.Text = "Them thanh cong";
                Capnhatluoi();
            }
            else
            {
                Label4.Text = "Them khong thanh cong";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            bool kq = Db.XoaQuyen(int.Parse(TextBox3.Text));
            if (kq == true)
            {
                Label6.Text = "Xoathanh cong";
                Capnhatluoi();
            }
            else
            {
                Label6.Text = "Xoa khong thanh cong";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            bool kq = Db.SuaQuyen(int.Parse(TextBox4.Text),TextBox5.Text);
            if (kq == true)
            {
                Label9.Text = "Sua thanh cong";
                Capnhatluoi();
            }
            else
            {
                Label9.Text = "Sua khong thanh cong";
            }
        }
    }
}