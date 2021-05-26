using MidtermProjectWindowsProgrammingUTE.BS_Layer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmTypeRoom : Form
    {
        #region Properties
        DataTable dtTypeRoom = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err = "";
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
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.pbSave.Show();
            this.pbCancel.Show();
            this.pbSave.Enabled = true;
            this.pbCancel.Enabled = true;
            this.gbInfor.Enabled = true;
            this.gbInfor.Text = "Adding.....";
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.pbAdd.Enabled = false;
            this.pbEdit.Enabled = false;
            this.pbBack.Enabled = false;
            this.pbDelete.Enabled = false;
            this.pbAdd.Hide();
            this.pbEdit.Hide();
            this.pbDelete.Hide();
            this.pbBack.Hide();
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
                    blTypeRoom.AddTypeRoom(this.txtRoomType.Text, this.txtNameType.Text, ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Added successfully!");
                }
                catch (SqlException)
                {
                    this.gbInfor.Text = "Information";
                    MessageBox.Show("Add failed!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLTypeRoom blTypeRoom = new BLTypeRoom();
                blTypeRoom.UpdateTypeRoom(this.txtRoomType.Text, this.txtNameType.Text, ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Edited successfully!");
            }
            // Đóng kết nối
        }
        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTypeRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTypeRoom.Rows.Count > 0)
                {
                    // Thứ tự dòng hiện hành
                    int r = dgvTypeRoom.CurrentCell.RowIndex;
                    // Chuyển thông tin lên panel
                    this.txtRoomType.Text = dgvTypeRoom.Rows[r].Cells["RoomType"].Value.ToString();
                    this.txtNameType.Text = dgvTypeRoom.Rows[r].Cells["NameType"].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot load data into DataGridView !");
            }
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtRoomType.ResetText();
            this.txtNameType.ResetText();
            this.txtRoomType.Enabled = true;
            this.txtNameType.Enabled = true;
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
            dgvTypeRoom_CellClick(null, null);
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
            this.gbInfor.Enabled = true;
            this.gbInfor.Text = "Editing.....";
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
            this.txtRoomType.Enabled = false;
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.gbInfor.Text = "Deleting.....";
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvTypeRoom.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strTypeRoom = dgvTypeRoom.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL 
                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Are you sure?", "Delete row", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbTypeRoom.DeleteTypeRoom(ref err, strTypeRoom);
                    if (dgvTypeRoom.Rows.Count > 0)
                    {
                        // Cập nhật lại DataGridView 
                        LoadData();
                        // Thông báo 
                        MessageBox.Show("Deleted successfully!");
                    }
                    else
                    {
                        this.gbInfor.Text = "Information";
                        // Thông báo 
                        MessageBox.Show("There are rooms with this type room !", "Deleted failed!");
                    }
                }
                else
                {
                    this.gbInfor.Text = "Information";
                    // Thông báo 
                    MessageBox.Show("Deleted failed!");
                }
            }
            catch (SqlException)
            {
                this.gbInfor.Text = "Information";
                MessageBox.Show("Deleted failed!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
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
                dgvTypeRoom.DataSource = dtTypeRoom;
                // Thay đổi độ rộng cột
                dgvTypeRoom.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtRoomType.ResetText();
                this.txtNameType.ResetText();
                this.txtRoomType.Enabled = true;
                this.txtNameType.Enabled = true;
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
                //
                dgvTypeRoom_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot get data from table 'LoaiPhong' !");
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
                dtTypeRoom = new DataTable();
                dtTypeRoom.Clear();
                string key = this.txtFind.Text;
                DataSet dsPurchase = dbTypeRoom.SearchTypeRoom(key);
                dtTypeRoom = dsPurchase.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvTypeRoom.DataSource = dtTypeRoom;
                // Thay đổi độ rộng cột
                dgvTypeRoom.AutoResizeColumns();
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
