using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FormStaff : Form
    {
        #region Constructors
        public FormStaff()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Click
        private void Client_Click(object sender, EventArgs e)
        {
            FrmClient frmclient = new FrmClient();
            frmclient.ShowDialog();
        }
        private void ServiceUsing_Click(object sender, EventArgs e)
        {
            FrmUseService frmuseService = new FrmUseService();
            frmuseService.ShowDialog();
        }
        private void RoomUsing_Click(object sender, EventArgs e)
        {
            FrmUseRoom frmuseRoom = new FrmUseRoom();
            frmuseRoom.ShowDialog();
        }
        private void Purchase_Click(object sender, EventArgs e)
        {
            FrmPurchase frmPurchase = new FrmPurchase();
            frmPurchase.ShowDialog();
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
    }
}
