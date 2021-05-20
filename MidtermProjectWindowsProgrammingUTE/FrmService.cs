using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MidtermProjectWindowsProgrammingUTE.BS_Layer;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmService : Form
    {
        public FrmService()
        {
            InitializeComponent();
        }

        private void FrmService_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        DataTable dtService = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLService dbService = new BLService();
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
                //this.pbCancel.Enabled = false;
                //this.panel.Enabled = false;

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
                MessageBox.Show("Cannot get data from table 'Phong' !");
            }
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtServiceID.ResetText();
            this.txtServiceName.ResetText();
            this.txtPrice.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.pbSave.Enabled = true;
            //this.btnHuyBo.Enabled = true;
            //this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.pbAdd.Enabled = false;
            this.pbEdit.Enabled = false;
            this.pbDelete.Enabled = false;
            //this.pbExit.Enabled = false;

            // Đưa con trỏ đến TextField txtRoom
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
                blService.AddService(this.txtServiceID.Text, this.txtServiceName.Text, float.Parse(this.txtPrice.Text), ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }






        

        private void pbBack_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            f.Show();
            this.Hide();
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
    }
}
