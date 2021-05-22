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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1713, 177);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(700, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFind.Location = new System.Drawing.Point(905, 242);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(288, 31);
            this.txtFind.TabIndex = 22;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(4, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Purchase Date:";
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.Location = new System.Drawing.Point(905, 308);
            this.dgvPurchase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.RowHeadersWidth = 51;
            this.dgvPurchase.Size = new System.Drawing.Size(791, 421);
            this.dgvPurchase.TabIndex = 20;
            this.dgvPurchase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchase_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(4, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Room ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(4, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Purchase ID:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotal.Location = new System.Drawing.Point(240, 70);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(233, 30);
            this.txtTotal.TabIndex = 30;
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPurchaseID.Location = new System.Drawing.Point(240, 6);
            this.txtPurchaseID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPurchaseID.Name = "txtPurchaseID";
            this.txtPurchaseID.Size = new System.Drawing.Size(132, 30);
            this.txtPurchaseID.TabIndex = 29;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(240, 198);
            this.dtpPurchaseDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(233, 30);
            this.dtpPurchaseDate.TabIndex = 32;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(16, 186);
            this.pbBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(64, 48);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 38;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbBill
            // 
            this.pbBill.Image = ((System.Drawing.Image)(resources.GetObject("pbBill.Image")));
            this.pbBill.Location = new System.Drawing.Point(1632, 226);
            this.pbBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBill.Name = "pbBill";
            this.pbBill.Size = new System.Drawing.Size(64, 54);
            this.pbBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBill.TabIndex = 39;
            this.pbBill.TabStop = false;
            this.pbBill.Click += new System.EventHandler(this.pbBill_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1628, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Purchase";
            // 
            // cmbRoomID
            // 
            this.cmbRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomID.FormattingEnabled = true;
            this.cmbRoomID.Location = new System.Drawing.Point(240, 142);
            this.cmbRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRoomID.Name = "cmbRoomID";
            this.cmbRoomID.Size = new System.Drawing.Size(233, 24);
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
            this.pnInfor.Location = new System.Drawing.Point(179, 308);
            this.pnInfor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnInfor.Name = "pnInfor";
            this.pnInfor.Size = new System.Drawing.Size(527, 249);
            this.pnInfor.TabIndex = 42;
            // 
            // pbAdd
            // 
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(172, 613);
            this.pbAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(80, 71);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 96;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbEdit
            // 
            this.pbEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbEdit.Image")));
            this.pbEdit.Location = new System.Drawing.Point(281, 613);
            this.pbEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(80, 71);
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
            this.btnSearch.Location = new System.Drawing.Point(1203, 242);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 46);
            this.btnSearch.TabIndex = 99;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnCom
            // 
            this.pnCom.Controls.Add(this.pbCancel);
            this.pnCom.Controls.Add(this.pbSave);
            this.pnCom.Location = new System.Drawing.Point(584, 613);
            this.pnCom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnCom.Name = "pnCom";
            this.pnCom.Size = new System.Drawing.Size(197, 82);
            this.pnCom.TabIndex = 102;
            // 
            // pbCancel
            // 
            this.pbCancel.Image = ((System.Drawing.Image)(resources.GetObject("pbCancel.Image")));
            this.pbCancel.Location = new System.Drawing.Point(113, 4);
            this.pbCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(80, 71);
            this.pbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancel.TabIndex = 98;
            this.pbCancel.TabStop = false;
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // pbSave
            // 
            this.pbSave.Image = ((System.Drawing.Image)(resources.GetObject("pbSave.Image")));
            this.pbSave.Location = new System.Drawing.Point(4, 4);
            this.pbSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(80, 71);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSave.TabIndex = 97;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // FrmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 743);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}