using MidtermProjectWindowsProgrammingUTE.BS_Layer;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidtermProjectWindowsProgrammingUTE
{
    public partial class FrmLogin : Form
    {
        #region Properties
        BLLogin dbLogin = new BLLogin();
        BLStaff dbStaff = new BLStaff();
        string err = "";
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
            string posstaff = "", idstaff = "";

            DataSet staff = dbLogin.GetIDStaff(this.txtUsername.Text, this.txtPassword.Text);
            if (staff.Tables[0].Rows.Count > 0)
            {
                idstaff = staff.Tables[0].Rows[0][0].ToString();
                posstaff = dbStaff.GetPosAndNameStaff(idstaff).Tables[0].Rows[0][1].ToString();
            }

            if (dbLogin.CheckAccount(this.txtUsername.Text, this.txtPassword.Text, ref err) == true)
            {
                if (posstaff == "Giám Đốc")
                {
                    FmMenu frmmain = new FmMenu(dbStaff.GetPosAndNameStaff(idstaff).Tables[0].Rows[0][0].ToString());
                    this.Hide();
                    frmmain.ShowDialog();
                    txtPassword.ResetText();
                    this.cbShow.Checked = false;
                    this.txtPassword.UseSystemPasswordChar = true;
                    this.Show();
                    this.txtPassword.Focus();
                }
                else
                {
                    if (posstaff == "Nhân Viên")
                    {
                        FormStaff formstaff = new FormStaff(dbStaff.GetPosAndNameStaff(idstaff).Tables[0].Rows[0][0].ToString());
                        this.Hide();
                        formstaff.ShowDialog();
                        txtPassword.ResetText();
                        this.cbShow.Checked = false;
                        this.txtPassword.UseSystemPasswordChar = true;
                        this.Show();
                        this.txtPassword.Focus();
                    }
                    else
                    {
                        MessageBox.Show("UserName or Password incorrected");
                        this.txtPassword.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("UserName or Password incorrected");
                this.txtPassword.Focus();
            }
        }
        #endregion

        #region Form_Closing
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Events_Changed
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

            this.txtPassword.Focus();
        }
        #endregion
    }
}
