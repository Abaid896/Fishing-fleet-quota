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
    public partial class ChangeForgotPassword : Form
    {
        public ChangeForgotPassword()
        {
            InitializeComponent();
        }

        private void ChangeForgotPassword_Load(object sender, EventArgs e)
        {

        }
        public bool NotNullFields()
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please Enter the Username!!!");
                return false;
            }
            else if (txtNewPassword.Text == "")
            {
                MessageBox.Show("Please Enter the New Password!!!");
                return false;
            }
            else if (txtNewPassword.Text.Length < 8)
            {
                MessageBox.Show("Password Must Contain Atleast 8 Characters!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtRePassword.Text == "")
            {
                MessageBox.Show("Please Re-Enter  Password!!!");
                return false;
            }
            else if (txtRePassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Passwords Are Not Matching!!!");
                return false;
            }
            return true;
        }
        private void btnUpdatepw_Click(object sender, EventArgs e)
        {
            if (NotNullFields())
            {
                DAL.AddNewPassword(new Login.SignUp(txtUserName.Text, txtNewPassword.Text));
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
