using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FormStaff : Form
    {
        string Name = "";

        #region Constructors
        public FormStaff(string TenNV)
        {
            InitializeComponent();
            this.Name = TenNV;
        }
        #endregion

        #region Events Click
        private void Client_Click(object sender, EventArgs e)
        {
            FrmClient frmclient = new FrmClient(this.Name);
            this.Hide();
            frmclient.ShowDialog();
            if (frmclient.Logout == true)
            {
                this.Close();
            }
            this.Show();
        }
        private void ServiceUsing_Click(object sender, EventArgs e)
        {
            FrmUseService frmuseService = new FrmUseService(this.Name);
            frmuseService.ShowDialog();
            this.Hide();
            if (frmuseService.Logout == true)
            {
                this.Close();
            }
            this.Show();
        }
        private void RoomUsing_Click(object sender, EventArgs e)
        {
            FrmUseRoom frmuseRoom = new FrmUseRoom(this.Name);
            this.Hide();
            frmuseRoom.ShowDialog();
            if (frmuseRoom.Logout == true)
            {
                this.Close();
            }
            this.Show();
        }
        private void Purchase_Click(object sender, EventArgs e)
        {
            FrmPurchase frmPurchase = new FrmPurchase(this.Name);
            this.Hide();
            frmPurchase.ShowDialog();
            if (frmPurchase.Logout == true)
            {
                this.Close();
            }
            this.Show();
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
        #endregion

        #region Function
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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        
        

        private void Room_Click(object sender, EventArgs e)
        {
            FrmRoom frmroom = new FrmRoom(this.Name);
            this.Hide();
            frmroom.ShowDialog();
            this.Show();
        }
        private void Room_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorChanged_Enter("room_yellow.png", this.lblRoom, this.pbRoom);
        }

        private void Room_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorChanged_Leave("room.png", this.lblRoom, this.pbRoom);
        }
    }
}
