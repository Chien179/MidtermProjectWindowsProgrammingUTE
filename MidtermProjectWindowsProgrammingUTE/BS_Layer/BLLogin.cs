using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidtermProjectWindowsProgrammingUTE.DB_Layer;

namespace MidtermProjectWindowsProgrammingUTE.BS_Layer
{
    class BLLogin
    {
        DBMain db = null;

        public BLLogin()
        {
            db = new DBMain();
        }

        public DataSet GetIDStaff(string namelogin, string password)
        {
            return db.ExecuteQueryDataSet("select MaNV from TaiKhoan where TenDangNhap='" + namelogin + "' and MatKhau ='" + password + "'", CommandType.Text);
        }

        public bool CheckAccount(string namelogin, string password, ref string err)
        {
            string sqlString = "select * from TaiKhoan Where TenDangNhap='" + namelogin + "' and MatKhau ='" + password + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool UpdateClient(string CMND, string TenKhachHang, string DiaChi, string SoDienThoai, string GioiTinh, string NgaySinh, ref string err)
        {
            string sqlString = "Update KhachHang Set TenKH=N'" + TenKhachHang + "',DiaChi=N'" + DiaChi + "',SoDienThoai='" + SoDienThoai + "',NgaySinh='" + NgaySinh + "',Nu='" + GioiTinh + "'Where CMND='" + CMND + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool DeleteClient(ref string err, string CMND)
        {
            string sqlString = "Delete From KhachHang Where CMND='" + CMND + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet SearchClient(string key, int Sex)
        {
            string sqlString = "Select * From KhachHang Where Nu =" + Sex + "and (CMND Like'%" + key + "%'or TenKH Like N'%" + key + "%'or DiaChi Like N'%" + key + "%'or SoDienThoai Like '%" + key + "%' or NgaySinh Like '%" + key + "%')";
            if (Sex == -1)
            {
                sqlString = "Select * From KhachHang Where CMND Like'%" + key + "%'or TenKH Like N'%" + key + "%'or DiaChi Like N'%" + key + "%'or SoDienThoai Like '%" + key + "%' or NgaySinh Like '%" + key + "%'";
            }
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);

        }
    }
}
