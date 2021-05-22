using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MidtermProjectWindowsProgrammingUTE.BS_Layer;
using System.IO;
using System.Drawing;
namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmTypeRoom : Form
    {
        #region Properties
        DataTable dtTypeRoom = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLTypeRoom dbTypeRoom = new BLTypeRoom();
        #endregion

        #region Constructors
        public FrmTypeRoom()
        {
            InitializeComponent();
        }

        private void FrmTypeRoom_Load(object sender, EventArgs e)
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
            this.txtRoomType.ResetText();
            this.txtNameType.ResetText();
            this.txtArea.ResetText();
            this.cmbNote.ResetText();
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
            // Đưa con trỏ đến TextField txtRoomType
            this.txtRoomType.Focus();
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
                    BLTypeRoom blTypeRoom = new BLTypeRoom();
                    blTypeRoom.AddTypeRoom(this.txtRoomType.Text, this.txtNameType.Text, this.cmbNote.Text,this.txtArea.Text, float.Parse(this.txtPrice.Text), ref err);
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
                BLTypeRoom blTypeRoom = new BLTypeRoom();
                blTypeRoom.UpdateTypeRoom(this.txtRoomType.Text, this.txtNameType.Text, this.cmbNote.Text, this.txtArea.Text, float.Parse(this.txtPrice.Text), ref err);
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

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvRoom.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtRoomType.Text =
            dgvRoom.Rows[r].Cells[0].Value.ToString();
            this.txtNameType.Text =
            dgvRoom.Rows[r].Cells[1].Value.ToString();
            this.txtArea.Text =
            dgvRoom.Rows[r].Cells[2].Value.ToString();
            this.cmbNote.Text =
            dgvRoom.Rows[r].Cells[3].Value.ToString(); 
            this.txtPrice.Text =
             dgvRoom.Rows[r].Cells[4].Value.ToString();

        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtArea.ResetText();
            this.txtNameType.ResetText();
            this.txtPrice.ResetText();
            this.txtRoomType.ResetText();
            this.cmbNote.ResetText();
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
            dgvRoom_CellClick(null, null);
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
            this.txtRoomType.Enabled = false;
        }
        #endregion

        #region Functions
        void LoadData()
        {
            try
            {
                dtTypeRoom = new DataTable();
                dtTypeRoom.Clear();
                DataSet ds = dbTypeRoom.GetTypeRoom();
                dtTypeRoom = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvRoom.DataSource = dtTypeRoom;
                // Thay đổi độ rộng cột
                dgvRoom.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtRoomType.ResetText();
                this.txtNameType.ResetText();
                this.txtArea.ResetText();
                this.cmbNote.ResetText();
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
                dgvRoom_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot get data from table 'LoaiPhong' !");
            }
        }
        #endregion
    }
}
