using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MidtermProjectWindowsProgrammingUTE.BS_Layer;
namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmPurchase : Form
    {
        #region properties
        DataTable dtPurchase = null;
        DataTable dtRoom = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLPurchase dbPurchase = new BLPurchase();
        BLRoom dbRoom = new BLRoom();
        #endregion

        #region constructor
        public FrmPurchase()
        {
            InitializeComponent();
        }

        private void FrmPurchase_Load(object sender, EventArgs e)
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
            this.txtPurchaseID.ResetText();
            this.txtTotal.ResetText();
            this.cmbRoomID.ResetText();
            this.dtpPurchaseDate.ResetText();
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
                    BLPurchase blPurchase = new BLPurchase();
                    blPurchase.AddPurchase(this.txtPurchaseID.Text,decimal.Parse(this.txtTotal.Text), this.dtpPurchaseDate.Text, this.cmbRoomID.SelectedValue.ToString(), ref err);
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
                BLPurchase blPurchase = new BLPurchase();
                blPurchase.UpdatePurchase(this.txtPurchaseID.Text, decimal.Parse(this.txtTotal.Text), this.dtpPurchaseDate.Text, this.cmbRoomID.SelectedValue.ToString(), ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void dgvPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r = dgvPurchase.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtPurchaseID.Text =
                dgvPurchase.Rows[r].Cells[0].Value.ToString();
                this.txtTotal.Text =
                dgvPurchase.Rows[r].Cells[1].Value.ToString();
                this.dtpPurchaseDate.Text =
                dgvPurchase.Rows[r].Cells[2].Value.ToString();
                this.cmbRoomID.Text =
                dgvPurchase.Rows[r].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Không load được dữ liệu lên bảng");
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
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

            // Đưa con trỏ đến TextField txtPurchase
            this.txtPurchaseID.Enabled = false;
            this.cmbRoomID.Focus();
        }

        private void pbBill_Click(object sender, EventArgs e)
        {
            // Lấy thứ tự record hiện hành 
            int r =dgvPurchase.CurrentCell.RowIndex;
            // Lấy MaPhong của record hiện hành 
            string str = dgvPurchase.Rows[r].Cells[3].Value.ToString();
            decimal Total = dbPurchase.Bill(str);

            //Hiển thị số tiền phải thanh toán lên màn hình
            MessageBox.Show( Total.ToString());
            
            //Thực hiện lệnh
            dbPurchase.UpdatePurchase(this.txtPurchaseID.Text, Total, this.dtpPurchaseDate.Text, this.cmbRoomID.SelectedValue.ToString(), ref err);
            // Load lại dữ liệu trên DataGridView
            LoadData();
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtPurchaseID.ResetText();
            this.txtTotal.ResetText();
            this.cmbRoomID.ResetText();
            this.dtpPurchaseDate.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.pbAdd.Enabled = true;
            this.pbEdit.Enabled = true;
            this.pbBack.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.pbSave.Hide();
            this.pbCancel.Hide();
            this.pbSave.Enabled = false;
            this.pbCancel.Enabled = false;
            // Không cho thao tác trên các ô thông tin
            this.pnInfor.Enabled = false;
            dgvPurchase_CellClick(null, null);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        #endregion

        #region Other Events
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        #endregion

        #region Functions
        void LoadData()
        {
            try
            {
                dtPurchase = new DataTable();
                dtRoom = new DataTable();
                dtPurchase.Clear();
                dtRoom.Clear();
                DataSet ds = dbPurchase.GetPurchase();
                DataSet dsroom = dbRoom.GetRoom();
                dtPurchase = ds.Tables[0];
                dtRoom = dsroom.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvPurchase.DataSource = dtPurchase;
                // Thay đổi độ rộng cột
                dgvPurchase.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtPurchaseID.ResetText();
                this.cmbRoomID.ResetText();
                this.txtTotal.ResetText();
                this.dtpPurchaseDate.ResetText();
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
                this.pbBack.Enabled = true;
                //Đưa dữ liệu mã phòng lên combobox
                this.cmbRoomID.DataSource = dtRoom;
                this.cmbRoomID.DisplayMember = dtRoom.Columns[0].ToString();
                this.cmbRoomID.ValueMember = dtRoom.Columns[0].ToString();

                dgvPurchase_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot get data from table 'ThanhToan' !");
            }
        }
        private void Search()
        {
            if (this.txtFind.Text == "")
            {
                LoadData();
            }
            else
            {
                dtPurchase = new DataTable();
                dtPurchase.Clear();
                string key = this.txtFind.Text;
                DataSet dsPurchase = dbPurchase.SearchPurchase(key);
                dtPurchase = dsPurchase.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvPurchase.DataSource = dtPurchase;
                // Thay đổi độ rộng cột
                dgvPurchase.AutoResizeColumns();
            }
        }
        #endregion
    }
}
