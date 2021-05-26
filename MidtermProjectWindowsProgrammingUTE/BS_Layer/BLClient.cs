using System.Data;
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

        public bool AddClient(string CMND, string TenKhachHang, string DiaChi, string SoDienThoai, string GioiTinh,string NgaySinh, ref string err)
        {
            string sqlString = "Insert Into KhachHang Values(" + "'" + CMND + "',N'" + TenKhachHang + "',N'" + DiaChi + "','" + SoDienThoai + "','" + GioiTinh + "','" + NgaySinh + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool UpdateClient(string CMND, string TenKhachHang, string DiaChi, string SoDienThoai, string GioiTinh, string NgaySinh, ref string err)
        {
            string sqlString = "Update KhachHang Set TenKH=N'" + TenKhachHang + "',DiaChi=N'" + DiaChi + "',SoDienThoai='" + SoDienThoai + "',NgaySinh='" + NgaySinh + "',Nu='" + GioiTinh + "'Where CMND='" + CMND + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet SearchClient(string key,int Sex)
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
