using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FmMenu : Form
    {
        string Name = "";

        #region Constructors
        public FmMenu(string TenNV)
        {
            InitializeComponent();
            this.Name = TenNV;
        }
        #endregion

        #region Events Click
        private void HotelManagement_Click(object sender, EventArgs e)
        {
            FrmManage frmmanage = new FrmManage(this.Name);
            this.Hide();
            frmmanage.ShowDialog();
            if (frmmanage.logout == true)
            {
                this.Close();
            }
            this.Show();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            FrmReport frmreport = new FrmReport();
            this.Hide();
            frmreport.ShowDialog();
            this.Show();
        }
        #endregion


    }
}
