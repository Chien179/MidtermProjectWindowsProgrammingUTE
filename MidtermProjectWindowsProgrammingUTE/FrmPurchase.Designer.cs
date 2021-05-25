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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPurchase = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPurchaseID = new System.Windows.Forms.TextBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbBill = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRoomID = new System.Windows.Forms.ComboBox();
            this.pnInfor = new System.Windows.Forms.Panel();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnCom = new System.Windows.Forms.Panel();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.PurchaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBill)).BeginInit();
            this.pnInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            this.pnCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Purchase Date:";
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseID,
            this.Total,
            this.PurchaseDate,
            this.RoomID});
            this.dgvPurchase.Location = new System.Drawing.Point(679, 250);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.RowHeadersWidth = 51;
            this.dgvPurchase.Size = new System.Drawing.Size(593, 342);
            this.dgvPurchase.TabIndex = 20;
            this.dgvPurchase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchase_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Room ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Purchase ID:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotal.Location = new System.Drawing.Point(180, 57);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(176, 30);
            this.txtTotal.TabIndex = 30;
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPurchaseID.Location = new System.Drawing.Point(180, 5);
            this.txtPurchaseID.Name = "txtPurchaseID";
            this.txtPurchaseID.Size = new System.Drawing.Size(100, 30);
            this.txtPurchaseID.TabIndex = 29;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(180, 161);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(176, 30);
            this.dtpPurchaseDate.TabIndex = 32;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(12, 151);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(48, 39);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 38;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbBill
            // 
            this.pbBill.Image = ((System.Drawing.Image)(resources.GetObject("pbBill.Image")));
            this.pbBill.Location = new System.Drawing.Point(1224, 184);
            this.pbBill.Name = "pbBill";
            this.pbBill.Size = new System.Drawing.Size(48, 44);
            this.pbBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBill.TabIndex = 39;
            this.pbBill.TabStop = false;
            this.pbBill.Click += new System.EventHandler(this.pbBill_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1221, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Purchase";
            // 
            // cmbRoomID
            // 
            this.cmbRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomID.FormattingEnabled = true;
            this.cmbRoomID.Location = new System.Drawing.Point(180, 115);
            this.cmbRoomID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRoomID.Name = "cmbRoomID";
            this.cmbRoomID.Size = new System.Drawing.Size(176, 21);
            this.cmbRoomID.TabIndex = 41;
            // 
            // pnInfor
            // 
            this.pnInfor.Controls.Add(this.label2);
            this.pnInfor.Controls.Add(this.cmbRoomID);
            this.pnInfor.Controls.Add(this.label3);
            this.pnInfor.Controls.Add(this.label4);
            this.pnInfor.Controls.Add(this.label5);
            this.pnInfor.Controls.Add(this.txtPurchaseID);
            this.pnInfor.Controls.Add(this.txtTotal);
            this.pnInfor.Controls.Add(this.dtpPurchaseDate);
            this.pnInfor.Location = new System.Drawing.Point(134, 250);
            this.pnInfor.Name = "pnInfor";
            this.pnInfor.Size = new System.Drawing.Size(395, 202);
            this.pnInfor.TabIndex = 42;
            // 
            // pbAdd
            // 
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(129, 498);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(60, 58);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 96;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbEdit
            // 
            this.pbEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbEdit.Image")));
            this.pbEdit.Location = new System.Drawing.Point(211, 498);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(60, 58);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEdit.TabIndex = 94;
            this.pbEdit.TabStop = false;
            this.pbEdit.Click += new System.EventHandler(this.pbEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(902, 197);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 37);
            this.btnSearch.TabIndex = 99;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnCom
            // 
            this.pnCom.Controls.Add(this.pbCancel);
            this.pnCom.Controls.Add(this.pbSave);
            this.pnCom.Location = new System.Drawing.Point(438, 498);
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
            // 
            // PurchaseID
            // 
            this.PurchaseID.DataPropertyName = "MaThanhToan";
            this.PurchaseID.HeaderText = "Purchase ID";
            this.PurchaseID.Name = "PurchaseID";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "ThanhTien";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.DataPropertyName = "NgayThanhToan";
            this.PurchaseDate.HeaderText = "Purchase Date";
            this.PurchaseDate.Name = "PurchaseDate";
            // 
            // RoomID
            // 
            this.RoomID.DataPropertyName = "MaPhong";
            this.RoomID.HeaderText = "Room ID";
            this.RoomID.Name = "RoomID";
            // 
            // FrmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 604);
            this.Controls.Add(this.pnCom);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnInfor);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbBill);
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.dgvPurchase);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.FrmPurchase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBill)).EndInit();
            this.pnInfor.ResumeLayout(false);
            this.pnInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            this.pnCom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPurchase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPurchaseID;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRoomID;
        private System.Windows.Forms.Panel pnInfor;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnCom;
        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
    }
}