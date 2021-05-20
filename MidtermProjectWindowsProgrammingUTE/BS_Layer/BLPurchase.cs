using MidtermProjectWindowsProgrammingUTE.DB_Layer;
using System.Data;

namespace MidtermProjectWindowsProgrammingUTE.BS_Layer
{
    class BLPurchase
    {
        DBMain db = null;
        public BLPurchase()
        {
            db = new DBMain();
        }
        public DataSet GetPurchase()
        {
            return db.ExecuteQueryDataSet("select * from ThanhToan", CommandType.Text);
        }
        public bool AddPurchase(string MaTT, float ThanhTien, string NgayThanhToan, string MaPhong, ref string err)
        {
            string sqlString = "Insert Into ThanhToan Values('" + MaTT + "'," + ThanhTien + ",'" + NgayThanhToan + "','" + MaPhong + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdatePurchase(string MaTT, float ThanhTien, string NgayThanhToan, string MaPhong, ref string err)
        {
            string sqlString = "Update ThanhToan Set ThanhTien=" + ThanhTien + ",NgayThanhToan='" + NgayThanhToan + "',MaPhong='" + MaPhong + "'Where MaThanhToan='" + MaTT + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
