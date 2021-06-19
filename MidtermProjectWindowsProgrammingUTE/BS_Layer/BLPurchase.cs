using MidtermProjectWindowsProgrammingUTE.DB_Layer;
using System;
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

        public bool AddPurchase(string MaTT, decimal ThanhTien, string NgayThanhToan, string MaPhong, string MaNV, string TrangThai, ref string err)
        {
            string sqlString = "Insert Into ThanhToan Values('" + MaTT + "'," + ThanhTien + ",'" + NgayThanhToan + "','" + MaPhong + "','" + MaNV + "','" + TrangThai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdatePurchase(string MaTT, decimal ThanhTien, string NgayThanhToan, string MaPhong, string MaNV, ref string err)
        {
            string sqlString = "Update ThanhToan Set ThanhTien=" + ThanhTien + ",NgayThanhToan='" + NgayThanhToan + "',MaPhong='" + MaPhong + "', MaNV='" + MaNV + "', TrangThai='0'" + "Where MaThanhToan='" + MaTT + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet SearchPurchase(string key)
        {
            string sqlString = "Select * From ThanhToan Where MaThanhToan Like'%" + key + "%'or ThanhTien Like '%" + key + "%' or NgayThanhToan Like '%" + key + "%'or MaPhong Like '%" + key + "%'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool DeletePurchase(ref string err, string MaTT)
        {
            string sqlString = "Delete From ThanhToan Where MaThanhToan='" + MaTT + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public decimal Bill(ref string err, string MaPhong, string NgayThanhToan)
        {
            try
            {
                decimal Bill = 0, RoomValue = 0, Total = 0, Deposit = 0, DateStay = 0;

                DataSet thongtinthanhtoan = db.ExecuteQueryDataSet("select Min(ThuePhong.NgayVao),MAX(ThuePhong.DatCoc),Phong.GiaThue "
                    + "from ThuePhong, Phong "
                    + "where ThuePhong.MaPhong = Phong.MaPhong and ThuePhong.MaPhong='" + MaPhong + "'"
                    + "group by ThuePhong.DatCoc,Phong.GiaThue", CommandType.Text);
                DataSet MaDV = db.ExecuteQueryDataSet("Select MaDV,SoLuong From SuDungDichVu Where MaPhong='" + MaPhong + "'and TrangThai='" + 0 + "'", CommandType.Text);
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

                if (thongtinthanhtoan.Tables[0].Rows.Count > 0)
                {
                    TimeSpan day = Convert.ToDateTime(NgayThanhToan) - Convert.ToDateTime((thongtinthanhtoan.Tables[0].Rows[0][0]));
                    DateStay = day.Days;

                    RoomValue = decimal.Parse(thongtinthanhtoan.Tables[0].Rows[0][2].ToString()) * DateStay;
                    Deposit = decimal.Parse(thongtinthanhtoan.Tables[0].Rows[0][1].ToString());
                    Total = Bill + RoomValue - Deposit;
                }

                return Total;
            }
            catch
            {
                return 0;
            }
        }
    }
}
