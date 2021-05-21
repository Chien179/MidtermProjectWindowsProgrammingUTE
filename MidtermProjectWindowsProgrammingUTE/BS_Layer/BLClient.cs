﻿using System.Data;
using MidtermProjectWindowsProgrammingUTE.DB_Layer;

namespace MidtermProjectWindowsProgrammingUTE.BS_Layer
{
    class BLClient
    {
        DBMain db = null;

        public BLClient()
        {
            db = new DBMain();
        }

        public DataSet GetClient()
        {
            return db.ExecuteQueryDataSet("select * from KhachHang", CommandType.Text);
        }

        public bool AddClient(string CMND, string TenKhachHang, string DiaChi, string SoDienThoai, ref string err)
        {
            string sqlString = "Insert Into KhachHang Values(" + "'" + CMND + "',N'" + TenKhachHang + "',N'" + DiaChi + "','" + SoDienThoai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool UpdateClient(string CMND, string TenKhachHang, string DiaChi, string SoDienThoai, ref string err)
        {
            string sqlString = "Update KhachHang Set TenKH=N'" + TenKhachHang + "',DiaChi=N'" + DiaChi + "',SoDienThoai='" + SoDienThoai + "'" + "Where CMND='" + CMND + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool DeleteClient(ref string err, string CMND)
        {
            string sqlString = "Delete From ThuePhong Where CMND='" + CMND + "'";
            db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            sqlString = "Delete From KhachHang Where CMND='" + CMND + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet SearchClient(string key)
        {
            string sqlString = "Select * From KhachHang Where CMND Like'%" + key + "%'or TenKH Like N'%" + key+ "%'or DiaChi Like N'%" + key+ "%'or SoDienThoai Like '%" + key+"%'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
