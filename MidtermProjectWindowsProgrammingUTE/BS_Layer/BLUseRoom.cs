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
        public bool AddUseRoom(string MaPhong, string CMND, string NgayVao, string NgayRa, float DatCoc, ref string err)
        {
            string sqlString = "Insert Into ThuePhong Values('" + MaPhong + "','" + CMND + "','" + NgayVao + "','" + NgayRa + "'," + DatCoc + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateUseRoom(string MaPhong, string CMND, string NgayVao, string NgayRa, float DatCoc, ref string err)
        {
            string sqlString = "Update ThuePhong Set NgayVao = '" + NgayVao + "',NgayRa='" + NgayRa + "',DatCoc=" + DatCoc +  "Where MaPhong='" + MaPhong + "' and CMND='" + CMND + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
