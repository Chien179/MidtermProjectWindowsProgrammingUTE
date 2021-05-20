using System.Data;
using MidtermProjectWindowsProgrammingUTE.DB_Layer;

namespace MidtermProjectWindowsProgrammingUTE.BS_Layer
{
    class BLRoom
    {
        DBMain db = null;
        public BLRoom()
        {
            db = new DBMain();
        }
        public DataSet GetRoom()
        {
            return db.ExecuteQueryDataSet("select * from Phong", CommandType.Text);
        }
        public bool AddRoom(string MaPhong, string MaLoai, bool TrangThai, ref string err)
        {
            string sqlString = "Insert Into Phong Values('" + MaPhong + "','" + MaLoai + "'," + TrangThai +  ")" ;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateRoom(string MaPhong, string MaLoai, bool TrangThai, ref string err)
        {
            string sqlString = "Update Phong Set MaLoai='" + MaLoai + "',TrangThai=" + TrangThai + "Where='" + MaPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
