
namespace MidtermProjectWindowsProgrammingUTE
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.pbPurchase = new System.Windows.Forms.PictureBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.pbClient = new System.Windows.Forms.PictureBox();
            this.plRoom = new System.Windows.Forms.Panel();
            this.lblRoom = new System.Windows.Forms.Label();
            this.pbRoom = new System.Windows.Forms.PictureBox();
            this.lblTypeRoom = new System.Windows.Forms.Label();
            this.pbTypeRoom = new System.Windows.Forms.PictureBox();
            this.pbService = new System.Windows.Forms.PictureBox();
            this.lblService = new System.Windows.Forms.Label();
            this.plService = new System.Windows.Forms.Panel();
            this.lblRoomUsing = new System.Windows.Forms.Label();
            this.lblServiceUsing = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.pbStaff = new System.Windows.Forms.PictureBox();
            this.pbRoomUsing = new System.Windows.Forms.PictureBox();
            this.pbServiceUsing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).BeginInit();
            this.plRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTypeRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).BeginInit();
            this.plService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoomUsing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServiceUsing)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Management";
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPurchase.Location = new System.Drawing.Point(367, 80);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(103, 25);
            this.lblPurchase.TabIndex = 2;
            this.lblPurchase.Text = "Purchase";
            this.lblPurchase.Click += new System.EventHandler(this.Purchase_Click);
            this.lblPurchase.MouseEnter += new System.EventHandler(this.Purchase_MouseEnter);
            this.lblPurchase.MouseLeave += new System.EventHandler(this.Purchase_MouseLeave);
            // 
            // pbPurchase
            // 
            this.pbPurchase.Image = ((System.Drawing.Image)(resources.GetObject("pbPurchase.Image")));
            this.pbPurchase.Location = new System.Drawing.Point(372, 108);
            this.pbPurchase.Name = "pbPurchase";
            this.pbPurchase.Size = new System.Drawing.Size(83, 79);
            this.pbPurchase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPurchase.TabIndex = 6;
            this.pbPurchase.TabStop = false;
            this.pbPurchase.Click += new System.EventHandler(this.Purchase_Click);
            this.pbPurchase.MouseEnter += new System.EventHandler(this.Purchase_MouseEnter);
            this.pbPurchase.MouseLeave += new System.EventHandler(this.Purchase_MouseLeave);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblClient.Location = new System.Drawing.Point(521, 80);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(67, 25);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Client";
            this.lblClient.Click += new System.EventHandler(this.Client_Click);
            this.lblClient.MouseEnter += new System.EventHandler(this.Client_MouseEnter);
            this.lblClient.MouseLeave += new System.EventHandler(this.Client_MouseLeave);
            // 
            // pbClient
            // 
            this.pbClient.Image = ((System.Drawing.Image)(resources.GetObject("pbClient.Image")));
            this.pbClient.Location = new System.Drawing.Point(516, 108);
            this.pbClient.Name = "pbClient";
            this.pbClient.Size = new System.Drawing.Size(83, 79);
            this.pbClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClient.TabIndex = 6;
            this.pbClient.TabStop = false;
            this.pbClient.Click += new System.EventHandler(this.Client_Click);
            this.pbClient.MouseEnter += new System.EventHandler(this.Client_MouseEnter);
            this.pbClient.MouseLeave += new System.EventHandler(this.Client_MouseLeave);
            // 
            // plRoom
            // 
            this.plRoom.Controls.Add(this.lblRoom);
            this.plRoom.Controls.Add(this.pbRoom);
            this.plRoom.Location = new System.Drawing.Point(62, 226);
            this.plRoom.Name = "plRoom";
            this.plRoom.Size = new System.Drawing.Size(83, 111);
            this.plRoom.TabIndex = 7;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRoom.Location = new System.Drawing.Point(6, 4);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(68, 25);
            this.lblRoom.TabIndex = 2;
            this.lblRoom.Text = "Room";
            this.lblRoom.Click += new System.EventHandler(this.Room_Click);
            this.lblRoom.MouseEnter += new System.EventHandler(this.Room_MouseEnter);
            this.lblRoom.MouseLeave += new System.EventHandler(this.Room_MouseLeave);
            // 
            // pbRoom
            // 
            this.pbRoom.Image = ((System.Drawing.Image)(resources.GetObject("pbRoom.Image")));
            this.pbRoom.Location = new System.Drawing.Point(0, 32);
            this.pbRoom.Name = "pbRoom";
            this.pbRoom.Size = new System.Drawing.Size(83, 79);
            this.pbRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRoom.TabIndex = 6;
            this.pbRoom.TabStop = false;
            this.pbRoom.Click += new System.EventHandler(this.Room_Click);
            this.pbRoom.MouseEnter += new System.EventHandler(this.Room_MouseEnter);
            this.pbRoom.MouseLeave += new System.EventHandler(this.Room_MouseLeave);
            // 
            // lblTypeRoom
            // 
            this.lblTypeRoom.AutoSize = true;
            this.lblTypeRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTypeRoom.Location = new System.Drawing.Point(43, 80);
            this.lblTypeRoom.Name = "lblTypeRoom";
            this.lblTypeRoom.Size = new System.Drawing.Size(122, 25);
            this.lblTypeRoom.TabIndex = 2;
            this.lblTypeRoom.Text = "Type Room";
            this.lblTypeRoom.Click += new System.EventHandler(this.TypeRoom_Click);
            this.lblTypeRoom.MouseEnter += new System.EventHandler(this.TypeRoom_MouseEnter);
            this.lblTypeRoom.MouseLeave += new System.EventHandler(this.TypeRoom_MouseLeave);
            // 
            // pbTypeRoom
            // 
            this.pbTypeRoom.Image = ((System.Drawing.Image)(resources.GetObject("pbTypeRoom.Image")));
            this.pbTypeRoom.Location = new System.Drawing.Point(62, 108);
            this.pbTypeRoom.Name = "pbTypeRoom";
            this.pbTypeRoom.Size = new System.Drawing.Size(83, 79);
            this.pbTypeRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTypeRoom.TabIndex = 6;
            this.pbTypeRoom.TabStop = false;
            this.pbTypeRoom.Click += new System.EventHandler(this.TypeRoom_Click);
            this.pbTypeRoom.MouseEnter += new System.EventHandler(this.TypeRoom_MouseEnter);
            this.pbTypeRoom.MouseLeave += new System.EventHandler(this.TypeRoom_MouseLeave);
            // 
            // pbService
            // 
            this.pbService.Image = ((System.Drawing.Image)(resources.GetObject("pbService.Image")));
            this.pbService.Location = new System.Drawing.Point(0, 32);
            this.pbService.Name = "pbService";
            this.pbService.Size = new System.Drawing.Size(83, 79);
            this.pbService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbService.TabIndex = 6;
            this.pbService.TabStop = false;
            this.pbService.Click += new System.EventHandler(this.Service_Click);
            this.pbService.MouseEnter += new System.EventHandler(this.Service_MouseEnter);
            this.pbService.MouseLeave += new System.EventHandler(this.Service_MouseLeave);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblService.Location = new System.Drawing.Point(3, 3);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(84, 25);
            this.lblService.TabIndex = 2;
            this.lblService.Text = "Service";
            this.lblService.Click += new System.EventHandler(this.Service_Click);
            this.lblService.MouseEnter += new System.EventHandler(this.Service_MouseEnter);
            this.lblService.MouseLeave += new System.EventHandler(this.Service_MouseLeave);
            // 
            // plService
            // 
            this.plService.Controls.Add(this.lblService);
            this.plService.Controls.Add(this.pbService);
            this.plService.Location = new System.Drawing.Point(372, 226);
            this.plService.Name = "plService";
            this.plService.Size = new System.Drawing.Size(83, 111);
            this.plService.TabIndex = 8;
            // 
            // lblRoomUsing
            // 
            this.lblRoomUsing.AutoSize = true;
            this.lblRoomUsing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRoomUsing.Location = new System.Drawing.Point(202, 80);
            this.lblRoomUsing.Name = "lblRoomUsing";
            this.lblRoomUsing.Size = new System.Drawing.Size(129, 25);
            this.lblRoomUsing.TabIndex = 9;
            this.lblRoomUsing.Text = "Room Using";
            this.lblRoomUsing.Click += new System.EventHandler(this.RoomUsing_Click);
            this.lblRoomUsing.MouseEnter += new System.EventHandler(this.RoomUsing_MouseEnter);
            this.lblRoomUsing.MouseLeave += new System.EventHandler(this.RoomUsing_MouseLeave);
            // 
            // lblServiceUsing
            // 
            this.lblServiceUsing.AutoSize = true;
            this.lblServiceUsing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblServiceUsing.Location = new System.Drawing.Point(202, 226);
            this.lblServiceUsing.Name = "lblServiceUsing";
            this.lblServiceUsing.Size = new System.Drawing.Size(145, 25);
            this.lblServiceUsing.TabIndex = 10;
            this.lblServiceUsing.Text = "Service Using";
            this.lblServiceUsing.Click += new System.EventHandler(this.ServiceUsing_Click);
            this.lblServiceUsing.MouseEnter += new System.EventHandler(this.ServiceUsing_MouseEnter);
            this.lblServiceUsing.MouseLeave += new System.EventHandler(this.ServiceUsing_MouseLeave);
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaff.Location = new System.Drawing.Point(521, 229);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(56, 25);
            this.lblStaff.TabIndex = 11;
            this.lblStaff.Text = "Staff";
            this.lblStaff.Click += new System.EventHandler(this.Staff_Click);
            this.lblStaff.MouseEnter += new System.EventHandler(this.Staff_MouseEnter);
            this.lblStaff.MouseLeave += new System.EventHandler(this.Staff_MouseLeave);
            // 
            // pbStaff
            // 
            this.pbStaff.Image = ((System.Drawing.Image)(resources.GetObject("pbStaff.Image")));
            this.pbStaff.Location = new System.Drawing.Point(516, 258);
            this.pbStaff.Name = "pbStaff";
            this.pbStaff.Size = new System.Drawing.Size(83, 79);
            this.pbStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStaff.TabIndex = 12;
            this.pbStaff.TabStop = false;
            this.pbStaff.Click += new System.EventHandler(this.Staff_Click);
            this.pbStaff.MouseEnter += new System.EventHandler(this.Staff_MouseEnter);
            this.pbStaff.MouseLeave += new System.EventHandler(this.Staff_MouseLeave);
            // 
            // pbRoomUsing
            // 
            this.pbRoomUsing.Image = ((System.Drawing.Image)(resources.GetObject("pbRoomUsing.Image")));
            this.pbRoomUsing.Location = new System.Drawing.Point(220, 108);
            this.pbRoomUsing.Name = "pbRoomUsing";
            this.pbRoomUsing.Size = new System.Drawing.Size(83, 79);
            this.pbRoomUsing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRoomUsing.TabIndex = 13;
            this.pbRoomUsing.TabStop = false;
            this.pbRoomUsing.Click += new System.EventHandler(this.RoomUsing_Click);
            this.pbRoomUsing.MouseEnter += new System.EventHandler(this.RoomUsing_MouseEnter);
            this.pbRoomUsing.MouseLeave += new System.EventHandler(this.RoomUsing_MouseLeave);
            // 
            // pbServiceUsing
            // 
            this.pbServiceUsing.Image = ((System.Drawing.Image)(resources.GetObject("pbServiceUsing.Image")));
            this.pbServiceUsing.Location = new System.Drawing.Point(220, 258);
            this.pbServiceUsing.Name = "pbServiceUsing";
            this.pbServiceUsing.Size = new System.Drawing.Size(83, 79);
            this.pbServiceUsing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbServiceUsing.TabIndex = 14;
            this.pbServiceUsing.TabStop = false;
            this.pbServiceUsing.Click += new System.EventHandler(this.ServiceUsing_Click);
            this.pbServiceUsing.MouseEnter += new System.EventHandler(this.ServiceUsing_MouseEnter);
            this.pbServiceUsing.MouseLeave += new System.EventHandler(this.ServiceUsing_MouseLeave);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(662, 381);
            this.Controls.Add(this.pbServiceUsing);
            this.Controls.Add(this.pbRoomUsing);
            this.Controls.Add(this.pbStaff);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.lblServiceUsing);
            this.Controls.Add(this.lblRoomUsing);
            this.Controls.Add(this.pbClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.pbTypeRoom);
            this.Controls.Add(this.lblTypeRoom);
            this.Controls.Add(this.pbPurchase);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.plService);
            this.Controls.Add(this.plRoom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).EndInit();
            this.plRoom.ResumeLayout(false);
            this.plRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTypeRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).EndInit();
            this.plService.ResumeLayout(false);
            this.plService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoomUsing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServiceUsing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.PictureBox pbPurchase;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.PictureBox pbClient;
        private System.Windows.Forms.Panel plRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.PictureBox pbRoom;
        private System.Windows.Forms.Label lblTypeRoom;
        private System.Windows.Forms.PictureBox pbTypeRoom;
        private System.Windows.Forms.PictureBox pbService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Panel plService;
        private System.Windows.Forms.Label lblRoomUsing;
        private System.Windows.Forms.Label lblServiceUsing;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.PictureBox pbStaff;
        private System.Windows.Forms.PictureBox pbRoomUsing;
        private System.Windows.Forms.PictureBox pbServiceUsing;
    }
}

