using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MidtermProjectWindowsProgrammingUTE.BS_Layer;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmService : Form
    {
        #region Properties
        DataTable dtService = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLService dbService = new BLService();
        #endregion

        #region Constructors
        public FrmService()
        {
            InitializeComponent();
        }

        private void FrmService_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        #endregion

        #region Events Click
        private void pbAdd_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtServiceID.ResetText();
            this.txtServiceName.ResetText();
            this.txtPrice.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.pbSave.Show();
            this.pbCancel.Show();
            this.pbSave.Enabled = true;
            this.pbCancel.Enabled = true;
            this.pnInfor.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.pbAdd.Enabled = false;
            this.pbEdit.Enabled = false;
            this.pbBack.Enabled = false;
            this.pbDelete.Enabled = false;
            // Đưa con trỏ đến TextField txtServiceID
            this.txtServiceID.Focus();
        }

        private void pbSave_Click(object sender, EventArgs e)
        {

            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {

                try
                {
                    // Thực hiện lệnh
                    BLService blService = new BLService();
                    blService.AddService(this.txtServiceID.Text, this.txtServiceName.Text, float.Parse(this.txtPrice.Text), ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLService blService = new BLService();
                blService.UpdateService(this.txtServiceID.Text, this.txtServiceName.Text, float.Parse(this.txtPrice.Text), ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }
        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvService.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtServiceID.Text =
            dgvService.Rows[r].Cells[0].Value.ToString();
            this.txtServiceName.Text =
            dgvService.Rows[r].Cells[1].Value.ToString();
            this.txtPrice.Text =
            dgvService.Rows[r].Cells[2].Value.ToString();
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = false;
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.pbSave.Show();
            this.pbCancel.Show();
            this.pbSave.Enabled = true;
            this.pbCancel.Enabled = true;
            this.pnInfor.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.pbAdd.Enabled = false;
            this.pbEdit.Enabled = false;
            this.pbBack.Enabled = false;
            this.pbDelete.Enabled = false;
            //
            this.txtServiceID.Enabled = false;
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtServiceID.ResetText();
            this.txtServiceName.ResetText();
            this.txtPrice.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.pbAdd.Enabled = true;
            this.pbEdit.Enabled = true;
            this.pbBack.Enabled = true;
            this.pbDelete.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.pbSave.Hide();
            this.pbCancel.Hide();
            this.pbSave.Enabled = false;
            this.pbCancel.Enabled = false;
            // Không cho thao tác trên các ô thông tin
            this.pnInfor.Enabled = false;
            dgvService_CellClick(null, null);
        }
        #endregion

        #region Functions
        void LoadData()
        {
            try
            {
                dtService = new DataTable();
                dtService.Clear();
                DataSet ds = dbService.GetService();
                dtService = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvService.DataSource = dtService;
                // Thay đổi độ rộng cột
                dgvService.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtServiceID.ResetText();
                this.txtServiceName.ResetText();
                this.txtPrice.ResetText();


                // Không cho thao tác trên các nút Lưu / Hủy
                this.pbSave.Enabled = false;
                this.pbCancel.Enabled = false;
                this.pbSave.Hide();
                this.pbCancel.Hide();
                // Không cho thao tác trên các ô thông tin
                this.pnInfor.Enabled = false;

                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.pbAdd.Enabled = true;
                this.pbEdit.Enabled = true;
                this.pbDelete.Enabled = true;
                this.pbBack.Enabled = true;
                //
                dgvService_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot get data from table 'Service' !");
            }
        }

        #endregion
    }
}
