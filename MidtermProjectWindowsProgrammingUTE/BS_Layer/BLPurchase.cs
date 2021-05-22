﻿using MidtermProjectWindowsProgrammingUTE.DB_Layer;
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

        public float Bill(string MaPhong)
        {
            float Bill = 0;

            DataSet Maloai = db.ExecuteQueryDataSet("Select MaLoai From Phong Where MaPhong='" + MaPhong + "'", CommandType.Text);
            DataSet MaDV = db.ExecuteQueryDataSet("Select MaDV,SoLuong From SuDungDichVu Where MaPhong='" + MaPhong + "'", CommandType.Text);
            DataSet GiaThue = db.ExecuteQueryDataSet("Select GiaThue From LoaiPhong Where MaLoai='" + Maloai.Tables[0].Rows[0][0].ToString() + "'", CommandType.Text);
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
                Bill += float.Parse(AGiaTien[i]) * float.Parse(ASoLuong[i]);
            }

            return Bill + float.Parse(GiaThue.Tables[0].Rows[0][0].ToString());
        }
    }
}
