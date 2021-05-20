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
        public DataSet GetUseSerVice()
        {
            return db.ExecuteQueryDataSet("select * from SuDungDichVu", CommandType.Text);
        }
        public bool AddUseSerVice(string MaPhong, string MaDV, string NgaySuDung, string SoLuong, ref string err)
        {
            string sqlString = "Insert Into SuDungDichVu Values('" + MaPhong + "','" + MaDV + "','" + NgaySuDung + "','" + SoLuong + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateUseSerVice(string MaPhong, string MaDV, string NgaySuDung, string SoLuong, ref string err)
        {
            string sqlString = "Update  Set NgaySuDung = '" +NgaySuDung + "',SoLuong='" + SoLuong + "Where MaPhong='" + MaPhong + "' and MaDV='" + MaDV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
