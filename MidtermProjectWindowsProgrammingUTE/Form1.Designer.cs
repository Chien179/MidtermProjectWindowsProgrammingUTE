
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
            this.plClient = new System.Windows.Forms.Panel();
            this.lblClient = new System.Windows.Forms.Label();
            this.pbClient = new System.Windows.Forms.PictureBox();
            this.plRoom = new System.Windows.Forms.Panel();
            this.lblRoom = new System.Windows.Forms.Label();
            this.pbRoom = new System.Windows.Forms.PictureBox();
            this.plService = new System.Windows.Forms.Panel();
            this.lblService = new System.Windows.Forms.Label();
            this.pbService = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPurchase)).BeginInit();
            this.plClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).BeginInit();
            this.plRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom)).BeginInit();
            this.plService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Management";
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPurchase.Location = new System.Drawing.Point(433, 82);
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
            this.pbPurchase.Location = new System.Drawing.Point(438, 110);
            this.pbPurchase.Name = "pbPurchase";
            this.pbPurchase.Size = new System.Drawing.Size(83, 79);
            this.pbPurchase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPurchase.TabIndex = 6;
            this.pbPurchase.TabStop = false;
            this.pbPurchase.Click += new System.EventHandler(this.Purchase_Click);
            this.pbPurchase.MouseEnter += new System.EventHandler(this.Purchase_MouseEnter);
            this.pbPurchase.MouseLeave += new System.EventHandler(this.Purchase_MouseLeave);
            // 
            // plClient
            // 
            this.plClient.Controls.Add(this.lblClient);
            this.plClient.Controls.Add(this.pbClient);
            this.plClient.Location = new System.Drawing.Point(297, 157);
            this.plClient.Name = "plClient";
            this.plClient.Size = new System.Drawing.Size(83, 111);
            this.plClient.TabIndex = 6;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblClient.Location = new System.Drawing.Point(8, 4);
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
            this.pbClient.Location = new System.Drawing.Point(3, 32);
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
            this.plRoom.Location = new System.Drawing.Point(145, 228);
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
            // plService
            // 
            this.plService.Controls.Add(this.lblService);
            this.plService.Controls.Add(this.pbService);
            this.plService.Location = new System.Drawing.Point(438, 228);
            this.plService.Name = "plService";
            this.plService.Size = new System.Drawing.Size(83, 111);
            this.plService.TabIndex = 8;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblService.Location = new System.Drawing.Point(2, 4);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(84, 25);
            this.lblService.TabIndex = 2;
            this.lblService.Text = "Service";
            this.lblService.Click += new System.EventHandler(this.Service_Click);
            this.lblService.MouseEnter += new System.EventHandler(this.Service_MouseEnter);
            this.lblService.MouseLeave += new System.EventHandler(this.Service_MouseLeave);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(131, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type Room";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(662, 381);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbPurchase);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.plService);
            this.Controls.Add(this.plRoom);
            this.Controls.Add(this.plClient);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbPurchase)).EndInit();
            this.plClient.ResumeLayout(false);
            this.plClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).EndInit();
            this.plRoom.ResumeLayout(false);
            this.plRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom)).EndInit();
            this.plService.ResumeLayout(false);
            this.plService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.PictureBox pbPurchase;
        private System.Windows.Forms.Panel plClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.PictureBox pbClient;
        private System.Windows.Forms.Panel plRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.PictureBox pbRoom;
        private System.Windows.Forms.Panel plService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.PictureBox pbService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

