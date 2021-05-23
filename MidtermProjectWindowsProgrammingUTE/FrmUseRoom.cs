﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MidtermProjectWindowsProgrammingUTE.BS_Layer;
using System.IO;
using System.Drawing;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmUseRoom : Form
    {
        #region Properties
        DataTable dtUseRoom = null;
        DataTable dtClient = null;
        DataTable dtRoom = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLUseRoom dbUseRoom = new BLUseRoom();
        BLClient dbCLient = new BLClient();
        BLRoom dbRoom = new BLRoom();
        #endregion

        #region Constructors
        public FrmUseRoom()
        {
            InitializeComponent();
        }

        private void FrmUseRoom_Load(object sender, EventArgs e)
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
            this.cmbRoomID.ResetText();
            this.cmbCMND.ResetText();
            this.dtpDateIn.ResetText();
            this.dtpDateOut.ResetText();
            this.txtDeposit.ResetText();
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
            this.cmbCMND.Focus();
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
                    BLUseRoom blUseRoom = new BLUseRoom();
                    blUseRoom.AddUseRoom(this.cmbRoomID.Text, this.cmbCMND.Text, this.dtpDateIn.Text, this.dtpDateOut.Text, float.Parse(this.txtDeposit.Text), ref err);
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
                BLUseRoom blUseRoom = new BLUseRoom();
                blUseRoom.AddUseRoom(this.cmbRoomID.Text, this.cmbCMND.Text, this.dtpDateIn.Text, this.dtpDateOut.Text, float.Parse(this.txtDeposit.Text), ref err);
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
                // Load lại dữ liệu trên DataGridView
                LoadData();
            }
            // Đóng kết nối
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvRoom.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.cmbRoomID.Text =
            dgvRoom.Rows[r].Cells[0].Value.ToString();
            this.cmbCMND.Text =
            dgvRoom.Rows[r].Cells[1].Value.ToString();
            this.dtpDateIn.Text =
            dgvRoom.Rows[r].Cells[2].Value.ToString();
            this.dtpDateOut.Text =
            dgvRoom.Rows[r].Cells[3].Value.ToString();
            this.txtDeposit.Text =
            dgvRoom.Rows[r].Cells[4].Value.ToString();
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

            //
            this.cmbRoomID.Enabled = false;
            this.cmbCMND.Enabled = false;
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.cmbRoomID.ResetText();
            this.cmbCMND.ResetText();
            this.dtpDateIn.ResetText();
            this.dtpDateOut.ResetText();
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
            dgvRoom_CellClick(null, null);
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Events Mouse
        

        private void pbSave_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged_Enter("save_blue.png", this.pbSave);
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged_Leave("save.png", this.pbSave);
        }

        private void pbCancel_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged_Enter("cancel_blue.png", this.pbCancel);
        }

        private void pbCancel_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged_Leave("cancel.png", this.pbCancel);
        }
        #endregion

        #region Other Events
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
        }
        #endregion

        #region Functions
        void LoadData()
        {
            try
            {
                dtUseRoom = new DataTable();
                dtRoom = new DataTable();
                dtClient = new DataTable();

                dtUseRoom.Clear();
                dtRoom.Clear();
                dtClient.Clear();

                DataSet ds = dbUseRoom.GetUseRoom();
                dtUseRoom = ds.Tables[0];

                DataSet dsRoom = dbRoom.GetRoom();
                dtRoom = dsRoom.Tables[0];

                DataSet dsClient = dbCLient.GetClient();
                dtClient = dsClient.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvRoom.DataSource = dtUseRoom;
                // Thay đổi độ rộng cột
                dgvRoom.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.cmbRoomID.ResetText();
                this.cmbCMND.ResetText();
                this.dtpDateIn.ResetText();
                this.dtpDateOut.ResetText();
                this.txtDeposit.ResetText();
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
                //đẩy dữ liệu lên cmb RoomID và CMND
                this.cmbRoomID.DataSource = dtRoom;
                this.cmbRoomID.DisplayMember = dtRoom.Columns[0].ToString();
                this.cmbRoomID.ValueMember = dtRoom.Columns[0].ToString();

                this.cmbCMND.DataSource = dtClient;
                this.cmbCMND.DisplayMember = dtClient.Columns[0].ToString();
                this.cmbCMND.ValueMember = dtClient.Columns[0].ToString();



                dgvRoom_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot get data from table 'Su Dung Phong' !");
            }
        }

        private void ButtonColorChanged_Enter(string picture, PictureBox pb)
        {
            pb.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Images\\" + picture);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void ButtonColorChanged_Leave(string picture, PictureBox pb)
        {
            pb.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Images\\" + picture);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        #endregion
    }
}
