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
        public bool AddService(string MaDV, string TenDV, float GiaTien,string DonViTinh, ref string err)
        {
            string sqlString = "Insert Into DichVu Values('" + MaDV + "',N'" + TenDV + "'," + GiaTien + ",N'" + DonViTinh + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateService(string MaDV, string TenDV, float GiaTien, string DonViTinh, ref string err)
        {
            string sqlString = "Update DichVu Set TenDV=N'" + TenDV + "',GiaTien=" + GiaTien + ",DonViTinh=N'" + DonViTinh + "'Where MaDV='" + MaDV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet SearchService(string key)
        {
            string sqlString = "Select * From DichVu Where MaDV Like'%" + key + "%'or TenDV Like N'%" + key + "%' or GiaTien Like '%" + key + "%'or DonViTinh Like N'%" + key + "%'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool DeleteService(ref string err, string MaDV)
        {
            string sqlString = "Delete From DichVu Where MaDV='" + MaDV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
