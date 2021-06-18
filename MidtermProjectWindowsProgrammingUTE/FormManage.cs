﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmMain : Form
    {
        string Name = "";

        #region Constructors
        public FrmMain(string TenNV)
        {
            InitializeComponent();
            this.Name = TenNV;
        }
        #endregion

        #region Events Click
        private void Client_Click(object sender, EventArgs e)
        {
            FrmClient frmclient = new FrmClient(this.Name);
            frmclient.ShowDialog();
            if (frmclient.Logout == true)
            {
                this.Close();
            }
        }
        private void Staff_Click(object sender, EventArgs e)
        {
            FrmStaff frmstaff = new FrmStaff(this.Name);
            frmstaff.ShowDialog();
            if (frmstaff.Logout == true)
            {
                this.Close();
            }
        }
        private void ServiceUsing_Click(object sender, EventArgs e)
        {
            FrmUseService frmuseService = new FrmUseService(this.Name);
            frmuseService.ShowDialog();
            if (frmuseService.Logout == true)
            {
                this.Close();
            }
        }
        private void RoomUsing_Click(object sender, EventArgs e)
        {
            FrmUseRoom frmuseRoom = new FrmUseRoom(this.Name);
            frmuseRoom.ShowDialog();
            if (frmuseRoom.Logout == true)
            {
                this.Close();
            }
        }
        private void Purchase_Click(object sender, EventArgs e)
        {
            FrmPurchase frmPurchase = new FrmPurchase(this.Name);
            frmPurchase.ShowDialog();
            if (frmPurchase.Logout == true)
            {
                this.Close();
            }
        }
        private void Room_Click(object sender, EventArgs e)
        {
            FrmRoom frmroom = new FrmRoom(this.Name);
            frmroom.ShowDialog();
            if (frmroom.Logout == true)
            {
                this.Close();
            }
        }

        private void Service_Click(object sender, EventArgs e)
        {
            FrmService frmservice = new FrmService(this.Name);
            frmservice.ShowDialog();
            if (frmservice.Logout == true)
            {
                this.Close();
            }
        }

        private void TypeRoom_Click(object sender, EventArgs e)
        {
            FrmTypeRoom frmTypeRoom = new FrmTypeRoom(this.Name);
            frmTypeRoom.ShowDialog();
            if (frmTypeRoom.Logout == true)
            {
                this.Close();
            }
        }
        #endregion

        #region Events Mouse
        private void Client_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged_Enter("client_yellow.png", this.lblClient, this.pbClient);
        }

        private void Client_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged_Leave("client.png", this.lblClient, this.pbClient);
        }

        private void Purchase_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged_Enter("purchase_yellow.png", this.lblPurchase, this.pbPurchase);
        }

        private void Purchase_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged_Leave("purchase.png", this.lblPurchase, this.pbPurchase);
        }

        private void Room_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged_Enter("room_yellow.png", this.lblRoom, this.pbRoom);
        }

        private void Room_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged_Leave("room.png", this.lblRoom, this.pbRoom);
        }

        private void Service_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged_Enter("service_yellow.png", this.lblService, this.pbService);
        }

        private void Service_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged_Leave("service.png", this.lblService, this.pbService);
        }
        private void TypeRoom_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged_Enter("typeroom_yellow.png", this.lblTypeRoom, this.pbTypeRoom);
        }

        private void TypeRoom_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged_Leave("typeroom.png", this.lblTypeRoom, this.pbTypeRoom);
        }
        private void ServiceUsing_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged_Enter("serviceUsing_yellow.png", this.lblServiceUsing, this.pbServiceUsing);
        }

        private void ServiceUsing_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged_Leave("serviceUsing.png", this.lblServiceUsing, this.pbServiceUsing);
        }
        private void RoomUsing_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged_Enter("roomUsing_yellow.png", this.lblRoomUsing, this.pbRoomUsing);
        }

        private void RoomUsing_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged_Leave("roomUsing.png", this.lblRoomUsing, this.pbRoomUsing);
        }
        private void Staff_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged_Enter("staff_yellow.png", this.lblStaff, this.pbStaff);
        }

        private void Staff_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged_Leave("staff.png", this.lblStaff, this.pbStaff);
        }
        #endregion

        #region Functions
        private void ButtonColorChanged_Enter(string picture, Label lbl, PictureBox pb)
        {
            lbl.ForeColor = Color.Yellow;
            pb.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Images\\" + picture);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void ButtonColorChanged_Leave(string picture, Label lbl, PictureBox pb)
        {
            lbl.ForeColor = Color.Black;
            pb.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Images\\" + picture);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        #endregion
    }
}
