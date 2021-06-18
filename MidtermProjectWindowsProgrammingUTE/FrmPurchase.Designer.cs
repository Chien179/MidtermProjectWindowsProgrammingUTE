namespace MidtermProjectWindowsProgrammingUTE
{
    partial class FrmPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.dgvPurchase = new System.Windows.Forms.DataGridView();
            this.PurchaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receipt = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.gbInfor = new System.Windows.Forms.GroupBox();
            this.cmbStaffID = new System.Windows.Forms.ComboBox();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRoomID = new System.Windows.Forms.ComboBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPurchaseID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            this.gbInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 144);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(525, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFind.Location = new System.Drawing.Point(679, 197);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(217, 31);
            this.txtFind.TabIndex = 22;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.AllowUserToAddRows = false;
            this.dgvPurchase.AllowUserToDeleteRows = false;
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseID,
            this.Total,
            this.RoomID,
            this.StaffID,
            this.CheckIn,
            this.PurchaseDate,
            this.Receipt});
            this.dgvPurchase.Location = new System.Drawing.Point(679, 250);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.ReadOnly = true;
            this.dgvPurchase.RowHeadersWidth = 51;
            this.dgvPurchase.Size = new System.Drawing.Size(593, 342);
            this.dgvPurchase.TabIndex = 20;
            this.dgvPurchase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchase_CellClick);
            this.dgvPurchase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchase_CellContentClick);
            this.dgvPurchase.Sorted += new System.EventHandler(this.dgvPurchase_Sorted);
            // 
            // PurchaseID
            // 
            this.PurchaseID.DataPropertyName = "MaThanhToan";
            this.PurchaseID.HeaderText = "Purchase ID";
            this.PurchaseID.MinimumWidth = 6;
            this.PurchaseID.Name = "PurchaseID";
            this.PurchaseID.ReadOnly = true;
            this.PurchaseID.Width = 125;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "ThanhTien";
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // RoomID
            // 
            // PurchaseID
            // 
            this.PurchaseID.DataPropertyName = "MaThanhToan";
            this.PurchaseID.HeaderText = "Purchase ID";
            this.PurchaseID.MinimumWidth = 6;
            this.PurchaseID.Name = "PurchaseID";
            this.PurchaseID.ReadOnly = true;
            this.PurchaseID.Width = 125;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "ThanhTien";
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // RoomID
            // 
            this.RoomID.DataPropertyName = "MaPhong";
            this.RoomID.HeaderText = "Room ID";
            this.RoomID.MinimumWidth = 6;
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            this.RoomID.Width = 125;
            // 
            // StaffID
            // 
            this.StaffID.DataPropertyName = "MaNV";
            this.StaffID.HeaderText = "Staff ID";
            this.StaffID.MinimumWidth = 6;
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            this.StaffID.Width = 125;
            // 
            // CheckIn
            // 
            this.CheckIn.HeaderText = "Check In";
            this.CheckIn.MinimumWidth = 6;
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.ReadOnly = true;
            this.CheckIn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckIn.Width = 125;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.DataPropertyName = "NgayThanhToan";
            this.PurchaseDate.HeaderText = "Purchase Date";
            this.PurchaseDate.MinimumWidth = 6;
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            this.PurchaseDate.Width = 125;
            // 
            // Receipt
            // 
            this.Receipt.HeaderText = "Receipt";
            this.Receipt.Name = "Receipt";
            this.Receipt.ReadOnly = true;
            this.Receipt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Receipt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(12, 151);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(55, 52);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 38;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            this.pbBack.MouseEnter += new System.EventHandler(this.pbBack_MouseEnter);
            this.pbBack.MouseLeave += new System.EventHandler(this.pbBack_MouseLeave);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(129, 520);
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
            this.pbEdit.Location = new System.Drawing.Point(211, 520);
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
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(902, 197);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 31);
            this.btnSearch.TabIndex = 99;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pbCancel
            // 
            this.pbCancel.Image = ((System.Drawing.Image)(resources.GetObject("pbCancel.Image")));
            this.pbCancel.Location = new System.Drawing.Point(509, 520);
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
            this.pbSave.Location = new System.Drawing.Point(428, 520);
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
            this.gbInfor.Controls.Add(this.cmbStaffID);
            this.gbInfor.Controls.Add(this.dtpDateIn);
            this.gbInfor.Controls.Add(this.label6);
            this.gbInfor.Controls.Add(this.lblStaffID);
            this.gbInfor.Controls.Add(this.label2);
            this.gbInfor.Controls.Add(this.cmbRoomID);
            this.gbInfor.Controls.Add(this.dtpPurchaseDate);
            this.gbInfor.Controls.Add(this.label3);
            this.gbInfor.Controls.Add(this.txtTotal);
            this.gbInfor.Controls.Add(this.label4);
            this.gbInfor.Controls.Add(this.txtPurchaseID);
            this.gbInfor.Controls.Add(this.label5);
            this.gbInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbInfor.Location = new System.Drawing.Point(129, 151);
            this.gbInfor.Name = "gbInfor";
            this.gbInfor.Size = new System.Drawing.Size(395, 363);
            this.gbInfor.TabIndex = 104;
            this.gbInfor.TabStop = false;
            this.gbInfor.Text = "Information";
            // 
            // cmbStaffID
            // 
            this.cmbStaffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbStaffID.FormattingEnabled = true;
            this.cmbStaffID.Location = new System.Drawing.Point(183, 210);
            this.cmbStaffID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStaffID.Name = "cmbStaffID";
            this.cmbStaffID.Size = new System.Drawing.Size(176, 32);
            this.cmbStaffID.TabIndex = 107;
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.CustomFormat = "";
            this.dtpDateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIn.Location = new System.Drawing.Point(183, 259);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(176, 30);
            this.dtpDateIn.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(6, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 106;
            this.label6.Text = "Check In:";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaffID.Location = new System.Drawing.Point(6, 215);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(88, 25);
            this.lblStaffID.TabIndex = 106;
            this.lblStaffID.Text = "Staff ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Purchase ID:";
            // 
            // cmbRoomID
            // 
            this.cmbRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbRoomID.FormattingEnabled = true;
            this.cmbRoomID.Location = new System.Drawing.Point(183, 162);
            this.cmbRoomID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRoomID.Name = "cmbRoomID";
            this.cmbRoomID.Size = new System.Drawing.Size(176, 32);
            this.cmbRoomID.TabIndex = 41;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(183, 311);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(176, 30);
            this.dtpPurchaseDate.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotal.Location = new System.Drawing.Point(183, 115);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(176, 30);
            this.txtTotal.TabIndex = 30;
            this.txtTotal.Text = "\r\n";
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(6, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Room ID:";
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPurchaseID.Location = new System.Drawing.Point(183, 63);
            this.txtPurchaseID.Name = "txtPurchaseID";
            this.txtPurchaseID.Size = new System.Drawing.Size(100, 30);
            this.txtPurchaseID.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(6, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Purchase Date:";
            // 
            // pbDelete
            // 
            this.pbDelete.Image = ((System.Drawing.Image)(resources.GetObject("pbDelete.Image")));
            this.pbDelete.Location = new System.Drawing.Point(296, 520);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(60, 58);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDelete.TabIndex = 105;
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            this.pbDelete.MouseEnter += new System.EventHandler(this.pbDelete_MouseEnter);
            this.pbDelete.MouseLeave += new System.EventHandler(this.pbDelete_MouseLeave);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(1163, 197);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(109, 40);
            this.btnReceipt.TabIndex = 106;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1095, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1095, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 124;
            this.label8.Text = "label8";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1163, 151);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(109, 40);
            this.btnLogout.TabIndex = 123;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // FrmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 604);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.pbCancel);
            this.Controls.Add(this.gbInfor);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.dgvPurchase);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.FrmPurchase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            this.gbInfor.ResumeLayout(false);
            this.gbInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.DataGridView dgvPurchase;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.GroupBox gbInfor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRoomID;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPurchaseID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.DateTimePicker dtpDateIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.ComboBox cmbStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewLinkColumn Receipt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLogout;
    }
}