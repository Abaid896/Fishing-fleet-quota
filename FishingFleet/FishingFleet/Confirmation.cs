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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }
        public bool NotNullFields()
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please Enter The Username To Delete!!!");
                return false;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter The Password To Delete!!!");
                return false;
            }
            return true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (NotNullFields())
            {
                DAL.DeleteUser(new Login.SignUp(txtUserName.Text, txtPassword.Text));
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
