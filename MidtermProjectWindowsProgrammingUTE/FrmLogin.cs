using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidtermProjectWindowsProgrammingUTE.BS_Layer;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmLogin : Form
    {
        DataTable dtLogin = null;
        BLLogin dbLogin = new BLLogin();
        BLStaff dbStaff = new BLStaff();
        string err = "";
        string namelogin = "";
        string password = "";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string idstaff = dbLogin.GetIDStaff(namelogin, password).Tables[0].Rows[0][0].ToString();
            string posstaff=dbStaff.GetPositionStaff(idstaff).Tables[0].Rows[0][0].ToString();

            if (dbLogin.CheckAccount(namelogin,password,ref err) == true)
            {
                if (posstaff == "Giám Đốc")
                {
                    FrmMain frmmain = new FrmMain();
                    this.Hide();
                    frmmain.ShowDialog();
                }
                else
                {

                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            this.namelogin = txtUsername.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.password = txtPassword.Text;
        }
    }
}
