using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmBill : Form
    {
        string roomid = "";

        public FrmBill(string x)
        {
            InitializeComponent();
            MessageBox.Show(x);
            this.roomid = x;
            // TODO: This line of code loads data into the 'QuanLyKhachSan.HoaDon' table. You can move, or remove it, as needed.
            this.HoaDonTableAdapter.Fill(this.QuanLyKhachSan.HoaDon, this.roomid);

            this.HoaDon.RefreshReport();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {

        }
    }
}
