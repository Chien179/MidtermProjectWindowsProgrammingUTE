﻿using MidtermProjectWindowsProgrammingUTE.BS_Layer;
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
        DataTable dtClient = null;
        DataTable dtRoom = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLUseService dbUseService = new BLUseService();
        BLClient dbCLient = new BLClient();
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
            dgvUseService_CellClick(null, null);
        }

        private void dgvUseService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvUseService.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.cmbRoomID.Text = dgvUseService.Rows[r].Cells["RoomID"].Value.ToString();
            this.cmbCMND.Text = dgvUseService.Rows[r].Cells["ServiceID"].Value.ToString();
            this.dtpDateIn.Text = dgvUseService.Rows[r].Cells["DateUse"].Value.ToString();
            this.txtAmount.Text = dgvUseService.Rows[r].Cells["Amount"].Value.ToString();
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
            this.pbDelete.Enabled = false;
            this.pbBack.Enabled = false;
            this.pbAdd.Hide();
            this.pbEdit.Hide();
            this.pbDelete.Hide();
            this.pbBack.Hide();

            // Đưa con trỏ đến cmbRoomID
            this.cmbRoomID.Focus();
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
            this.gbInfor.Text = "Editing";
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.pbAdd.Enabled = false;
            this.pbEdit.Enabled = false;
            this.pbDelete.Enabled = false;
            this.pbBack.Enabled = false;
            this.pbAdd.Hide();
            this.pbEdit.Hide();
            this.pbDelete.Hide();
            this.pbBack.Hide();

            //
            this.cmbRoomID.Enabled = false;
            this.cmbCMND.Enabled = false;
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
                    blUseService.AddUseService(this.cmbRoomID.Text, this.cmbCMND.Text, this.dtpDateIn.Text, int.Parse(this.txtAmount.Text), ref err);
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
                BLUseService blUseService = new BLUseService();
                blUseService.AddUseService(this.cmbRoomID.Text, this.cmbCMND.Text, this.dtpDateIn.Text, int.Parse(this.txtAmount.Text), ref err);
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
                // Load lại dữ liệu trên DataGridView
                LoadData();
            }
            // Đóng kết nối
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

        #region Functions
        void LoadData()
        {
            try
            {
                dtUseService = new DataTable();
                dtRoom = new DataTable();
                dtClient = new DataTable();

                dtUseService.Clear();
                dtRoom.Clear();
                dtClient.Clear();

                DataSet ds = dbUseService.GetUseService();
                dtUseService = ds.Tables[0];

                DataSet dsRoom = dbRoom.GetRoom();
                dtRoom = dsRoom.Tables[0];

                DataSet dsClient = dbCLient.GetClient();
                dtClient = dsClient.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvUseService.DataSource = dtUseService;
                // Thay đổi độ rộng cột
                dgvUseService.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.cmbRoomID.ResetText();
                this.cmbCMND.ResetText();
                this.dtpDateIn.ResetText();
                this.txtAmount.ResetText();
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
                //đẩy dữ liệu lên cmb RoomID và CMND
                this.cmbRoomID.DataSource = dtRoom;
                this.cmbRoomID.DisplayMember = dtRoom.Columns[0].ToString();
                this.cmbRoomID.ValueMember = dtRoom.Columns[0].ToString();

                this.cmbCMND.DataSource = dtClient;
                this.cmbCMND.DisplayMember = dtClient.Columns[0].ToString();
                this.cmbCMND.ValueMember = dtClient.Columns[0].ToString();
                dgvUseService_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot get data from table 'Su Dung Phong' !");
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
