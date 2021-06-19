using MidtermProjectWindowsProgrammingUTE.DB_Layer;
using System.Data;

namespace MidtermProjectWindowsProgrammingUTE.BS_Layer
{
    class BLUseRoom
    {
        DBMain db = null;

        public BLUseRoom()
        {
            db = new DBMain();
        }

        public DataSet GetUseRoom()
        {
            return db.ExecuteQueryDataSet("select * from ThuePhong", CommandType.Text);
        }

        public DataSet GetUseRoomCheckIn(string idroom)
        {
            return db.ExecuteQueryDataSet("select min(NgayVao) from ThuePhong Where MaPhong='" + idroom + "'", CommandType.Text);
        }

        public DataSet GetUseRoomUnpaid()
        {
            return db.ExecuteQueryDataSet("select * from ThuePhong Where TrangThai=" + 0, CommandType.Text);
        }

        public bool AddUseRoom(string MaPhong, string CMND, string NgayVao, float DatCoc, string MaNV, ref string err)
        {
            string sqlString = "Update Phong Set  TrangThai=" + 1 + "Where MaPhong ='" + MaPhong + "'";
            db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            sqlString = "Insert Into ThuePhong Values('" + MaPhong + "','" + CMND + "','" + NgayVao + "'," + DatCoc + ",'" + MaNV + "', '0')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool DeleteUseRoom(string MaPhong, ref string err)
        {
            string sqlString = "Delete From ThuePhong Where MaPhong ='" + MaPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet SearchUseRoom(string key)
        {
            string sqlString = "Select * From ThuePhong Where MaPhong Like'%" + key + "%'or CMND Like '%" + key + "%' or NgayVao Like '%" + key + "%'or NgayRa Like '%" + key + "%'or DatCoc Like '%" + key + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool UpdateUseRoom(string MaPhong, string CMND, string NgayVao, float DatCoc, string MaNV, ref string err)
        {            
            string sqlString = "Update ThuePhong Set NgayVao = '" + NgayVao + "',DatCoc=" + DatCoc + ",MaNV='" + MaNV + "',TrangThai=" + 0 + " Where MaPhong='" + MaPhong + "' and CMND='" + CMND + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool UpdateCheckInDay(string MaPhong, string NgayVao, ref string err)
        {
            string sqlString = "Update ThuePhong Set NgayVao = '" + NgayVao + "' Where MaPhong='" + MaPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool UpdateUseRoomStatus(string MaPhong, ref string err)
        {
            string sqlString = "Update ThuePhong Set TrangThai = 1 Where MaPhong='" + MaPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
