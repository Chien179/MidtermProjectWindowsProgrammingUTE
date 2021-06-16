using MidtermProjectWindowsProgrammingUTE.BS_Layer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmUseService : Form
    {
        #region Properties
        DataTable dtUseService = null;
        DataTable dtService = null;
        DataTable dtRoom = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLUseService dbUseService = new BLUseService();
        BLService dbService = new BLService();
        BLRoom dbRoom = new BLRoom();
        #endregion

        #region Constructors
        public FrmUseService()
        {
            InitializeComponent();
        }

        private void FrmUseService_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        #region Events Click
        private void pbCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.cmbRoomID.ResetText();
            this.cmbCMND.ResetText();
            this.dtpDateIn.ResetText();
            this.txtAmount.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.pbAdd.Enabled = true;
            this.pbEdit.Enabled = true;
            this.pbEdit.Enabled = true;
            this.pbBack.Enabled = true;
            this.pbAdd.Show();
            this.pbEdit.Show();
            this.pbBack.Show();
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.pbSave.Hide();
            this.pbCancel.Hide();
            this.pbSave.Enabled = false;
            this.pbCancel.Enabled = false;
            // Không cho thao tác trên các ô thông tin
            this.gbInfor.Enabled = false;
            this.gbInfor.Text = "Information";
            dgvUseService_CellClick(null, null);
        }

        private void dgvUseService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUseService.Rows.Count > 0)
            {
                // Thứ tự dòng hiện hành
                int r = dgvUseService.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.cmbRoomID.Text = dgvUseService.Rows[r].Cells["RoomID"].Value.ToString();
                this.cmbCMND.Text = dgvUseService.Rows[r].Cells["ServiceID"].Value.ToString();
                this.dtpDateIn.Text = dgvUseService.Rows[r].Cells["DateUse"].Value.ToString();
                this.txtAmount.Text = dgvUseService.Rows[r].Cells["Amount"].Value.ToString();
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.cmbRoomID.ResetText();
            this.cmbCMND.ResetText();
            this.dtpDateIn.ResetText();
            this.txtAmount.ResetText();
            this.cmbRoomID.Enabled = true;
            this.cmbCMND.Enabled = true;
            this.dtpDateIn.Enabled = true;
            this.txtAmount.Enabled = true;
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
            this.pbAdd.Hide();
            this.pbEdit.Hide();
            this.pbBack.Hide();

            // Đưa con trỏ đến cmbRoomID
            this.cmbRoomID.Focus();
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            if (dgvUseService.Rows.Count > 0)
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
                this.pbAdd.Hide();
                this.pbEdit.Hide();
                this.pbBack.Hide();

                //
                this.cmbRoomID.Enabled = false;
                this.cmbCMND.Enabled = false;
            }
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
                    BLUseService blUseService = new BLUseService();
                    if (this.cmbRoomID.Text != "" && this.cmbCMND.Text != "")
                    {
                        int Amount = 0;
                        if (this.txtAmount.Text != "")
                        {
                            Amount = int.Parse(this.txtAmount.Text);
                        }
                        blUseService.AddUseService(this.cmbRoomID.SelectedValue.ToString(), this.cmbCMND.SelectedValue.ToString(), this.dtpDateIn.Text, Amount, ref err);
                        // Thông báo
                        MessageBox.Show("Added successfully!");
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Added failed!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLUseService blUseService = new BLUseService();
                blUseService.UpdateUseService(this.cmbRoomID.SelectedValue.ToString(), this.cmbCMND.SelectedValue.ToString(), this.dtpDateIn.Text, int.Parse(this.txtAmount.Text), ref err);
                // Thông báo
                MessageBox.Show("Edited successfully!");
                // Load lại dữ liệu trên DataGridView
                LoadData();
            }
            // Đóng kết nối
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            FrmService frmservice = new FrmService();
            frmservice.ShowDialog();
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

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
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
                dtUseService = new DataTable();
                dtRoom = new DataTable();
                dtService = new DataTable();

                dtUseService.Clear();
                dtRoom.Clear();
                dtService.Clear();

                DataSet ds = dbUseService.GetUseService();
                dtUseService = ds.Tables[0];

                DataSet dsRoom = dbRoom.GetRoom();
                dtRoom = dsRoom.Tables[0];

                DataSet dsService = dbService.GetService();
                dtService = dsService.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvUseService.DataSource = dtUseService;
                // Thay đổi độ rộng cột
                dgvUseService.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.cmbRoomID.ResetText();
                this.cmbCMND.ResetText();
                this.dtpDateIn.ResetText();
                this.txtAmount.ResetText();
                this.cmbRoomID.Enabled = true;
                this.cmbCMND.Enabled = true;
                this.dtpDateIn.Enabled = true;
                this.txtAmount.Enabled = true;
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
                //đẩy dữ liệu lên cmb RoomID và CMND
                this.cmbRoomID.DataSource = dtRoom;
                this.cmbRoomID.DisplayMember = dtRoom.Columns[0].ToString();
                this.cmbRoomID.ValueMember = dtRoom.Columns[0].ToString();

                this.cmbCMND.DataSource = dtService;
                this.cmbCMND.DisplayMember = dtService.Columns[0].ToString();
                this.cmbCMND.ValueMember = dtService.Columns[0].ToString();
                dgvUseService_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot get data from table 'Su Dung Phong' !");
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
                dtUseService = new DataTable();
                dtUseService.Clear();
                string key = this.txtFind.Text;
                DataSet dsPurchase = dbUseService.SearchUseService(key);
                dtUseService = dsPurchase.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvUseService.DataSource = dtUseService;
                // Thay đổi độ rộng cột
                dgvUseService.AutoResizeColumns();
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
