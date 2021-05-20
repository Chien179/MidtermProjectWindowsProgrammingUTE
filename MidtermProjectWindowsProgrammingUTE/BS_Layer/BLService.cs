using System.Data;
using MidtermProjectWindowsProgrammingUTE.DB_Layer;

namespace MidtermProjectWindowsProgrammingUTE.BS_Layer
{
    class BLService
    {
        DBMain db = null;
        public BLService()
        {
            db = new DBMain();
        }
        public DataSet GetService()
        {
            return db.ExecuteQueryDataSet("select * from DichVu", CommandType.Text);
        }
        public bool AddService(string MaDV, string TenDV, float GiaTien, ref string err)
        {
            string sqlString = "Insert Into DichVu Values('" + MaDV + "','" + TenDV + "'," + GiaTien + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateService(string MaDV, string TenDV, float GiaTien, ref string err)
        {
            string sqlString = "Update DichVu Set TenDV='" + TenDV + "',GiaTien=" + GiaTien + "Where MaDV='" + MaDV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
