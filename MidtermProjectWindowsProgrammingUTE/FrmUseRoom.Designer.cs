
namespace MidtermProjectWindowsProgrammingUTE
{
    partial class FrmUseRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUseRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.gbInfor = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateOut = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRoomID = new System.Windows.Forms.ComboBox();
            this.cmbCMND = new System.Windows.Forms.ComboBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.btnRooms = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            this.gbInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 144);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(528, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Room";
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(12, 153);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(55, 52);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 67;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            this.pbBack.MouseEnter += new System.EventHandler(this.pbBack_MouseEnter);
            this.pbBack.MouseLeave += new System.EventHandler(this.pbBack_MouseLeave);
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFind.Location = new System.Drawing.Point(679, 198);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(217, 31);
            this.txtFind.TabIndex = 69;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // dgvRoom
            // 
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomID,
            this.CMND,
            this.CheckIn,
            this.CheckOut,
            this.Deposit});
            this.dgvRoom.Location = new System.Drawing.Point(679, 251);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.Size = new System.Drawing.Size(593, 341);
            this.dgvRoom.TabIndex = 68;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            // 
            // RoomID
            // 
            this.RoomID.DataPropertyName = "MaPhong";
            this.RoomID.HeaderText = "Room ID";
            this.RoomID.Name = "RoomID";
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // CheckIn
            // 
            this.CheckIn.DataPropertyName = "NgayVao";
            this.CheckIn.HeaderText = "Check In";
            this.CheckIn.Name = "CheckIn";
            // 
            // CheckOut
            // 
            this.CheckOut.DataPropertyName = "NgayRa";
            this.CheckOut.HeaderText = "Check Out";
            this.CheckOut.Name = "CheckOut";
            // 
            // Deposit
            // 
            this.Deposit.DataPropertyName = "DatCoc";
            this.Deposit.HeaderText = "Deposit";
            this.Deposit.Name = "Deposit";
            // 
            // pbAdd
            // 
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(91, 509);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(60, 58);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 96;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            this.pbAdd.MouseEnter += new System.EventHandler(this.pbAdd_MouseEnter);
            this.pbAdd.MouseLeave += new System.EventHandler(this.pbAdd_MouseLeave);
            // 
            // pbEdit
            // 
            this.pbEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbEdit.Image")));
            this.pbEdit.Location = new System.Drawing.Point(173, 509);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(60, 58);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEdit.TabIndex = 94;
            this.pbEdit.TabStop = false;
            this.pbEdit.Click += new System.EventHandler(this.pbEdit_Click);
            this.pbEdit.MouseEnter += new System.EventHandler(this.pbEdit_MouseEnter);
            this.pbEdit.MouseLeave += new System.EventHandler(this.pbEdit_MouseLeave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(902, 198);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 100;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pbCancel
            // 
            this.pbCancel.Image = ((System.Drawing.Image)(resources.GetObject("pbCancel.Image")));
            this.pbCancel.Location = new System.Drawing.Point(500, 509);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(60, 58);
            this.pbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancel.TabIndex = 98;
            this.pbCancel.TabStop = false;
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            this.pbCancel.MouseEnter += new System.EventHandler(this.pbCancel_MouseEnter);
            this.pbCancel.MouseLeave += new System.EventHandler(this.pbCancel_MouseLeave);
            // 
            // pbSave
            // 
            this.pbSave.Image = ((System.Drawing.Image)(resources.GetObject("pbSave.Image")));
            this.pbSave.Location = new System.Drawing.Point(417, 509);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(60, 58);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSave.TabIndex = 97;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            this.pbSave.MouseEnter += new System.EventHandler(this.pbSave_MouseEnter);
            this.pbSave.MouseLeave += new System.EventHandler(this.pbSave_MouseLeave);
            // 
            // gbInfor
            // 
            this.gbInfor.Controls.Add(this.label2);
            this.gbInfor.Controls.Add(this.label4);
            this.gbInfor.Controls.Add(this.dtpDateOut);
            this.gbInfor.Controls.Add(this.label5);
            this.gbInfor.Controls.Add(this.dtpDateIn);
            this.gbInfor.Controls.Add(this.label3);
            this.gbInfor.Controls.Add(this.label6);
            this.gbInfor.Controls.Add(this.cmbRoomID);
            this.gbInfor.Controls.Add(this.cmbCMND);
            this.gbInfor.Controls.Add(this.txtDeposit);
            this.gbInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbInfor.Location = new System.Drawing.Point(124, 187);
            this.gbInfor.Name = "gbInfor";
            this.gbInfor.Size = new System.Drawing.Size(422, 306);
            this.gbInfor.TabIndex = 104;
            this.gbInfor.TabStop = false;
            this.gbInfor.Text = "Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 65;
            this.label2.Text = "Room ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 61;
            this.label4.Text = "CMND:";
            // 
            // dtpDateOut
            // 
            this.dtpDateOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOut.Location = new System.Drawing.Point(166, 223);
            this.dtpDateOut.Name = "dtpDateOut";
            this.dtpDateOut.Size = new System.Drawing.Size(200, 30);
            this.dtpDateOut.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 62;
            this.label5.Text = "Check In:";
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpDateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIn.Location = new System.Drawing.Point(166, 169);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(200, 30);
            this.dtpDateIn.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "Check Out:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(6, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 77;
            this.label6.Text = "Deposit:";
            // 
            // cmbRoomID
            // 
            this.cmbRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbRoomID.FormattingEnabled = true;
            this.cmbRoomID.Location = new System.Drawing.Point(166, 57);
            this.cmbRoomID.Name = "cmbRoomID";
            this.cmbRoomID.Size = new System.Drawing.Size(161, 33);
            this.cmbRoomID.TabIndex = 72;
            // 
            // cmbCMND
            // 
            this.cmbCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbCMND.FormattingEnabled = true;
            this.cmbCMND.Location = new System.Drawing.Point(166, 114);
            this.cmbCMND.Name = "cmbCMND";
            this.cmbCMND.Size = new System.Drawing.Size(200, 33);
            this.cmbCMND.TabIndex = 74;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDeposit.Location = new System.Drawing.Point(166, 273);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(200, 30);
            this.txtDeposit.TabIndex = 78;
            // 
            // btnRooms
            // 
            this.btnRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRooms.Location = new System.Drawing.Point(1176, 192);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(96, 43);
            this.btnRooms.TabIndex = 106;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // FrmUseRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 604);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.pbCancel);
            this.Controls.Add(this.gbInfor);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUseRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Use Room";
            this.Load += new System.EventHandler(this.FrmUseRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            this.gbInfor.ResumeLayout(false);
            this.gbInfor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposit;
        private System.Windows.Forms.GroupBox gbInfor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRoomID;
        private System.Windows.Forms.ComboBox cmbCMND;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Button btnRooms;
    }
}