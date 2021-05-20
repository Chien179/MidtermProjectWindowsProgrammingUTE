using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MidtermProjectWindowsProgrammingUTE.BS_Layer;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmRoom : Form
    {
        public FrmRoom()
        {
            InitializeComponent();
        }
        private void FrmRoom_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        DataTable dtRoom = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLRoom dbRoom = new BLRoom();       
        void LoadData()
        {
            try
            {
                dtRoom = new DataTable();
                dtRoom.Clear();
                DataSet ds = dbRoom.GetRoom();
                dtRoom = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvRoom.DataSource = dtRoom;
                // Thay đổi độ rộng cột
                dgvRoom.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtRoomID.ResetText();
                this.txtRoomType.ResetText();

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
                dgvRoom_CellClick(null, null);
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
            this.txtRoomID.ResetText();
            this.txtRoomType.ResetText();
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
            this.txtRoomID.Focus();
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
                    BLRoom blRoom = new BLRoom();
                    blRoom.AddRoom(this.txtRoomID.Text, this.txtRoomType.Text, true, ref err);
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
                BLRoom blRoom = new BLRoom();
                blRoom.UpdateRoom(this.txtRoomID.Text, this.txtRoomType.Text, true, ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvRoom.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtRoomID.Text =
            dgvRoom.Rows[r].Cells[0].Value.ToString();
            this.txtRoomType.Text =
            dgvRoom.Rows[r].Cells[1].Value.ToString();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            f.Show();
            this.Hide();
        }
    }
}
