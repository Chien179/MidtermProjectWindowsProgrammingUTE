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

        public bool AddPurchase(string MaTT, decimal ThanhTien, string NgayThanhToan, string MaPhong, ref string err)
        {
            string sqlString = "Insert Into ThanhToan Values('" + MaTT + "'," + ThanhTien + ",'" + NgayThanhToan + "','" + MaPhong + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdatePurchase(string MaTT, decimal ThanhTien, string NgayThanhToan, string MaPhong, ref string err)
        {
            string sqlString = "Update ThanhToan Set ThanhTien=" + ThanhTien + ",NgayThanhToan='" + NgayThanhToan + "',MaPhong='" + MaPhong + "'Where MaThanhToan='" + MaTT + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public decimal Bill(string MaPhong)
        {
            decimal Bill = 0,RoomValue=0,Total=0,Deposit=0;

            DataSet SoNgay = db.ExecuteQueryDataSet("Select Max(DateDiff(Day,NgayVao,NgayRa)),Max(Datcoc) From ThuePhong Where MaPhong='" + MaPhong + "'", CommandType.Text);
            DataSet GiaThue = db.ExecuteQueryDataSet("Select GiaThue From Phong Where MaPhong='" + MaPhong + "'", CommandType.Text);
            DataSet MaDV = db.ExecuteQueryDataSet("Select MaDV,SoLuong From SuDungDichVu Where MaPhong='" + MaPhong + "'", CommandType.Text);
            string[] AMaDV = new string[MaDV.Tables[0].Rows.Count];
            string[] ASoLuong = new string[MaDV.Tables[0].Rows.Count];
            string[] AGiaTien = new string[MaDV.Tables[0].Rows.Count];

            //Lưu MaDV và SoLuong vào string[] AMaDV và ASoLuong
            for (int i = 0; i < MaDV.Tables[0].Rows.Count; i++)
            {
                AMaDV[i] = MaDV.Tables[0].Rows[i][0].ToString();
                ASoLuong[i] = MaDV.Tables[0].Rows[i][1].ToString();
            }

            //Lấy giá dịch vụ và lưu GiaTien vào string[] AGiaTien
            for (int i = 0; i < MaDV.Tables[0].Rows.Count; i++)
            {
                DataSet GiaTien = db.ExecuteQueryDataSet("Select GiaTien From DichVu Where MaDV='" + AMaDV[i] + "'", CommandType.Text);
                string temp = GiaTien.Tables[0].Rows[0][0].ToString();
                AGiaTien[i] = temp;
            }

            //Tính tiền
            for (int i = 0; i < MaDV.Tables[0].Rows.Count; i++)
            {
                Bill += decimal.Parse(AGiaTien[i]) * decimal.Parse(ASoLuong[i]);
            }

            RoomValue = decimal.Parse(GiaThue.Tables[0].Rows[0][0].ToString()) * decimal.Parse(SoNgay.Tables[0].Rows[0][0].ToString());
            Deposit = decimal.Parse(SoNgay.Tables[0].Rows[0][1].ToString());
            Total = Bill + RoomValue - Deposit;

            return Total;
        }

        public DataSet SearchPurchase(string key)
        {
            string sqlString = "Select * From ThanhToan Where MaThanhToan Like'%" + key + "%'or ThanhTien Like '%" + key + "%' or NgayThanhToan Like '%" + key + "%'or MaPhong Like '%" + key + "%'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
