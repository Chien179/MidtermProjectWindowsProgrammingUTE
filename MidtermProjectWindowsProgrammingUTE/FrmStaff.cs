using MidtermProjectWindowsProgrammingUTE.BS_Layer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmStaff : Form
    {
        #region Properties
        DataTable dtStaff = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        bool logout = false;
        string err = "";
        BLStaff dbStaff = new BLStaff();
        #endregion

        #region Constructor
        public FrmStaff(string TenNV)
        {
            InitializeComponent();
            this.label8.Text = TenNV;
        }

        private void FrmStaff_Load(object sender, EventArgs e)
        {
            this.cbSex.SelectedIndex = 0;
            LoadData();
        }
        #endregion

        #region Event_Click
        private void pbAdd_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtID.ResetText();
            this.txtName.ResetText();
            this.txtChucVu.ResetText();
            this.dtpBirthDate.ResetText();
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
            // 
            this.txtID.Focus();
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            if (dgvStaff.Rows.Count > 0)
            {
                // Kich hoạt biến Them
                Them = false;
                // Cho thao tác trên các nút Lưu / Hủy / Panel
                this.pbSave.Show();
                this.pbCancel.Show();
                this.pbSave.Enabled = true;
                this.pbCancel.Enabled = true;
                this.gbInfor.Enabled = true;
                this.gbInfor.Text = "Editing......";
                // Không cho thao tác trên các nút Thêm / Xóa / Thoát
                this.pbAdd.Enabled = false;
                this.pbEdit.Enabled = false;
                this.pbBack.Enabled = false;
                this.pbDelete.Enabled = false;
                this.pbAdd.Hide();
                this.pbEdit.Hide();
                this.pbBack.Hide();
                this.pbDelete.Hide();
                // Đưa con trỏ đến TextField txtThanhPho
                this.txtID.Enabled = false;
                this.txtName.Focus();
            }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStaff.Rows.Count > 0)
                {
                    this.gbInfor.Text = "Deleting.....";
                    // Thực hiện lệnh 
                    // Lấy thứ tự record hiện hành 
                    int r = dgvStaff.CurrentCell.RowIndex;
                    // Lấy MaKH của record hiện hành 
                    string strCMND = dgvStaff.Rows[r].Cells[0].Value.ToString();
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
                        dbStaff.DeleteStaff(ref err, strCMND);
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
                            MessageBox.Show("Staff is still using room !", "Delete failed!");
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

        private void pbSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                if (this.txtID.Text == "" || this.txtName.Text == "")
                {
                    if (this.txtID.Text == "")
                    {
                        MessageBox.Show("Please fill in Staff's CMND !");
                        return;
                    }
                    else
                    {

                        MessageBox.Show("Please fill in Staff's Name !");
                        return;
                    }
                }
                for (int i = 0; i < dgvStaff.Rows.Count; i++)
                {
                    string t = txtID.Text.Trim();
                    if (t == dgvStaff.Rows[i].Cells["ID"].Value.ToString())
                    {
                        MessageBox.Show("Existed '" + t + "', please type another one !");
                        txtID.ResetText();
                        txtChucVu.ResetText();
                        txtName.ResetText();
                        txtID.Focus();
                        return;
                    }
                }
                try
                {
                    // Thực hiện lệnh
                    BLStaff blStaff = new BLStaff();
                    if (this.txtID.Text != "")
                    {
                        blStaff.AddStaff(this.txtID.Text, this.txtName.Text, this.txtChucVu.Text, this.dtpBirthDate.Text, this.cbFemale.Checked.ToString(), ref err);
                        
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
                if (this.txtID.Text == "" || this.txtName.Text == "")
                {
                    if (this.txtID.Text == "")
                    {
                        MessageBox.Show("Please fill in Staff's CMND !");
                        return;
                    }
                    else
                    {

                        MessageBox.Show("Please fill in Staff's Name !");
                        return;
                    }
                }
                // Thực hiện lệnh
                BLStaff blStaff = new BLStaff();
                blStaff.UpdateStaff(this.txtID.Text, this.txtName.Text, this.txtChucVu.Text, this.dtpBirthDate.Text, this.cbFemale.Checked.ToString(), ref err);                
                // Thông báo
                MessageBox.Show("Edited successfully!");
                // Load lại dữ liệu trên DataGridView
                LoadData();
            }
            // Đóng kết nối
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtID.ResetText();
            this.txtName.ResetText();
            this.txtChucVu.ResetText();
            this.dtpBirthDate.ResetText();
            this.txtID.Enabled = true;
            this.txtName.Enabled = true;
            this.txtChucVu.Enabled = true;
            this.dtpBirthDate.Enabled = true;
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
            dgvStaff_CellClick(null, null);
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStaff.Rows.Count > 0)
                {
                    // Thứ tự dòng hiện hành
                    int r = dgvStaff.CurrentCell.RowIndex;
                    // Chuyển thông tin lên panel
                    this.txtID.Text = dgvStaff.Rows[r].Cells["ID"].Value.ToString();
                    this.txtName.Text = dgvStaff.Rows[r].Cells["NameStaff"].Value.ToString();
                    this.txtChucVu.Text = dgvStaff.Rows[r].Cells["ChucVu"].Value.ToString();
                    this.cbFemale.Checked = Convert.ToBoolean(dgvStaff.Rows[r].Cells["Female"].Value);
                    this.dtpBirthDate.Text = dgvStaff.Rows[r].Cells["BirthDate"].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot load data into DataGridView !");
            }
        }
        #endregion

        #region Events Mouse
        private void pbAdd_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged("add_Client_blue.png", this.pbAdd);
        }

        private void pbAdd_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged("add_Client.png", this.pbAdd);
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
            ButtonColorChanged("edit_Client_blue.png", this.pbEdit);
        }

        private void pbEdit_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged("edit_Client.png", this.pbEdit);
        }

        private void pbDelete_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged("delete_Client_blue.png", this.pbDelete);
        }

        private void pbDelete_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged("delete_Client.png", this.pbDelete);
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

        #region Others Events
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
                dtStaff = new DataTable();
                dtStaff.Clear();
                DataSet ds = dbStaff.GetStaff();
                dtStaff = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvStaff.DataSource = dtStaff;
                // Thay đổi độ rộng cột
                dgvStaff.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtID.ResetText();
                this.txtName.ResetText();
                this.txtChucVu.ResetText();
                this.dtpBirthDate.ResetText();
                this.txtID.Enabled = true;
                this.txtName.Enabled = true;
                this.txtChucVu.Enabled = true;
                this.dtpBirthDate.Enabled = true;
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
                this.pbDelete.Enabled = true;
                this.pbAdd.Show();
                this.pbEdit.Show();
                this.pbBack.Show();
                this.pbDelete.Show();
                //
                dgvStaff_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot get data from table 'NhanVien' !");
            }
        }

        private void Search()
        {
            try
            {
                int Sex = this.cbSex.SelectedIndex - 1;

                if (this.txtFind.Text == "" && Sex == -1)
                {
                    LoadData();
                }
                else
                {
                    dtStaff = new DataTable();
                    dtStaff.Clear();
                    string key = this.txtFind.Text;
                    DataSet dsStaff = dbStaff.SearchStaff(key, Sex);
                    dtStaff = dsStaff.Tables[0];
                    // Đưa dữ liệu lên DataGridView
                    dgvStaff.DataSource = dtStaff;
                    // Thay đổi độ rộng cột
                    dgvStaff.AutoResizeColumns();
                }
            }
            catch { }
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

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
