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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        public bool NotNullFields()
        {
            if (txtFullName.Text == "")
            {
                MessageBox.Show("Please Enter Full Name!!!");
                return false;
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Please Enter User Name!!!");
                return false;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password!!!");
                return false;
            }
            else if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password Must Contain Atleast 8 Characters!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtPetName.Text == "")
            {
                MessageBox.Show("Please Enter the PetName!!!");
                return false;
            }
            else if (txtCPassword.Text == "")
            {
                MessageBox.Show("Please Confirm the Password!!!");
                return false;
            }
            else if (txtPassword.Text != txtCPassword.Text)
            {
                MessageBox.Show("Password is Not Matching!!!");
                return false;
            }
            else if (txtPhone.Text.Length != 11)
            {
                MessageBox.Show("Phone Number Must be of 11 Digit");
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (NotNullFields())
            {
                DAL.SignUp(new Login.SignUp(txtFullName.Text, txtUserName.Text, txtPassword.Text, txtPhone.Text, txtPetName.Text));
                this.Close();
            }
        }
    }
}
