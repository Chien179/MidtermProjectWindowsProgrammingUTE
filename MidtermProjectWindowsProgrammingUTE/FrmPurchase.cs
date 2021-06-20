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
        DataTable dtUseRoom = null;
        DataTable dtStaff = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        bool logout = false;
        string err = "";
        BLPurchase dbPurchase = new BLPurchase();
        BLUseRoom dbUseRoom = new BLUseRoom();
        BLStaff dbStaff = new BLStaff();
        #endregion

        #region constructor
        public FrmPurchase(string TenNV)
        {
            InitializeComponent();
            this.label8.Text = TenNV;
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
            this.cmbStaffID.ResetText();
            this.dtpDateIn.ResetText();
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
            this.dtpDateIn.Enabled = false;
            this.pbAdd.Hide();
            this.pbEdit.Hide();
            this.pbBack.Hide();
            this.pbDelete.Hide();

            this.txtTotal.Enabled = false;
        }

        private void pbSave_Click(object sender, EventArgs e)
        {

            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                try
                {
                    if (this.cmbRoomID.Text == "" || this.txtPurchaseID.Text == "" || this.cmbStaffID.Text == "")
                    {
                        if (this.cmbRoomID.Text == "")
                        {
                            MessageBox.Show("Choose a room !");
                            return;
                        }
                        else
                        {
                            if (this.cmbStaffID.Text == "")
                            {
                                MessageBox.Show("Choose a staff !");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Please don't leave blank input");
                                return;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < dgvPurchase.Rows.Count; i++) //kiểm tra id vừa nhập đã tồn tại
                        {
                            string t = txtPurchaseID.Text.Trim();
                            if (t == dgvPurchase.Rows[i].Cells["PurchaseID"].Value.ToString().Trim())
                            {
                                MessageBox.Show("Existed '" + t + "', please type another one !");
                                txtPurchaseID.ResetText();
                                txtTotal.ResetText();
                                txtPurchaseID.Focus();
                                return;
                            }

                            string id = cmbRoomID.SelectedValue.ToString();

                            if (id == dgvPurchase.Rows[i].Cells["RoomID"].Value.ToString())
                            {
                                if (Convert.ToBoolean(dgvPurchase.Rows[i].Cells["Paid"].Value) == false)
                                {
                                    MessageBox.Show("This receipt hasn't been purchased");
                                    txtTotal.ResetText();
                                    txtPurchaseID.Focus();
                                    return;
                                }
                            }
                        }

                        // Thực hiện lệnh
                        BLPurchase blPurchase = new BLPurchase();
                        decimal Total = dbPurchase.Bill(ref err, this.cmbRoomID.SelectedValue.ToString(), this.dtpPurchaseDate.Text);
                        if (Total != 0)
                        {
                            DataSet roomusing = dbUseRoom.GetUseRoomCheckIn(this.cmbRoomID.SelectedValue.ToString());
                            string[] NgayVao = roomusing.Tables[0].Rows[0][0].ToString().Split(' ');
                            this.dtpDateIn.Text = NgayVao[0];

                            blPurchase.AddPurchase(this.txtPurchaseID.Text, Total, this.dtpPurchaseDate.Text, this.cmbRoomID.SelectedValue.ToString(), this.cmbStaffID.SelectedValue.ToString(), "0", ref err);
                            // Load lại dữ liệu trên DataGridView
                            LoadData();
                            // Thông báo
                            MessageBox.Show("Added successfully!");
                        }
                        else
                        {
                            this.gbInfor.Text = "Information";
                            MessageBox.Show("There are no datas in table 'ThuePhong'!");
                        }

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
                int r = dgvPurchase.CurrentCell.RowIndex;
                if (bool.Parse(dgvPurchase.Rows[r].Cells["Paid"].Value.ToString()) == true) //không thể edit dòng nào đã thanh toán rồi
                {
                    MessageBox.Show("Cannot edit paid rooms !");
                    return;
                }
                // Thực hiện lệnh
                BLPurchase blPurchase = new BLPurchase();
                if (this.cmbRoomID.Text == "" || this.txtPurchaseID.Text == "" || this.cmbStaffID.Text == "")
                {
                    if (this.cmbRoomID.Text == "")
                    {
                        MessageBox.Show("Choose a room !");
                        return;
                    }
                    else
                    {
                        if (this.cmbStaffID.Text == "")
                        {
                            MessageBox.Show("Choose a staff !");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Please don't leave blank input");
                            return;
                        }
                    }
                }
                else
                {
                    dbUseRoom.UpdateCheckInDay(this.cmbRoomID.SelectedValue.ToString(), this.dtpDateIn.Text, ref err);
                    decimal Total = dbPurchase.Bill(ref err, this.cmbRoomID.SelectedValue.ToString(), this.dtpPurchaseDate.Text);
                    blPurchase.UpdatePurchase(this.txtPurchaseID.Text, Total, this.dtpPurchaseDate.Text, this.cmbRoomID.SelectedValue.ToString(), this.cmbStaffID.Text, 0, ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Edited successfully!");
                }
            }
            // Đóng kết nối
        }

        private void dgvPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPurchase.Rows.Count > 0)
                {
                    int r = dgvPurchase.CurrentCell.RowIndex;
                    // Chuyển thông tin lên panel
                    this.txtPurchaseID.Text = dgvPurchase.Rows[r].Cells["PurchaseID"].Value.ToString();
                    this.txtTotal.Text = dgvPurchase.Rows[r].Cells["Total"].Value.ToString();
                    this.dtpPurchaseDate.Text = dgvPurchase.Rows[r].Cells["PurchaseDate"].Value.ToString();
                    this.cmbRoomID.Text = dgvPurchase.Rows[r].Cells["RoomID"].Value.ToString();
                    this.cmbStaffID.Text = dgvPurchase.Rows[r].Cells["StaffID"].Value.ToString();
                    this.dtpDateIn.Text = dgvPurchase.Rows[r].Cells["CheckIn"].Value.ToString();
                    this.cbStatus.Checked = Convert.ToBoolean(dgvPurchase.Rows[r].Cells["Paid"].Value.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot load data into DataGridView !");
            }
        }

        private void dgvPurchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dgvPurchase.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "receipt" && Convert.ToBoolean(dgvPurchase.Rows[e.RowIndex].Cells["Paid"].Value) == true)
                    {
                        FrmBill frmreport = new FrmBill(dgvPurchase.Rows[e.RowIndex].Cells["RoomID"].Value.ToString());
                        frmreport.Show();
                    }
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

        private void pbEdit_Click(object sender, EventArgs e)
        {
            if (dgvPurchase.Rows.Count > 0)
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
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtPurchaseID.ResetText();
            this.txtTotal.ResetText();
            this.cmbRoomID.ResetText();
            this.dtpPurchaseDate.ResetText();
            this.cmbStaffID.ResetText();
            this.dtpDateIn.ResetText();
            this.txtPurchaseID.Enabled = true;
            this.cmbRoomID.Enabled = true;
            this.txtTotal.Enabled = true;
            this.dtpPurchaseDate.Enabled = true;
            this.dtpDateIn.Enabled = true;
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
                if (dgvPurchase.Rows.Count > 0)
                {
                    this.gbInfor.Text = "Deleting.....";
                    // Thực hiện lệnh 
                    // Lấy thứ tự record hiện hành 
                    int r = dgvPurchase.CurrentCell.RowIndex;
                    // Lấy MaKH của record hiện hành 
                    string strCMND = dgvPurchase.Rows[r].Cells[0].Value.ToString();
                    if (bool.Parse(dgvPurchase.Rows[r].Cells["Paid"].Value.ToString()) == true)
                    {
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
                            BLUseService blUseService = new BLUseService();
                            blUseService.DeleteUseService(dgvPurchase.Rows[r].Cells["RoomID"].Value.ToString(), ref err);
                            dbUseRoom.DeleteUseRoom(dgvPurchase.Rows[r].Cells["RoomID"].Value.ToString(), ref err);
                            dbPurchase.DeletePurchase(ref err, this.txtPurchaseID.Text);
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
                                MessageBox.Show("Client is still using room !", "Delete failed!");
                            }
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

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dgvPurchase_Sorted(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        #region Functions
        void LoadData()
        {
            try
            {
                dtPurchase = new DataTable();
                dtUseRoom = new DataTable();
                dtStaff = new DataTable();

                dtPurchase.Clear();
                dtUseRoom.Clear();
                dtStaff.Clear();

                DataSet dsstaff = dbStaff.GetStaff();
                DataSet ds = dbPurchase.GetPurchase();
                DataSet dsroom = dbUseRoom.GetUseRoomUnpaid();
                dtPurchase = ds.Tables[0];
                dtUseRoom = dsroom.Tables[0];
                dtStaff = dsstaff.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvPurchase.DataSource = dtPurchase;

                for (int i = 0; i < dgvPurchase.Rows.Count; i++)
                {
                    DataSet roomusing = dbUseRoom.GetUseRoomCheckIn(dgvPurchase.Rows[i].Cells["RoomID"].Value.ToString());
                    string[] NgayVao = roomusing.Tables[0].Rows[0][0].ToString().Split(' ');
                    dgvPurchase.Rows[i].Cells["CheckIn"].Value = NgayVao[0];
                }

                for (int i = 0; i < this.dgvPurchase.Rows.Count; i++)
                {
                    dgvPurchase.Rows[i].Cells["Receipt"].Value = "receipt";
                }

                //Đưa dữ liệu mã phòng lên combobox
                this.cmbRoomID.DataSource = dtUseRoom;
                this.cmbRoomID.DisplayMember = dtUseRoom.Columns[0].ToString();
                this.cmbRoomID.ValueMember = dtUseRoom.Columns[0].ToString();

                //Đưa mã nv lên cmb
                this.cmbStaffID.DataSource = dtStaff;
                this.cmbStaffID.DisplayMember = dtStaff.Columns[0].ToString();
                this.cmbStaffID.ValueMember = dtStaff.Columns[0].ToString();

                // Thay đổi độ rộng cột
                dgvPurchase.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtPurchaseID.ResetText();
                this.cmbRoomID.ResetText();
                this.txtTotal.ResetText();
                this.dtpPurchaseDate.ResetText();
                this.cmbStaffID.ResetText();
                this.dtpDateIn.ResetText();
                this.txtPurchaseID.Enabled = true;
                this.cmbRoomID.Enabled = true;
                this.txtTotal.Enabled = true;
                this.dtpPurchaseDate.Enabled = true;
                this.cmbStaffID.Enabled = true;
                this.dtpDateIn.Enabled = true;
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
                for (int i = 0; i < dgvPurchase.Rows.Count; i++)
                {
                    DataSet roomusing = dbUseRoom.GetUseRoomCheckIn(dgvPurchase.Rows[i].Cells["RoomID"].Value.ToString());
                    string[] NgayVao = roomusing.Tables[0].Rows[0][0].ToString().Split(' ');
                    dgvPurchase.Rows[i].Cells["CheckIn"].Value = NgayVao[0];
                }

                for (int i = 0; i < this.dgvPurchase.Rows.Count; i++)
                {
                    dgvPurchase.Rows[i].Cells["Receipt"].Value = "receipt";
                }
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
        }

        public bool Logout
        {
            get { return logout; }
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            if (dgvPurchase.Rows.Count > 0)
            {
                int r = dgvPurchase.CurrentCell.RowIndex;
                if (Convert.ToBoolean(this.dgvPurchase.Rows[r].Cells["Paid"].Value) == false)
                {
                    BLPurchase blPurchase = new BLPurchase();
                    BLUseService blUseService = new BLUseService();
                    BLRoom blRoom = new BLRoom();
                    blPurchase.UpdatePurchase(this.txtPurchaseID.Text, decimal.Parse(this.txtTotal.Text), this.dtpPurchaseDate.Text, this.cmbRoomID.SelectedValue.ToString(), this.cmbStaffID.Text, 1, ref err);
                    dbUseRoom.UpdateUseRoomStatus(this.cmbRoomID.SelectedValue.ToString(), ref err);
                    blUseService.UpdateStatusUseService(this.cmbRoomID.SelectedValue.ToString(), ref err);
                    blRoom.UpdateStatusRoom(this.cmbRoomID.SelectedValue.ToString(), ref err);
                    LoadData();
                    MessageBox.Show("Paid", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
