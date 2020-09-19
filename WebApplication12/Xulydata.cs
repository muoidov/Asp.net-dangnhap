using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication12
{
    
    public class Xulydata
    {
        string chuoiketnoi = "Server=.\\sqlex;UID=sa;PWD=dovanmuoi;Database=quanlybanhang";
        SqlConnection ketnoi=new SqlConnection();
        public bool KTDangNhap(string username,string password)
        {
            moketnoi();
            SqlCommand cm = new SqlCommand("Select*from Nguoidung where TenDangNhap=@tendangnhap and MatKhau=@matkhau", ketnoi);
            cm.Parameters.Add("tendangnhap", username);
            cm.Parameters.Add("matkhau", password);

            SqlDataReader reader=cm.ExecuteReader();
            bool ok = false;
            if (reader.HasRows == true)
                ok = true;
            Dongketnoi();
            return ok;
        }
        public string LayMaQuyen(string username)
        {
            moketnoi();
            SqlCommand cm = new SqlCommand("Select Quyen from NguoiDung where TenDangNhap='" + username + "'", ketnoi);
            int maquyen = (int)cm.ExecuteScalar(); 
     
            Dongketnoi();

            return maquyen;
        }
        public DataTable LayDsQuyen()
        {
            DataTable bangtrave = new DataTable();
            moketnoi();
            SqlCommand cm = new SqlCommand("Select * from Quyen ", ketnoi);
            SqlDataReader reader = cm.ExecuteReader();
            bangtrave.Load(reader);
            Dongketnoi();
            return bangtrave;
        }
        public bool ThemQuyen(int ma ,string ten)
        {
            bool ok;
            moketnoi();
            SqlCommand cm = new SqlCommand("insert into Quyen values("+ma+",N'"+ten+"')", ketnoi);

            try
            { cm.ExecuteNonQuery();
                ok = true;
            }
            catch
            {
                ok = false;
            }
            Dongketnoi();
            return ok;
        }
        public bool XoaQuyen(int ma)
        {
            bool ok;
            moketnoi();
            SqlCommand cm = new SqlCommand("delete Quyen where Ma="+ma, ketnoi);

            try
            {
                cm.ExecuteNonQuery();
                ok = true;
            }
            catch
            {
                ok = false;
            }
            Dongketnoi();
            return ok;
        }
        public bool SuaQuyen(int ma,string ten)
        {
            bool ok;
            moketnoi();
            SqlCommand cm = new SqlCommand("update Quyen Set Ten=N'"+ten+"' where Ma="+ma , ketnoi);

            try
            {
                cm.ExecuteNonQuery();
                ok = true;
            }
            catch
            {
                ok = false;
            }
            Dongketnoi();
            return ok;
        }
        public string LayHoTen(string username)
        {
            moketnoi();
            SqlCommand cm = new SqlCommand("Select HoTen from Nguoidung where TenDangNhap='" + username + "'", ketnoi);

            string hoten = cm.ExecuteScalar().ToString();
            Dongketnoi();
            return hoten;
        }
        void moketnoi()
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            ketnoi.Open();
        }
        void Dongketnoi()
        {
            ketnoi.Close();
        }
    }
    
    

    
}