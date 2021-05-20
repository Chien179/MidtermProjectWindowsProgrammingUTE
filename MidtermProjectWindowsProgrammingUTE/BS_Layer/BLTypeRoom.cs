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
        public bool AddTypeRoom(string MaLoai, string TenLoai, string GhiChu, string DienTich, float GiaThue, ref string err)
        {
            string sqlString = "Insert Into Phong Values('" + MaLoai + "','" + TenLoai + "','" + GhiChu + "','" + DienTich + "'," + GiaThue + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateTypeRoom(string MaLoai, string TenLoai, string GhiChu, string DienTich, float GiaThue, ref string err)
        {
            string sqlString = "Update Phong Set TenLoai = '" + TenLoai + "',GhiChu='" + GhiChu + "',DienTich='" + DienTich + "',GiaThue=" + GiaThue + "Where MaLoai='" + MaLoai + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
