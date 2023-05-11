using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingFleet
{
    public partial class frmLogin : Form
    {
        private static string userName;
        public static string Username { get { return userName; } set { userName = value; } }
        public frmLogin()
        {
            InitializeComponent();
        }
        public bool NotNullFields()
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please Enter User Name!!!");
                return false;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password!!!");
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (NotNullFields())
            {
                DAL.LoginUser(new Login.Login(txtUserName.Text, txtPassword.Text));
                userName = txtUserName.Text;
                this.Close();

            }
        }

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked == false)
                txtPassword.UseSystemPasswordChar = true;
            else
                txtPassword.UseSystemPasswordChar = false;
        }

        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }
        private void OpenMainMenuForm()
        {
            Application.Run(new MainMenu());
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (NotNullFields())
            {
                DAL.LoginUser(new Login.Login(txtUserName.Text, txtPassword.Text));
                userName = txtUserName.Text;
                this.Close();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
