using MidtermProjectWindowsProgrammingUTE.BS_Layer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmClient : Form
    {
        #region Properties
        DataTable dtClient = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLClient dbClient = new BLClient();
        #endregion

        #region Constructors
        public FrmClient()
        {
            InitializeComponent();
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            this.cbSex.SelectedIndex = 0;
            LoadData();
        }
        #endregion

        #region Events Click
        private void pbAdd_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtID.ResetText();
            this.txtName.ResetText();
            this.txtAddress.ResetText();
            this.txtPhoneNumber.ResetText();
            this.dtpBirthDate.ResetText();
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

            // 
            this.txtID.Focus();
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
                    BLClient blClient = new BLClient();
                    blClient.AddClient(this.txtID.Text, this.txtName.Text, this.txtAddress.Text, this.txtPhoneNumber.Text,this.cbFemale.Checked.ToString(), this.dtpBirthDate.Text, ref err);
                   
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLClient blClient = new BLClient();
                blClient.UpdateClient(this.txtID.Text, this.txtName.Text, this.txtAddress.Text, this.txtPhoneNumber.Text, this.cbFemale.Checked.ToString(), this.dtpBirthDate.Text, ref err);
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
                // Load lại dữ liệu trên DataGridView
                LoadData();
            }
            // Đóng kết nối
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvClient.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtID.Text = dgvClient.Rows[r].Cells["CMND"].Value.ToString();
            this.txtName.Text = dgvClient.Rows[r].Cells["NameClient"].Value.ToString();
            this.txtAddress.Text = dgvClient.Rows[r].Cells["Address"].Value.ToString();
            this.txtPhoneNumber.Text = dgvClient.Rows[r].Cells["PhoneNumber"].Value.ToString();
            this.cbFemale.Checked = Convert.ToBoolean(dgvClient.Rows[r].Cells["Female"].Value);
            this.dtpBirthDate.Text = dgvClient.Rows[r].Cells["BirthDate"].Value.ToString();
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

            // Đưa con trỏ đến TextField txtThanhPho
            this.txtID.Enabled = false;
            this.txtName.Focus();
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtID.ResetText();
            this.txtName.ResetText();
            this.txtAddress.ResetText();
            this.txtPhoneNumber.ResetText();
            this.dtpBirthDate.ResetText();
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
            dgvClient_CellClick(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void pbEdit_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged("edit_Client_blue.png", this.pbEdit);
        }

        private void pbEdit_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged("edit_Client.png", this.pbEdit);
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
            this.txtFind.Focus();
            Search();
        }
        #endregion

        #region Functions
        void LoadData()
        {
            try
            {
                dtClient = new DataTable();
                dtClient.Clear();
                DataSet ds = dbClient.GetClient();
                dtClient = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvClient.DataSource = dtClient;
                // Thay đổi độ rộng cột
                dgvClient.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtID.ResetText();
                this.txtName.ResetText();
                this.txtAddress.ResetText();
                this.txtPhoneNumber.ResetText();
                this.dtpBirthDate.ResetText();
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
                //
                dgvClient_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot get data from table 'KhachHang' !");
            }
        }

        private void Search()
        {
            int Sex = this.cbSex.SelectedIndex - 1;

            if (this.txtFind.Text == "" && Sex == -1)
            {
                LoadData();
            }
            else
            {
                dtClient = new DataTable();
                dtClient.Clear();
                string key = this.txtFind.Text;
                DataSet dsclient = dbClient.SearchClient(key, Sex);
                dtClient = dsclient.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvClient.DataSource = dtClient;
                // Thay đổi độ rộng cột
                dgvClient.AutoResizeColumns();
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
