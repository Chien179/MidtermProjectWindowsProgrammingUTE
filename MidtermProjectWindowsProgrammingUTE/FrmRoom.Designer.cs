﻿namespace MidtermProjectWindowsProgrammingUTE
{
    partial class FrmRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Used = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.btnUseRoom = new System.Windows.Forms.Button();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnCom = new System.Windows.Forms.Panel();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.cbStatusSearch = new System.Windows.Forms.ComboBox();
            this.gbInfor = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            this.pnCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            this.gbInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 144);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(450, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Information";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFind.Location = new System.Drawing.Point(679, 198);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(217, 31);
            this.txtFind.TabIndex = 22;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToDeleteRows = false;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomID,
            this.RoomType,
            this.Used,
            this.Note,
            this.Area,
            this.Price});
            this.dgvRoom.Location = new System.Drawing.Point(679, 251);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.Size = new System.Drawing.Size(593, 341);
            this.dgvRoom.TabIndex = 20;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            // 
            // RoomID
            // 
            this.RoomID.DataPropertyName = "MaPhong";
            this.RoomID.HeaderText = "Room ID";
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            // 
            // RoomType
            // 
            this.RoomType.DataPropertyName = "MaLoai";
            this.RoomType.HeaderText = "Room Type";
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // Used
            // 
            this.Used.DataPropertyName = "TrangThai";
            this.Used.HeaderText = "Used";
            this.Used.Name = "Used";
            this.Used.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "GhiChu";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.DataPropertyName = "DienTich";
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "GiaThue";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(12, 152);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(48, 39);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 36;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // btnUseRoom
            // 
            this.btnUseRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUseRoom.Location = new System.Drawing.Point(1149, 192);
            this.btnUseRoom.Name = "btnUseRoom";
            this.btnUseRoom.Size = new System.Drawing.Size(123, 43);
            this.btnUseRoom.TabIndex = 40;
            this.btnUseRoom.Text = "Use Room";
            this.btnUseRoom.UseVisualStyleBackColor = true;
            this.btnUseRoom.Click += new System.EventHandler(this.btnUseRoom_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(119, 480);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(60, 58);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 96;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            this.pbAdd.MouseEnter += new System.EventHandler(this.pbAdd_MouseEnter);
            this.pbAdd.MouseLeave += new System.EventHandler(this.pbAdd_MouseLeave);
            // 
            // pbDelete
            // 
            this.pbDelete.Image = ((System.Drawing.Image)(resources.GetObject("pbDelete.Image")));
            this.pbDelete.Location = new System.Drawing.Point(283, 480);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(60, 58);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDelete.TabIndex = 95;
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            this.pbDelete.MouseEnter += new System.EventHandler(this.pbDelete_MouseEnter);
            this.pbDelete.MouseLeave += new System.EventHandler(this.pbDelete_MouseLeave);
            // 
            // pbEdit
            // 
            this.pbEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbEdit.Image")));
            this.pbEdit.Location = new System.Drawing.Point(201, 480);
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
            this.btnSearch.Size = new System.Drawing.Size(34, 31);
            this.btnSearch.TabIndex = 100;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnCom
            // 
            this.pnCom.Controls.Add(this.pbCancel);
            this.pnCom.Controls.Add(this.pbSave);
            this.pnCom.Location = new System.Drawing.Point(442, 480);
            this.pnCom.Name = "pnCom";
            this.pnCom.Size = new System.Drawing.Size(148, 67);
            this.pnCom.TabIndex = 102;
            // 
            // pbCancel
            // 
            this.pbCancel.Image = ((System.Drawing.Image)(resources.GetObject("pbCancel.Image")));
            this.pbCancel.Location = new System.Drawing.Point(85, 3);
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
            this.pbSave.Location = new System.Drawing.Point(3, 3);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(60, 58);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSave.TabIndex = 97;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            this.pbSave.MouseEnter += new System.EventHandler(this.pbSave_MouseEnter);
            this.pbSave.MouseLeave += new System.EventHandler(this.pbSave_MouseLeave);
            // 
            // cbStatusSearch
            // 
            this.cbStatusSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusSearch.FormattingEnabled = true;
            this.cbStatusSearch.Items.AddRange(new object[] {
            "None",
            "Free",
            "Used"});
            this.cbStatusSearch.Location = new System.Drawing.Point(679, 167);
            this.cbStatusSearch.Name = "cbStatusSearch";
            this.cbStatusSearch.Size = new System.Drawing.Size(121, 24);
            this.cbStatusSearch.TabIndex = 103;
            this.cbStatusSearch.SelectedIndexChanged += new System.EventHandler(this.cbSex_SelectedIndexChanged);
            // 
            // gbInfor
            // 
            this.gbInfor.Controls.Add(this.txtNote);
            this.gbInfor.Controls.Add(this.label2);
            this.gbInfor.Controls.Add(this.label4);
            this.gbInfor.Controls.Add(this.txtRoomType);
            this.gbInfor.Controls.Add(this.label5);
            this.gbInfor.Controls.Add(this.txtRoomID);
            this.gbInfor.Controls.Add(this.label6);
            this.gbInfor.Controls.Add(this.cbStatus);
            this.gbInfor.Controls.Add(this.txtPrice);
            this.gbInfor.Controls.Add(this.label3);
            this.gbInfor.Controls.Add(this.txtArea);
            this.gbInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbInfor.Location = new System.Drawing.Point(119, 179);
            this.gbInfor.Name = "gbInfor";
            this.gbInfor.Size = new System.Drawing.Size(460, 281);
            this.gbInfor.TabIndex = 105;
            this.gbInfor.TabStop = false;
            this.gbInfor.Text = "Information";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNote.Location = new System.Drawing.Point(171, 195);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(176, 30);
            this.txtNote.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Room ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 61;
            this.label4.Text = "Area:";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtRoomType.Location = new System.Drawing.Point(171, 99);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(176, 30);
            this.txtRoomType.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(6, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 62;
            this.label5.Text = "Note:";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtRoomID.Location = new System.Drawing.Point(171, 59);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(100, 30);
            this.txtRoomID.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(6, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 64;
            this.label6.Text = "Price:";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbStatus.Location = new System.Drawing.Point(365, 101);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(73, 28);
            this.cbStatus.TabIndex = 38;
            this.cbStatus.Text = "Used";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPrice.Location = new System.Drawing.Point(171, 238);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(176, 30);
            this.txtPrice.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Room Type:";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtArea.Location = new System.Drawing.Point(171, 145);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(176, 30);
            this.txtArea.TabIndex = 66;
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 604);
            this.Controls.Add(this.gbInfor);
            this.Controls.Add(this.cbStatusSearch);
            this.Controls.Add(this.pnCom);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.btnUseRoom);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room";
            this.Load += new System.EventHandler(this.FrmRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            this.pnCom.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Button btnUseRoom;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnCom;
        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Used;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.ComboBox cbStatusSearch;
        private System.Windows.Forms.GroupBox gbInfor;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArea;
    }
}