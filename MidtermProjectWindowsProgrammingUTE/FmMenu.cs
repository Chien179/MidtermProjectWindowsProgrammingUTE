using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FmMenu : Form
    {
        #region Constructors
        public FmMenu()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Click
        private void HotelManagement_Click(object sender, EventArgs e)
        {
            FrmManage frmmanage = new FrmManage();
            frmmanage.ShowDialog();
        }
        private void Report_Click(object sender, EventArgs e)
        {
            FrmReport frmreport = new FrmReport();
            frmreport.ShowDialog();
        }
        #endregion
        private void FmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
