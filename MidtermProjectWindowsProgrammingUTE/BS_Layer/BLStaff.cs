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

        public DataSet GetPositionStaff(string IDStaff)
        {
            return db.ExecuteQueryDataSet("select ChucVu from NhanVien where MaNV='"+ IDStaff +"'", CommandType.Text);
        }

        public DataSet GetStaff()
        {
            return db.ExecuteQueryDataSet("select * from NhanVien", CommandType.Text);
        }

        public bool AddStaff(string MaNV, string TenNV, string ChucVu, string NamSinh, string GioiTinh, ref string err)
        {
            string sqlString = "Insert Into NhanVien Values(" + "'" + MaNV + "',N'" + TenNV + "',N'" + ChucVu + "','" + NamSinh + "', '" + GioiTinh + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool UpdateStaff(string MaNV, string TenNV, string ChucVu, string NamSinh, string GioiTinh, ref string err)
        {
            string sqlString = "Update NhanVien Set TenNV=N'" + TenNV + "',ChucVu=N'" + ChucVu + "',NamSinh='" + NamSinh + "',Nu='" + GioiTinh + "'Where MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool DeleteStaff(ref string err, string MaNV)
        {
            string sqlString = "Delete From NhanVien Where MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet SearchStaff(string key, int Sex)
        {
            string sqlString = "Select * From NhanVien Where Nu =" + Sex + "and (MaNV Like'%" + key + "%'or TenNV Like N'%" + key + "%'or ChucVu Like N'%" + key + "%'or NamSinh Like '%" + key +"%')";
            if (Sex == -1)
            {
                sqlString = "Select * From NhanVien Where MaNV Like'%" + key + "%'or TenNV Like N'%" + key + "%'or ChucVu Like N'%" + key + "%'or NamSinh Like '%" + key + "%'";
            }
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
