using MidtermProjectWindowsProgrammingUTE.BS_Layer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmRoom : Form
    {
        #region Properties
        DataTable dtRoom = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLRoom dbRoom = new BLRoom();
        #endregion

        #region Constructors
        public FrmRoom()
        {
            InitializeComponent();
        }
        private void FrmRoom_Load(object sender, EventArgs e)
        {
            this.cbStatusSearch.SelectedIndex = 0;
            LoadData();
        }
        #endregion

        #region Events Click
        private void pbAdd_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtRoomID.ResetText();
            this.txtRoomType.ResetText();
            this.txtArea.ResetText();
            this.txtNote.ResetText();
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
            // Đưa con trỏ đến TextField txtRoomID
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
                    blRoom.AddRoom(this.txtRoomID.Text, this.txtRoomType.Text, this.cbStatus.Checked.ToString(), this.txtNote.Text, this.txtArea.Text, float.Parse(this.txtPrice.Text), ref err);
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
                blRoom.UpdateRoom(this.txtRoomID.Text, this.txtRoomType.Text, this.cbStatus.Checked.ToString(), this.txtNote.Text, this.txtArea.Text, float.Parse(this.txtPrice.Text), ref err);
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
            this.txtRoomID.Text = dgvRoom.Rows[r].Cells["RoomID"].Value.ToString();
            this.txtRoomType.Text = dgvRoom.Rows[r].Cells["RoomType"].Value.ToString();
            this.cbStatus.Checked = Convert.ToBoolean(dgvRoom.Rows[r].Cells["Used"].Value);
            this.txtNote.Text = dgvRoom.Rows[r].Cells["Note"].Value.ToString();
            this.txtArea.Text = dgvRoom.Rows[r].Cells["Area"].Value.ToString();
            this.txtPrice.Text = dgvRoom.Rows[r].Cells["Price"].Value.ToString();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUseRoom_Click(object sender, EventArgs e)
        {
            FrmUseRoom f = new FrmUseRoom();
            f.ShowDialog();
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtRoomID.ResetText();
            this.txtRoomType.ResetText();
            this.txtArea.ResetText();
            this.txtPrice.ResetText();
            this.txtNote.ResetText();
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
            this.txtRoomID.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Events Mouse
        private void pbAdd_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged("add_blue.png", this.pbAdd);
        }

        private void pbAdd_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged("add.png", this.pbAdd);
        }

        private void pbEdit_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged("edit_blue.png", this.pbEdit);
        }

        private void pbEdit_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged("edit.png", this.pbEdit);
        }

        private void pbDelete_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged("delete_blue.png", this.pbDelete);
        }

        private void pbDelete_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged("delete.png", this.pbDelete);
        }

        private void pbSave_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged("save_blue.png", this.pbSave);
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged("save.png", this.pbSave);
        }

        private void pbCancel_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged("cancel_blue.png", this.pbCancel);
        }

        private void pbCancel_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged("cancel.png", this.pbCancel);
        }
        #endregion

        #region Other Events
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbStatusSearch.Focus();
            Search();
        }
        #endregion

        #region Functions
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
                this.txtArea.ResetText();
                this.txtNote.ResetText();
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
                MessageBox.Show("Cannot get data from table 'Phong' !");
            }
        }

        private void Search()
        {
            int Status = this.cbStatusSearch.SelectedIndex - 1;

            if (this.txtFind.Text == "" && Status == -1)
            {
                LoadData();
            }
            else
            {
                dtRoom = new DataTable();
                dtRoom.Clear();
                string key = this.txtFind.Text;
                DataSet dscroom = dbRoom.SearchRoom(key, Status);
                dtRoom = dscroom.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvRoom.DataSource = dtRoom;
                // Thay đổi độ rộng cột
                dgvRoom.AutoResizeColumns();
            }
        }

        private void ButtonColorChanged(string picture, PictureBox pb)
        {
            pb.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Images\\" + picture);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        #endregion
    }
}
