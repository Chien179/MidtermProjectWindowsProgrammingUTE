using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MidtermProjectWindowsProgrammingUTE.BS_Layer;
namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmClient : Form
    {
        DataTable dtClient = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLClient dbClient = new BLClient();
        public FrmClient()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtClient = new DataTable();
                dtClient.Clear();
                DataSet ds = dbClient.GetClient();
                dtClient = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvClient.DataSource = dtClient;
                // Thay đổi độ rộng cột
                dgvClient.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtID.ResetText();
                this.txtName.ResetText();
                this.txtAddress.ResetText();
                this.txtPhoneNumber.ResetText();

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
                dgvClient_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot get data from table 'KhachHang' !");
            }
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtID.ResetText();
            this.txtName.ResetText();
            this.txtAddress.ResetText();
            this.txtPhoneNumber.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.pbSave.Enabled = true;
            //this.btnHuyBo.Enabled = true;
            //this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.pbAdd.Enabled = false;
            this.pbEdit.Enabled = false;
            this.pbDelete.Enabled = false;
            //this.pbExit.Enabled = false;
           
            // Đưa con trỏ đến TextField txtThanhPho
            this.txtID.Focus();
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
                    BLClient blClient = new BLClient();
                    blClient.AddClient(this.txtID.Text, this.txtName.Text,this.txtAddress.Text, this.txtPhoneNumber.Text, ref err);
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
                BLClient blClient = new BLClient();
                blClient.UpdateClient(this.txtID.Text, this.txtName.Text, this.txtAddress.Text, this.txtPhoneNumber.Text, ref err);// Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvClient.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtID.Text =
            dgvClient.Rows[r].Cells[0].Value.ToString();
            this.txtName.Text =
            dgvClient.Rows[r].Cells[1].Value.ToString();
            this.txtAddress.Text =
            dgvClient.Rows[r].Cells[2].Value.ToString(); 
            this.txtPhoneNumber.Text =
             dgvClient.Rows[r].Cells[3].Value.ToString();
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            f.Show();
            this.Hide();
        }
    }
}
