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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Close();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            UserDetails userDetails = new UserDetails();
            userDetails.Show();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            Confirmation confirmation = new Confirmation();
            confirmation.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
