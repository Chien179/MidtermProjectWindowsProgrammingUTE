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
        BLLogin dbLogin = new BLLogin();
        BLStaff dbStaff = new BLStaff();
        string err = "";
        string namelogin = "";
        string password = "";

        public FrmLogin()
        {
            InitializeComponent();
            this.txtPassword.UseSystemPasswordChar = true;
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
                
                if(posstaff=="Nhân Viên")
                {
                    FormStaff formstaff = new FormStaff();
                    this.Hide();
                    formstaff.ShowDialog();
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            this.namelogin = this.txtUsername.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.password = this.txtPassword.Text;
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPassword.UseSystemPasswordChar = false;
        }
    }
}
