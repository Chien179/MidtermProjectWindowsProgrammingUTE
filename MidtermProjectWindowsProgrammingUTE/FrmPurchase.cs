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

                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.pbAdd.Enabled = true;
                this.pbEdit.Enabled = true;
                this.pbDelete.Enabled = true;
                this.pbBack.Enabled = true;
                //Đưa dữ liệu mã phòng lên combobox
                this.cmbRoomID.DataSource = dtRoom;
                this.cmbRoomID.DisplayMember = dtRoom.Columns[0].ToString();
                this.cmbRoomID.ValueMember= dtRoom.Columns[0].ToString();

                dgvPurchase_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot get data from table 'ThanhToan' !");
            }
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtPurchaseID.ResetText();
            this.txtTotal.ResetText();
            this.cmbRoomID.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.pbSave.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.pbAdd.Enabled = false;
            this.pbEdit.Enabled = false;
            this.pbDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtRoom
            this.txtPurchaseID.Focus();
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
                    blPurchase.AddPurchase(this.txtPurchaseID.Text,float.Parse(this.txtTotal.Text), this.dtpPurchaseDate.Text, this.cmbRoomID.SelectedValue.ToString(), ref err);
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
                blPurchase.UpdatePurchase(this.txtPurchaseID.Text, float.Parse(this.txtTotal.Text), this.dtpPurchaseDate.Text, this.cmbRoomID.SelectedValue.ToString(), ref err);
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
            FrmMain f = new FrmMain();
            f.Show();
            this.Hide();
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            // Cho phép thao tác trên Panel 
            dgvPurchase_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.pbSave.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.pbAdd.Enabled = false;
            this.pbEdit.Enabled = false;
            this.pbDelete.Enabled = false;
            this.pbBack.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH 
            this.txtPurchaseID.Enabled = false;
            this.txtTotal.Focus();
        }
    }
}
