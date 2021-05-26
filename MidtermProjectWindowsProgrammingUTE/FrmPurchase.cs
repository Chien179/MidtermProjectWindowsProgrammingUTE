using MidtermProjectWindowsProgrammingUTE.BS_Layer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
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
            this.txtTotal.Enabled = false;
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
            this.pbBack.Hide();
            this.pbDelete.Hide();
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
                    decimal Total = dbPurchase.Bill(ref err, this.txtPurchaseID.Text, this.cmbRoomID.SelectedValue.ToString());
                    blPurchase.AddPurchase(this.txtPurchaseID.Text, Total, this.dtpPurchaseDate.Text, this.cmbRoomID.SelectedValue.ToString(), ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    this.gbInfor.Text = "Information";
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLPurchase blPurchase = new BLPurchase();
                if (this.txtTotal.Text == "")
                {
                    this.txtTotal.Text = "0";
                }
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
                this.txtPurchaseID.Text = dgvPurchase.Rows[r].Cells["PurchaseID"].Value.ToString();
                this.txtTotal.Text = dgvPurchase.Rows[r].Cells["Total"].Value.ToString();
                this.dtpPurchaseDate.Text = dgvPurchase.Rows[r].Cells["PurchaseDate"].Value.ToString();
                this.cmbRoomID.Text = dgvPurchase.Rows[r].Cells["RoomID"].Value.ToString();
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
            this.gbInfor.Enabled = true;
            this.gbInfor.Text = "Editing.....";
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.pbAdd.Enabled = false;
            this.pbEdit.Enabled = false;
            this.pbBack.Enabled = false;
            this.pbDelete.Enabled = false;
            this.pbAdd.Hide();
            this.pbEdit.Hide();
            this.pbBack.Hide();
            this.pbDelete.Hide();
            // Đưa con trỏ đến TextField txtPurchase
            this.txtPurchaseID.Enabled = false;
            this.cmbRoomID.Enabled = false;
            this.cmbRoomID.Focus();

        }

        private void pbBill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Da xoa het thong tin khach hang","Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtPurchaseID.ResetText();
            this.txtTotal.ResetText();
            this.cmbRoomID.ResetText();
            this.dtpPurchaseDate.ResetText();
            this.txtPurchaseID.Enabled = true;
            this.cmbRoomID.Enabled = true;
            this.txtTotal.Enabled = true;
            this.dtpPurchaseDate.Enabled = true;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.pbAdd.Enabled = true;
            this.pbEdit.Enabled = true;
            this.pbBack.Enabled = true;
            this.pbDelete.Enabled = true;
            this.pbAdd.Show();
            this.pbEdit.Show();
            this.pbBack.Show();
            this.pbDelete.Show();
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.pbSave.Hide();
            this.pbCancel.Hide();
            this.pbSave.Enabled = false;
            this.pbCancel.Enabled = false;
            // Không cho thao tác trên các ô thông tin
            this.gbInfor.Enabled = false;
            this.gbInfor.Text = "Information";
            dgvPurchase_CellClick(null, null);
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.gbInfor.Text = "Deleting.....";
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvPurchase.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strPurchase = dgvPurchase.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL 
                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbPurchase.DeletePuchase(ref err, strPurchase);
                    // Cập nhật lại DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    this.gbInfor.Text = "Information";
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                this.gbInfor.Text = "Information";
                MessageBox.Show("Không xóa được. Lỗi rồi!");
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
                this.txtPurchaseID.Enabled = true;
                this.cmbRoomID.Enabled = true;
                this.txtTotal.Enabled = true;
                this.dtpPurchaseDate.Enabled = true;
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
                this.pbBack.Enabled = true;
                this.pbAdd.Show();
                this.pbEdit.Show();
                this.pbBack.Show();
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

        private void ButtonColorChanged(string picture, PictureBox pb)
        {
            pb.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Images\\" + picture);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        #endregion
    }
}
