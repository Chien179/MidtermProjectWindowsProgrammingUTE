using System.Data;
using MidtermProjectWindowsProgrammingUTE.DB_Layer;

namespace MidtermProjectWindowsProgrammingUTE.BS_Layer
{
    class BLStaff
    {
        DBMain db = null;

        public BLStaff()
        {
            db = new DBMain();
        }

        public DataSet GetStaff()
        {
            return db.ExecuteQueryDataSet("select * from NhanVien", CommandType.Text);
        }

        public bool AddStaff(string CMND, string TenKhachHang, string DiaChi, string GioiTinh, string NgaySinh, ref string err)
        {
            string sqlString = "Insert Into KhachHang Values(" + "'" + CMND + "',N'" + TenKhachHang + "',N'" + DiaChi + "','" + GioiTinh + "','" + NgaySinh + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool UpdateStaff(string CMND, string TenKhachHang, string DiaChi, string GioiTinh, string NgaySinh, ref string err)
        {
            string sqlString = "Update KhachHang Set TenKH=N'" + TenKhachHang + "',DiaChi=N'" + DiaChi  + "',NgaySinh='" + NgaySinh + "',Nu='" + GioiTinh + "'Where CMND='" + CMND + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool DeleteStaff(ref string err, string CMND)
        {
            string sqlString = "Delete From KhachHang Where CMND='" + CMND + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet SearchStaff(string key, int Sex)
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
