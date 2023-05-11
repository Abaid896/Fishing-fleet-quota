using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FishingFleet
{
    public partial class ForgotPassword : Form
    {
        private static string userName;
        public static string Username { get { return userName; } set { userName = value; } }

        public ForgotPassword()
        {
            InitializeComponent();
        }

        public bool NotNullFields()
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please Enter a User Name!!!");
                return false;
            }
            else if (txtPetName.Text == "")
            {
                MessageBox.Show("Please Enter a Pet Name!!!");
                return false;
            }

            return true;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (NotNullFields())
            {
                userName = txtUserName.Text;

                DAL.ForgotPassword(txtUserName.Text, txtPetName.Text);
                this.Close();
            }
        }
    }
}
