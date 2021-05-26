using System.Data;
using MidtermProjectWindowsProgrammingUTE.DB_Layer;

namespace MidtermProjectWindowsProgrammingUTE.BS_Layer
{
    class BLRoom
    {
        DBMain db = null;
        public BLRoom()
        {
            db = new DBMain();
        }
        public DataSet GetRoom()
        {
            return db.ExecuteQueryDataSet("select * from Phong", CommandType.Text);
        }
        public bool AddRoom(string MaPhong, string MaLoai, string TrangThai, string GhiChu, string DienTich, float GiaThue, ref string err)
        {
            string sqlString = "Insert Into Phong Values('" + MaPhong + "','" + MaLoai + "','" + TrangThai + "','" + GhiChu + "','" + DienTich + "'," + GiaThue + ")" ;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateRoom(string MaPhong, string MaLoai, string TrangThai, string GhiChu, string DienTich, float GiaThue, ref string err)
        {
            string sqlString = "Update Phong Set MaLoai='" + MaLoai + "',TrangThai='" + TrangThai + "',GhiChu='" + GhiChu + "',DienTich='" + DienTich + "',GiaThue=" + GiaThue + "Where MaPhong='" + MaPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet SearchRoom(string key, int Status)
        {
            string sqlString = "Select * From Phong Where TrangThai =" + Status + "and (MaPhong Like'%" + key + "%'or MaLoai Like N'%" + key + "%'or GhiChu Like N'%" + key + "%'or DienTich Like '%" + key + "%' or GiaThue Like '%" + key + "%')";
            if (Status == -1)
            {
                sqlString = "Select * From Phong Where MaPhong Like'%" + key + "%'or MaLoai Like N'%" + key + "%'or GhiChu Like N'%" + key + "%'or DienTich Like '%" + key + "%' or GiaThue Like '%" + key + "%'";
            }
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
