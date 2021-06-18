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
        #region Properties
        BLLogin dbLogin = new BLLogin();
        BLStaff dbStaff = new BLStaff();
        string err = "";
        string namelogin = "";
        string password = "";
        string posstaff = "";
        #endregion

        #region Construction
        public FrmLogin()
        {
            InitializeComponent();
            this.txtPassword.UseSystemPasswordChar = true;
        }
        #endregion

        #region Events_Click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataSet staff = dbLogin.GetIDStaff(namelogin, password);
            if (staff.Tables[0].Rows.Count > 0)
            {
                string idstaff = staff.Tables[0].Rows[0][0].ToString();
                posstaff = dbStaff.GetPositionStaff(idstaff).Tables[0].Rows[0][0].ToString();
            }

            if (dbLogin.CheckAccount(namelogin,password,ref err) == true)
            {
                if (posstaff == "Giám Đốc")
                {
                    FrmMain frmmain = new FrmMain();
                    this.Hide();
                    frmmain.ShowDialog();
                    this.Show();
                }
                else
                {
                    if (posstaff == "Nhân Viên")
                    {
                        FormStaff formstaff = new FormStaff();
                        this.Hide();
                        formstaff.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("UserName or Password incorrected");
                    }
                }
            }
            else
            {
                MessageBox.Show("UserName or Password incorrected");
            }
        }
        #endregion

        #region Events_Changed
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
            if (cbShow.Checked == true)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }
        #endregion

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
