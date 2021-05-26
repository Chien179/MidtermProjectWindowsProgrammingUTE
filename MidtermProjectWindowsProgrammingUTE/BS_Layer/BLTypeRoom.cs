using MidtermProjectWindowsProgrammingUTE.DB_Layer;
using System.Data;

namespace MidtermProjectWindowsProgrammingUTE.BS_Layer
{
    class BLTypeRoom
    {
        DBMain db = null;

        public BLTypeRoom()
        {
            db = new DBMain();
        }

        public DataSet GetTypeRoom()
        {
            return db.ExecuteQueryDataSet("select * from LoaiPhong", CommandType.Text);
        }

        public bool AddTypeRoom(string MaLoai, string TenLoai,  ref string err)
        {
            string sqlString = "Insert Into LoaiPhong Values('" + MaLoai + "','" + TenLoai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool UpdateTypeRoom(string MaLoai, string TenLoai,  ref string err)
        {
            string sqlString = "Update LoaiPhong Set TenLoai = '" + TenLoai +   "'Where MaLoai='" + MaLoai + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet SearchTypeRoom(string key)
        {
            string sqlString = "Select * From LoaiPhong Where MaLoai Like'%" + key + "%'or TenLoai Like '%" + key + "%'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool DeleteTypeRoom(ref string err, string MaLoai)
        {
            string sqlString = "Delete From LoaiPhong Where MaLoai='" + MaLoai + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
