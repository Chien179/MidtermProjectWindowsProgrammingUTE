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
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err = "";
        BLPurchase dbPurchase = new BLPurchase();
        BLUseRoom dbUseRoom = new BLUseRoom();
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
                    decimal Total = dbPurchase.Bill(ref err, this.cmbRoomID.SelectedValue.ToString(), this.txtPurchaseID.Text);
                    if (Total != 0)
                    {
                        blPurchase.AddPurchase(this.txtPurchaseID.Text, Total, this.dtpPurchaseDate.Text, this.cmbRoomID.SelectedValue.ToString(), ref err);
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
                catch (SqlException)
                {
                    this.gbInfor.Text = "Information";
                    MessageBox.Show("Cannot add data !");
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
                MessageBox.Show("Edited successfully!");
            }
            // Đóng kết nối
        }

        private void dgvPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPurchase.Rows.Count > 0)
                {
                    // Thứ tự dòng hiện hành
                    int r = dgvPurchase.CurrentCell.RowIndex;
                    // Chuyển thông tin lên panel
                    this.txtPurchaseID.Text = dgvPurchase.Rows[r].Cells["PurchaseID"].Value.ToString();
                    this.txtTotal.Text = dgvPurchase.Rows[r].Cells["Total"].Value.ToString();
                    this.dtpPurchaseDate.Text = dgvPurchase.Rows[r].Cells["PurchaseDate"].Value.ToString();
                    this.cmbRoomID.Text = dgvPurchase.Rows[r].Cells["RoomID"].Value.ToString();
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
                int r = dgvPurchase.CurrentCell.RowIndex;
                // Lấy MaTT và MaPhong của record hiện hành 
                string strPurchase = dgvPurchase.Rows[r].Cells[0].Value.ToString();
                string strRoomID = dgvPurchase.Rows[r].Cells[3].Value.ToString();
                dbPurchase.Puchase(ref err, strPurchase, strRoomID);
                MessageBox.Show("Deleted all selected Clients' informations", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
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
        #endregion

        #region Functions
        void LoadData()
        {
            try
            {
                dtPurchase = new DataTable();
                dtUseRoom = new DataTable();
                dtPurchase.Clear();
                dtUseRoom.Clear();
                DataSet ds = dbPurchase.GetPurchase();
                DataSet dsroom = dbUseRoom.GetUseRoom();
                dtPurchase = ds.Tables[0];
                dtUseRoom = dsroom.Tables[0];
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
                this.cmbRoomID.DataSource = dtUseRoom;
                this.cmbRoomID.DisplayMember = dtUseRoom.Columns[0].ToString();
                this.cmbRoomID.ValueMember = dtUseRoom.Columns[0].ToString();

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
