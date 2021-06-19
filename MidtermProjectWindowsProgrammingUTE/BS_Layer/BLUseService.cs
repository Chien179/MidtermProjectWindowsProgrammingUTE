using MidtermProjectWindowsProgrammingUTE.DB_Layer;
using System.Data;

namespace MidtermProjectWindowsProgrammingUTE.BS_Layer
{
    class BLUseService
    {
        DBMain db = null;

        public BLUseService()
        {
            db = new DBMain();
        }

        public DataSet GetUseService()
        {
            return db.ExecuteQueryDataSet("select * from SuDungDichVu", CommandType.Text);
        }

        public bool AddUseService(string MaPhong, string MaDV, string NgaySuDung, int SoLuong, ref string err)
        {
            string sqlString = "Insert Into SuDungDichVu Values('" + MaPhong + "','" + MaDV + "','" + NgaySuDung + "'," + SoLuong + ",'0')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool UpdateUseService(string MaPhong, string MaDV, string NgaySuDung, int SoLuong, ref string err)
        {
            string sqlString = "Update SuDungDichVu Set NgaySuDung = '" + NgaySuDung + "',SoLuong=" + SoLuong + ",TrangThai='0'" + "Where MaPhong='" + MaPhong + "' and MaDV='" + MaDV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool UpdateStatusUseService(string MaPhong, ref string err)
        {
            string sqlString = "Update SuDungDichVu Set TrangThai = 1 Where MaPhong='" + MaPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool DeleteUseService(string MaPhong, ref string err)
        {
            string sqlString = "Delete From SuDungDichVu Where MaPhong ='" + MaPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet SearchUseService(string key)
        {
            string sqlString = "Select * From SuDungDichVu Where MaPhong Like'%" + key + "%'or MaDV Like '%" + key + "%' or NgaySuDung Like '%" + key + "%'or SoLuong Like '%" + key + "%'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
