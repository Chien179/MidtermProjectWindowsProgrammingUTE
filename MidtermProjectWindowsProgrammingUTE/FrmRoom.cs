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
        DataTable dtTypeRoom = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        bool logout = false;
        string err = "";
        BLRoom dbRoom = new BLRoom();
        BLTypeRoom dbTypeRoom = new BLTypeRoom();
        #endregion

        #region Constructors
        public FrmRoom(string TenNV)
        {
            InitializeComponent();
            this.label8.Text = TenNV;
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
            this.cmbRoomType.ResetText();
            this.txtArea.ResetText();
            this.txtNote.ResetText();
            this.txtPrice.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.pbSave.Show();
            this.pbCancel.Show();
            this.pbSave.Enabled = true;
            this.pbCancel.Enabled = true;
            this.gbInfor.Enabled = true;
            this.gbInfor.Text = "Adding";
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.pbAdd.Enabled = false;
            this.pbEdit.Enabled = false;
            this.pbBack.Enabled = false;
            this.pbDelete.Enabled = false;
            this.pbAdd.Hide();
            this.pbEdit.Hide();
            this.pbDelete.Hide();
            this.pbBack.Hide();
            // Đưa con trỏ đến TextField txtRoomID
            this.txtRoomID.Focus();
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                for (int i = 0; i < dgvRoom.Rows.Count; i++)
                {
                    if (txtRoomID.Text == dgvRoom.Rows[i].Cells["RoomID"].Value.ToString().Trim())
                    {
                        MessageBox.Show("Existed '" + txtRoomID.Text + "', please type another one !");
                        txtRoomID.ResetText();
                        txtArea.ResetText();
                        txtNote.ResetText();
                        txtPrice.ResetText();
                        txtRoomID.Focus();
                        return;
                    }
                }
                try
                {
                    // Thực hiện lệnh
                    BLRoom blRoom = new BLRoom();
                    if (this.txtRoomID.Text != "" && this.cmbRoomType.Text != "")
                    {
                        float Price = 0;
                        if (this.txtPrice.Text != "")
                        {
                            Price = float.Parse(this.txtPrice.Text);
                        }
                        blRoom.AddRoom(this.txtRoomID.Text, this.cmbRoomType.SelectedValue.ToString(), this.cbStatus.Checked.ToString(), this.txtNote.Text, this.txtArea.Text, Price, ref err);
                        
                        // Load lại dữ liệu trên DataGridView
                        LoadData();

                        // Thông báo
                        MessageBox.Show("Added successfully!");
                    }
                }
                catch (SqlException)
                {
                    this.gbInfor.Text = "Information";
                    MessageBox.Show("Cannot add data !");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLRoom blRoom = new BLRoom();
                blRoom.UpdateRoom(this.txtRoomID.Text, this.cmbRoomType.SelectedValue.ToString(), this.cbStatus.Checked.ToString(), this.txtNote.Text, this.txtArea.Text, float.Parse(this.txtPrice.Text), ref err);
                // Thông báo
                MessageBox.Show("Edited successfully!");
                // Load lại dữ liệu trên DataGridView
                LoadData();
            }
            // Đóng kết nối
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvRoom.Rows.Count > 0)
                {
                    // Thứ tự dòng hiện hành
                    int r = dgvRoom.CurrentCell.RowIndex;
                    // Chuyển thông tin lên panel
                    this.txtRoomID.Text = dgvRoom.Rows[r].Cells["RoomID"].Value.ToString();
                    this.cmbRoomType.Text = dgvRoom.Rows[r].Cells["RoomType"].Value.ToString();
                    this.cbStatus.Checked = Convert.ToBoolean(dgvRoom.Rows[r].Cells["Used"].Value);
                    this.txtNote.Text = dgvRoom.Rows[r].Cells["Note"].Value.ToString();
                    this.txtArea.Text = dgvRoom.Rows[r].Cells["Area"].Value.ToString();
                    this.txtPrice.Text = dgvRoom.Rows[r].Cells["Price"].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot load data into DataGridView !");
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtRoomID.ResetText();
            this.cmbRoomType.ResetText();
            this.txtArea.ResetText();
            this.txtPrice.ResetText();
            this.txtNote.ResetText();
            this.txtRoomID.Enabled = true;
            this.cmbRoomType.Enabled = true;
            this.txtArea.Enabled = true;
            this.txtNote.Enabled = true;
            this.txtPrice.Enabled = true;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.pbAdd.Enabled = true;
            this.pbEdit.Enabled = true;
            this.pbBack.Enabled = true;
            this.pbDelete.Enabled = true;
            this.pbAdd.Show();
            this.pbEdit.Show();
            this.pbDelete.Show();
            this.pbBack.Show();
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.pbSave.Hide();
            this.pbCancel.Hide();
            this.pbSave.Enabled = false;
            this.pbCancel.Enabled = false;
            // Không cho thao tác trên các ô thông tin
            this.gbInfor.Enabled = false;
            this.gbInfor.Text = "Information";
            dgvRoom_CellClick(null, null);
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            if (dgvRoom.Rows.Count > 0)
            {
                // Kich hoạt biến Them
                Them = false;
                // Cho thao tác trên các nút Lưu / Hủy / Panel
                this.pbSave.Show();
                this.pbCancel.Show();
                this.pbSave.Enabled = true;
                this.pbCancel.Enabled = true;
                this.gbInfor.Enabled = true;
                this.gbInfor.Text = "Editing";
                // Không cho thao tác trên các nút Thêm / Xóa / Thoát
                this.pbAdd.Enabled = false;
                this.pbEdit.Enabled = false;
                this.pbBack.Enabled = false;
                this.pbDelete.Enabled = false;
                this.pbAdd.Hide();
                this.pbEdit.Hide();
                this.pbDelete.Hide();
                this.pbBack.Hide();
                //
                this.txtRoomID.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoom.Rows.Count > 0)
                {
                    // Thực hiện lệnh 
                    // Lấy thứ tự record hiện hành 
                    int r = dgvRoom.CurrentCell.RowIndex;
                    // Lấy MaKH của record hiện hành 
                    string strRoomID = dgvRoom.Rows[r].Cells[0].Value.ToString();
                    // Viết câu lệnh SQL 
                    // Hiện thông báo xác nhận việc xóa mẫu tin 
                    // Khai báo biến traloi 
                    DialogResult traloi;
                    // Hiện hộp thoại hỏi đáp 
                    traloi = MessageBox.Show("Are you sure?", "Delete row",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // Kiểm tra có nhắp chọn nút Ok không? 
                    if (traloi == DialogResult.Yes)
                    {
                        dbRoom.DeleteRoom(ref err, strRoomID);
                        if (err == "")
                        {
                            // Thông báo 
                            MessageBox.Show("Deleted successfully!");
                            // Cập nhật lại DataGridView 
                            LoadData();
                        }
                        else
                        {
                            this.gbInfor.Text = "Information";
                            // Thông báo 
                            MessageBox.Show("Room currently in use !", "Delete failed!");
                        }
                    }
                    else
                    {
                        this.gbInfor.Text = "Information";
                        // Thông báo 
                        MessageBox.Show("Delete failed!");
                    }
                }
            }
            catch (SqlException)
            {
                this.gbInfor.Text = "Information";
                MessageBox.Show("Delete failed!");
            }
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

        private void pbBack_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged("back_blue.png", this.pbBack);
        }

        private void pbBack_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged("back.png", this.pbBack);
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

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Functions
        void LoadData()
        {
            try
            {
                dtRoom = new DataTable();
                dtRoom.Clear();

                dtTypeRoom = new DataTable();
                dtTypeRoom.Clear();

                DataSet dsTypeRoom = dbTypeRoom.GetTypeRoom();
                DataSet ds = dbRoom.GetRoom();

                dtTypeRoom = dsTypeRoom.Tables[0];
                dtRoom = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvRoom.DataSource = dtRoom;
                // Thay đổi độ rộng cột
                dgvRoom.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtRoomID.ResetText();
                this.cmbRoomType.ResetText();
                this.txtArea.ResetText();
                this.txtNote.ResetText();
                this.txtPrice.ResetText();
                this.txtRoomID.Enabled = true;
                this.cmbRoomType.Enabled = true;
                this.txtArea.Enabled = true;
                this.txtNote.Enabled = true;
                this.txtPrice.Enabled = true;
                // Không cho thao tác trên các nút Lưu / Hủy
                this.pbSave.Enabled = false;
                this.pbCancel.Enabled = false;
                this.pbSave.Hide();
                this.pbCancel.Hide();
                // Không cho thao tác trên các ô thông tin
                this.gbInfor.Enabled = false;
                this.gbInfor.Text = "Information";
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.pbAdd.Enabled = true;
                this.pbEdit.Enabled = true;
                this.pbDelete.Enabled = true;
                this.pbBack.Enabled = true;
                this.pbAdd.Show();
                this.pbEdit.Show();
                this.pbDelete.Show();
                this.pbBack.Show();
                //đẩy dữ liệu lên cmbTypeRoom
                this.cmbRoomType.DataSource = dtTypeRoom;
                this.cmbRoomType.DisplayMember = dtTypeRoom.Columns[0].ToString();
                this.cmbRoomType.ValueMember = dtTypeRoom.Columns[0].ToString();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
        }

        public bool Logout
        {
            get { return logout; }
        }
    }
}
